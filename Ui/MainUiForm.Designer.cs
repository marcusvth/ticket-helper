using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using tickethelper.Properties;

namespace tickethelper
{
    partial class MainUiForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUiForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnlSchin = new System.Windows.Forms.Panel();
            this.btnSchinMoreInfo = new System.Windows.Forms.Button();
            this.btnResetSchin = new System.Windows.Forms.Button();
            this.btnToggleSchin = new System.Windows.Forms.Button();
            this.lbSchinBadPwd = new System.Windows.Forms.Label();
            this.lbSchinBadPwdHeader = new System.Windows.Forms.Label();
            this.lbSchinPwdExpire = new System.Windows.Forms.Label();
            this.lbSchinAccountExpire = new System.Windows.Forms.Label();
            this.lbSchinIsLocked = new System.Windows.Forms.Label();
            this.lbSchinPwdExpireHeader = new System.Windows.Forms.Label();
            this.lbSchinAccountExpireHeader = new System.Windows.Forms.Label();
            this.lbSchinIsLockedHeader = new System.Windows.Forms.Label();
            this.lbSchinPanelTitle = new System.Windows.Forms.Label();
            this.pbSchinWindowsLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeiway = new System.Windows.Forms.Panel();
            this.btnHeiwayMoreInfo = new System.Windows.Forms.Button();
            this.btnResetHeiway = new System.Windows.Forms.Button();
            this.btnToggleHeiway = new System.Windows.Forms.Button();
            this.lbHeiwayBadPwd = new System.Windows.Forms.Label();
            this.lbHeiwayBadPwdHeader = new System.Windows.Forms.Label();
            this.lbHeiwayPwdExpire = new System.Windows.Forms.Label();
            this.lbHeiwayAccountExpire = new System.Windows.Forms.Label();
            this.lbHeiwayIsLocked = new System.Windows.Forms.Label();
            this.lbHeiwayPwdExpireHeader = new System.Windows.Forms.Label();
            this.lbHeiwayAccountExpireHeader = new System.Windows.Forms.Label();
            this.lbHeiwayIsLockedHeader = new System.Windows.Forms.Label();
            this.lbHeiwayPanelTitle = new System.Windows.Forms.Label();
            this.pbHeiwayWindowsLogo = new System.Windows.Forms.PictureBox();
            this.pbHeiDM = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnAddPhone = new System.Windows.Forms.PictureBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.lbPhone2Header = new System.Windows.Forms.Label();
            this.lbPhone1 = new System.Windows.Forms.Label();
            this.lbPhone1Header = new System.Windows.Forms.Label();
            this.lbGlobalId = new System.Windows.Forms.Label();
            this.lbGlobalIdHeader = new System.Windows.Forms.Label();
            this.lbManagerId = new System.Windows.Forms.Label();
            this.lbManagerMail = new System.Windows.Forms.Label();
            this.lbManagerName = new System.Windows.Forms.Label();
            this.lbManagerIdHeader = new System.Windows.Forms.Label();
            this.lbManagerMailHeader = new System.Windows.Forms.Label();
            this.lbManagerHeader = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.lbEmployeeIdHeader = new System.Windows.Forms.Label();
            this.lbOpCo = new System.Windows.Forms.Label();
            this.lbOpCoHeader = new System.Windows.Forms.Label();
            this.lbHeiwayId = new System.Windows.Forms.Label();
            this.lbHeiwayIdHeader = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMailHeader = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.pbManagerNotFound = new System.Windows.Forms.PictureBox();
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copyUserDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEnglishDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyManagerDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockDetailedViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onboardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbConnectedAs = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlDetailed = new System.Windows.Forms.Panel();
            this.dgDetailed = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestaoTelecom = new System.Windows.Forms.Button();
            this.btnDetailedView = new System.Windows.Forms.Button();
            this.btnScript = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.pbUserNotFound = new System.Windows.Forms.PictureBox();
            this.pbSchinNotFound = new System.Windows.Forms.PictureBox();
            this.pbHeiwayNotFound = new System.Windows.Forms.PictureBox();
            this.pnlSchin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchinWindowsLogo)).BeginInit();
            this.pnlHeiway.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiwayWindowsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiDM)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagerNotFound)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.pnlDetailed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchinNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiwayNotFound)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbSearch.ForeColor = System.Drawing.Color.Honeydew;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(293, 29);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PromptText = "Buscar usuário...";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(217, 23);
            this.tbSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.tbSearch.TabIndex = 70;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.UseStyleColors = true;
            this.tbSearch.WaterMark = "Buscar usuário...";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearch_KeyDown);
            // 
            // pnlSchin
            // 
            this.pnlSchin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSchin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlSchin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSchin.Controls.Add(this.btnSchinMoreInfo);
            this.pnlSchin.Controls.Add(this.btnResetSchin);
            this.pnlSchin.Controls.Add(this.btnToggleSchin);
            this.pnlSchin.Controls.Add(this.lbSchinBadPwd);
            this.pnlSchin.Controls.Add(this.lbSchinBadPwdHeader);
            this.pnlSchin.Controls.Add(this.lbSchinPwdExpire);
            this.pnlSchin.Controls.Add(this.lbSchinAccountExpire);
            this.pnlSchin.Controls.Add(this.lbSchinIsLocked);
            this.pnlSchin.Controls.Add(this.lbSchinPwdExpireHeader);
            this.pnlSchin.Controls.Add(this.lbSchinAccountExpireHeader);
            this.pnlSchin.Controls.Add(this.lbSchinIsLockedHeader);
            this.pnlSchin.Controls.Add(this.lbSchinPanelTitle);
            this.pnlSchin.Controls.Add(this.pbSchinWindowsLogo);
            this.pnlSchin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(221)))), ((int)(((byte)(108)))));
            this.pnlSchin.Location = new System.Drawing.Point(383, 275);
            this.pnlSchin.Name = "pnlSchin";
            this.pnlSchin.Size = new System.Drawing.Size(402, 192);
            this.pnlSchin.TabIndex = 64;
            // 
            // btnSchinMoreInfo
            // 
            this.btnSchinMoreInfo.AutoSize = true;
            this.btnSchinMoreInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchinMoreInfo.BackgroundImage")));
            this.btnSchinMoreInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchinMoreInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSchinMoreInfo.FlatAppearance.BorderSize = 0;
            this.btnSchinMoreInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSchinMoreInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSchinMoreInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSchinMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchinMoreInfo.Location = new System.Drawing.Point(358, 10);
            this.btnSchinMoreInfo.Name = "btnSchinMoreInfo";
            this.btnSchinMoreInfo.Size = new System.Drawing.Size(24, 24);
            this.btnSchinMoreInfo.TabIndex = 82;
            this.btnSchinMoreInfo.TabStop = false;
            this.btnSchinMoreInfo.UseVisualStyleBackColor = true;
            this.btnSchinMoreInfo.Click += new System.EventHandler(this.BtnSchinMoreInfo_Click);
            // 
            // btnResetSchin
            // 
            this.btnResetSchin.AutoSize = true;
            this.btnResetSchin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetSchin.BackgroundImage")));
            this.btnResetSchin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetSchin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetSchin.FlatAppearance.BorderSize = 0;
            this.btnResetSchin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetSchin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetSchin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetSchin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSchin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResetSchin.Location = new System.Drawing.Point(299, 133);
            this.btnResetSchin.Name = "btnResetSchin";
            this.btnResetSchin.Size = new System.Drawing.Size(34, 25);
            this.btnResetSchin.TabIndex = 76;
            this.btnResetSchin.TabStop = false;
            this.btnResetSchin.UseVisualStyleBackColor = true;
            this.btnResetSchin.Click += new System.EventHandler(this.BtnResetSchin_Click);
            // 
            // btnToggleSchin
            // 
            this.btnToggleSchin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToggleSchin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleSchin.FlatAppearance.BorderSize = 0;
            this.btnToggleSchin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleSchin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleSchin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleSchin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSchin.Image = global::tickethelper.Properties.Resources.switch_off;
            this.btnToggleSchin.Location = new System.Drawing.Point(339, 131);
            this.btnToggleSchin.Name = "btnToggleSchin";
            this.btnToggleSchin.Size = new System.Drawing.Size(56, 33);
            this.btnToggleSchin.TabIndex = 75;
            this.btnToggleSchin.TabStop = false;
            this.btnToggleSchin.UseVisualStyleBackColor = true;
            this.btnToggleSchin.Click += new System.EventHandler(this.BtnToggleSchin_Click);
            // 
            // lbSchinBadPwd
            // 
            this.lbSchinBadPwd.AutoSize = true;
            this.lbSchinBadPwd.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbSchinBadPwd.ForeColor = System.Drawing.Color.Honeydew;
            this.lbSchinBadPwd.Location = new System.Drawing.Point(147, 114);
            this.lbSchinBadPwd.Name = "lbSchinBadPwd";
            this.lbSchinBadPwd.Size = new System.Drawing.Size(16, 19);
            this.lbSchinBadPwd.TabIndex = 72;
            this.lbSchinBadPwd.Text = "3";
            this.lbSchinBadPwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinBadPwdHeader
            // 
            this.lbSchinBadPwdHeader.AutoSize = true;
            this.lbSchinBadPwdHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSchinBadPwdHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbSchinBadPwdHeader.Location = new System.Drawing.Point(7, 114);
            this.lbSchinBadPwdHeader.Name = "lbSchinBadPwdHeader";
            this.lbSchinBadPwdHeader.Size = new System.Drawing.Size(134, 19);
            this.lbSchinBadPwdHeader.TabIndex = 71;
            this.lbSchinBadPwdHeader.Text = "Tentativas incorretas";
            this.lbSchinBadPwdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinPwdExpire
            // 
            this.lbSchinPwdExpire.AutoSize = true;
            this.lbSchinPwdExpire.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbSchinPwdExpire.ForeColor = System.Drawing.Color.Honeydew;
            this.lbSchinPwdExpire.Location = new System.Drawing.Point(147, 90);
            this.lbSchinPwdExpire.Name = "lbSchinPwdExpire";
            this.lbSchinPwdExpire.Size = new System.Drawing.Size(75, 19);
            this.lbSchinPwdExpire.TabIndex = 70;
            this.lbSchinPwdExpire.Text = "06/07/2007";
            this.lbSchinPwdExpire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinAccountExpire
            // 
            this.lbSchinAccountExpire.AutoSize = true;
            this.lbSchinAccountExpire.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbSchinAccountExpire.ForeColor = System.Drawing.Color.Honeydew;
            this.lbSchinAccountExpire.Location = new System.Drawing.Point(147, 66);
            this.lbSchinAccountExpire.Name = "lbSchinAccountExpire";
            this.lbSchinAccountExpire.Size = new System.Drawing.Size(69, 19);
            this.lbSchinAccountExpire.TabIndex = 69;
            this.lbSchinAccountExpire.Text = "14/12/1995";
            this.lbSchinAccountExpire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinIsLocked
            // 
            this.lbSchinIsLocked.AutoSize = true;
            this.lbSchinIsLocked.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbSchinIsLocked.ForeColor = System.Drawing.Color.Coral;
            this.lbSchinIsLocked.Location = new System.Drawing.Point(147, 42);
            this.lbSchinIsLocked.Name = "lbSchinIsLocked";
            this.lbSchinIsLocked.Size = new System.Drawing.Size(164, 19);
            this.lbSchinIsLocked.TabIndex = 68;
            this.lbSchinIsLocked.Text = "Sim. Falha ao desbloquear";
            this.lbSchinIsLocked.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinPwdExpireHeader
            // 
            this.lbSchinPwdExpireHeader.AutoSize = true;
            this.lbSchinPwdExpireHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSchinPwdExpireHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbSchinPwdExpireHeader.Location = new System.Drawing.Point(7, 90);
            this.lbSchinPwdExpireHeader.Name = "lbSchinPwdExpireHeader";
            this.lbSchinPwdExpireHeader.Size = new System.Drawing.Size(119, 19);
            this.lbSchinPwdExpireHeader.TabIndex = 67;
            this.lbSchinPwdExpireHeader.Text = "Validade da senha";
            this.lbSchinPwdExpireHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinAccountExpireHeader
            // 
            this.lbSchinAccountExpireHeader.AutoSize = true;
            this.lbSchinAccountExpireHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSchinAccountExpireHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbSchinAccountExpireHeader.Location = new System.Drawing.Point(7, 66);
            this.lbSchinAccountExpireHeader.Name = "lbSchinAccountExpireHeader";
            this.lbSchinAccountExpireHeader.Size = new System.Drawing.Size(117, 19);
            this.lbSchinAccountExpireHeader.TabIndex = 66;
            this.lbSchinAccountExpireHeader.Text = "Validade da conta";
            this.lbSchinAccountExpireHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinIsLockedHeader
            // 
            this.lbSchinIsLockedHeader.AutoSize = true;
            this.lbSchinIsLockedHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSchinIsLockedHeader.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbSchinIsLockedHeader.Location = new System.Drawing.Point(7, 42);
            this.lbSchinIsLockedHeader.Name = "lbSchinIsLockedHeader";
            this.lbSchinIsLockedHeader.Size = new System.Drawing.Size(73, 19);
            this.lbSchinIsLockedHeader.TabIndex = 65;
            this.lbSchinIsLockedHeader.Text = "Bloqueada";
            this.lbSchinIsLockedHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSchinPanelTitle
            // 
            this.lbSchinPanelTitle.AutoSize = true;
            this.lbSchinPanelTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbSchinPanelTitle.ForeColor = System.Drawing.Color.White;
            this.lbSchinPanelTitle.Location = new System.Drawing.Point(36, 8);
            this.lbSchinPanelTitle.Name = "lbSchinPanelTitle";
            this.lbSchinPanelTitle.Size = new System.Drawing.Size(95, 25);
            this.lbSchinPanelTitle.TabIndex = 64;
            this.lbSchinPanelTitle.Tag = "1";
            this.lbSchinPanelTitle.Text = "Schincariol";
            this.lbSchinPanelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSchinWindowsLogo
            // 
            this.pbSchinWindowsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbSchinWindowsLogo.Image")));
            this.pbSchinWindowsLogo.Location = new System.Drawing.Point(2, 6);
            this.pbSchinWindowsLogo.Name = "pbSchinWindowsLogo";
            this.pbSchinWindowsLogo.Size = new System.Drawing.Size(30, 30);
            this.pbSchinWindowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSchinWindowsLogo.TabIndex = 63;
            this.pbSchinWindowsLogo.TabStop = false;
            this.pbSchinWindowsLogo.Tag = "1";
            // 
            // pnlHeiway
            // 
            this.pnlHeiway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeiway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlHeiway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHeiway.Controls.Add(this.btnHeiwayMoreInfo);
            this.pnlHeiway.Controls.Add(this.btnResetHeiway);
            this.pnlHeiway.Controls.Add(this.btnToggleHeiway);
            this.pnlHeiway.Controls.Add(this.lbHeiwayBadPwd);
            this.pnlHeiway.Controls.Add(this.lbHeiwayBadPwdHeader);
            this.pnlHeiway.Controls.Add(this.lbHeiwayPwdExpire);
            this.pnlHeiway.Controls.Add(this.lbHeiwayAccountExpire);
            this.pnlHeiway.Controls.Add(this.lbHeiwayIsLocked);
            this.pnlHeiway.Controls.Add(this.lbHeiwayPwdExpireHeader);
            this.pnlHeiway.Controls.Add(this.lbHeiwayAccountExpireHeader);
            this.pnlHeiway.Controls.Add(this.lbHeiwayIsLockedHeader);
            this.pnlHeiway.Controls.Add(this.lbHeiwayPanelTitle);
            this.pnlHeiway.Controls.Add(this.pbHeiwayWindowsLogo);
            this.pnlHeiway.Controls.Add(this.pbHeiDM);
            this.pnlHeiway.Location = new System.Drawing.Point(383, 80);
            this.pnlHeiway.Name = "pnlHeiway";
            this.pnlHeiway.Size = new System.Drawing.Size(402, 192);
            this.pnlHeiway.TabIndex = 77;
            // 
            // btnHeiwayMoreInfo
            // 
            this.btnHeiwayMoreInfo.AutoSize = true;
            this.btnHeiwayMoreInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHeiwayMoreInfo.BackgroundImage")));
            this.btnHeiwayMoreInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeiwayMoreInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnHeiwayMoreInfo.FlatAppearance.BorderSize = 0;
            this.btnHeiwayMoreInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnHeiwayMoreInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnHeiwayMoreInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnHeiwayMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeiwayMoreInfo.Location = new System.Drawing.Point(358, 9);
            this.btnHeiwayMoreInfo.Name = "btnHeiwayMoreInfo";
            this.btnHeiwayMoreInfo.Size = new System.Drawing.Size(24, 24);
            this.btnHeiwayMoreInfo.TabIndex = 86;
            this.btnHeiwayMoreInfo.TabStop = false;
            this.btnHeiwayMoreInfo.UseVisualStyleBackColor = true;
            this.btnHeiwayMoreInfo.Click += new System.EventHandler(this.BtnHeiwayMoreInfo_Click);
            // 
            // btnResetHeiway
            // 
            this.btnResetHeiway.AutoSize = true;
            this.btnResetHeiway.BackgroundImage = global::tickethelper.Properties.Resources.password;
            this.btnResetHeiway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetHeiway.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetHeiway.FlatAppearance.BorderSize = 0;
            this.btnResetHeiway.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetHeiway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetHeiway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnResetHeiway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetHeiway.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResetHeiway.Location = new System.Drawing.Point(299, 131);
            this.btnResetHeiway.Name = "btnResetHeiway";
            this.btnResetHeiway.Size = new System.Drawing.Size(34, 25);
            this.btnResetHeiway.TabIndex = 76;
            this.btnResetHeiway.TabStop = false;
            this.btnResetHeiway.UseVisualStyleBackColor = true;
            this.btnResetHeiway.Click += new System.EventHandler(this.BtnResetHeiway_Click);
            // 
            // btnToggleHeiway
            // 
            this.btnToggleHeiway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleHeiway.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleHeiway.FlatAppearance.BorderSize = 0;
            this.btnToggleHeiway.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleHeiway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleHeiway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnToggleHeiway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleHeiway.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleHeiway.Image")));
            this.btnToggleHeiway.Location = new System.Drawing.Point(339, 129);
            this.btnToggleHeiway.Name = "btnToggleHeiway";
            this.btnToggleHeiway.Size = new System.Drawing.Size(56, 33);
            this.btnToggleHeiway.TabIndex = 75;
            this.btnToggleHeiway.TabStop = false;
            this.btnToggleHeiway.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleHeiway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToggleHeiway.UseVisualStyleBackColor = true;
            this.btnToggleHeiway.Click += new System.EventHandler(this.BtnToggleHeiway_Click);
            // 
            // lbHeiwayBadPwd
            // 
            this.lbHeiwayBadPwd.AutoSize = true;
            this.lbHeiwayBadPwd.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbHeiwayBadPwd.ForeColor = System.Drawing.Color.Honeydew;
            this.lbHeiwayBadPwd.Location = new System.Drawing.Point(147, 111);
            this.lbHeiwayBadPwd.Name = "lbHeiwayBadPwd";
            this.lbHeiwayBadPwd.Size = new System.Drawing.Size(16, 19);
            this.lbHeiwayBadPwd.TabIndex = 72;
            this.lbHeiwayBadPwd.Text = "3";
            this.lbHeiwayBadPwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayBadPwdHeader
            // 
            this.lbHeiwayBadPwdHeader.AutoSize = true;
            this.lbHeiwayBadPwdHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbHeiwayBadPwdHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbHeiwayBadPwdHeader.Location = new System.Drawing.Point(7, 111);
            this.lbHeiwayBadPwdHeader.Name = "lbHeiwayBadPwdHeader";
            this.lbHeiwayBadPwdHeader.Size = new System.Drawing.Size(134, 19);
            this.lbHeiwayBadPwdHeader.TabIndex = 71;
            this.lbHeiwayBadPwdHeader.Text = "Tentativas incorretas";
            this.lbHeiwayBadPwdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayPwdExpire
            // 
            this.lbHeiwayPwdExpire.AutoSize = true;
            this.lbHeiwayPwdExpire.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbHeiwayPwdExpire.ForeColor = System.Drawing.Color.Honeydew;
            this.lbHeiwayPwdExpire.Location = new System.Drawing.Point(147, 87);
            this.lbHeiwayPwdExpire.Name = "lbHeiwayPwdExpire";
            this.lbHeiwayPwdExpire.Size = new System.Drawing.Size(75, 19);
            this.lbHeiwayPwdExpire.TabIndex = 70;
            this.lbHeiwayPwdExpire.Text = "06/07/2007";
            this.lbHeiwayPwdExpire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayAccountExpire
            // 
            this.lbHeiwayAccountExpire.AutoSize = true;
            this.lbHeiwayAccountExpire.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbHeiwayAccountExpire.ForeColor = System.Drawing.Color.Honeydew;
            this.lbHeiwayAccountExpire.Location = new System.Drawing.Point(147, 63);
            this.lbHeiwayAccountExpire.Name = "lbHeiwayAccountExpire";
            this.lbHeiwayAccountExpire.Size = new System.Drawing.Size(69, 19);
            this.lbHeiwayAccountExpire.TabIndex = 69;
            this.lbHeiwayAccountExpire.Text = "14/12/1995";
            this.lbHeiwayAccountExpire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayIsLocked
            // 
            this.lbHeiwayIsLocked.AutoSize = true;
            this.lbHeiwayIsLocked.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbHeiwayIsLocked.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbHeiwayIsLocked.Location = new System.Drawing.Point(147, 39);
            this.lbHeiwayIsLocked.Name = "lbHeiwayIsLocked";
            this.lbHeiwayIsLocked.Size = new System.Drawing.Size(184, 19);
            this.lbHeiwayIsLocked.TabIndex = 68;
            this.lbHeiwayIsLocked.Text = "Sim. Desbloqueio automático.";
            this.lbHeiwayIsLocked.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayPwdExpireHeader
            // 
            this.lbHeiwayPwdExpireHeader.AutoSize = true;
            this.lbHeiwayPwdExpireHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbHeiwayPwdExpireHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbHeiwayPwdExpireHeader.Location = new System.Drawing.Point(7, 87);
            this.lbHeiwayPwdExpireHeader.Name = "lbHeiwayPwdExpireHeader";
            this.lbHeiwayPwdExpireHeader.Size = new System.Drawing.Size(119, 19);
            this.lbHeiwayPwdExpireHeader.TabIndex = 67;
            this.lbHeiwayPwdExpireHeader.Text = "Validade da senha";
            this.lbHeiwayPwdExpireHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayAccountExpireHeader
            // 
            this.lbHeiwayAccountExpireHeader.AutoSize = true;
            this.lbHeiwayAccountExpireHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbHeiwayAccountExpireHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbHeiwayAccountExpireHeader.Location = new System.Drawing.Point(7, 63);
            this.lbHeiwayAccountExpireHeader.Name = "lbHeiwayAccountExpireHeader";
            this.lbHeiwayAccountExpireHeader.Size = new System.Drawing.Size(117, 19);
            this.lbHeiwayAccountExpireHeader.TabIndex = 66;
            this.lbHeiwayAccountExpireHeader.Text = "Validade da conta";
            this.lbHeiwayAccountExpireHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayIsLockedHeader
            // 
            this.lbHeiwayIsLockedHeader.AutoSize = true;
            this.lbHeiwayIsLockedHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbHeiwayIsLockedHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbHeiwayIsLockedHeader.Location = new System.Drawing.Point(7, 39);
            this.lbHeiwayIsLockedHeader.Name = "lbHeiwayIsLockedHeader";
            this.lbHeiwayIsLockedHeader.Size = new System.Drawing.Size(73, 19);
            this.lbHeiwayIsLockedHeader.TabIndex = 65;
            this.lbHeiwayIsLockedHeader.Text = "Bloqueada";
            this.lbHeiwayIsLockedHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayPanelTitle
            // 
            this.lbHeiwayPanelTitle.AutoSize = true;
            this.lbHeiwayPanelTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbHeiwayPanelTitle.ForeColor = System.Drawing.Color.White;
            this.lbHeiwayPanelTitle.Location = new System.Drawing.Point(36, 6);
            this.lbHeiwayPanelTitle.Name = "lbHeiwayPanelTitle";
            this.lbHeiwayPanelTitle.Size = new System.Drawing.Size(70, 25);
            this.lbHeiwayPanelTitle.TabIndex = 64;
            this.lbHeiwayPanelTitle.Tag = "1";
            this.lbHeiwayPanelTitle.Text = "Heiway";
            this.lbHeiwayPanelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbHeiwayWindowsLogo
            // 
            this.pbHeiwayWindowsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbHeiwayWindowsLogo.Image")));
            this.pbHeiwayWindowsLogo.Location = new System.Drawing.Point(2, 3);
            this.pbHeiwayWindowsLogo.Name = "pbHeiwayWindowsLogo";
            this.pbHeiwayWindowsLogo.Size = new System.Drawing.Size(30, 30);
            this.pbHeiwayWindowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeiwayWindowsLogo.TabIndex = 63;
            this.pbHeiwayWindowsLogo.TabStop = false;
            this.pbHeiwayWindowsLogo.Tag = "1";
            // 
            // pbHeiDM
            // 
            this.pbHeiDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHeiDM.Image = ((System.Drawing.Image)(resources.GetObject("pbHeiDM.Image")));
            this.pbHeiDM.Location = new System.Drawing.Point(105, 12);
            this.pbHeiDM.Name = "pbHeiDM";
            this.pbHeiDM.Size = new System.Drawing.Size(44, 17);
            this.pbHeiDM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbHeiDM.TabIndex = 85;
            this.pbHeiDM.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlUser.Controls.Add(this.btnAddPhone);
            this.pnlUser.Controls.Add(this.lbPhone2);
            this.pnlUser.Controls.Add(this.lbPhone2Header);
            this.pnlUser.Controls.Add(this.lbPhone1);
            this.pnlUser.Controls.Add(this.lbPhone1Header);
            this.pnlUser.Controls.Add(this.lbGlobalId);
            this.pnlUser.Controls.Add(this.lbGlobalIdHeader);
            this.pnlUser.Controls.Add(this.lbManagerId);
            this.pnlUser.Controls.Add(this.lbManagerMail);
            this.pnlUser.Controls.Add(this.lbManagerName);
            this.pnlUser.Controls.Add(this.lbManagerIdHeader);
            this.pnlUser.Controls.Add(this.lbManagerMailHeader);
            this.pnlUser.Controls.Add(this.lbManagerHeader);
            this.pnlUser.Controls.Add(this.lbMail);
            this.pnlUser.Controls.Add(this.lbDepartment);
            this.pnlUser.Controls.Add(this.lbEmployeeId);
            this.pnlUser.Controls.Add(this.lbEmployeeIdHeader);
            this.pnlUser.Controls.Add(this.lbOpCo);
            this.pnlUser.Controls.Add(this.lbOpCoHeader);
            this.pnlUser.Controls.Add(this.lbHeiwayId);
            this.pnlUser.Controls.Add(this.lbHeiwayIdHeader);
            this.pnlUser.Controls.Add(this.lbTitle);
            this.pnlUser.Controls.Add(this.lbMailHeader);
            this.pnlUser.Controls.Add(this.lbDisplayName);
            this.pnlUser.Controls.Add(this.pbManagerNotFound);
            this.pnlUser.Location = new System.Drawing.Point(8, 79);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(372, 388);
            this.pnlUser.TabIndex = 78;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.Image")));
            this.btnAddPhone.Location = new System.Drawing.Point(60, 226);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(16, 16);
            this.btnAddPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddPhone.TabIndex = 98;
            this.btnAddPhone.TabStop = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbPhone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbPhone2.Location = new System.Drawing.Point(102, 224);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(102, 19);
            this.lbPhone2.TabIndex = 97;
            this.lbPhone2.Text = "+556799999999";
            this.lbPhone2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPhone2.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbPhone2Header
            // 
            this.lbPhone2Header.AutoSize = true;
            this.lbPhone2Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbPhone2Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbPhone2Header.Location = new System.Drawing.Point(5, 224);
            this.lbPhone2Header.Name = "lbPhone2Header";
            this.lbPhone2Header.Size = new System.Drawing.Size(56, 19);
            this.lbPhone2Header.TabIndex = 96;
            this.lbPhone2Header.Text = "Celular";
            this.lbPhone2Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPhone2Header.Click += new System.EventHandler(this.LbPhone2Header_Click);
            // 
            // lbPhone1
            // 
            this.lbPhone1.AutoSize = true;
            this.lbPhone1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbPhone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbPhone1.Location = new System.Drawing.Point(102, 249);
            this.lbPhone1.Name = "lbPhone1";
            this.lbPhone1.Size = new System.Drawing.Size(109, 19);
            this.lbPhone1.TabIndex = 95;
            this.lbPhone1.Text = "+5567988888888";
            this.lbPhone1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPhone1.Visible = false;
            this.lbPhone1.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbPhone1Header
            // 
            this.lbPhone1Header.AutoSize = true;
            this.lbPhone1Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbPhone1Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbPhone1Header.Location = new System.Drawing.Point(5, 249);
            this.lbPhone1Header.Name = "lbPhone1Header";
            this.lbPhone1Header.Size = new System.Drawing.Size(66, 19);
            this.lbPhone1Header.TabIndex = 94;
            this.lbPhone1Header.Text = "Telefone";
            this.lbPhone1Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPhone1Header.Visible = false;
            // 
            // lbGlobalId
            // 
            this.lbGlobalId.AutoSize = true;
            this.lbGlobalId.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbGlobalId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbGlobalId.Location = new System.Drawing.Point(103, 128);
            this.lbGlobalId.Name = "lbGlobalId";
            this.lbGlobalId.Size = new System.Drawing.Size(50, 19);
            this.lbGlobalId.TabIndex = 93;
            this.lbGlobalId.Text = "P00000";
            this.lbGlobalId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGlobalIdHeader
            // 
            this.lbGlobalIdHeader.AutoSize = true;
            this.lbGlobalIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbGlobalIdHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbGlobalIdHeader.Location = new System.Drawing.Point(5, 128);
            this.lbGlobalIdHeader.Name = "lbGlobalIdHeader";
            this.lbGlobalIdHeader.Size = new System.Drawing.Size(71, 19);
            this.lbGlobalIdHeader.TabIndex = 92;
            this.lbGlobalIdHeader.Text = "Global ID";
            this.lbGlobalIdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbManagerId
            // 
            this.lbManagerId.AutoSize = true;
            this.lbManagerId.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbManagerId.ForeColor = System.Drawing.Color.Honeydew;
            this.lbManagerId.Location = new System.Drawing.Point(58, 358);
            this.lbManagerId.Name = "lbManagerId";
            this.lbManagerId.Size = new System.Drawing.Size(72, 19);
            this.lbManagerId.TabIndex = 90;
            this.lbManagerId.Text = "MisterM20";
            this.lbManagerId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbManagerId.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbManagerMail
            // 
            this.lbManagerMail.AutoSize = true;
            this.lbManagerMail.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbManagerMail.ForeColor = System.Drawing.Color.Honeydew;
            this.lbManagerMail.Location = new System.Drawing.Point(58, 334);
            this.lbManagerMail.Name = "lbManagerMail";
            this.lbManagerMail.Size = new System.Drawing.Size(140, 19);
            this.lbManagerMail.TabIndex = 89;
            this.lbManagerMail.Text = "sample.mail@host.org";
            this.lbManagerMail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbManagerMail.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbManagerName
            // 
            this.lbManagerName.AutoSize = true;
            this.lbManagerName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbManagerName.ForeColor = System.Drawing.Color.Honeydew;
            this.lbManagerName.Location = new System.Drawing.Point(6, 309);
            this.lbManagerName.Name = "lbManagerName";
            this.lbManagerName.Size = new System.Drawing.Size(121, 21);
            this.lbManagerName.TabIndex = 88;
            this.lbManagerName.Text = "Foo Bar Johnson";
            this.lbManagerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbManagerName.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbManagerIdHeader
            // 
            this.lbManagerIdHeader.AutoSize = true;
            this.lbManagerIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbManagerIdHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbManagerIdHeader.Location = new System.Drawing.Point(8, 358);
            this.lbManagerIdHeader.Name = "lbManagerIdHeader";
            this.lbManagerIdHeader.Size = new System.Drawing.Size(23, 19);
            this.lbManagerIdHeader.TabIndex = 87;
            this.lbManagerIdHeader.Text = "ID";
            this.lbManagerIdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbManagerMailHeader
            // 
            this.lbManagerMailHeader.AutoSize = true;
            this.lbManagerMailHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbManagerMailHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbManagerMailHeader.Location = new System.Drawing.Point(8, 334);
            this.lbManagerMailHeader.Name = "lbManagerMailHeader";
            this.lbManagerMailHeader.Size = new System.Drawing.Size(47, 19);
            this.lbManagerMailHeader.TabIndex = 86;
            this.lbManagerMailHeader.Text = "E-mail";
            this.lbManagerMailHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbManagerHeader
            // 
            this.lbManagerHeader.AutoSize = true;
            this.lbManagerHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbManagerHeader.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.lbManagerHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbManagerHeader.Location = new System.Drawing.Point(3, 271);
            this.lbManagerHeader.Name = "lbManagerHeader";
            this.lbManagerHeader.Size = new System.Drawing.Size(78, 31);
            this.lbManagerHeader.TabIndex = 85;
            this.lbManagerHeader.Text = "Gestor";
            this.lbManagerHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbMail.Location = new System.Drawing.Point(103, 175);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(140, 19);
            this.lbMail.TabIndex = 66;
            this.lbMail.Text = "sample.mail@host.org";
            this.lbMail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMail.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbDepartment.Location = new System.Drawing.Point(6, 67);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(33, 21);
            this.lbDepartment.TabIndex = 75;
            this.lbDepartment.Text = "GIS";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDepartment.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbEmployeeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbEmployeeId.Location = new System.Drawing.Point(103, 103);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(50, 19);
            this.lbEmployeeId.TabIndex = 74;
            this.lbEmployeeId.Text = "P00000";
            this.lbEmployeeId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbEmployeeId.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbEmployeeIdHeader
            // 
            this.lbEmployeeIdHeader.AutoSize = true;
            this.lbEmployeeIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbEmployeeIdHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbEmployeeIdHeader.Location = new System.Drawing.Point(5, 103);
            this.lbEmployeeIdHeader.Name = "lbEmployeeIdHeader";
            this.lbEmployeeIdHeader.Size = new System.Drawing.Size(72, 19);
            this.lbEmployeeIdHeader.TabIndex = 73;
            this.lbEmployeeIdHeader.Text = "Matrícula";
            this.lbEmployeeIdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOpCo
            // 
            this.lbOpCo.AutoSize = true;
            this.lbOpCo.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbOpCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbOpCo.Location = new System.Drawing.Point(103, 199);
            this.lbOpCo.Name = "lbOpCo";
            this.lbOpCo.Size = new System.Drawing.Size(123, 19);
            this.lbOpCo.TabIndex = 72;
            this.lbOpCo.Text = "Jacksonville, Florida";
            this.lbOpCo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbOpCo.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbOpCoHeader
            // 
            this.lbOpCoHeader.AutoSize = true;
            this.lbOpCoHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbOpCoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbOpCoHeader.Location = new System.Drawing.Point(5, 199);
            this.lbOpCoHeader.Name = "lbOpCoHeader";
            this.lbOpCoHeader.Size = new System.Drawing.Size(47, 19);
            this.lbOpCoHeader.TabIndex = 71;
            this.lbOpCoHeader.Text = "OpCo";
            this.lbOpCoHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHeiwayId
            // 
            this.lbHeiwayId.AutoSize = true;
            this.lbHeiwayId.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbHeiwayId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbHeiwayId.Location = new System.Drawing.Point(103, 151);
            this.lbHeiwayId.Name = "lbHeiwayId";
            this.lbHeiwayId.Size = new System.Drawing.Size(72, 19);
            this.lbHeiwayId.TabIndex = 70;
            this.lbHeiwayId.Text = "MisterM20";
            this.lbHeiwayId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHeiwayId.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbHeiwayIdHeader
            // 
            this.lbHeiwayIdHeader.AutoSize = true;
            this.lbHeiwayIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbHeiwayIdHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbHeiwayIdHeader.Location = new System.Drawing.Point(5, 151);
            this.lbHeiwayIdHeader.Name = "lbHeiwayIdHeader";
            this.lbHeiwayIdHeader.Size = new System.Drawing.Size(23, 19);
            this.lbHeiwayIdHeader.TabIndex = 69;
            this.lbHeiwayIdHeader.Text = "ID";
            this.lbHeiwayIdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbTitle.Location = new System.Drawing.Point(5, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 25);
            this.lbTitle.TabIndex = 68;
            this.lbTitle.Text = "Service Desk Agent";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitle.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbMailHeader
            // 
            this.lbMailHeader.AutoSize = true;
            this.lbMailHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbMailHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbMailHeader.Location = new System.Drawing.Point(5, 175);
            this.lbMailHeader.Name = "lbMailHeader";
            this.lbMailHeader.Size = new System.Drawing.Size(51, 19);
            this.lbMailHeader.TabIndex = 67;
            this.lbMailHeader.Text = "E-mail";
            this.lbMailHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDisplayName.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.lbDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(71)))));
            this.lbDisplayName.Image = global::tickethelper.Properties.Resources.vip;
            this.lbDisplayName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDisplayName.Location = new System.Drawing.Point(3, 1);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(449, 31);
            this.lbDisplayName.TabIndex = 65;
            this.lbDisplayName.Text = "     Marcus Vinícius Theodoro Martins da Silva";
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDisplayName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // pbManagerNotFound
            // 
            this.pbManagerNotFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbManagerNotFound.Image = global::tickethelper.Properties.Resources.account_not_found;
            this.pbManagerNotFound.Location = new System.Drawing.Point(150, 312);
            this.pbManagerNotFound.Name = "pbManagerNotFound";
            this.pbManagerNotFound.Size = new System.Drawing.Size(72, 66);
            this.pbManagerNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManagerNotFound.TabIndex = 91;
            this.pbManagerNotFound.TabStop = false;
            this.pbManagerNotFound.Visible = false;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUserDataItem,
            this.copyEnglishDataItem,
            this.copyManagerDataItem,
            this.dockDetailedViewItem,
            this.onboardingToolStripMenuItem,
            this.settingsItem,
            this.closeItem});
            this.contextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(246, 158);
            this.contextMenu.Style = MetroFramework.MetroColorStyle.Green;
            this.contextMenu.Text = "Ticket Helper";
            this.contextMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.contextMenu.UseStyleColors = true;
            // 
            // copyUserDataItem
            // 
            this.copyUserDataItem.Name = "copyUserDataItem";
            this.copyUserDataItem.Size = new System.Drawing.Size(245, 22);
            this.copyUserDataItem.Text = "Copiar dados do usuário";
            this.copyUserDataItem.Click += new System.EventHandler(this.CopyUserDataItem_Click);
            // 
            // copyEnglishDataItem
            // 
            this.copyEnglishDataItem.Name = "copyEnglishDataItem";
            this.copyEnglishDataItem.Size = new System.Drawing.Size(245, 22);
            this.copyEnglishDataItem.Text = "Copiar dados do usuário (inglês)";
            this.copyEnglishDataItem.Click += new System.EventHandler(this.CopyEnglishDataItem_Click);
            // 
            // copyManagerDataItem
            // 
            this.copyManagerDataItem.Name = "copyManagerDataItem";
            this.copyManagerDataItem.Size = new System.Drawing.Size(245, 22);
            this.copyManagerDataItem.Text = "Copiar dados do gestor";
            this.copyManagerDataItem.Click += new System.EventHandler(this.CopyManagerDataItem_Click);
            // 
            // dockDetailedViewItem
            // 
            this.dockDetailedViewItem.CheckOnClick = true;
            this.dockDetailedViewItem.Name = "dockDetailedViewItem";
            this.dockDetailedViewItem.Size = new System.Drawing.Size(245, 22);
            this.dockDetailedViewItem.Text = "Fixar visualização detalhada";
            this.dockDetailedViewItem.Click += new System.EventHandler(this.dockDetailedViewItem_Click);
            // 
            // onboardingToolStripMenuItem
            // 
            this.onboardingToolStripMenuItem.CheckOnClick = true;
            this.onboardingToolStripMenuItem.Name = "onboardingToolStripMenuItem";
            this.onboardingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.onboardingToolStripMenuItem.Text = "Mostrar painel de onboarding";
            this.onboardingToolStripMenuItem.Click += new System.EventHandler(this.OnboardingToolStripMenuItem_Click);
            // 
            // settingsItem
            // 
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(245, 22);
            this.settingsItem.Text = "Configurações";
            this.settingsItem.Click += new System.EventHandler(this.SettingsItem_Click);
            // 
            // closeItem
            // 
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(245, 22);
            this.closeItem.Text = "Sair";
            this.closeItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // lbConnectedAs
            // 
            this.lbConnectedAs.AutoSize = true;
            this.lbConnectedAs.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbConnectedAs.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbConnectedAs.Location = new System.Drawing.Point(1, 9);
            this.lbConnectedAs.Name = "lbConnectedAs";
            this.lbConnectedAs.Size = new System.Drawing.Size(176, 15);
            this.lbConnectedAs.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbConnectedAs.TabIndex = 82;
            this.lbConnectedAs.Text = "Conectado como ADMMisterM20";
            this.lbConnectedAs.UseCustomBackColor = true;
            this.lbConnectedAs.UseCustomForeColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Ticket Helper";
            this.notifyIcon.Visible = true;
            // 
            // pnlDetailed
            // 
            this.pnlDetailed.Controls.Add(this.dgDetailed);
            this.pnlDetailed.Location = new System.Drawing.Point(6, 509);
            this.pnlDetailed.Name = "pnlDetailed";
            this.pnlDetailed.Size = new System.Drawing.Size(780, 151);
            this.pnlDetailed.TabIndex = 92;
            // 
            // dgDetailed
            // 
            this.dgDetailed.AllowUserToResizeRows = false;
            this.dgDetailed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDetailed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgDetailed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetailed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDetailed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetailed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetailed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetailed.EnableHeadersVisualStyles = false;
            this.dgDetailed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgDetailed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgDetailed.Location = new System.Drawing.Point(0, 0);
            this.dgDetailed.Name = "dgDetailed";
            this.dgDetailed.ReadOnly = true;
            this.dgDetailed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetailed.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetailed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgDetailed.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetailed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetailed.Size = new System.Drawing.Size(780, 151);
            this.dgDetailed.Style = MetroFramework.MetroColorStyle.Green;
            this.dgDetailed.TabIndex = 9;
            this.dgDetailed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgDetailed.UseCustomForeColor = true;
            this.dgDetailed.DataSourceChanged += new System.EventHandler(this.DgDetailed_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Visualização detalhada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGestaoTelecom
            // 
            this.btnGestaoTelecom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoTelecom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGestaoTelecom.FlatAppearance.BorderSize = 0;
            this.btnGestaoTelecom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnGestaoTelecom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGestaoTelecom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGestaoTelecom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoTelecom.Image = global::tickethelper.Properties.Resources.gestao_telecom;
            this.btnGestaoTelecom.Location = new System.Drawing.Point(654, 29);
            this.btnGestaoTelecom.Name = "btnGestaoTelecom";
            this.btnGestaoTelecom.Size = new System.Drawing.Size(25, 25);
            this.btnGestaoTelecom.TabIndex = 91;
            this.btnGestaoTelecom.TabStop = false;
            this.btnGestaoTelecom.UseVisualStyleBackColor = true;
            this.btnGestaoTelecom.Visible = false;
            this.btnGestaoTelecom.Click += new System.EventHandler(this.btnGestaoTelecom_Click);
            // 
            // btnDetailedView
            // 
            this.btnDetailedView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetailedView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDetailedView.FlatAppearance.BorderSize = 0;
            this.btnDetailedView.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnDetailedView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDetailedView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDetailedView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailedView.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailedView.Image")));
            this.btnDetailedView.Location = new System.Drawing.Point(695, 28);
            this.btnDetailedView.Name = "btnDetailedView";
            this.btnDetailedView.Size = new System.Drawing.Size(25, 25);
            this.btnDetailedView.TabIndex = 90;
            this.btnDetailedView.TabStop = false;
            this.btnDetailedView.UseVisualStyleBackColor = true;
            this.btnDetailedView.Click += new System.EventHandler(this.btnDetailedView_Click);
            // 
            // btnScript
            // 
            this.btnScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnScript.FlatAppearance.BorderSize = 0;
            this.btnScript.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScript.Image = ((System.Drawing.Image)(resources.GetObject("btnScript.Image")));
            this.btnScript.Location = new System.Drawing.Point(742, 29);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(24, 24);
            this.btnScript.TabIndex = 89;
            this.btnScript.TabStop = false;
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.AutoSize = true;
            this.btnBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.BackgroundImage")));
            this.btnBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Location = new System.Drawing.Point(256, 28);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(24, 24);
            this.btnBackward.TabIndex = 88;
            this.btnBackward.TabStop = false;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Visible = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.AutoSize = true;
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(522, 28);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(24, 24);
            this.btnForward.TabIndex = 87;
            this.btnForward.TabStop = false;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // pbUserNotFound
            // 
            this.pbUserNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserNotFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUserNotFound.Image = global::tickethelper.Properties.Resources.notfound;
            this.pbUserNotFound.Location = new System.Drawing.Point(84, 143);
            this.pbUserNotFound.Name = "pbUserNotFound";
            this.pbUserNotFound.Size = new System.Drawing.Size(224, 226);
            this.pbUserNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserNotFound.TabIndex = 79;
            this.pbUserNotFound.TabStop = false;
            // 
            // pbSchinNotFound
            // 
            this.pbSchinNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSchinNotFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSchinNotFound.Image = global::tickethelper.Properties.Resources.account_not_found;
            this.pbSchinNotFound.Location = new System.Drawing.Point(535, 313);
            this.pbSchinNotFound.Name = "pbSchinNotFound";
            this.pbSchinNotFound.Size = new System.Drawing.Size(105, 107);
            this.pbSchinNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSchinNotFound.TabIndex = 81;
            this.pbSchinNotFound.TabStop = false;
            // 
            // pbHeiwayNotFound
            // 
            this.pbHeiwayNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeiwayNotFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHeiwayNotFound.Image = global::tickethelper.Properties.Resources.account_not_found;
            this.pbHeiwayNotFound.Location = new System.Drawing.Point(536, 123);
            this.pbHeiwayNotFound.Name = "pbHeiwayNotFound";
            this.pbHeiwayNotFound.Size = new System.Drawing.Size(105, 107);
            this.pbHeiwayNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeiwayNotFound.TabIndex = 81;
            this.pbHeiwayNotFound.TabStop = false;
            this.pbHeiwayNotFound.Visible = false;
            // 
            // MainUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 475);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDetailed);
            this.Controls.Add(this.btnGestaoTelecom);
            this.Controls.Add(this.btnDetailedView);
            this.Controls.Add(this.btnScript);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lbConnectedAs);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pbUserNotFound);
            this.Controls.Add(this.pnlSchin);
            this.Controls.Add(this.pnlHeiway);
            this.Controls.Add(this.pbSchinNotFound);
            this.Controls.Add(this.pbHeiwayNotFound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(792, 399);
            this.Name = "MainUiForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Activated += new System.EventHandler(this.MainUiForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModernCompactUi_FormClosing);
            this.Shown += new System.EventHandler(this.ModernCompactUi_Shown);
            this.Move += new System.EventHandler(this.PnlBorder_Move);
            this.pnlSchin.ResumeLayout(false);
            this.pnlSchin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchinWindowsLogo)).EndInit();
            this.pnlHeiway.ResumeLayout(false);
            this.pnlHeiway.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiwayWindowsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiDM)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagerNotFound)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.pnlDetailed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchinNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeiwayNotFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlSchin;
        private Button btnResetSchin;
        private Button btnToggleSchin;

        private Label lbSchinBadPwd;
        private Label lbSchinBadPwdHeader;
        private Label lbSchinPwdExpire;
        private Label lbSchinAccountExpire;
        private Label lbSchinIsLocked;
        private Label lbSchinPwdExpireHeader;
        private Label lbSchinAccountExpireHeader;
        private Label lbSchinIsLockedHeader;
        private Label lbSchinPanelTitle;
        private PictureBox pbSchinWindowsLogo;
        private Panel pnlHeiway;
        private Button btnResetHeiway;
        private Button btnToggleHeiway;
        private Label lbHeiwayBadPwd;
        private Label lbHeiwayBadPwdHeader;
        private Label lbHeiwayPwdExpire;
        private Label lbHeiwayAccountExpire;
        private Label lbHeiwayIsLocked;
        private Label lbHeiwayPwdExpireHeader;
        private Label lbHeiwayAccountExpireHeader;
        private Label lbHeiwayIsLockedHeader;
        private Label lbHeiwayPanelTitle;
        private PictureBox pbHeiwayWindowsLogo;
        private Panel pnlUser;
        private Label lbDepartment;
        private Label lbEmployeeId;
        private Label lbEmployeeIdHeader;
        private Label lbOpCo;
        private Label lbOpCoHeader;
        private Label lbHeiwayId;
        private Label lbHeiwayIdHeader;
        private Label lbTitle;
        private Label lbMailHeader;
        private Label lbMail;
        private Label lbDisplayName;
        private PictureBox pbHeiDM;
        private ToolStripMenuItem settingsItem;
        private ToolStripMenuItem closeItem;
        private ToolStripMenuItem copyUserDataItem;
        private ToolStripMenuItem copyManagerDataItem;
        private PictureBox pbUserNotFound;
        private PictureBox pbHeiwayNotFound;
        private PictureBox pbSchinNotFound;
        private Button btnSchinMoreInfo;
        private Button btnHeiwayMoreInfo;
        private Label lbManagerId;
        private Label lbManagerMail;
        private Label lbManagerName;
        private Label lbManagerIdHeader;
        private Label lbManagerMailHeader;
        private Label lbManagerHeader;
        private PictureBox pbManagerNotFound;
        private ToolStripMenuItem onboardingToolStripMenuItem;
        private MetroTextBox tbSearch;
        private MetroLabel lbConnectedAs;
        private MetroContextMenu contextMenu;
        private ToolStripMenuItem copyEnglishDataItem;
        private Button btnForward;
        private Button btnBackward;
        private NotifyIcon notifyIcon;
        private Button btnScript;
        private ToolStripMenuItem dockDetailedViewItem;
        private Button btnDetailedView;
        private Button btnGestaoTelecom;
        private Panel pnlDetailed;
        private MetroGrid dgDetailed;
        private Label label1;
        private Label lbGlobalId;
        private Label lbGlobalIdHeader;
        private Label lbPhone2;
        private Label lbPhone2Header;
        private Label lbPhone1;
        private Label lbPhone1Header;
        private PictureBox btnAddPhone;
    }
}

