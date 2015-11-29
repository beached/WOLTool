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
			this.btnWakeUp.Location = new System.Drawing.Point(218, 54);
			this.btnWakeUp.Name = "btnWakeUp";
			this.btnWakeUp.Size = new System.Drawing.Size(75, 23);
			this.btnWakeUp.TabIndex = 2;
			this.btnWakeUp.Text = "Wake Up";
			this.btnWakeUp.UseVisualStyleBackColor = true;
			this.btnWakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 89);
			this.Controls.Add(this.btnWakeUp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMACAddress);
			this.Name = "frmMain";
			this.Text = "WOL Tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMACAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnWakeUp;
	}
}

