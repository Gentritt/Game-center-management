namespace Game_center_management.Computer_Forms
{
	partial class ManageComputers
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
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageComputers));
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.gridManageComputers = new Telerik.WinControls.UI.RadGridView();
			this.btnADD = new Telerik.WinControls.UI.RadButton();
			this.btnUpdate = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.btnParts = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridManageComputers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridManageComputers.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnParts)).BeginInit();
			this.SuspendLayout();
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.radLabel1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(716, 61);
			this.radPanel1.TabIndex = 0;
			this.radPanel1.ThemeName = "CrystalDark";
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.ForeColor = System.Drawing.Color.White;
			this.radLabel1.Location = new System.Drawing.Point(168, 3);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(329, 53);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Manage Computers";
			// 
			// gridManageComputers
			// 
			this.gridManageComputers.Location = new System.Drawing.Point(0, 62);
			// 
			// 
			// 
			this.gridManageComputers.MasterTemplate.ViewDefinition = tableViewDefinition2;
			this.gridManageComputers.Name = "gridManageComputers";
			this.gridManageComputers.Size = new System.Drawing.Size(590, 389);
			this.gridManageComputers.TabIndex = 1;
			this.gridManageComputers.ThemeName = "Crystal";
			// 
			// btnADD
			// 
			this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
			this.btnADD.Location = new System.Drawing.Point(596, 67);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(110, 53);
			this.btnADD.TabIndex = 2;
			this.btnADD.Text = "       ADD";
			this.btnADD.ThemeName = "CrystalDark";
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.Location = new System.Drawing.Point(596, 124);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(110, 53);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "          UPDATE";
			this.btnUpdate.ThemeName = "CrystalDark";
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(596, 181);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 53);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "      DELETE";
			this.btnDelete.ThemeName = "CrystalDark";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnParts
			// 
			this.btnParts.Image = ((System.Drawing.Image)(resources.GetObject("btnParts.Image")));
			this.btnParts.Location = new System.Drawing.Point(596, 240);
			this.btnParts.Name = "btnParts";
			this.btnParts.Size = new System.Drawing.Size(110, 50);
			this.btnParts.TabIndex = 5;
			this.btnParts.Text = "       PARTS";
			this.btnParts.ThemeName = "CrystalDark";
			this.btnParts.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// ManageComputers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 458);
			this.Controls.Add(this.btnParts);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnADD);
			this.Controls.Add(this.gridManageComputers);
			this.Controls.Add(this.radPanel1);
			this.Name = "ManageComputers";
			this.Text = "ManageComputers";
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			this.radPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridManageComputers.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridManageComputers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnADD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnParts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadGridView gridManageComputers;
		private Telerik.WinControls.UI.RadButton btnADD;
		private Telerik.WinControls.UI.RadButton btnUpdate;
		private Telerik.WinControls.UI.RadButton btnDelete;
		private Telerik.WinControls.UI.RadButton btnParts;
	}
}