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
			this.lblUsername = new System.Windows.Forms.Label();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
			this.txtPassowrd = new JTextBox.JTextBox();
			this.grUserInformation = new Telerik.WinControls.UI.RadGroupBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
			this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
			this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
			this.radTextBox4 = new Telerik.WinControls.UI.RadTextBox();
			this.radTextBox5 = new Telerik.WinControls.UI.RadTextBox();
			this.btnSave = new Telerik.WinControls.UI.RadButton();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.grLoginInformation)).BeginInit();
			this.grLoginInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grUserInformation)).BeginInit();
			this.grUserInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			this.SuspendLayout();
			// 
			// grLoginInformation
			// 
			this.grLoginInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grLoginInformation.Controls.Add(this.txtPassowrd);
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
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.Location = new System.Drawing.Point(24, 79);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(76, 25);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(116, 32);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(146, 20);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassowrd
			// 
			this.txtPassowrd.AutoSize = true;
			this.txtPassowrd.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.txtPassowrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPassowrd.Hint = "";
			this.txtPassowrd.IsPassword = true;
			this.txtPassowrd.Length = 0;
			this.txtPassowrd.Location = new System.Drawing.Point(116, 80);
			this.txtPassowrd.Name = "txtPassowrd";
			this.txtPassowrd.OnFocus = System.Drawing.Color.DarkGray;
			this.txtPassowrd.OnlyChar = false;
			this.txtPassowrd.OnlyNumber = false;
			this.txtPassowrd.Size = new System.Drawing.Size(146, 24);
			this.txtPassowrd.TabIndex = 3;
			this.txtPassowrd.TextValue = "";
			// 
			// grUserInformation
			// 
			this.grUserInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grUserInformation.Controls.Add(this.radTextBox5);
			this.grUserInformation.Controls.Add(this.radTextBox4);
			this.grUserInformation.Controls.Add(this.radTextBox3);
			this.grUserInformation.Controls.Add(this.radTextBox2);
			this.grUserInformation.Controls.Add(this.radTextBox1);
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
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 40);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(51, 17);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name: ";
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
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(6, 124);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(67, 17);
			this.lblBirthday.TabIndex = 2;
			this.lblBirthday.Text = "Birthday: ";
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
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(6, 208);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(48, 17);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Email: ";
			// 
			// radTextBox1
			// 
			this.radTextBox1.Location = new System.Drawing.Point(91, 40);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.Size = new System.Drawing.Size(148, 20);
			this.radTextBox1.TabIndex = 5;
			// 
			// radTextBox2
			// 
			this.radTextBox2.Location = new System.Drawing.Point(91, 130);
			this.radTextBox2.Name = "radTextBox2";
			this.radTextBox2.Size = new System.Drawing.Size(148, 20);
			this.radTextBox2.TabIndex = 6;
			// 
			// radTextBox3
			// 
			this.radTextBox3.Location = new System.Drawing.Point(91, 85);
			this.radTextBox3.Name = "radTextBox3";
			this.radTextBox3.Size = new System.Drawing.Size(148, 20);
			this.radTextBox3.TabIndex = 6;
			// 
			// radTextBox4
			// 
			this.radTextBox4.Location = new System.Drawing.Point(91, 175);
			this.radTextBox4.Name = "radTextBox4";
			this.radTextBox4.Size = new System.Drawing.Size(148, 20);
			this.radTextBox4.TabIndex = 6;
			// 
			// radTextBox5
			// 
			this.radTextBox5.Location = new System.Drawing.Point(91, 220);
			this.radTextBox5.Name = "radTextBox5";
			this.radTextBox5.Size = new System.Drawing.Size(148, 20);
			this.radTextBox5.TabIndex = 7;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(45, 439);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 46);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.ThemeName = "Crystal";
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
			((System.ComponentModel.ISupportInitialize)(this.grLoginInformation)).EndInit();
			this.grLoginInformation.ResumeLayout(false);
			this.grLoginInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grUserInformation)).EndInit();
			this.grUserInformation.ResumeLayout(false);
			this.grUserInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox grLoginInformation;
		private System.Windows.Forms.Label lblUsername;
		private JTextBox.JTextBox txtPassowrd;
		private Telerik.WinControls.UI.RadTextBox txtUsername;
		private Telerik.WinControls.UI.RadTextBox radTextBox1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadGroupBox grUserInformation;
		private Telerik.WinControls.UI.RadTextBox radTextBox5;
		private Telerik.WinControls.UI.RadTextBox radTextBox4;
		private Telerik.WinControls.UI.RadTextBox radTextBox3;
		private Telerik.WinControls.UI.RadTextBox radTextBox2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblName;
		private Telerik.WinControls.UI.RadButton btnSave;
		private Telerik.WinControls.UI.RadButton btnCancel;
	}
}