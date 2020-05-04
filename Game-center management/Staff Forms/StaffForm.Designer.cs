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
			this.components = new System.ComponentModel.Container();
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.pnlServicStaff = new Telerik.WinControls.UI.RadPanel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
			this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
			this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
			this.btnAdd = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
			this.employessBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridServiceStaff = new Telerik.WinControls.UI.RadGridView();
			this.btnEdit = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.pnlServicStaff)).BeginInit();
			this.pnlServicStaff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employessBLLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlServicStaff
			// 
			this.pnlServicStaff.Controls.Add(this.radLabel1);
			this.pnlServicStaff.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlServicStaff.Location = new System.Drawing.Point(0, 0);
			this.pnlServicStaff.Name = "pnlServicStaff";
			this.pnlServicStaff.Size = new System.Drawing.Size(819, 59);
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
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(21, 65);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(138, 47);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.ThemeName = "TelerikMetroTouch";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(165, 65);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(126, 47);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.ThemeName = "TelerikMetroTouch";
			// 
			// employessBLLBindingSource
			// 
			this.employessBLLBindingSource.DataSource = typeof(game_center_management.BLL.EmployessBLL);
			// 
			// gridServiceStaff
			// 
			this.gridServiceStaff.Location = new System.Drawing.Point(21, 137);
			// 
			// 
			// 
			this.gridServiceStaff.MasterTemplate.AllowAddNewRow = false;
			this.gridServiceStaff.MasterTemplate.AllowColumnReorder = false;
			this.gridServiceStaff.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed;
			this.gridServiceStaff.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
			this.gridServiceStaff.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
			this.gridServiceStaff.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.gridServiceStaff.Name = "gridServiceStaff";
			this.gridServiceStaff.ReadOnly = true;
			this.gridServiceStaff.Size = new System.Drawing.Size(786, 409);
			this.gridServiceStaff.TabIndex = 4;
			this.gridServiceStaff.ThemeName = "Crystal";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(297, 65);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(127, 47);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Edit";
			this.btnEdit.ThemeName = "TelerikMetroTouch";
			// 
			// StaffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 558);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.gridServiceStaff);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlServicStaff);
			this.Name = "StaffForm";
			this.Text = "StaffForm";
			this.Load += new System.EventHandler(this.StaffForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pnlServicStaff)).EndInit();
			this.pnlServicStaff.ResumeLayout(false);
			this.pnlServicStaff.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employessBLLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel pnlServicStaff;
		private Telerik.WinControls.Themes.DesertTheme desertTheme1;
		private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
		private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnAdd;
		private Telerik.WinControls.UI.RadButton btnDelete;
		private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
		private System.Windows.Forms.BindingSource employessBLLBindingSource;
		private Telerik.WinControls.UI.RadGridView gridServiceStaff;
		private Telerik.WinControls.UI.RadButton btnEdit;
	}
}