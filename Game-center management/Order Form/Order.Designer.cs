namespace Game_center_management.Products
{
    partial class Order
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnGiveOrder = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.grvOrders = new Telerik.WinControls.UI.RadGridView();
            this.grvProducts = new Telerik.WinControls.UI.RadGridView();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiveOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Location = new System.Drawing.Point(102, 9);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(35, 13);
            this.lblBillID.TabIndex = 4;
            this.lblBillID.Text = "label5";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(107, 56);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(102, 21);
            this.cmbProduct.TabIndex = 5;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(104, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "label5";
            // 
            // btnGiveOrder
            // 
            this.btnGiveOrder.Location = new System.Drawing.Point(25, 205);
            this.btnGiveOrder.Name = "btnGiveOrder";
            this.btnGiveOrder.Size = new System.Drawing.Size(80, 24);
            this.btnGiveOrder.TabIndex = 8;
            this.btnGiveOrder.Text = "Give order";
            this.btnGiveOrder.Click += new System.EventHandler(this.btnGiveOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grvOrders
            // 
            this.grvOrders.Location = new System.Drawing.Point(267, 28);
            // 
            // 
            // 
            this.grvOrders.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.grvOrders.Name = "grvOrders";
            this.grvOrders.Size = new System.Drawing.Size(341, 274);
            this.grvOrders.TabIndex = 13;
            // 
            // grvProducts
            // 
            this.grvProducts.Location = new System.Drawing.Point(43, 319);
            // 
            // 
            // 
            this.grvProducts.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.Size = new System.Drawing.Size(13, 10);
            this.grvProducts.TabIndex = 14;
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbQuantity.Location = new System.Drawing.Point(105, 99);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(102, 21);
            this.cmbQuantity.TabIndex = 15;
            this.cmbQuantity.SelectedIndexChanged += new System.EventHandler(this.cmbQuantity_SelectedIndexChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 250);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.grvProducts);
            this.Controls.Add(this.grvOrders);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGiveOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGiveOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton btnGiveOrder;
        private Telerik.WinControls.UI.RadButton btnCancel;
        public System.Windows.Forms.Label lblBillID;
        public System.Windows.Forms.ComboBox cmbProduct;
        public System.Windows.Forms.Label lblPrice;
        private Telerik.WinControls.UI.RadGridView grvOrders;
        private Telerik.WinControls.UI.RadGridView grvProducts;
        public System.Windows.Forms.ComboBox cmbQuantity;
    }
}