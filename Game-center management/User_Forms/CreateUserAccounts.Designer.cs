namespace Game_center_management.Forms
{
	partial class CreateUserAccounts
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
			this.grLoginInformation = new Telerik.WinControls.UI.RadGroupBox();
			this.txtPasswordUserAcc = new Telerik.WinControls.UI.RadTextBox();
			this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.lblUsername = new System.Windows.Forms.Label();
			this.grUserInformation = new Telerik.WinControls.UI.RadGroupBox();
			this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
			this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
			this.txtLastname = new Telerik.WinControls.UI.RadTextBox();
			this.txtBirthday = new Telerik.WinControls.UI.RadTextBox();
			this.txtName = new Telerik.WinControls.UI.RadTextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.grLoginInformation)).BeginInit();
			this.grLoginInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPasswordUserAcc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grUserInformation)).BeginInit();
			this.grUserInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastname)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			this.SuspendLayout();
			// 
			// grLoginInformation
			// 
			this.grLoginInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grLoginInformation.Controls.Add(this.txtPasswordUserAcc);
			this.grLoginInformation.Controls.Add(this.txtUsername);
			this.grLoginInformation.Controls.Add(this.radLabel1);
			this.grLoginInformation.Controls.Add(this.lblUsername);
			this.grLoginInformation.HeaderMargin = new System.Windows.Forms.Padding(1);
			this.grLoginInformation.HeaderText = "Login Information";
			this.grLoginInformation.Location = new System.Drawing.Point(36, 24);
			this.grLoginInformation.Name = "grLoginInformation";
			this.grLoginInformation.Size = new System.Drawing.Size(304, 126);
			this.grLoginInformation.TabIndex = 0;
			this.grLoginInformation.Text = "Login Information";
			this.grLoginInformation.ThemeName = "Crystal";
			this.grLoginInformation.Click += new System.EventHandler(this.grLoginInformation_Click);
			// 
			// txtPasswordUserAcc
			// 
			this.txtPasswordUserAcc.Location = new System.Drawing.Point(116, 79);
			this.txtPasswordUserAcc.Name = "txtPasswordUserAcc";
			this.txtPasswordUserAcc.Size = new System.Drawing.Size(146, 20);
			this.txtPasswordUserAcc.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(116, 32);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(146, 20);
			this.txtUsername.TabIndex = 2;
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.Location = new System.Drawing.Point(24, 79);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(76, 25);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(20, 31);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(81, 21);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			// 
			// grUserInformation
			// 
			this.grUserInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grUserInformation.Controls.Add(this.txtEmail);
			this.grUserInformation.Controls.Add(this.txtPhone);
			this.grUserInformation.Controls.Add(this.txtLastname);
			this.grUserInformation.Controls.Add(this.txtBirthday);
			this.grUserInformation.Controls.Add(this.txtName);
			this.grUserInformation.Controls.Add(this.lblEmail);
			this.grUserInformation.Controls.Add(this.lblPhone);
			this.grUserInformation.Controls.Add(this.lblBirthday);
			this.grUserInformation.Controls.Add(this.lblLastName);
			this.grUserInformation.Controls.Add(this.lblName);
			this.grUserInformation.HeaderMargin = new System.Windows.Forms.Padding(1);
			this.grUserInformation.HeaderText = "User Information";
			this.grUserInformation.Location = new System.Drawing.Point(36, 156);
			this.grUserInformation.Name = "grUserInformation";
			this.grUserInformation.Size = new System.Drawing.Size(304, 277);
			this.grUserInformation.TabIndex = 1;
			this.grUserInformation.Text = "User Information";
			this.grUserInformation.ThemeName = "Crystal";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(91, 220);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(148, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(91, 175);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(148, 20);
			this.txtPhone.TabIndex = 6;
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(91, 85);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(148, 20);
			this.txtLastname.TabIndex = 6;
			// 
			// txtBirthday
			// 
			this.txtBirthday.Location = new System.Drawing.Point(91, 130);
			this.txtBirthday.Name = "txtBirthday";
			this.txtBirthday.Size = new System.Drawing.Size(148, 20);
			this.txtBirthday.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(91, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(148, 20);
			this.txtName.TabIndex = 5;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(6, 208);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(48, 17);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Email: ";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(6, 166);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(54, 17);
			this.lblPhone.TabIndex = 3;
			this.lblPhone.Text = "Phone: ";
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(6, 124);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(67, 17);
			this.lblBirthday.TabIndex = 2;
			this.lblBirthday.Text = "Birthday: ";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(6, 82);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(79, 17);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "LastName: ";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 40);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(51, 17);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name: ";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(45, 439);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 46);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(210, 439);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(110, 46);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "Crystal";
			// 
			// CreateUserAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 508);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.grUserInformation);
			this.Controls.Add(this.grLoginInformation);
			this.Name = "CreateUserAccounts";
			this.Text = "CreateUserAccounts";
			this.Load += new System.EventHandler(this.CreateUserAccounts_Load);
			((System.ComponentModel.ISupportInitialize)(this.grLoginInformation)).EndInit();
			this.grLoginInformation.ResumeLayout(false);
			this.grLoginInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPasswordUserAcc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grUserInformation)).EndInit();
			this.grUserInformation.ResumeLayout(false);
			this.grUserInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastname)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox grLoginInformation;
		private System.Windows.Forms.Label lblUsername;
		private Telerik.WinControls.UI.RadTextBox txtUsername;
		private Telerik.WinControls.UI.RadTextBox txtName;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadGroupBox grUserInformation;
		private Telerik.WinControls.UI.RadTextBox txtEmail;
		private Telerik.WinControls.UI.RadTextBox txtPhone;
		private Telerik.WinControls.UI.RadTextBox txtLastname;
		private Telerik.WinControls.UI.RadTextBox txtBirthday;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblName;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.UI.RadTextBox txtPasswordUserAcc;
	}
}