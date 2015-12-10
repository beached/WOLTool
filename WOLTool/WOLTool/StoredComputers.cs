using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOLTool {
	class StoredComputers: IDisposable {
		private SQLiteConnection m_dbConnection;
		private bool m_is_disposed = false;

		public struct StoredComputerItem {
			public string computer_name;
			public string mac_address;
			public DateTime last_used;

			public StoredComputerItem( string cn, string ma, long lu ) {
				computer_name = cn;
				mac_address = ma;
				last_used = DateTime.FromBinary( lu );
			}
		}

		public StoredComputers( string file_name = "stored_computers.sqlite" ) {
			bool new_db = false;
			if( !System.IO.File.Exists( file_name ) ) {
				SQLiteConnection.CreateFile( file_name );
				new_db = true;
			}
			m_dbConnection = new SQLiteConnection( string.Format( @"Data Source={0};Version=3;", file_name ) );
			m_dbConnection.Open( );
			if( new_db ) {
				const string sql_create_table = @"CREATE TABLE stored_computers(name VARCHAR(253), mac_address CHAR(6), last_used INTEGER)";
				using( var cmd = new SQLiteCommand( sql_create_table, m_dbConnection ) ) {
					cmd.ExecuteNonQuery( );
				}				
			}

		}

		public void AddNewOrUpdate( string mac_address, string computer_name ) {
			if( computer_name.Length > 253 ) {
				throw new ArgumentException( "computer_name is longer than 253 characters, the max", "computer_name" );
			}

			if( mac_address.Length != 12 ) {
				throw new ArgumentException( "MAC Addresses are 6 bytes long or 12 nibbles, this one is neither", "mac_address" );
			}
			var sql_remove_old = string.Format( @"DELETE FROM stored_computers WHERE mac_address='{0}'", mac_address );
			using( var cmd = new SQLiteCommand( sql_remove_old, m_dbConnection ) ) {
				cmd.ExecuteNonQuery( );
			}
			var sql_add_new = string.Format( @"INSERT INTO stored_computers( name, mac_address, last_used ) VALUES( '{0}', '{1}', {2} )", computer_name, mac_address, DateTime.Now.ToBinary( ) );
			using( var cmd = new SQLiteCommand( sql_add_new, m_dbConnection ) ) {
				cmd.ExecuteNonQuery( );
			}
		}
		
		private string format_mac( string mac_address ) {
			string result = string.Empty;
			for( int n=1; n<=12; n++ ) {
				result += mac_address[n-1];
				if( n % 2 == 0 && n != 12 ) {
					result += ":";
				}
			}
			return result;
		}

		public List<StoredComputerItem> GetStoredItems( ) {
			var result = new List<StoredComputerItem>( );
			const string sql_get_items = "SELECT * FROM stored_computers ORDER by last_used DESC";
			using( var cmd = new SQLiteCommand( sql_get_items, m_dbConnection ) ) {
				var reader = cmd.ExecuteReader( );
				try {
					var mac_address_column = reader.GetOrdinal( "mac_address" );
					var computer_name_column = reader.GetOrdinal( "name" );
					var last_used_column = reader.GetOrdinal( "last_used" );
					while( reader.Read( ) ) {
						result.Add( new StoredComputerItem( reader.GetString( computer_name_column ), format_mac( reader.GetString( mac_address_column ) ), reader.GetInt64( last_used_column ) ) );
					}
				} finally {
					reader.Close( );
				}
			}
			return result;
		}

		void Close( ) {
			m_dbConnection.Dispose( );
		}

		// IDisposable stuff
		public void Dispose( ) {
			Dispose( true );
			GC.SuppressFinalize( this );
		}

		protected virtual void Dispose( bool disposing ) {
			if( m_is_disposed ) {
				return;
			}

			if( disposing ) {
				Close( );
			}
			m_is_disposed = true;
		}

		~StoredComputers( ) {
			Dispose( false );
		}
	}	// StoredComputers
}	// Namespace WOLTool
