
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.LstProgramList = new System.Windows.Forms.ListBox();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.TxtFileInput = new System.Windows.Forms.TextBox();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.PBoxIcon = new System.Windows.Forms.PictureBox();
            this.LblIcon = new System.Windows.Forms.Label();
            this.BtnLaunchProgram = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblPreviewTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuItmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxIcon)).BeginInit();
            this.PnlLoc.SuspendLayout();
            this.PnlName.SuspendLayout();
            this.PnlFileName.SuspendLayout();
            this.PnlParam.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstProgramList
            // 
            this.LstProgramList.FormattingEnabled = true;
            this.LstProgramList.Location = new System.Drawing.Point(12, 57);
            this.LstProgramList.Name = "LstProgramList";
            this.LstProgramList.Size = new System.Drawing.Size(423, 251);
            this.LstProgramList.TabIndex = 3;
            this.LstProgramList.SelectedIndexChanged += new System.EventHandler(this.LstProgramList_SelectedIndexChanged);
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Location = new System.Drawing.Point(12, 315);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadFile.TabIndex = 4;
            this.BtnLoadFile.Text = "Load File";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // TxtFileInput
            // 
            this.TxtFileInput.Location = new System.Drawing.Point(93, 316);
            this.TxtFileInput.Name = "TxtFileInput";
            this.TxtFileInput.Size = new System.Drawing.Size(261, 22);
            this.TxtFileInput.TabIndex = 5;
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.Location = new System.Drawing.Point(360, 315);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProgram.TabIndex = 6;
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
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Name:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(442, 279);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(30, 13);
            this.LblSize.TabIndex = 21;
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
            this.LblIcon.TabIndex = 8;
            this.LblIcon.Text = "Icon:";
            // 
            // BtnLaunchProgram
            // 
            this.BtnLaunchProgram.Location = new System.Drawing.Point(456, 314);
            this.BtnLaunchProgram.Name = "BtnLaunchProgram";
            this.BtnLaunchProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnLaunchProgram.TabIndex = 23;
            this.BtnLaunchProgram.Text = "Launch";
            this.BtnLaunchProgram.UseVisualStyleBackColor = true;
            this.BtnLaunchProgram.Click += new System.EventHandler(this.BtnLaunchProgram_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(537, 314);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 24;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // PnlLoc
            // 
            this.PnlLoc.AutoScroll = true;
            this.PnlLoc.Controls.Add(this.BtnLocation);
            this.PnlLoc.Controls.Add(this.TxtLocationInput);
            this.PnlLoc.Location = new System.Drawing.Point(440, 190);
            this.PnlLoc.Name = "PnlLoc";
            this.PnlLoc.Size = new System.Drawing.Size(423, 38);
            this.PnlLoc.TabIndex = 15;
            // 
            // BtnLocation
            // 
            this.BtnLocation.Location = new System.Drawing.Point(0, 0);
            this.BtnLocation.Name = "BtnLocation";
            this.BtnLocation.Size = new System.Drawing.Size(61, 23);
            this.BtnLocation.TabIndex = 16;
            this.BtnLocation.Text = "Location";
            this.BtnLocation.UseVisualStyleBackColor = true;
            this.BtnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // TxtLocationInput
            // 
            this.TxtLocationInput.Location = new System.Drawing.Point(77, 0);
            this.TxtLocationInput.Name = "TxtLocationInput";
            this.TxtLocationInput.Size = new System.Drawing.Size(346, 22);
            this.TxtLocationInput.TabIndex = 17;
            // 
            // PnlName
            // 
            this.PnlName.AutoScroll = true;
            this.PnlName.Controls.Add(this.TxtNameInput);
            this.PnlName.Controls.Add(this.LblName);
            this.PnlName.Location = new System.Drawing.Point(440, 102);
            this.PnlName.Name = "PnlName";
            this.PnlName.Size = new System.Drawing.Size(423, 38);
            this.PnlName.TabIndex = 9;
            // 
            // TxtNameInput
            // 
            this.TxtNameInput.Location = new System.Drawing.Point(77, 0);
            this.TxtNameInput.Name = "TxtNameInput";
            this.TxtNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtNameInput.TabIndex = 11;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(699, 314);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(618, 314);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 25;
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
            this.PnlFileName.TabIndex = 12;
            // 
            // TxtFileNameInput
            // 
            this.TxtFileNameInput.Location = new System.Drawing.Point(77, 1);
            this.TxtFileNameInput.Name = "TxtFileNameInput";
            this.TxtFileNameInput.ReadOnly = true;
            this.TxtFileNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtFileNameInput.TabIndex = 14;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(1, 4);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(60, 13);
            this.LblFileName.TabIndex = 13;
            this.LblFileName.Text = "File Name:";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(517, 276);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.ReadOnly = true;
            this.TxtSize.Size = new System.Drawing.Size(346, 22);
            this.TxtSize.TabIndex = 22;
            // 
            // LblParameters
            // 
            this.LblParameters.AutoSize = true;
            this.LblParameters.Location = new System.Drawing.Point(1, 4);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(66, 13);
            this.LblParameters.TabIndex = 19;
            this.LblParameters.Text = "Parameters:";
            // 
            // TxtParametersInput
            // 
            this.TxtParametersInput.Location = new System.Drawing.Point(77, 0);
            this.TxtParametersInput.Name = "TxtParametersInput";
            this.TxtParametersInput.Size = new System.Drawing.Size(346, 22);
            this.TxtParametersInput.TabIndex = 20;
            // 
            // PnlParam
            // 
            this.PnlParam.AutoScroll = true;
            this.PnlParam.Controls.Add(this.TxtParametersInput);
            this.PnlParam.Controls.Add(this.LblParameters);
            this.PnlParam.Location = new System.Drawing.Point(440, 234);
            this.PnlParam.Name = "PnlParam";
            this.PnlParam.Size = new System.Drawing.Size(423, 38);
            this.PnlParam.TabIndex = 18;
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Location = new System.Drawing.Point(780, 314);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(75, 23);
            this.BtnDuplicate.TabIndex = 27;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 22);
            this.textBox1.TabIndex = 2;
            // 
            // LblPreviewTitle
            // 
            this.LblPreviewTitle.AutoSize = true;
            this.LblPreviewTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewTitle.Location = new System.Drawing.Point(595, 28);
            this.LblPreviewTitle.Name = "LblPreviewTitle";
            this.LblPreviewTitle.Size = new System.Drawing.Size(133, 30);
            this.LblPreviewTitle.TabIndex = 7;
            this.LblPreviewTitle.Text = "Preview Area";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmMenu,
            this.MnuItmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "MnuMainStrip";
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
            this.MnuItmApplication.Size = new System.Drawing.Size(180, 22);
            this.MnuItmApplication.Text = "Application";
            // 
            // MnuItmRestart
            // 
            this.MnuItmRestart.Name = "MnuItmRestart";
            this.MnuItmRestart.Size = new System.Drawing.Size(180, 22);
            this.MnuItmRestart.Text = "Restart";
            this.MnuItmRestart.Click += new System.EventHandler(this.MnuItmRestart_Click);
            // 
            // MnuItmExit
            // 
            this.MnuItmExit.Name = "MnuItmExit";
            this.MnuItmExit.Size = new System.Drawing.Size(180, 22);
            this.MnuItmExit.Text = "Exit";
            this.MnuItmExit.Click += new System.EventHandler(this.MnuItmExit_Click);
            // 
            // MnuItmExport
            // 
            this.MnuItmExport.Name = "MnuItmExport";
            this.MnuItmExport.Size = new System.Drawing.Size(180, 22);
            this.MnuItmExport.Text = "Export Data";
            this.MnuItmExport.Click += new System.EventHandler(this.MnuItmExport_Click);
            // 
            // MnuItmQuit
            // 
            this.MnuItmQuit.Name = "MnuItmQuit";
            this.MnuItmQuit.Size = new System.Drawing.Size(180, 22);
            this.MnuItmQuit.Text = "Quit";
            this.MnuItmQuit.Click += new System.EventHandler(this.MnuItmQuit_Click);
            // 
            // MnuItmAbout
            // 
            this.MnuItmAbout.Name = "MnuItmAbout";
            this.MnuItmAbout.Size = new System.Drawing.Size(52, 20);
            this.MnuItmAbout.Text = "About";
            this.MnuItmAbout.Click += new System.EventHandler(this.MnuItmAbout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 346);
            this.Controls.Add(this.LblPreviewTitle);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDuplicate);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.PnlFileName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PnlName);
            this.Controls.Add(this.PnlParam);
            this.Controls.Add(this.PnlLoc);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnLaunchProgram);
            this.Controls.Add(this.LblIcon);
            this.Controls.Add(this.PBoxIcon);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.BtnAddProgram);
            this.Controls.Add(this.TxtFileInput);
            this.Controls.Add(this.BtnLoadFile);
            this.Controls.Add(this.LstProgramList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(890, 385);
            this.MinimumSize = new System.Drawing.Size(890, 345);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstProgramList;
        private System.Windows.Forms.Button BtnLoadFile;
        private System.Windows.Forms.TextBox TxtFileInput;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.PictureBox PBoxIcon;
        private System.Windows.Forms.Label LblIcon;
        private System.Windows.Forms.Button BtnLaunchProgram;
        private System.Windows.Forms.Button BtnRefresh;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblPreviewTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuItmMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItmApplication;
        private System.Windows.Forms.ToolStripMenuItem MnuItmRestart;
        private System.Windows.Forms.ToolStripMenuItem MnuItmExit;
        private System.Windows.Forms.ToolStripMenuItem MnuItmExport;
        private System.Windows.Forms.ToolStripMenuItem MnuItmQuit;
        private System.Windows.Forms.ToolStripMenuItem MnuItmAbout;
    }
}

