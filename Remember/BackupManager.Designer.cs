
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
            this.LblBackupTitle = new System.Windows.Forms.Label();
            this.LstBackupItems = new System.Windows.Forms.ListBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBackupTitle
            // 
            this.LblBackupTitle.AutoSize = true;
            this.LblBackupTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBackupTitle.Location = new System.Drawing.Point(156, 4);
            this.LblBackupTitle.Name = "LblBackupTitle";
            this.LblBackupTitle.Size = new System.Drawing.Size(171, 30);
            this.LblBackupTitle.TabIndex = 9;
            this.LblBackupTitle.Text = "Manage Backups";
            // 
            // LstBackupItems
            // 
            this.LstBackupItems.FormattingEnabled = true;
            this.LstBackupItems.Location = new System.Drawing.Point(17, 41);
            this.LstBackupItems.Name = "LstBackupItems";
            this.LstBackupItems.Size = new System.Drawing.Size(454, 277);
            this.LstBackupItems.TabIndex = 10;
            this.LstBackupItems.SelectedIndexChanged += new System.EventHandler(this.LstBackupItems_SelectedIndexChanged);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(161, 328);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 11;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(252, 328);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BackupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.LstBackupItems);
            this.Controls.Add(this.LblBackupTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BackupManager";
            this.Text = "BackupManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBackupTitle;
        private System.Windows.Forms.ListBox LstBackupItems;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnDelete;
    }
}