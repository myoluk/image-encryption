
namespace ImageEncryptDecrypt
{
    partial class ImageEncryptDecrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEncryptDecrypt));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMainItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMainItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemModeEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemModeHard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainItemHelpContact = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxImage = new System.Windows.Forms.GroupBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.gbxSetPassword = new System.Windows.Forms.GroupBox();
            this.cbxHide = new System.Windows.Forms.CheckBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.rbtnSetPassword = new System.Windows.Forms.RadioButton();
            this.rbtnDefault = new System.Windows.Forms.RadioButton();
            this.gbxEncryptedDecrypted = new System.Windows.Forms.GroupBox();
            this.pbxEncryptedDecrypted = new System.Windows.Forms.PictureBox();
            this.ctxmsSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmsSaveDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmsSaveSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.gbxEncryptedPassword = new System.Windows.Forms.GroupBox();
            this.rbxEncryptedPassword = new System.Windows.Forms.RichTextBox();
            this.menuMain.SuspendLayout();
            this.gbxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.gbxPassword.SuspendLayout();
            this.gbxSetPassword.SuspendLayout();
            this.gbxEncryptedDecrypted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEncryptedDecrypted)).BeginInit();
            this.ctxmsSave.SuspendLayout();
            this.gbxEncryptedPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainItemFile,
            this.menuMainItemMode,
            this.menuMainItemHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(784, 24);
            this.menuMain.TabIndex = 10;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuMainItemFile
            // 
            this.menuMainItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainItemFileOpen,
            this.menuMainItemFileSave,
            this.menuMainItemFileClear,
            this.toolStripSeparator1,
            this.menuMainItemFileExit});
            this.menuMainItemFile.Name = "menuMainItemFile";
            this.menuMainItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuMainItemFile.Text = "File";
            // 
            // menuMainItemFileOpen
            // 
            this.menuMainItemFileOpen.Name = "menuMainItemFileOpen";
            this.menuMainItemFileOpen.Size = new System.Drawing.Size(190, 22);
            this.menuMainItemFileOpen.Text = "Open Image";
            this.menuMainItemFileOpen.Click += new System.EventHandler(this.menuMainItemFileOpen_Click);
            // 
            // menuMainItemFileSave
            // 
            this.menuMainItemFileSave.Name = "menuMainItemFileSave";
            this.menuMainItemFileSave.Size = new System.Drawing.Size(190, 22);
            this.menuMainItemFileSave.Text = "Save Encrypted Image";
            this.menuMainItemFileSave.Click += new System.EventHandler(this.menuMainItemFileSave_Click);
            // 
            // menuMainItemFileClear
            // 
            this.menuMainItemFileClear.Name = "menuMainItemFileClear";
            this.menuMainItemFileClear.Size = new System.Drawing.Size(190, 22);
            this.menuMainItemFileClear.Text = "Clear";
            this.menuMainItemFileClear.Click += new System.EventHandler(this.menuMainItemFileClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // menuMainItemFileExit
            // 
            this.menuMainItemFileExit.Name = "menuMainItemFileExit";
            this.menuMainItemFileExit.Size = new System.Drawing.Size(190, 22);
            this.menuMainItemFileExit.Text = "Exit";
            this.menuMainItemFileExit.Click += new System.EventHandler(this.menuMainItemFileExit_Click);
            // 
            // menuMainItemMode
            // 
            this.menuMainItemMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainItemModeEasy,
            this.menuMainItemModeHard});
            this.menuMainItemMode.Name = "menuMainItemMode";
            this.menuMainItemMode.Size = new System.Drawing.Size(50, 20);
            this.menuMainItemMode.Text = "Mode";
            // 
            // menuMainItemModeEasy
            // 
            this.menuMainItemModeEasy.Name = "menuMainItemModeEasy";
            this.menuMainItemModeEasy.Size = new System.Drawing.Size(172, 22);
            this.menuMainItemModeEasy.Text = "Easy/Fast (Default)";
            this.menuMainItemModeEasy.Click += new System.EventHandler(this.menuMainItemModeEasy_Click);
            // 
            // menuMainItemModeHard
            // 
            this.menuMainItemModeHard.Name = "menuMainItemModeHard";
            this.menuMainItemModeHard.Size = new System.Drawing.Size(172, 22);
            this.menuMainItemModeHard.Text = "Hard/Slow";
            this.menuMainItemModeHard.Click += new System.EventHandler(this.menuMainItemModeHard_Click);
            // 
            // menuMainItemHelp
            // 
            this.menuMainItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainItemHelpAbout,
            this.menuMainItemHelpContact});
            this.menuMainItemHelp.Name = "menuMainItemHelp";
            this.menuMainItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuMainItemHelp.Text = "Help";
            // 
            // menuMainItemHelpAbout
            // 
            this.menuMainItemHelpAbout.Name = "menuMainItemHelpAbout";
            this.menuMainItemHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuMainItemHelpAbout.Text = "About";
            this.menuMainItemHelpAbout.Click += new System.EventHandler(this.menuMainItemHelpAbout_Click);
            // 
            // menuMainItemHelpContact
            // 
            this.menuMainItemHelpContact.Name = "menuMainItemHelpContact";
            this.menuMainItemHelpContact.Size = new System.Drawing.Size(116, 22);
            this.menuMainItemHelpContact.Text = "Contact";
            this.menuMainItemHelpContact.Click += new System.EventHandler(this.menuMainItemHelpContact_Click);
            // 
            // gbxImage
            // 
            this.gbxImage.Controls.Add(this.pbxImage);
            this.gbxImage.Location = new System.Drawing.Point(12, 27);
            this.gbxImage.Name = "gbxImage";
            this.gbxImage.Size = new System.Drawing.Size(374, 345);
            this.gbxImage.TabIndex = 1;
            this.gbxImage.TabStop = false;
            this.gbxImage.Text = "Image";
            // 
            // pbxImage
            // 
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(3, 22);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(368, 320);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.pbxImage_Click);
            // 
            // gbxPassword
            // 
            this.gbxPassword.Controls.Add(this.gbxSetPassword);
            this.gbxPassword.Controls.Add(this.rbtnSetPassword);
            this.gbxPassword.Controls.Add(this.rbtnDefault);
            this.gbxPassword.Location = new System.Drawing.Point(12, 378);
            this.gbxPassword.Name = "gbxPassword";
            this.gbxPassword.Size = new System.Drawing.Size(290, 150);
            this.gbxPassword.TabIndex = 0;
            this.gbxPassword.TabStop = false;
            this.gbxPassword.Text = "Password";
            // 
            // gbxSetPassword
            // 
            this.gbxSetPassword.Controls.Add(this.cbxHide);
            this.gbxSetPassword.Controls.Add(this.tbxPassword);
            this.gbxSetPassword.Enabled = false;
            this.gbxSetPassword.Location = new System.Drawing.Point(6, 71);
            this.gbxSetPassword.Name = "gbxSetPassword";
            this.gbxSetPassword.Size = new System.Drawing.Size(278, 73);
            this.gbxSetPassword.TabIndex = 2;
            this.gbxSetPassword.TabStop = false;
            // 
            // cbxHide
            // 
            this.cbxHide.AutoSize = true;
            this.cbxHide.Location = new System.Drawing.Point(216, 25);
            this.cbxHide.Name = "cbxHide";
            this.cbxHide.Size = new System.Drawing.Size(56, 22);
            this.cbxHide.TabIndex = 4;
            this.cbxHide.TabStop = false;
            this.cbxHide.Text = "Hide";
            this.cbxHide.UseVisualStyleBackColor = true;
            this.cbxHide.CheckedChanged += new System.EventHandler(this.cbxHide_CheckedChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(13, 23);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(200, 26);
            this.tbxPassword.TabIndex = 0;
            // 
            // rbtnSetPassword
            // 
            this.rbtnSetPassword.AutoSize = true;
            this.rbtnSetPassword.Location = new System.Drawing.Point(6, 53);
            this.rbtnSetPassword.Name = "rbtnSetPassword";
            this.rbtnSetPassword.Size = new System.Drawing.Size(168, 22);
            this.rbtnSetPassword.TabIndex = 2;
            this.rbtnSetPassword.Text = "I want to set password:";
            this.rbtnSetPassword.UseVisualStyleBackColor = true;
            this.rbtnSetPassword.CheckedChanged += new System.EventHandler(this.rbtnSetPassword_CheckedChanged);
            // 
            // rbtnDefault
            // 
            this.rbtnDefault.AutoSize = true;
            this.rbtnDefault.Checked = true;
            this.rbtnDefault.Location = new System.Drawing.Point(6, 25);
            this.rbtnDefault.Name = "rbtnDefault";
            this.rbtnDefault.Size = new System.Drawing.Size(156, 22);
            this.rbtnDefault.TabIndex = 1;
            this.rbtnDefault.TabStop = true;
            this.rbtnDefault.Text = "Set password for me.";
            this.rbtnDefault.UseVisualStyleBackColor = true;
            this.rbtnDefault.CheckedChanged += new System.EventHandler(this.rbtnDefault_CheckedChanged);
            // 
            // gbxEncryptedDecrypted
            // 
            this.gbxEncryptedDecrypted.Controls.Add(this.pbxEncryptedDecrypted);
            this.gbxEncryptedDecrypted.Location = new System.Drawing.Point(398, 27);
            this.gbxEncryptedDecrypted.Name = "gbxEncryptedDecrypted";
            this.gbxEncryptedDecrypted.Size = new System.Drawing.Size(374, 345);
            this.gbxEncryptedDecrypted.TabIndex = 1;
            this.gbxEncryptedDecrypted.TabStop = false;
            this.gbxEncryptedDecrypted.Text = "Encrypted/Decrypted";
            // 
            // pbxEncryptedDecrypted
            // 
            this.pbxEncryptedDecrypted.ContextMenuStrip = this.ctxmsSave;
            this.pbxEncryptedDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxEncryptedDecrypted.Location = new System.Drawing.Point(3, 22);
            this.pbxEncryptedDecrypted.Name = "pbxEncryptedDecrypted";
            this.pbxEncryptedDecrypted.Size = new System.Drawing.Size(368, 320);
            this.pbxEncryptedDecrypted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEncryptedDecrypted.TabIndex = 1;
            this.pbxEncryptedDecrypted.TabStop = false;
            // 
            // ctxmsSave
            // 
            this.ctxmsSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmsSaveDelete,
            this.ctxmsSaveSave});
            this.ctxmsSave.Name = "ctxmsSave";
            this.ctxmsSave.Size = new System.Drawing.Size(108, 48);
            // 
            // ctxmsSaveDelete
            // 
            this.ctxmsSaveDelete.Name = "ctxmsSaveDelete";
            this.ctxmsSaveDelete.Size = new System.Drawing.Size(107, 22);
            this.ctxmsSaveDelete.Text = "Delete";
            this.ctxmsSaveDelete.Click += new System.EventHandler(this.ctxmsSaveDelete_Click);
            // 
            // ctxmsSaveSave
            // 
            this.ctxmsSaveSave.Name = "ctxmsSaveSave";
            this.ctxmsSaveSave.Size = new System.Drawing.Size(107, 22);
            this.ctxmsSaveSave.Text = "Save";
            this.ctxmsSaveSave.Click += new System.EventHandler(this.ctxmsSaveSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(308, 386);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 30);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(308, 458);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 30);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(308, 422);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // gbxEncryptedPassword
            // 
            this.gbxEncryptedPassword.Controls.Add(this.rbxEncryptedPassword);
            this.gbxEncryptedPassword.Location = new System.Drawing.Point(401, 378);
            this.gbxEncryptedPassword.Name = "gbxEncryptedPassword";
            this.gbxEncryptedPassword.Size = new System.Drawing.Size(368, 150);
            this.gbxEncryptedPassword.TabIndex = 6;
            this.gbxEncryptedPassword.TabStop = false;
            this.gbxEncryptedPassword.Text = "Encrypted Password";
            // 
            // rbxEncryptedPassword
            // 
            this.rbxEncryptedPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbxEncryptedPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbxEncryptedPassword.Location = new System.Drawing.Point(3, 22);
            this.rbxEncryptedPassword.Name = "rbxEncryptedPassword";
            this.rbxEncryptedPassword.ReadOnly = true;
            this.rbxEncryptedPassword.Size = new System.Drawing.Size(362, 125);
            this.rbxEncryptedPassword.TabIndex = 8;
            this.rbxEncryptedPassword.Text = "";
            // 
            // ImageEncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.gbxEncryptedPassword);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.gbxPassword);
            this.Controls.Add(this.gbxEncryptedDecrypted);
            this.Controls.Add(this.gbxImage);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 580);
            this.Name = "ImageEncryptDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Encrypt/Decrypt";
            this.Load += new System.EventHandler(this.MST_ImageEncryptorDecryptor_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.gbxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.gbxPassword.ResumeLayout(false);
            this.gbxPassword.PerformLayout();
            this.gbxSetPassword.ResumeLayout(false);
            this.gbxSetPassword.PerformLayout();
            this.gbxEncryptedDecrypted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEncryptedDecrypted)).EndInit();
            this.ctxmsSave.ResumeLayout(false);
            this.gbxEncryptedPassword.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemHelpContact;
        private System.Windows.Forms.GroupBox gbxImage;
        private System.Windows.Forms.GroupBox gbxPassword;
        private System.Windows.Forms.GroupBox gbxSetPassword;
        private System.Windows.Forms.CheckBox cbxHide;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.RadioButton rbtnSetPassword;
        private System.Windows.Forms.RadioButton rbtnDefault;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.GroupBox gbxEncryptedDecrypted;
        private System.Windows.Forms.PictureBox pbxEncryptedDecrypted;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox gbxEncryptedPassword;
        private System.Windows.Forms.RichTextBox rbxEncryptedPassword;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemMode;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemModeHard;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemModeEasy;
        private System.Windows.Forms.ToolStripMenuItem menuMainItemFileClear;
        private System.Windows.Forms.ContextMenuStrip ctxmsSave;
        private System.Windows.Forms.ToolStripMenuItem ctxmsSaveSave;
        private System.Windows.Forms.ToolStripMenuItem ctxmsSaveDelete;
    }
}

