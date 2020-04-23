namespace Game_center_management.Forms
{
	partial class StaffForm
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
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.pnlServicStaff = new Telerik.WinControls.UI.RadPanel();
			this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
			this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
			this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.grdServiceStaff = new Telerik.WinControls.UI.RadGridView();
			this.btnAdd = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.pnlServicStaff)).BeginInit();
			this.pnlServicStaff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdServiceStaff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdServiceStaff.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlServicStaff
			// 
			this.pnlServicStaff.Controls.Add(this.radLabel1);
			this.pnlServicStaff.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlServicStaff.Location = new System.Drawing.Point(0, 0);
			this.pnlServicStaff.Name = "pnlServicStaff";
			this.pnlServicStaff.Size = new System.Drawing.Size(800, 59);
			this.pnlServicStaff.TabIndex = 0;
			this.pnlServicStaff.ThemeName = "CrystalDark";
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.ForeColor = System.Drawing.Color.White;
			this.radLabel1.Location = new System.Drawing.Point(21, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(298, 33);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Administration of Service Staff";
			// 
			// grdServiceStaff
			// 
			this.grdServiceStaff.Location = new System.Drawing.Point(12, 89);
			// 
			// 
			// 
			this.grdServiceStaff.MasterTemplate.AllowAddNewRow = false;
			this.grdServiceStaff.MasterTemplate.AllowColumnReorder = false;
			this.grdServiceStaff.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.grdServiceStaff.Name = "grdServiceStaff";
			this.grdServiceStaff.ReadOnly = true;
			this.grdServiceStaff.Size = new System.Drawing.Size(588, 349);
			this.grdServiceStaff.TabIndex = 1;
			this.grdServiceStaff.ThemeName = "Crystal";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(606, 89);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(182, 75);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.ThemeName = "Crystal";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(606, 170);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(182, 70);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.ThemeName = "Crystal";
			// 
			// StaffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.grdServiceStaff);
			this.Controls.Add(this.pnlServicStaff);
			this.Name = "StaffForm";
			this.Text = "StaffForm";
			((System.ComponentModel.ISupportInitialize)(this.pnlServicStaff)).EndInit();
			this.pnlServicStaff.ResumeLayout(false);
			this.pnlServicStaff.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdServiceStaff.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdServiceStaff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel pnlServicStaff;
		private Telerik.WinControls.Themes.DesertTheme desertTheme1;
		private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
		private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadGridView grdServiceStaff;
		private Telerik.WinControls.UI.RadButton btnAdd;
		private Telerik.WinControls.UI.RadButton btnDelete;
	}
}