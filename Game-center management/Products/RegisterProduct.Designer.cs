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
			this.components = new System.ComponentModel.Container();
			this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtInserDate = new Telerik.WinControls.UI.RadTextBox();
			this.txtInserBy = new Telerik.WinControls.UI.RadTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtQuantity = new Telerik.WinControls.UI.RadTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
			this.txtProductName = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.erpProductName = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpProductPrice = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpQuantity = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpInsertBy = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpInsertDate = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInserDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInserBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpProductPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpInsertBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpInsertDate)).BeginInit();
			this.SuspendLayout();
			// 
			// radGroupBox1
			// 
			this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.label3);
			this.radGroupBox1.Controls.Add(this.txtInserDate);
			this.radGroupBox1.Controls.Add(this.txtInserBy);
			this.radGroupBox1.Controls.Add(this.label2);
			this.radGroupBox1.Controls.Add(this.txtQuantity);
			this.radGroupBox1.Controls.Add(this.label1);
			this.radGroupBox1.Controls.Add(this.btnCancel);
			this.radGroupBox1.Controls.Add(this.btnSave);
			this.radGroupBox1.Controls.Add(this.txtPrice);
			this.radGroupBox1.Controls.Add(this.txtProductName);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.Controls.Add(this.radLabel1);
			this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
			this.radGroupBox1.HeaderText = "Register Product";
			this.radGroupBox1.Location = new System.Drawing.Point(31, 28);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new System.Drawing.Size(255, 283);
			this.radGroupBox1.TabIndex = 0;
			this.radGroupBox1.Text = "Register Product";
			this.radGroupBox1.ThemeName = "Crystal";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 17);
			this.label3.TabIndex = 13;
			this.label3.Text = "InsertDate: ";
			// 
			// txtInserDate
			// 
			this.txtInserDate.Location = new System.Drawing.Point(100, 195);
			this.txtInserDate.Name = "txtInserDate";
			this.txtInserDate.Size = new System.Drawing.Size(133, 20);
			this.txtInserDate.TabIndex = 4;
			// 
			// txtInserBy
			// 
			this.txtInserBy.Location = new System.Drawing.Point(100, 155);
			this.txtInserBy.Name = "txtInserBy";
			this.txtInserBy.Size = new System.Drawing.Size(133, 20);
			this.txtInserBy.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "InsertBY: ";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(100, 120);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(133, 20);
			this.txtQuantity.TabIndex = 2;
			this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Quantity: ";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(147, 232);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 24);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(17, 232);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(86, 24);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(100, 85);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(133, 20);
			this.txtPrice.TabIndex = 1;
			this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(100, 47);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(133, 20);
			this.txtProductName.TabIndex = 0;
			// 
			// radLabel2
			// 
			this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel2.Location = new System.Drawing.Point(11, 85);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(92, 21);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Product Price: ";
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.Location = new System.Drawing.Point(11, 47);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(99, 21);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Product Name: ";
			// 
			// erpProductName
			// 
			this.erpProductName.ContainerControl = this;
			// 
			// erpProductPrice
			// 
			this.erpProductPrice.ContainerControl = this;
			// 
			// erpQuantity
			// 
			this.erpQuantity.ContainerControl = this;
			// 
			// erpInsertBy
			// 
			this.erpInsertBy.ContainerControl = this;
			// 
			// erpInsertDate
			// 
			this.erpInsertDate.ContainerControl = this;
			// 
			// RegisterProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 355);
			this.Controls.Add(this.radGroupBox1);
			this.Name = "RegisterProduct";
			this.Text = "RegisterProduct";
			this.Load += new System.EventHandler(this.RegisterProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInserDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInserBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpProductPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpInsertBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpInsertDate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadTextBox txtPrice;
		private Telerik.WinControls.UI.RadTextBox txtProductName;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadTextBox txtQuantity;
		private System.Windows.Forms.Label label1;
		private Telerik.WinControls.UI.RadTextBox txtInserDate;
		private Telerik.WinControls.UI.RadTextBox txtInserBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider erpProductName;
		private System.Windows.Forms.ErrorProvider erpProductPrice;
		private System.Windows.Forms.ErrorProvider erpQuantity;
		private System.Windows.Forms.ErrorProvider erpInsertBy;
		private System.Windows.Forms.ErrorProvider erpInsertDate;
	}
}