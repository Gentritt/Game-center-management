namespace Game_center_management.Computer_Forms
{
	partial class RegisterComputers
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
			this.components = new System.ComponentModel.Container();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.txtPricePerHour = new Telerik.WinControls.UI.RadTextBox();
			this.txtPartID = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.erpPricePerhour = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPartID = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPartID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPricePerhour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPartID)).BeginInit();
			this.SuspendLayout();
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(22, 49);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(77, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "PricePerHour: ";
			// 
			// txtPricePerHour
			// 
			this.txtPricePerHour.Location = new System.Drawing.Point(106, 46);
			this.txtPricePerHour.Name = "txtPricePerHour";
			this.txtPricePerHour.Size = new System.Drawing.Size(135, 20);
			this.txtPricePerHour.TabIndex = 1;
			// 
			// txtPartID
			// 
			this.txtPartID.Location = new System.Drawing.Point(106, 82);
			this.txtPartID.Name = "txtPartID";
			this.txtPartID.Size = new System.Drawing.Size(135, 20);
			this.txtPartID.TabIndex = 3;
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(22, 85);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(43, 18);
			this.radLabel2.TabIndex = 2;
			this.radLabel2.Text = "PartID: ";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(169, 167);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 33);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(22, 167);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 33);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			// 
			// erpPricePerhour
			// 
			this.erpPricePerhour.ContainerControl = this;
			// 
			// erpPartID
			// 
			this.erpPartID.ContainerControl = this;
			// 
			// RegisterComputers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 241);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtPartID);
			this.Controls.Add(this.radLabel2);
			this.Controls.Add(this.txtPricePerHour);
			this.Controls.Add(this.radLabel1);
			this.Name = "RegisterComputers";
			this.Text = "RegisterComputers";
			this.Load += new System.EventHandler(this.RegisterComputers_Load);
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPartID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPricePerhour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPartID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadTextBox txtPricePerHour;
		private Telerik.WinControls.UI.RadTextBox txtPartID;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadButton btnSave;
		private System.Windows.Forms.ErrorProvider erpPricePerhour;
		private System.Windows.Forms.ErrorProvider erpPartID;
	}
}