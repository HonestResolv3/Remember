using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Remember
{
    public partial class BackupManager : Form
    {
        readonly List<BackupData> dataEntries = new List<BackupData>();
        readonly MainPage mainRef;
        public static bool IsActive = false;
        public BackupManager(MainPage page)
        {
            InitializeComponent();
            LoadBackups();
            mainRef = page;
            IsActive = true;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstBackupItems.SelectedIndex < 0 || LstBackupItems.SelectedIndex > LstBackupItems.Items.Count)
            {
                MessageBox.Show("Please select a valid entry from the list!", "Backup Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string choice = Interaction.InputBox($"Confirm deleting the entry at location {LstBackupItems.SelectedIndex + 1}?" +
                "\n\nType Y to continue, anything else to exit" +
                "\n\nPress X or Cancel to exit as well", "Delete Entry?");
            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                LstBackupItems.Items.RemoveAt(LstBackupItems.SelectedIndex);
                if (!mainRef.TStrpMnuItmDisableMsg.Checked)
                    MessageBox.Show("The entry has now been deleted!", "Backup Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackupManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsActive = false;
        }

        private void LoadBackups()
        {
            string[] files = System.IO.Directory.GetFiles(Remember.MainPage.Dir, "*.json");
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    string fileName = file.Substring(file.LastIndexOf("\\"), file.LastIndexOf("."));
                    MessageBox.Show(fileName + "\n\n" + file);
                    BackupData data = new BackupData(fileName, file);
                    dataEntries.Add(data);
                    LstBackupItems.Items.Add(data);
                }
            }
        }
    }
}
