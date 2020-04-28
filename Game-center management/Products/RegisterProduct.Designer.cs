namespace Game_center_management.Products
{
	partial class RegisterProduct
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
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
			this.txtProductName = new Telerik.WinControls.UI.RadTextBox();
			this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
			this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			this.SuspendLayout();
			// 
			// radGroupBox1
			// 
			this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.btnCancel);
			this.radGroupBox1.Controls.Add(this.btnSave);
			this.radGroupBox1.Controls.Add(this.radMultiColumnComboBox1);
			this.radGroupBox1.Controls.Add(this.txtPrice);
			this.radGroupBox1.Controls.Add(this.txtProductName);
			this.radGroupBox1.Controls.Add(this.radLabel3);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.Controls.Add(this.radLabel1);
			this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
			this.radGroupBox1.HeaderText = "Register Product";
			this.radGroupBox1.Location = new System.Drawing.Point(31, 28);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new System.Drawing.Size(247, 266);
			this.radGroupBox1.TabIndex = 0;
			this.radGroupBox1.Text = "Register Product";
			this.radGroupBox1.ThemeName = "Crystal";
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(16, 47);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(84, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Product Name: ";
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(16, 85);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(78, 18);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Product Price: ";
			// 
			// radLabel3
			// 
			this.radLabel3.Location = new System.Drawing.Point(16, 127);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new System.Drawing.Size(57, 18);
			this.radLabel3.TabIndex = 2;
			this.radLabel3.Text = "Category: ";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(100, 47);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(133, 20);
			this.txtProductName.TabIndex = 3;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(100, 85);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(133, 20);
			this.txtPrice.TabIndex = 4;
			// 
			// radMultiColumnComboBox1
			// 
			// 
			// radMultiColumnComboBox1.NestedRadGridView
			// 
			this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
			this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
			// 
			// 
			// 
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
			gridViewTextBoxColumn1.HeaderText = "Drink";
			gridViewTextBoxColumn1.Name = "cmdDrink";
			gridViewTextBoxColumn1.StretchVertically = false;
			gridViewTextBoxColumn2.HeaderText = "Food";
			gridViewTextBoxColumn2.Name = "cmbFood";
			gridViewTextBoxColumn2.Width = 70;
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
			this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
			this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
			this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
			this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
			this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
			this.radMultiColumnComboBox1.Location = new System.Drawing.Point(100, 127);
			this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
			this.radMultiColumnComboBox1.Size = new System.Drawing.Size(100, 24);
			this.radMultiColumnComboBox1.TabIndex = 5;
			this.radMultiColumnComboBox1.TabStop = false;
			this.radMultiColumnComboBox1.ThemeName = "Crystal";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(40, 198);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(86, 24);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(144, 198);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 24);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			// 
			// RegisterProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 326);
			this.Controls.Add(this.radGroupBox1);
			this.Name = "RegisterProduct";
			this.Text = "RegisterProduct";
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
		private Telerik.WinControls.UI.RadTextBox txtPrice;
		private Telerik.WinControls.UI.RadTextBox txtProductName;
		private Telerik.WinControls.UI.RadLabel radLabel3;
		private Telerik.WinControls.UI.RadLabel radLabel2;
	}
}