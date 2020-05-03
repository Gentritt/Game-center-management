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
			this.components = new System.ComponentModel.Container();
			Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
			this.btnCreateAccount = new Telerik.WinControls.UI.RadButton();
			this.btnEditAccount = new Telerik.WinControls.UI.RadButton();
			this.btnDeleteAccount = new Telerik.WinControls.UI.RadButton();
			this.gridUsers = new Telerik.WinControls.UI.RadGridView();
			this.clientsBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCreateAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBLLBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.radLabel1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(800, 59);
			this.radPanel1.TabIndex = 0;
			this.radPanel1.ThemeName = "CrystalDark";
			// 
			// radLabel1
			// 
			this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radLabel1.ForeColor = System.Drawing.Color.White;
			this.radLabel1.Location = new System.Drawing.Point(203, 12);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(292, 33);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "User Accounts Administration";
			this.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Location = new System.Drawing.Point(622, 65);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(178, 37);
			this.btnCreateAccount.TabIndex = 2;
			this.btnCreateAccount.Text = "Create new Account";
			this.btnCreateAccount.ThemeName = "Crystal";
			this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
			// 
			// btnEditAccount
			// 
			this.btnEditAccount.Location = new System.Drawing.Point(622, 118);
			this.btnEditAccount.Name = "btnEditAccount";
			this.btnEditAccount.Size = new System.Drawing.Size(178, 37);
			this.btnEditAccount.TabIndex = 3;
			this.btnEditAccount.Text = "Edit Account";
			this.btnEditAccount.ThemeName = "Crystal";
			// 
			// btnDeleteAccount
			// 
			this.btnDeleteAccount.Location = new System.Drawing.Point(622, 170);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new System.Drawing.Size(178, 37);
			this.btnDeleteAccount.TabIndex = 4;
			this.btnDeleteAccount.Text = "Delete Account";
			this.btnDeleteAccount.ThemeName = "Crystal";
			// 
			// gridUsers
			// 
			this.gridUsers.Location = new System.Drawing.Point(13, 75);
			// 
			// 
			// 
			this.gridUsers.MasterTemplate.AllowAddNewRow = false;
			this.gridUsers.MasterTemplate.AllowColumnReorder = false;
			sortDescriptor1.PropertyName = "Name";
			this.gridUsers.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
			this.gridUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.ReadOnly = true;
			this.gridUsers.Size = new System.Drawing.Size(603, 363);
			this.gridUsers.TabIndex = 5;
			this.gridUsers.ThemeName = "Crystal";
			this.gridUsers.Click += new System.EventHandler(this.gridUsers_Click);
			// 
			// clientsBLLBindingSource
			// 
			this.clientsBLLBindingSource.DataSource = typeof(game_center_management.BLL.ClientsBLL);
			// 
			// UserAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gridUsers);
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
			((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBLLBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
		private Telerik.WinControls.UI.RadButton btnCreateAccount;
		private Telerik.WinControls.UI.RadButton btnEditAccount;
		private Telerik.WinControls.UI.RadButton btnDeleteAccount;
		private System.Windows.Forms.BindingSource clientsBLLBindingSource;
		private Telerik.WinControls.UI.RadGridView gridUsers;
	}
}