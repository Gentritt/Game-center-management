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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
			this.btnADD = new Telerik.WinControls.UI.RadButton();
			this.btnUpdate = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.ProductsGRID = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new Telerik.WinControls.UI.RadButton();
			this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
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
			// ProductsGRID
			// 
			this.ProductsGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductsGRID.Location = new System.Drawing.Point(2, 71);
			this.ProductsGRID.Name = "ProductsGRID";
			this.ProductsGRID.Size = new System.Drawing.Size(692, 394);
			this.ProductsGRID.TabIndex = 4;
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
			// Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 477);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.ProductsGRID);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnADD);
			this.Name = "Products";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.Products_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Telerik.WinControls.UI.RadButton btnADD;
		private Telerik.WinControls.UI.RadButton btnUpdate;
		private Telerik.WinControls.UI.RadButton btnDelete;
		private System.Windows.Forms.DataGridView ProductsGRID;
		private Telerik.WinControls.UI.RadButton btnRefresh;
		private Telerik.WinControls.RadThemeManager radThemeManager1;
	}
}