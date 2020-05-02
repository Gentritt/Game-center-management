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
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.ProductsGRID = new Telerik.WinControls.UI.RadGridView();
			this.btnADD = new Telerik.WinControls.UI.RadButton();
			this.btnUpdate = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// ProductsGRID
			// 
			this.ProductsGRID.Location = new System.Drawing.Point(2, 71);
			// 
			// 
			// 
			this.ProductsGRID.MasterTemplate.AllowAddNewRow = false;
			this.ProductsGRID.MasterTemplate.AllowColumnReorder = false;
			this.ProductsGRID.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.ProductsGRID.Name = "ProductsGRID";
			this.ProductsGRID.ReadOnly = true;
			this.ProductsGRID.Size = new System.Drawing.Size(622, 373);
			this.ProductsGRID.TabIndex = 0;
			this.ProductsGRID.ThemeName = "Crystal";
			// 
			// btnADD
			// 
			this.btnADD.Location = new System.Drawing.Point(641, 71);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(110, 43);
			this.btnADD.TabIndex = 1;
			this.btnADD.Text = "ADD";
			this.btnADD.ThemeName = "Crystal";
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(641, 126);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(110, 43);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.ThemeName = "Crystal";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(641, 181);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 43);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.ThemeName = "Crystal";
			// 
			// Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnADD);
			this.Controls.Add(this.ProductsGRID);
			this.Name = "Products";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.Products_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGRID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGridView ProductsGRID;
		private Telerik.WinControls.UI.RadButton btnADD;
		private Telerik.WinControls.UI.RadButton btnUpdate;
		private Telerik.WinControls.UI.RadButton btnDelete;
	}
}