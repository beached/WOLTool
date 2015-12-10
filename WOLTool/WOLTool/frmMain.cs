using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOLTool {

	public partial class frmMain: Form {
		StoredComputers m_stored_computers;

		public frmMain( ) {
			m_stored_computers = new StoredComputers( );
			InitializeComponent( );
			
			foreach( var comp in m_stored_computers.GetStoredItems( ) ) {
				dataGridView1.Rows.Add( comp.mac_address, comp.computer_name, comp.last_used );
			}
		}

		private static string cleanup_mac_string( string orig_mac_string ) {
			const string valid_mac_address_chars = @"0123456789ABCDEF";
			string mac_address = string.Empty;
			foreach( var c in orig_mac_string.ToUpper( ) ) {
				if( valid_mac_address_chars.Contains( c ) ) {
					mac_address += c;
				}
			}
			return mac_address;
		}

		private static byte str_to_nibble( char str_val ) {
			if( str_val >= '0' && str_val <= '9' ) {
				return (byte)(str_val - '0');
			}
			str_val |= ' ';
			byte result = (byte)(str_val - 'a' + 10);
			return result;
		}

		private static byte str_to_byte( char str_val1, char str_val2 ) {
			byte p1 = (byte)(str_to_nibble( str_val1 ) << 4);
			byte p2 = str_to_nibble( str_val2 );
			byte result = (byte)(p1 | p2);
			return result;
		}

		private static byte[] hex_string_to_byte( string hex_string ) {
			System.Diagnostics.Debug.Assert( hex_string.Length % 2 == 0 );
			var result = new byte[hex_string.Length / 2];
			for( var i = 0; i < hex_string.Length; i += 2 ) {
				result[i / 2] = str_to_byte( hex_string[i], hex_string[i + 1] );
			}
			return result;
		}

		private static string repeat_string( string value, int count ) {
			var result = value;
			for( int i = 1; i < count; ++i ) {
				result += value;
			}
			return result;
		}

		private static void send_packet( string data_package ) {
			var magic_packet = new System.Net.Sockets.UdpClient( );
			try {
				magic_packet.Connect( System.Net.IPAddress.Broadcast, 9 );
				var dgram = hex_string_to_byte( data_package );
				magic_packet.Send( dgram, dgram.Length );
				magic_packet.Close( );
			} catch( Exception e ) {
				MessageBox.Show( string.Format( "Exception while sending packet: {0}", e.Message ) );
			}
		}

		private void btnWakeUp_Click( object sender, EventArgs e ) {
			var dgram = repeat_string( @"FF", 6 );
			var mac_address = cleanup_mac_string( txtMACAddress.Text );
			var computer_name = txtComputerName.Text.Trim( ).ToLowerInvariant( );
			dgram += repeat_string( mac_address, 16 );
			send_packet( dgram );
			m_stored_computers.AddNewOrUpdate( mac_address, computer_name );
		}

		private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e ) {
			var row = dataGridView1.Rows[e.RowIndex];
			txtMACAddress.Text = row.Cells[0].Value as string;
			txtComputerName.Text = row.Cells[1].Value as string;
		}
	}
}