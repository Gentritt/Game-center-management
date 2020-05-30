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
			this.btnADD = new Telerik.WinControls.UI.RadButton();
			this.btnUpdate = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.btnRefresh = new Telerik.WinControls.UI.RadButton();
			this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
			this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
			this.ProductsGRID = new System.Windows.Forms.DataGridView();
			this.productBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productBLLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource)).BeginInit();
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
			// ProductsGRID
			// 
			this.ProductsGRID.AllowUserToAddRows = false;
			this.ProductsGRID.AllowUserToDeleteRows = false;
			this.ProductsGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ProductsGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductsGRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID,
			this.Name,
			this.ProductPrice,
			this.Quantity});
			this.ProductsGRID.Location = new System.Drawing.Point(44, 99);
			this.ProductsGRID.Name = "ProductsGRID";
			this.ProductsGRID.ReadOnly = true;
			this.ProductsGRID.Size = new System.Drawing.Size(595, 366);
			this.ProductsGRID.TabIndex = 6;
			this.ProductsGRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGRID_CellContentClick);
			this.ProductsGRID.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGRID_CellDoubleClick);
			// 
			// productBLLBindingSource
			// 
			this.productBLLBindingSource.DataSource = typeof(game_center_management.BLL.ProductBLL);
			// 
			// productBLLBindingSource1
			// 
			this.productBLLBindingSource1.DataSource = typeof(game_center_management.BLL.ProductBLL);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ProductID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Name
			// 
			this.Name.DataPropertyName = "ProductName";
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// ProductPrice
			// 
			this.ProductPrice.DataPropertyName = "Price";
			this.ProductPrice.HeaderText = "ProductPrice";
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.DataPropertyName = "Quantity";
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
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
			this.Name.Name = "Products";
			this.Text = "Products";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Products_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBLLBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource productBLLBindingSource1;
		private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
		public System.Windows.Forms.DataGridView ProductsGRID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
	}
}