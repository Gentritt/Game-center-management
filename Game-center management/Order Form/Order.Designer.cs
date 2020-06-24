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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.btnGiveOrder = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grvOrders = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiveOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Location = new System.Drawing.Point(102, 31);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(35, 13);
            this.lblBillID.TabIndex = 4;
            this.lblBillID.Text = "label5";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(105, 61);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(100, 21);
            this.cmbProduct.TabIndex = 5;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(102, 136);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "label5";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 99);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // btnGiveOrder
            // 
            this.btnGiveOrder.Location = new System.Drawing.Point(23, 173);
            this.btnGiveOrder.Name = "btnGiveOrder";
            this.btnGiveOrder.Size = new System.Drawing.Size(80, 24);
            this.btnGiveOrder.TabIndex = 8;
            this.btnGiveOrder.Text = "Give order";
            this.btnGiveOrder.Click += new System.EventHandler(this.btnGiveOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 203);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // grvOrders
            // 
            this.grvOrders.Location = new System.Drawing.Point(248, 31);
            // 
            // 
            // 
            this.grvOrders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grvOrders.Name = "grvOrders";
            this.grvOrders.Size = new System.Drawing.Size(352, 293);
            this.grvOrders.TabIndex = 13;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 362);
            this.Controls.Add(this.grvOrders);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGiveOrder);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiveOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton btnGiveOrder;
        private Telerik.WinControls.UI.RadButton btnCancel;
        public System.Windows.Forms.Label lblBillID;
        public System.Windows.Forms.ComboBox cmbProduct;
        public System.Windows.Forms.Label lblPrice;
        public Telerik.WinControls.UI.RadTextBox txtQuantity;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textBox2;
        private Telerik.WinControls.UI.RadGridView grvOrders;
    }
}