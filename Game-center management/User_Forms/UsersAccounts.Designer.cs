namespace Game_center_management.Forms
{
	partial class UserAccounts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccounts));
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.jImageButton1 = new JImageButton.JImageButton();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
			this.btnCreateAccount = new Telerik.WinControls.UI.RadButton();
			this.btnEditAccount = new Telerik.WinControls.UI.RadButton();
			this.btnDeleteAccount = new Telerik.WinControls.UI.RadButton();
			this.btnRefresh = new Telerik.WinControls.UI.RadButton();
			this.gridUsers = new Telerik.WinControls.UI.RadGridView();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCreateAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).BeginInit();
			this.SuspendLayout();
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.jImageButton1);
			this.radPanel1.Controls.Add(this.radLabel1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(801, 59);
			this.radPanel1.TabIndex = 0;
			this.radPanel1.ThemeName = "CrystalDark";
			// 
			// jImageButton1
			// 
			this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.jImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.jImageButton1.CausesValidation = false;
			this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
			this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
			this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
			this.jImageButton1.ImageHover = null;
			this.jImageButton1.InitialImage = null;
			this.jImageButton1.Location = new System.Drawing.Point(0, 0);
			this.jImageButton1.Name = "jImageButton1";
			this.jImageButton1.Size = new System.Drawing.Size(160, 59);
			this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.jImageButton1.TabIndex = 2;
			this.jImageButton1.Zoom = 4;
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.ForeColor = System.Drawing.Color.White;
			this.radLabel1.Location = new System.Drawing.Point(189, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(292, 33);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "User Accounts Administration";
			this.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.Image")));
			this.btnCreateAccount.Location = new System.Drawing.Point(13, 65);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(147, 37);
			this.btnCreateAccount.TabIndex = 2;
			this.btnCreateAccount.Text = "ADD ";
			this.btnCreateAccount.ThemeName = "Crystal";
			this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
			// 
			// btnEditAccount
			// 
			this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
			this.btnEditAccount.Location = new System.Drawing.Point(189, 65);
			this.btnEditAccount.Name = "btnEditAccount";
			this.btnEditAccount.Size = new System.Drawing.Size(147, 37);
			this.btnEditAccount.TabIndex = 3;
			this.btnEditAccount.Text = "EDIT";
			this.btnEditAccount.ThemeName = "Crystal";
			// 
			// btnDeleteAccount
			// 
			this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
			this.btnDeleteAccount.Location = new System.Drawing.Point(361, 65);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new System.Drawing.Size(147, 37);
			this.btnDeleteAccount.TabIndex = 4;
			this.btnDeleteAccount.Text = "DELETE";
			this.btnDeleteAccount.ThemeName = "CrystalDark";
			this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(537, 65);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(147, 38);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "      REFRESH";
			this.btnRefresh.ThemeName = "CrystalDark";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// gridUsers
			// 
			this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridUsers.Location = new System.Drawing.Point(12, 128);
			// 
			// 
			// 
			this.gridUsers.MasterTemplate.AllowAddNewRow = false;
			this.gridUsers.MasterTemplate.AllowColumnReorder = false;
			this.gridUsers.MasterTemplate.AllowSearchRow = true;
			this.gridUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
			this.gridUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.ReadOnly = true;
			// 
			// 
			// 
			this.gridUsers.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
			this.gridUsers.RootElement.BorderHighlightColor = System.Drawing.Color.Gray;
			this.gridUsers.Size = new System.Drawing.Size(672, 339);
			this.gridUsers.TabIndex = 7;
			this.gridUsers.ThemeName = "CrystalDark";
			// 
			// UserAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 465);
			this.Controls.Add(this.gridUsers);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDeleteAccount);
			this.Controls.Add(this.btnEditAccount);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.radPanel1);
			this.Name = "UserAccounts";
			this.Text = "Create_User";
			this.Load += new System.EventHandler(this.Create_User_Load);
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			this.radPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCreateAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
		private Telerik.WinControls.UI.RadButton btnCreateAccount;
		private Telerik.WinControls.UI.RadButton btnEditAccount;
		private Telerik.WinControls.UI.RadButton btnDeleteAccount;
		private Telerik.WinControls.UI.RadButton btnRefresh;
		private JImageButton.JImageButton jImageButton1;
		private Telerik.WinControls.UI.RadGridView gridUsers;
	}
}