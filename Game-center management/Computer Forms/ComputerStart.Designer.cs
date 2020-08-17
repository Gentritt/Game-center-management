namespace Game_center_management.Computer_Forms
{
    partial class ComputerStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerStart));
            this.cmbClientID = new System.Windows.Forms.ComboBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtStartTime = new Telerik.WinControls.UI.RadTextBox();
            this.txtComputerID = new Telerik.WinControls.UI.RadTextBox();
            this.txtEmployee = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientID
            // 
            this.cmbClientID.FormattingEnabled = true;
            resources.ApplyResources(this.cmbClientID, "cmbClientID");
            this.cmbClientID.Name = "cmbClientID";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtStartTime
            // 
            resources.ApplyResources(this.txtStartTime, "txtStartTime");
            this.txtStartTime.Name = "txtStartTime";
            // 
            // txtComputerID
            // 
            resources.ApplyResources(this.txtComputerID, "txtComputerID");
            this.txtComputerID.Name = "txtComputerID";
            // 
            // txtEmployee
            // 
            resources.ApplyResources(this.txtEmployee, "txtEmployee");
            this.txtEmployee.Name = "txtEmployee";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ComputerStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbClientID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComputerStart";
            this.Load += new System.EventHandler(this.ComputerStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientID;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadTextBox txtComputerID;
        public Telerik.WinControls.UI.RadTextBox txtEmployee;
    }
}