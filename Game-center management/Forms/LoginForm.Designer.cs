namespace Game_center_management
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
			this.jDragControl1 = new JDragControl.JDragControl(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new JTextBox.JTextBox();
			this.txtPassword = new JTextBox.JTextBox();
			this.btnCancel = new Telerik.WinControls.UI.RadButton();
			this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
			this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
			this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
			this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
			this.btnSubmit = new Telerik.WinControls.UI.RadButton();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblX = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// jDragControl1
			// 
			this.jDragControl1.GetForm = this;
			this.jDragControl1.TargetControl = this.panel1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblX);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(359, 124);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(56, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log In into your Account";
			// 
			// txtUsername
			// 
			this.txtUsername.AutoSize = true;
			this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
			this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtUsername.Hint = "";
			this.txtUsername.IsPassword = false;
			this.txtUsername.Length = 0;
			this.txtUsername.Location = new System.Drawing.Point(50, 153);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.OnFocus = System.Drawing.Color.DarkGray;
			this.txtUsername.OnlyChar = false;
			this.txtUsername.OnlyNumber = false;
			this.txtUsername.Size = new System.Drawing.Size(252, 39);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextValue = "";
			// 
			// txtPassword
			// 
			this.txtPassword.AutoSize = true;
			this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
			this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPassword.Hint = "";
			this.txtPassword.IsPassword = true;
			this.txtPassword.Length = 0;
			this.txtPassword.Location = new System.Drawing.Point(50, 224);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.OnFocus = System.Drawing.Color.DarkGray;
			this.txtPassword.OnlyChar = false;
			this.txtPassword.OnlyNumber = false;
			this.txtPassword.Size = new System.Drawing.Size(252, 39);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.TextValue = "";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Location = new System.Drawing.Point(203, 296);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 36);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.ThemeName = "MaterialBlueGrey";
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnSubmit.Location = new System.Drawing.Point(50, 296);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(99, 36);
			this.btnSubmit.TabIndex = 3;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.ThemeName = "MaterialBlueGrey";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblUsername.Location = new System.Drawing.Point(56, 127);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(92, 21);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "USERNAME";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblPassword.Location = new System.Drawing.Point(56, 198);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(95, 21);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "PASSWORD";
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX.ForeColor = System.Drawing.Color.White;
			this.lblX.Location = new System.Drawing.Point(344, 0);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(21, 23);
			this.lblX.TabIndex = 5;
			this.lblX.Text = "X";
			this.lblX.Click += new System.EventHandler(this.lblX_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(116, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(91, 79);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(359, 409);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Telerik.WinControls.RadThemeManager radThemeManager1;
		private JDragControl.JDragControl jDragControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private JTextBox.JTextBox txtUsername;
		private JTextBox.JTextBox txtPassword;
		private Telerik.WinControls.UI.RadButton btnCancel;
		private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
		private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
		private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
		private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
		private Telerik.WinControls.UI.RadButton btnSubmit;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}