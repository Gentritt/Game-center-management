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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.erpPricePerhour = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPartID = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtInsertDate = new Telerik.WinControls.UI.RadTextBox();
            this.InsertDate = new Telerik.WinControls.UI.RadLabel();
            this.txtInsertBY = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.computerPartsBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPricePerhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPartID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPartsBLLBindingSource)).BeginInit();
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
            this.btnCancel.Location = new System.Drawing.Point(150, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "Crystal";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "Crystal";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // erpPricePerhour
            // 
            this.erpPricePerhour.ContainerControl = this;
            // 
            // erpPartID
            // 
            this.erpPartID.ContainerControl = this;
            // 
            // txtInsertDate
            // 
            this.txtInsertDate.Location = new System.Drawing.Point(106, 157);
            this.txtInsertDate.Name = "txtInsertDate";
            this.txtInsertDate.Size = new System.Drawing.Size(135, 20);
            this.txtInsertDate.TabIndex = 10;
            // 
            // InsertDate
            // 
            this.InsertDate.Location = new System.Drawing.Point(22, 160);
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.Size = new System.Drawing.Size(60, 18);
            this.InsertDate.TabIndex = 9;
            this.InsertDate.Text = "InsertDate:";
            // 
            // txtInsertBY
            // 
            this.txtInsertBY.Location = new System.Drawing.Point(106, 121);
            this.txtInsertBY.Name = "txtInsertBY";
            this.txtInsertBY.Size = new System.Drawing.Size(135, 20);
            this.txtInsertBY.TabIndex = 8;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(22, 124);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(52, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "InsertBy: ";
            // 
            // computerPartsBLLBindingSource
            // 
            // cmbPC
            // 
            this.cmbPC.FormattingEnabled = true;
            this.cmbPC.Location = new System.Drawing.Point(106, 85);
            this.cmbPC.Name = "cmbPC";
            this.cmbPC.Size = new System.Drawing.Size(121, 21);
            this.cmbPC.TabIndex = 11;
            // 
            // RegisterComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 263);
            this.Controls.Add(this.cmbPC);
            this.Controls.Add(this.txtInsertDate);
            this.Controls.Add(this.InsertDate);
            this.Controls.Add(this.txtInsertBY);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtPricePerHour);
            this.Controls.Add(this.radLabel1);
            this.Name = "RegisterComputers";
            this.Text = "z";
            this.Load += new System.EventHandler(this.RegisterComputers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPricePerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPricePerhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPartID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsertBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPartsBLLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadTextBox txtPricePerHour;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadButton btnSave;
		private System.Windows.Forms.ErrorProvider erpPricePerhour;
		private System.Windows.Forms.ErrorProvider erpPartID;
		private Telerik.WinControls.UI.RadTextBox txtInsertDate;
		private Telerik.WinControls.UI.RadLabel InsertDate;
		private Telerik.WinControls.UI.RadTextBox txtInsertBY;
		private Telerik.WinControls.UI.RadLabel radLabel4;
		private System.Windows.Forms.BindingSource computerPartsBLLBindingSource;
		private System.Windows.Forms.ComboBox cmbPC;
	}
}