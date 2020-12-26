
namespace Remember
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.TxtFileInput = new System.Windows.Forms.TextBox();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.PBoxIcon = new System.Windows.Forms.PictureBox();
            this.LblIcon = new System.Windows.Forms.Label();
            this.BtnLaunchProgram = new System.Windows.Forms.Button();
            this.PnlLoc = new System.Windows.Forms.Panel();
            this.BtnLocation = new System.Windows.Forms.Button();
            this.TxtLocationInput = new System.Windows.Forms.TextBox();
            this.PnlName = new System.Windows.Forms.Panel();
            this.TxtNameInput = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlFileName = new System.Windows.Forms.Panel();
            this.TxtFileNameInput = new System.Windows.Forms.TextBox();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.LblParameters = new System.Windows.Forms.Label();
            this.TxtParametersInput = new System.Windows.Forms.TextBox();
            this.PnlParam = new System.Windows.Forms.Panel();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearchInput = new System.Windows.Forms.TextBox();
            this.LblPreviewTitle = new System.Windows.Forms.Label();
            this.MnuStrpMainMenu = new System.Windows.Forms.MenuStrip();
            this.MnuItmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmDisableMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmResizing = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmSetTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmOff = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItm15Timer = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItm30Timer = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItm60Timer = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmCustomTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrpMnuItmBackupUI = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClearSearch = new System.Windows.Forms.Button();
            this.LstVewPrograms = new System.Windows.Forms.ListView();
            this.ImgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.TmrSaveData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxIcon)).BeginInit();
            this.PnlLoc.SuspendLayout();
            this.PnlName.SuspendLayout();
            this.PnlFileName.SuspendLayout();
            this.PnlParam.SuspendLayout();
            this.MnuStrpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Location = new System.Drawing.Point(12, 315);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadFile.TabIndex = 5;
            this.BtnLoadFile.Text = "Load File";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // TxtFileInput
            // 
            this.TxtFileInput.Location = new System.Drawing.Point(93, 316);
            this.TxtFileInput.Name = "TxtFileInput";
            this.TxtFileInput.Size = new System.Drawing.Size(261, 22);
            this.TxtFileInput.TabIndex = 6;
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.Location = new System.Drawing.Point(360, 315);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProgram.TabIndex = 7;
            this.BtnAddProgram.Text = "Confirm";
            this.BtnAddProgram.UseVisualStyleBackColor = true;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(1, 4);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 13);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Name:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(442, 279);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(30, 13);
            this.LblSize.TabIndex = 22;
            this.LblSize.Text = "Size:";
            // 
            // PBoxIcon
            // 
            this.PBoxIcon.Location = new System.Drawing.Point(517, 55);
            this.PBoxIcon.Name = "PBoxIcon";
            this.PBoxIcon.Size = new System.Drawing.Size(36, 37);
            this.PBoxIcon.TabIndex = 12;
            this.PBoxIcon.TabStop = false;
            // 
            // LblIcon
            // 
            this.LblIcon.AutoSize = true;
            this.LblIcon.Location = new System.Drawing.Point(442, 65);
            this.LblIcon.Name = "LblIcon";
            this.LblIcon.Size = new System.Drawing.Size(32, 13);
            this.LblIcon.TabIndex = 9;
            this.LblIcon.Text = "Icon:";
            // 
            // BtnLaunchProgram
            // 
            this.BtnLaunchProgram.Location = new System.Drawing.Point(499, 316);
            this.BtnLaunchProgram.Name = "BtnLaunchProgram";
            this.BtnLaunchProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnLaunchProgram.TabIndex = 24;
            this.BtnLaunchProgram.Text = "Launch";
            this.BtnLaunchProgram.UseVisualStyleBackColor = true;
            this.BtnLaunchProgram.Click += new System.EventHandler(this.BtnLaunchProgram_Click);
            // 
            // PnlLoc
            // 
            this.PnlLoc.AutoScroll = true;
            this.PnlLoc.Controls.Add(this.BtnLocation);
            this.PnlLoc.Controls.Add(this.TxtLocationInput);
            this.PnlLoc.Location = new System.Drawing.Point(440, 190);
            this.PnlLoc.Name = "PnlLoc";
            this.PnlLoc.Size = new System.Drawing.Size(423, 38);
            this.PnlLoc.TabIndex = 16;
            // 
            // BtnLocation
            // 
            this.BtnLocation.Location = new System.Drawing.Point(0, 0);
            this.BtnLocation.Name = "BtnLocation";
            this.BtnLocation.Size = new System.Drawing.Size(61, 23);
            this.BtnLocation.TabIndex = 17;
            this.BtnLocation.Text = "Location";
            this.BtnLocation.UseVisualStyleBackColor = true;
            this.BtnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // TxtLocationInput
            // 
            this.TxtLocationInput.Location = new System.Drawing.Point(77, 0);
            this.TxtLocationInput.Name = "TxtLocationInput";
            this.TxtLocationInput.Size = new System.Drawing.Size(346, 22);
            this.TxtLocationInput.TabIndex = 18;
            // 
            // PnlName
            // 
            this.PnlName.AutoScroll = true;
            this.PnlName.Controls.Add(this.TxtNameInput);
            this.PnlName.Controls.Add(this.LblName);
            this.PnlName.Location = new System.Drawing.Point(440, 102);
            this.PnlName.Name = "PnlName";
            this.PnlName.Size = new System.Drawing.Size(423, 38);
            this.PnlName.TabIndex = 10;
            // 
            // TxtNameInput
            // 
            this.TxtNameInput.Location = new System.Drawing.Point(77, 0);
            this.TxtNameInput.Name = "TxtNameInput";
            this.TxtNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtNameInput.TabIndex = 12;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(580, 316);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 25;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(742, 316);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PnlFileName
            // 
            this.PnlFileName.AutoScroll = true;
            this.PnlFileName.Controls.Add(this.TxtFileNameInput);
            this.PnlFileName.Controls.Add(this.LblFileName);
            this.PnlFileName.Location = new System.Drawing.Point(440, 146);
            this.PnlFileName.Name = "PnlFileName";
            this.PnlFileName.Size = new System.Drawing.Size(423, 38);
            this.PnlFileName.TabIndex = 13;
            // 
            // TxtFileNameInput
            // 
            this.TxtFileNameInput.Location = new System.Drawing.Point(77, 1);
            this.TxtFileNameInput.Name = "TxtFileNameInput";
            this.TxtFileNameInput.ReadOnly = true;
            this.TxtFileNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtFileNameInput.TabIndex = 15;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(1, 4);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(60, 13);
            this.LblFileName.TabIndex = 14;
            this.LblFileName.Text = "File Name:";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(517, 276);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.ReadOnly = true;
            this.TxtSize.Size = new System.Drawing.Size(346, 22);
            this.TxtSize.TabIndex = 23;
            // 
            // LblParameters
            // 
            this.LblParameters.AutoSize = true;
            this.LblParameters.Location = new System.Drawing.Point(1, 4);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(66, 13);
            this.LblParameters.TabIndex = 20;
            this.LblParameters.Text = "Parameters:";
            // 
            // TxtParametersInput
            // 
            this.TxtParametersInput.Location = new System.Drawing.Point(77, 0);
            this.TxtParametersInput.Name = "TxtParametersInput";
            this.TxtParametersInput.Size = new System.Drawing.Size(346, 22);
            this.TxtParametersInput.TabIndex = 21;
            // 
            // PnlParam
            // 
            this.PnlParam.AutoScroll = true;
            this.PnlParam.Controls.Add(this.TxtParametersInput);
            this.PnlParam.Controls.Add(this.LblParameters);
            this.PnlParam.Location = new System.Drawing.Point(440, 234);
            this.PnlParam.Name = "PnlParam";
            this.PnlParam.Size = new System.Drawing.Size(423, 38);
            this.PnlParam.TabIndex = 19;
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Location = new System.Drawing.Point(661, 316);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(75, 23);
            this.BtnDuplicate.TabIndex = 26;
            this.BtnDuplicate.Text = "Duplicate";
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(12, 28);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearchInput
            // 
            this.TxtSearchInput.Location = new System.Drawing.Point(93, 29);
            this.TxtSearchInput.Name = "TxtSearchInput";
            this.TxtSearchInput.Size = new System.Drawing.Size(261, 22);
            this.TxtSearchInput.TabIndex = 2;
            // 
            // LblPreviewTitle
            // 
            this.LblPreviewTitle.AutoSize = true;
            this.LblPreviewTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblPreviewTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewTitle.Location = new System.Drawing.Point(590, 26);
            this.LblPreviewTitle.Name = "LblPreviewTitle";
            this.LblPreviewTitle.Size = new System.Drawing.Size(133, 30);
            this.LblPreviewTitle.TabIndex = 8;
            this.LblPreviewTitle.Text = "Preview Area";
            // 
            // MnuStrpMainMenu
            // 
            this.MnuStrpMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmMenu,
            this.settingsToolStripMenuItem,
            this.MnuItmBackup,
            this.MnuItmAbout});
            this.MnuStrpMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuStrpMainMenu.Name = "MnuStrpMainMenu";
            this.MnuStrpMainMenu.Size = new System.Drawing.Size(874, 24);
            this.MnuStrpMainMenu.TabIndex = 27;
            this.MnuStrpMainMenu.Text = "MnuMainStrip";
            // 
            // MnuItmMenu
            // 
            this.MnuItmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmApplication,
            this.MnuItmExport,
            this.MnuItmQuit});
            this.MnuItmMenu.Name = "MnuItmMenu";
            this.MnuItmMenu.Size = new System.Drawing.Size(50, 20);
            this.MnuItmMenu.Text = "Menu";
            // 
            // MnuItmApplication
            // 
            this.MnuItmApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmRestart,
            this.MnuItmExit});
            this.MnuItmApplication.Name = "MnuItmApplication";
            this.MnuItmApplication.Size = new System.Drawing.Size(135, 22);
            this.MnuItmApplication.Text = "Application";
            // 
            // MnuItmRestart
            // 
            this.MnuItmRestart.Name = "MnuItmRestart";
            this.MnuItmRestart.Size = new System.Drawing.Size(110, 22);
            this.MnuItmRestart.Text = "Restart";
            this.MnuItmRestart.Click += new System.EventHandler(this.MnuItmRestart_Click);
            // 
            // MnuItmExit
            // 
            this.MnuItmExit.Name = "MnuItmExit";
            this.MnuItmExit.Size = new System.Drawing.Size(110, 22);
            this.MnuItmExit.Text = "Exit";
            this.MnuItmExit.Click += new System.EventHandler(this.MnuItmExit_Click);
            // 
            // MnuItmExport
            // 
            this.MnuItmExport.Name = "MnuItmExport";
            this.MnuItmExport.Size = new System.Drawing.Size(135, 22);
            this.MnuItmExport.Text = "Export Data";
            this.MnuItmExport.Click += new System.EventHandler(this.MnuItmExport_Click);
            // 
            // MnuItmQuit
            // 
            this.MnuItmQuit.Name = "MnuItmQuit";
            this.MnuItmQuit.Size = new System.Drawing.Size(135, 22);
            this.MnuItmQuit.Text = "Quit";
            this.MnuItmQuit.Click += new System.EventHandler(this.MnuItmQuit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrpMnuItmDisableMsg,
            this.TStrpMnuItmResizing,
            this.TStrpMnuItmSetTimer});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // TStrpMnuItmDisableMsg
            // 
            this.TStrpMnuItmDisableMsg.Name = "TStrpMnuItmDisableMsg";
            this.TStrpMnuItmDisableMsg.Size = new System.Drawing.Size(192, 22);
            this.TStrpMnuItmDisableMsg.Text = "Disable Info Messages";
            this.TStrpMnuItmDisableMsg.Click += new System.EventHandler(this.TStrpMnuItmDisableMsg_Click);
            // 
            // TStrpMnuItmResizing
            // 
            this.TStrpMnuItmResizing.Name = "TStrpMnuItmResizing";
            this.TStrpMnuItmResizing.Size = new System.Drawing.Size(192, 22);
            this.TStrpMnuItmResizing.Text = "Enable Resizing";
            this.TStrpMnuItmResizing.Click += new System.EventHandler(this.TStrpMnuItmResizing_Click);
            // 
            // TStrpMnuItmSetTimer
            // 
            this.TStrpMnuItmSetTimer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrpMnuItmOff,
            this.TStrpMnuItm15Timer,
            this.TStrpMnuItm30Timer,
            this.TStrpMnuItm60Timer,
            this.TStrpMnuItmCustomTimer});
            this.TStrpMnuItmSetTimer.Name = "TStrpMnuItmSetTimer";
            this.TStrpMnuItmSetTimer.Size = new System.Drawing.Size(192, 22);
            this.TStrpMnuItmSetTimer.Text = "Set Backup Save Timer";
            // 
            // TStrpMnuItmOff
            // 
            this.TStrpMnuItmOff.Name = "TStrpMnuItmOff";
            this.TStrpMnuItmOff.Size = new System.Drawing.Size(132, 22);
            this.TStrpMnuItmOff.Text = "Off";
            this.TStrpMnuItmOff.Click += new System.EventHandler(this.TStrpMnuItmOff_Click);
            // 
            // TStrpMnuItm15Timer
            // 
            this.TStrpMnuItm15Timer.Name = "TStrpMnuItm15Timer";
            this.TStrpMnuItm15Timer.Size = new System.Drawing.Size(132, 22);
            this.TStrpMnuItm15Timer.Text = "15 Minutes";
            this.TStrpMnuItm15Timer.Click += new System.EventHandler(this.TStrpMnuItm15Timer_Click);
            // 
            // TStrpMnuItm30Timer
            // 
            this.TStrpMnuItm30Timer.Name = "TStrpMnuItm30Timer";
            this.TStrpMnuItm30Timer.Size = new System.Drawing.Size(132, 22);
            this.TStrpMnuItm30Timer.Text = "30 Minutes";
            this.TStrpMnuItm30Timer.Click += new System.EventHandler(this.TStrpMnuItm30Timer_Click);
            // 
            // TStrpMnuItm60Timer
            // 
            this.TStrpMnuItm60Timer.Name = "TStrpMnuItm60Timer";
            this.TStrpMnuItm60Timer.Size = new System.Drawing.Size(132, 22);
            this.TStrpMnuItm60Timer.Text = "60 Minutes";
            this.TStrpMnuItm60Timer.Click += new System.EventHandler(this.TStrpMnuItm60Timer_Click);
            // 
            // TStrpMnuItmCustomTimer
            // 
            this.TStrpMnuItmCustomTimer.Name = "TStrpMnuItmCustomTimer";
            this.TStrpMnuItmCustomTimer.Size = new System.Drawing.Size(132, 22);
            this.TStrpMnuItmCustomTimer.Text = "Custom";
            this.TStrpMnuItmCustomTimer.Click += new System.EventHandler(this.TStrpMnuItmCustomTimer_Click);
            // 
            // MnuItmBackup
            // 
            this.MnuItmBackup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrpMnuItmBackupUI});
            this.MnuItmBackup.Name = "MnuItmBackup";
            this.MnuItmBackup.Size = new System.Drawing.Size(58, 20);
            this.MnuItmBackup.Text = "Backup";
            // 
            // TStrpMnuItmBackupUI
            // 
            this.TStrpMnuItmBackupUI.Name = "TStrpMnuItmBackupUI";
            this.TStrpMnuItmBackupUI.Size = new System.Drawing.Size(156, 22);
            this.TStrpMnuItmBackupUI.Text = "Load Backup UI";
            this.TStrpMnuItmBackupUI.Click += new System.EventHandler(this.TStrpMnuItmBackupUI_Click);
            // 
            // MnuItmAbout
            // 
            this.MnuItmAbout.Name = "MnuItmAbout";
            this.MnuItmAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuItmAbout.Text = "About";
            this.MnuItmAbout.Click += new System.EventHandler(this.MnuItmAbout_Click);
            // 
            // BtnClearSearch
            // 
            this.BtnClearSearch.Location = new System.Drawing.Point(360, 28);
            this.BtnClearSearch.Name = "BtnClearSearch";
            this.BtnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnClearSearch.TabIndex = 3;
            this.BtnClearSearch.Text = "Reset";
            this.BtnClearSearch.UseVisualStyleBackColor = true;
            this.BtnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // LstVewPrograms
            // 
            this.LstVewPrograms.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LstVewPrograms.AllowColumnReorder = true;
            this.LstVewPrograms.FullRowSelect = true;
            this.LstVewPrograms.HideSelection = false;
            this.LstVewPrograms.LargeImageList = this.ImgLstIcons;
            this.LstVewPrograms.Location = new System.Drawing.Point(12, 57);
            this.LstVewPrograms.Name = "LstVewPrograms";
            this.LstVewPrograms.Size = new System.Drawing.Size(422, 251);
            this.LstVewPrograms.SmallImageList = this.ImgLstIcons;
            this.LstVewPrograms.TabIndex = 4;
            this.LstVewPrograms.UseCompatibleStateImageBehavior = false;
            this.LstVewPrograms.View = System.Windows.Forms.View.List;
            this.LstVewPrograms.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstVewPrograms_ItemSelectionChanged);
            // 
            // ImgLstIcons
            // 
            this.ImgLstIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgLstIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TmrSaveData
            // 
            this.TmrSaveData.Interval = 15000;
            this.TmrSaveData.Tick += new System.EventHandler(this.TmrSaveData_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 347);
            this.Controls.Add(this.LstVewPrograms);
            this.Controls.Add(this.BtnClearSearch);
            this.Controls.Add(this.LblPreviewTitle);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearchInput);
            this.Controls.Add(this.BtnDuplicate);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.PnlFileName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PnlName);
            this.Controls.Add(this.PnlParam);
            this.Controls.Add(this.PnlLoc);
            this.Controls.Add(this.BtnLaunchProgram);
            this.Controls.Add(this.LblIcon);
            this.Controls.Add(this.PBoxIcon);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.BtnAddProgram);
            this.Controls.Add(this.TxtFileInput);
            this.Controls.Add(this.BtnLoadFile);
            this.Controls.Add(this.MnuStrpMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuStrpMainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 386);
            this.MinimumSize = new System.Drawing.Size(890, 386);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remember";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxIcon)).EndInit();
            this.PnlLoc.ResumeLayout(false);
            this.PnlLoc.PerformLayout();
            this.PnlName.ResumeLayout(false);
            this.PnlName.PerformLayout();
            this.PnlFileName.ResumeLayout(false);
            this.PnlFileName.PerformLayout();
            this.PnlParam.ResumeLayout(false);
            this.PnlParam.PerformLayout();
            this.MnuStrpMainMenu.ResumeLayout(false);
            this.MnuStrpMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLoadFile;
        private System.Windows.Forms.TextBox TxtFileInput;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.PictureBox PBoxIcon;
        private System.Windows.Forms.Label LblIcon;
        private System.Windows.Forms.Button BtnLaunchProgram;
        private System.Windows.Forms.Panel PnlLoc;
        private System.Windows.Forms.Panel PnlName;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel PnlFileName;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.TextBox TxtLocationInput;
        private System.Windows.Forms.TextBox TxtNameInput;
        private System.Windows.Forms.TextBox TxtFileNameInput;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label LblParameters;
        private System.Windows.Forms.TextBox TxtParametersInput;
        private System.Windows.Forms.Panel PnlParam;
        private System.Windows.Forms.Button BtnLocation;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearchInput;
        private System.Windows.Forms.Label LblPreviewTitle;
        private System.Windows.Forms.MenuStrip MnuStrpMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItmMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItmApplication;
        private System.Windows.Forms.ToolStripMenuItem MnuItmRestart;
        private System.Windows.Forms.ToolStripMenuItem MnuItmExit;
        private System.Windows.Forms.ToolStripMenuItem MnuItmExport;
        private System.Windows.Forms.ToolStripMenuItem MnuItmQuit;
        private System.Windows.Forms.ToolStripMenuItem MnuItmAbout;
        private System.Windows.Forms.Button BtnClearSearch;
        private System.Windows.Forms.ListView LstVewPrograms;
        private System.Windows.Forms.ImageList ImgLstIcons;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItmBackup;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItmBackupUI;
        public System.Windows.Forms.ToolStripMenuItem TStrpMnuItmResizing;
        public System.Windows.Forms.ToolStripMenuItem TStrpMnuItmDisableMsg;
        private System.Windows.Forms.Timer TmrSaveData;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItmSetTimer;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItm15Timer;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItm30Timer;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItm60Timer;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItmCustomTimer;
        private System.Windows.Forms.ToolStripMenuItem TStrpMnuItmOff;
    }
}

