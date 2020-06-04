namespace Game_center_management.Computer_Forms
{
	partial class ComputersEdit
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbPC = new System.Windows.Forms.ComboBox();
			this.txtUpdateDate = new Telerik.WinControls.UI.RadTextBox();
			this.UpdateDate = new Telerik.WinControls.UI.RadLabel();
			this.txtupdateby = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.txtPricePerHour = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.txtUpdateNo = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
			this.txtComputerID = new Telerik.WinControls.UI.RadTextBox();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpdateDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtupdateby)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbPC
			// 
			this.cmbPC.FormattingEnabled = true;
			this.cmbPC.Location = new System.Drawing.Point(119, 58);
			this.cmbPC.Name = "cmbPC";
			this.cmbPC.Size = new System.Drawing.Size(121, 21);
			this.cmbPC.TabIndex = 21;
			this.cmbPC.SelectedIndexChanged += new System.EventHandler(this.cmbPC_SelectedIndexChanged);
			// 
			// txtUpdateDate
			// 
			this.txtUpdateDate.Location = new System.Drawing.Point(119, 130);
			this.txtUpdateDate.Name = "txtUpdateDate";
			this.txtUpdateDate.Size = new System.Drawing.Size(135, 20);
			this.txtUpdateDate.TabIndex = 20;
			// 
			// UpdateDate
			// 
			this.UpdateDate.Location = new System.Drawing.Point(35, 133);
			this.UpdateDate.Name = "UpdateDate";
			this.UpdateDate.Size = new System.Drawing.Size(60, 18);
			this.UpdateDate.TabIndex = 19;
			this.UpdateDate.Text = "InsertDate:";
			// 
			// txtupdateby
			// 
			this.txtupdateby.Location = new System.Drawing.Point(119, 94);
			this.txtupdateby.Name = "txtupdateby";
			this.txtupdateby.Size = new System.Drawing.Size(135, 20);
			this.txtupdateby.TabIndex = 18;
			// 
			// radLabel4
			// 
			this.radLabel4.Location = new System.Drawing.Point(35, 97);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new System.Drawing.Size(60, 18);
			this.radLabel4.TabIndex = 17;
			this.radLabel4.Text = "UpdateBy: ";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(35, 243);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 33);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(163, 243);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 33);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(35, 58);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(43, 18);
			this.radLabel2.TabIndex = 14;
			this.radLabel2.Text = "PartID: ";
			// 
			// txtPricePerHour
			// 
			this.txtPricePerHour.Location = new System.Drawing.Point(119, 19);
			this.txtPricePerHour.Name = "txtPricePerHour";
			this.txtPricePerHour.Size = new System.Drawing.Size(135, 20);
			this.txtPricePerHour.TabIndex = 13;
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(35, 22);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(77, 18);
			this.radLabel1.TabIndex = 12;
			this.radLabel1.Text = "PricePerHour: ";
			// 
			// txtUpdateNo
			// 
			this.txtUpdateNo.Location = new System.Drawing.Point(119, 170);
			this.txtUpdateNo.Name = "txtUpdateNo";
			this.txtUpdateNo.Size = new System.Drawing.Size(135, 20);
			this.txtUpdateNo.TabIndex = 23;
			// 
			// radLabel3
			// 
			this.radLabel3.Location = new System.Drawing.Point(35, 172);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new System.Drawing.Size(60, 18);
			this.radLabel3.TabIndex = 22;
			this.radLabel3.Text = "UpdateNo.";
			// 
			// txtComputerID
			// 
			this.txtComputerID.Location = new System.Drawing.Point(119, 207);
			this.txtComputerID.Name = "txtComputerID";
			this.txtComputerID.Size = new System.Drawing.Size(135, 20);
			this.txtComputerID.TabIndex = 24;
			// 
			// ComputersEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 310);
			this.Controls.Add(this.txtComputerID);
			this.Controls.Add(this.txtUpdateNo);
			this.Controls.Add(this.radLabel3);
			this.Controls.Add(this.cmbPC);
			this.Controls.Add(this.txtUpdateDate);
			this.Controls.Add(this.UpdateDate);
			this.Controls.Add(this.txtupdateby);
			this.Controls.Add(this.radLabel4);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.txtPricePerHour);
			this.Controls.Add(this.radLabel1);
			this.Name = "ComputersEdit";
			this.Text = "ComputersEdit";
			this.Load += new System.EventHandler(this.ComputersEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpdateDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtupdateby)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Telerik.WinControls.UI.RadLabel UpdateDate;
		private Telerik.WinControls.UI.RadLabel radLabel4;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		public System.Windows.Forms.ComboBox cmbPC;
		public Telerik.WinControls.UI.RadTextBox txtUpdateDate;
		public Telerik.WinControls.UI.RadTextBox txtupdateby;
		public Telerik.WinControls.UI.RadTextBox txtPricePerHour;
		public Telerik.WinControls.UI.RadTextBox txtUpdateNo;
		private Telerik.WinControls.UI.RadLabel radLabel3;
		public Telerik.WinControls.UI.RadTextBox txtComputerID;
	}
}