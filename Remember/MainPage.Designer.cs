
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
            this.LblLocation = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.PBoxIcon = new System.Windows.Forms.PictureBox();
            this.LblIcon = new System.Windows.Forms.Label();
            this.BtnLaunchProgram = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.PnlLoc = new System.Windows.Forms.Panel();
            this.PnlName = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlFileName = new System.Windows.Forms.Panel();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TxtFileNameInput = new System.Windows.Forms.TextBox();
            this.TxtNameInput = new System.Windows.Forms.TextBox();
            this.TxtLocationInput = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.LblParameters = new System.Windows.Forms.Label();
            this.TxtParametersInput = new System.Windows.Forms.TextBox();
            this.PnlParam = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxIcon)).BeginInit();
            this.PnlLoc.SuspendLayout();
            this.PnlName.SuspendLayout();
            this.PnlFileName.SuspendLayout();
            this.PnlParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstProgramList
            // 
            this.LstProgramList.FormattingEnabled = true;
            this.LstProgramList.Location = new System.Drawing.Point(12, 13);
            this.LstProgramList.Name = "LstProgramList";
            this.LstProgramList.Size = new System.Drawing.Size(423, 251);
            this.LstProgramList.TabIndex = 0;
            this.LstProgramList.SelectedIndexChanged += new System.EventHandler(this.LstProgramList_SelectedIndexChanged);
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Location = new System.Drawing.Point(12, 273);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadFile.TabIndex = 1;
            this.BtnLoadFile.Text = "Load File";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // TxtFileInput
            // 
            this.TxtFileInput.Location = new System.Drawing.Point(93, 274);
            this.TxtFileInput.Name = "TxtFileInput";
            this.TxtFileInput.Size = new System.Drawing.Size(261, 22);
            this.TxtFileInput.TabIndex = 2;
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.Location = new System.Drawing.Point(360, 273);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProgram.TabIndex = 3;
            this.BtnAddProgram.Text = "Add";
            this.BtnAddProgram.UseVisualStyleBackColor = true;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(1, 4);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 13);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Name:";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(1, 5);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(54, 13);
            this.LblLocation.TabIndex = 12;
            this.LblLocation.Text = "Location:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(441, 237);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(30, 13);
            this.LblSize.TabIndex = 17;
            this.LblSize.Text = "Size:";
            // 
            // PBoxIcon
            // 
            this.PBoxIcon.Location = new System.Drawing.Point(516, 12);
            this.PBoxIcon.Name = "PBoxIcon";
            this.PBoxIcon.Size = new System.Drawing.Size(36, 37);
            this.PBoxIcon.TabIndex = 12;
            this.PBoxIcon.TabStop = false;
            // 
            // LblIcon
            // 
            this.LblIcon.AutoSize = true;
            this.LblIcon.Location = new System.Drawing.Point(441, 23);
            this.LblIcon.Name = "LblIcon";
            this.LblIcon.Size = new System.Drawing.Size(32, 13);
            this.LblIcon.TabIndex = 4;
            this.LblIcon.Text = "Icon:";
            // 
            // BtnLaunchProgram
            // 
            this.BtnLaunchProgram.Location = new System.Drawing.Point(500, 273);
            this.BtnLaunchProgram.Name = "BtnLaunchProgram";
            this.BtnLaunchProgram.Size = new System.Drawing.Size(75, 23);
            this.BtnLaunchProgram.TabIndex = 19;
            this.BtnLaunchProgram.Text = "Launch";
            this.BtnLaunchProgram.UseVisualStyleBackColor = true;
            this.BtnLaunchProgram.Click += new System.EventHandler(this.BtnLaunchProgram_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(581, 273);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 20;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // PnlLoc
            // 
            this.PnlLoc.AutoScroll = true;
            this.PnlLoc.Controls.Add(this.TxtLocationInput);
            this.PnlLoc.Controls.Add(this.LblLocation);
            this.PnlLoc.Location = new System.Drawing.Point(439, 148);
            this.PnlLoc.Name = "PnlLoc";
            this.PnlLoc.Size = new System.Drawing.Size(423, 38);
            this.PnlLoc.TabIndex = 11;
            // 
            // PnlName
            // 
            this.PnlName.AutoScroll = true;
            this.PnlName.Controls.Add(this.TxtNameInput);
            this.PnlName.Controls.Add(this.LblName);
            this.PnlName.Location = new System.Drawing.Point(439, 60);
            this.PnlName.Name = "PnlName";
            this.PnlName.Size = new System.Drawing.Size(423, 38);
            this.PnlName.TabIndex = 5;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(743, 273);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 22;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(662, 273);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PnlFileName
            // 
            this.PnlFileName.AutoScroll = true;
            this.PnlFileName.Controls.Add(this.TxtFileNameInput);
            this.PnlFileName.Controls.Add(this.LblFileName);
            this.PnlFileName.Location = new System.Drawing.Point(439, 104);
            this.PnlFileName.Name = "PnlFileName";
            this.PnlFileName.Size = new System.Drawing.Size(423, 38);
            this.PnlFileName.TabIndex = 8;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(1, 4);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(60, 13);
            this.LblFileName.TabIndex = 9;
            this.LblFileName.Text = "File Name:";
            // 
            // TxtFileNameInput
            // 
            this.TxtFileNameInput.Location = new System.Drawing.Point(77, 1);
            this.TxtFileNameInput.Name = "TxtFileNameInput";
            this.TxtFileNameInput.ReadOnly = true;
            this.TxtFileNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtFileNameInput.TabIndex = 10;
            // 
            // TxtNameInput
            // 
            this.TxtNameInput.Location = new System.Drawing.Point(77, 0);
            this.TxtNameInput.Name = "TxtNameInput";
            this.TxtNameInput.Size = new System.Drawing.Size(346, 22);
            this.TxtNameInput.TabIndex = 7;
            // 
            // TxtLocationInput
            // 
            this.TxtLocationInput.Location = new System.Drawing.Point(77, 0);
            this.TxtLocationInput.Name = "TxtLocationInput";
            this.TxtLocationInput.Size = new System.Drawing.Size(346, 22);
            this.TxtLocationInput.TabIndex = 13;
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(516, 234);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.ReadOnly = true;
            this.TxtSize.Size = new System.Drawing.Size(346, 22);
            this.TxtSize.TabIndex = 18;
            // 
            // LblParameters
            // 
            this.LblParameters.AutoSize = true;
            this.LblParameters.Location = new System.Drawing.Point(1, 4);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(66, 13);
            this.LblParameters.TabIndex = 15;
            this.LblParameters.Text = "Parameters:";
            // 
            // TxtParametersInput
            // 
            this.TxtParametersInput.Location = new System.Drawing.Point(77, 0);
            this.TxtParametersInput.Name = "TxtParametersInput";
            this.TxtParametersInput.Size = new System.Drawing.Size(346, 22);
            this.TxtParametersInput.TabIndex = 16;
            // 
            // PnlParam
            // 
            this.PnlParam.AutoScroll = true;
            this.PnlParam.Controls.Add(this.TxtParametersInput);
            this.PnlParam.Controls.Add(this.LblParameters);
            this.PnlParam.Location = new System.Drawing.Point(439, 192);
            this.PnlParam.Name = "PnlParam";
            this.PnlParam.Size = new System.Drawing.Size(423, 38);
            this.PnlParam.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 306);
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(890, 345);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstProgramList;
        private System.Windows.Forms.Button BtnLoadFile;
        private System.Windows.Forms.TextBox TxtFileInput;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLocation;
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
    }
}

