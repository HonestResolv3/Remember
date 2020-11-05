
namespace Remember
{
    partial class BackupManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupManager));
            this.LblBackupTitle = new System.Windows.Forms.Label();
            this.LstBackupItems = new System.Windows.Forms.ListBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblPreviewArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBackupTitle
            // 
            this.LblBackupTitle.AutoSize = true;
            this.LblBackupTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBackupTitle.Location = new System.Drawing.Point(76, 5);
            this.LblBackupTitle.Name = "LblBackupTitle";
            this.LblBackupTitle.Size = new System.Drawing.Size(171, 30);
            this.LblBackupTitle.TabIndex = 9;
            this.LblBackupTitle.Text = "Manage Backups";
            // 
            // LstBackupItems
            // 
            this.LstBackupItems.FormattingEnabled = true;
            this.LstBackupItems.Location = new System.Drawing.Point(12, 41);
            this.LstBackupItems.Name = "LstBackupItems";
            this.LstBackupItems.Size = new System.Drawing.Size(305, 277);
            this.LstBackupItems.TabIndex = 10;
            this.LstBackupItems.SelectedIndexChanged += new System.EventHandler(this.LstBackupItems_SelectedIndexChanged);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(242, 329);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 11;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(323, 329);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(323, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 277);
            this.listBox1.TabIndex = 14;
            // 
            // LblPreviewArea
            // 
            this.LblPreviewArea.AutoSize = true;
            this.LblPreviewArea.BackColor = System.Drawing.Color.Transparent;
            this.LblPreviewArea.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreviewArea.Location = new System.Drawing.Point(406, 5);
            this.LblPreviewArea.Name = "LblPreviewArea";
            this.LblPreviewArea.Size = new System.Drawing.Size(133, 30);
            this.LblPreviewArea.TabIndex = 15;
            this.LblPreviewArea.Text = "Preview Area";
            // 
            // BackupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 360);
            this.Controls.Add(this.LblPreviewArea);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.LstBackupItems);
            this.Controls.Add(this.LblBackupTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 399);
            this.Name = "BackupManager";
            this.Text = "Backup Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBackupTitle;
        private System.Windows.Forms.ListBox LstBackupItems;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LblPreviewArea;
    }
}