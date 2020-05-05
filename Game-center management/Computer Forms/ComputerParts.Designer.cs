namespace Game_center_management.Computer_Forms
{
	partial class ComputerParts
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
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.gridComputerParts = new Telerik.WinControls.UI.RadGridView();
			this.btnEdit = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridComputerParts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridComputerParts.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.radLabel1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(714, 50);
			this.radPanel1.TabIndex = 0;
			this.radPanel1.ThemeName = "CrystalDark";
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.ForeColor = System.Drawing.Color.White;
			this.radLabel1.Location = new System.Drawing.Point(12, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(158, 33);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Computer Parts";
			// 
			// gridComputerParts
			// 
			this.gridComputerParts.Location = new System.Drawing.Point(0, 109);
			// 
			// 
			// 
			this.gridComputerParts.MasterTemplate.AllowAddNewRow = false;
			this.gridComputerParts.MasterTemplate.AllowColumnReorder = false;
			this.gridComputerParts.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.gridComputerParts.Name = "gridComputerParts";
			this.gridComputerParts.ReadOnly = true;
			this.gridComputerParts.Size = new System.Drawing.Size(702, 347);
			this.gridComputerParts.TabIndex = 1;
			this.gridComputerParts.ThemeName = "Crystal";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(71, 68);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(110, 35);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.ThemeName = "Crystal";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(207, 68);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 35);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.ThemeName = "Crystal";
			// 
			// ComputerParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 468);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.gridComputerParts);
			this.Controls.Add(this.radPanel1);
			this.Name = "ComputerParts";
			this.Text = "ComputerParts";
			this.Load += new System.EventHandler(this.ComputerParts_Load);
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			this.radPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridComputerParts.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridComputerParts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnEdit;
		private Telerik.WinControls.UI.RadButton btnDelete;
		public Telerik.WinControls.UI.RadGridView gridComputerParts;
	}
}