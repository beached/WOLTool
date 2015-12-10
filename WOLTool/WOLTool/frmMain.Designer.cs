
namespace WOLTool {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && (components != null) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}
		

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.txtMACAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnWakeUp = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblComputerName = new System.Windows.Forms.Label();
			this.txtComputerName = new System.Windows.Forms.TextBox();
			this.mac_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.computer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.last_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtMACAddress
			// 
			this.txtMACAddress.Location = new System.Drawing.Point(89, 6);
			this.txtMACAddress.Name = "txtMACAddress";
			this.txtMACAddress.Size = new System.Drawing.Size(153, 20);
			this.txtMACAddress.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "MAC Address";
			// 
			// btnWakeUp
			// 
			this.btnWakeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnWakeUp.Location = new System.Drawing.Point(477, 342);
			this.btnWakeUp.Name = "btnWakeUp";
			this.btnWakeUp.Size = new System.Drawing.Size(75, 23);
			this.btnWakeUp.TabIndex = 2;
			this.btnWakeUp.Text = "Wake Up";
			this.btnWakeUp.UseVisualStyleBackColor = true;
			this.btnWakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mac_address,
            this.computer_name,
            this.last_used});
			this.dataGridView1.Location = new System.Drawing.Point(13, 36);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(539, 300);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// lblComputerName
			// 
			this.lblComputerName.AutoSize = true;
			this.lblComputerName.Location = new System.Drawing.Point(248, 9);
			this.lblComputerName.Name = "lblComputerName";
			this.lblComputerName.Size = new System.Drawing.Size(83, 13);
			this.lblComputerName.TabIndex = 5;
			this.lblComputerName.Text = "Computer Name";
			// 
			// txtComputerName
			// 
			this.txtComputerName.Location = new System.Drawing.Point(337, 6);
			this.txtComputerName.Name = "txtComputerName";
			this.txtComputerName.Size = new System.Drawing.Size(215, 20);
			this.txtComputerName.TabIndex = 4;
			// 
			// mac_address
			// 
			this.mac_address.HeaderText = "Mac Address";
			this.mac_address.Name = "mac_address";
			this.mac_address.ReadOnly = true;
			// 
			// computer_name
			// 
			this.computer_name.HeaderText = "Computer Name";
			this.computer_name.Name = "computer_name";
			this.computer_name.ReadOnly = true;
			// 
			// last_used
			// 
			this.last_used.HeaderText = "Last Used";
			this.last_used.Name = "last_used";
			this.last_used.ReadOnly = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 377);
			this.Controls.Add(this.lblComputerName);
			this.Controls.Add(this.txtComputerName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnWakeUp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMACAddress);
			this.Name = "frmMain";
			this.Text = "WOL Tool";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMACAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnWakeUp;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn mac_address;
		private System.Windows.Forms.DataGridViewTextBoxColumn computer_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn last_used;
		private System.Windows.Forms.Label lblComputerName;
		private System.Windows.Forms.TextBox txtComputerName;
	}
}

