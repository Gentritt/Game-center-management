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
			this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
			this.txtProductName = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			this.SuspendLayout();
			// 
			// radGroupBox1
			// 
			this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.cmbCategory);
			this.radGroupBox1.Controls.Add(this.btnCancel);
			this.radGroupBox1.Controls.Add(this.btnSave);
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
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(144, 198);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 24);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(40, 198);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(86, 24);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(100, 85);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(133, 20);
			this.txtPrice.TabIndex = 4;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(100, 47);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(133, 20);
			this.txtProductName.TabIndex = 3;
			// 
			// radLabel3
			// 
			this.radLabel3.Location = new System.Drawing.Point(16, 127);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new System.Drawing.Size(57, 18);
			this.radLabel3.TabIndex = 2;
			this.radLabel3.Text = "Category: ";
			// 
			// radLabel2
			// 
			this.radLabel2.Location = new System.Drawing.Point(16, 85);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(78, 18);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Product Price: ";
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(16, 47);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(84, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Product Name: ";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Drinks"});
			this.cmbCategory.Location = new System.Drawing.Point(100, 123);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 21);
			this.cmbCategory.TabIndex = 8;
			// 
			// RegisterProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 326);
			this.Controls.Add(this.radGroupBox1);
			this.Name = "RegisterProduct";
			this.Text = "RegisterProduct";
			this.Load += new System.EventHandler(this.RegisterProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadTextBox txtPrice;
		private Telerik.WinControls.UI.RadTextBox txtProductName;
		private Telerik.WinControls.UI.RadLabel radLabel3;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private System.Windows.Forms.ComboBox cmbCategory;
	}
}