namespace Game_center_management.Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new Telerik.WinControls.UI.RadTextBox();
            this.txtComputerID = new Telerik.WinControls.UI.RadTextBox();
            this.txtStartTime = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.cmbClientID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ComputerID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ClientID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(103, 22);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // txtComputerID
            // 
            this.txtComputerID.Location = new System.Drawing.Point(103, 62);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.Size = new System.Drawing.Size(100, 20);
            this.txtComputerID.TabIndex = 5;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(103, 149);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            // 
            // cmbClientID
            // 
            this.cmbClientID.FormattingEnabled = true;
            this.cmbClientID.Location = new System.Drawing.Point(103, 106);
            this.cmbClientID.Name = "cmbClientID";
            this.cmbClientID.Size = new System.Drawing.Size(100, 21);
            this.cmbClientID.TabIndex = 10;
            // 
            // StartComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 227);
            this.Controls.Add(this.cmbClientID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartComputer";
            this.Text = "StartComputer";
            this.Load += new System.EventHandler(this.StartComputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtEmployeeID;
        private Telerik.WinControls.UI.RadTextBox txtComputerID;
        private Telerik.WinControls.UI.RadTextBox txtStartTime;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.ComboBox cmbClientID;
    }
}