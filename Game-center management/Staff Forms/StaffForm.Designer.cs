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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
			this.pnlServicStaff = new Telerik.WinControls.UI.RadPanel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
			this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
			this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
			this.btnAdd = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
			this.btnEdit = new Telerik.WinControls.UI.RadButton();
			this.gridServiceStaff = new System.Windows.Forms.DataGridView();
			this.employessBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnRefresh = new Telerik.WinControls.UI.RadButton();
			this.jImageButton1 = new JImageButton.JImageButton();
			((System.ComponentModel.ISupportInitialize)(this.pnlServicStaff)).BeginInit();
			this.pnlServicStaff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employessBLLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlServicStaff
			// 
			this.pnlServicStaff.Controls.Add(this.jImageButton1);
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
			this.radLabel1.Location = new System.Drawing.Point(215, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(298, 33);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Administration of Service Staff";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(21, 65);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(138, 47);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "ADD";
			this.btnAdd.ThemeName = "CrystalDark";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(165, 65);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(126, 47);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "   DELETE";
			this.btnDelete.ThemeName = "CrystalDark";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(297, 65);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(127, 47);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.ThemeName = "CrystalDark";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// gridServiceStaff
			// 
			this.gridServiceStaff.AllowUserToAddRows = false;
			this.gridServiceStaff.AllowUserToDeleteRows = false;
			this.gridServiceStaff.AllowUserToResizeRows = false;
			this.gridServiceStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridServiceStaff.Location = new System.Drawing.Point(12, 135);
			this.gridServiceStaff.Name = "gridServiceStaff";
			this.gridServiceStaff.Size = new System.Drawing.Size(795, 325);
			this.gridServiceStaff.TabIndex = 6;
			// 
			// employessBLLBindingSource
			// 
			this.employessBLLBindingSource.DataSource = typeof(game_center_management.BLL.EmployessBLL);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(643, 65);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(129, 47);
			this.btnRefresh.TabIndex = 7;
			this.btnRefresh.Text = "       REFRESH";
			this.btnRefresh.ThemeName = "CrystalDark";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// jImageButton1
			// 
			this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.jImageButton1.BackColor = System.Drawing.SystemColors.Highlight;
			this.jImageButton1.CausesValidation = false;
			this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
			this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
			this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
			this.jImageButton1.ImageHover = null;
			this.jImageButton1.InitialImage = null;
			this.jImageButton1.Location = new System.Drawing.Point(0, 0);
			this.jImageButton1.Name = "jImageButton1";
			this.jImageButton1.Size = new System.Drawing.Size(157, 59);
			this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.jImageButton1.TabIndex = 8;
			this.jImageButton1.Zoom = 4;
			// 
			// StaffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 558);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.gridServiceStaff);
			this.Controls.Add(this.btnEdit);
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
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridServiceStaff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employessBLLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
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
		private Telerik.WinControls.UI.RadButton btnEdit;
		private System.Windows.Forms.DataGridView gridServiceStaff;
		private Telerik.WinControls.UI.RadButton btnRefresh;
		private JImageButton.JImageButton jImageButton1;
	}
}