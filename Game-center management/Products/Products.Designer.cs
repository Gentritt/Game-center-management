namespace Game_center_management.Products
{
	partial class Products
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.btnADD = new Telerik.WinControls.UI.RadButton();
			this.btnUpdate = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.btnRefresh = new Telerik.WinControls.UI.RadButton();
			this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
			this.productBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProductsGRID = new Telerik.WinControls.UI.RadGridView();
			this.productBLLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnADD
			// 
			this.btnADD.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnADD.ForeColor = System.Drawing.Color.White;
			this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
			this.btnADD.Location = new System.Drawing.Point(12, 22);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(114, 43);
			this.btnADD.TabIndex = 1;
			this.btnADD.Text = "         ADD";
			this.btnADD.ThemeName = "CrystalDark";
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.Location = new System.Drawing.Point(150, 22);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(108, 43);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "         EDIT";
			this.btnUpdate.ThemeName = "CrystalDark";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(286, 22);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 43);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "          DELETE";
			this.btnDelete.ThemeName = "CrystalDark";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(580, 22);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(114, 43);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "          REFRESH";
			this.btnRefresh.ThemeName = "CrystalDark";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// productBLLBindingSource
			// 
			this.productBLLBindingSource.DataSource = typeof(game_center_management.BLL.ProductBLL);
			// 
			// ProductsGRID
			// 
			this.ProductsGRID.Location = new System.Drawing.Point(12, 94);
			// 
			// 
			// 
			this.ProductsGRID.MasterTemplate.AllowAddNewRow = false;
			this.ProductsGRID.MasterTemplate.AllowColumnReorder = false;
			this.ProductsGRID.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
			gridViewTextBoxColumn1.AllowHide = false;
			gridViewTextBoxColumn1.HeaderText = "ProdcutID";
			gridViewTextBoxColumn1.Name = "ProductID";
			gridViewTextBoxColumn1.Width = 122;
			gridViewTextBoxColumn2.HeaderText = "ProductName";
			gridViewTextBoxColumn2.Name = "ProductName";
			gridViewTextBoxColumn2.Width = 122;
			gridViewTextBoxColumn3.HeaderText = "ProductPrice";
			gridViewTextBoxColumn3.Name = "ProductPrice";
			gridViewTextBoxColumn3.Width = 122;
			gridViewTextBoxColumn4.HeaderText = "ProductQuantity";
			gridViewTextBoxColumn4.Name = "ProdcutQuantity";
			gridViewTextBoxColumn4.Width = 121;
			this.ProductsGRID.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
			this.ProductsGRID.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.ProductsGRID.Name = "ProductsGRID";
			this.ProductsGRID.ReadOnly = true;
			this.ProductsGRID.Size = new System.Drawing.Size(519, 302);
			this.ProductsGRID.TabIndex = 6;
			this.ProductsGRID.ThemeName = "Crystal";
			this.ProductsGRID.Click += new System.EventHandler(this.ProductsGRID_Click);
			// 
			// productBLLBindingSource1
			// 
			this.productBLLBindingSource1.DataSource = typeof(game_center_management.BLL.ProductBLL);
			// 
			// Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 477);
			this.Controls.Add(this.ProductsGRID);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnADD);
			this.Name = "Products";
			this.Text = "Products";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Products_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Telerik.WinControls.UI.RadButton btnADD;
		private Telerik.WinControls.UI.RadButton btnUpdate;
		private Telerik.WinControls.UI.RadButton btnDelete;
		private Telerik.WinControls.UI.RadButton btnRefresh;
		private Telerik.WinControls.RadThemeManager radThemeManager1;
		private System.Windows.Forms.BindingSource productBLLBindingSource;
		private Telerik.WinControls.UI.RadGridView ProductsGRID;
		private System.Windows.Forms.BindingSource productBLLBindingSource1;
		private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
	}
}