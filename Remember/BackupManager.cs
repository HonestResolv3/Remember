using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Remember
{
    public partial class BackupManager : Form
    {
        int searchIndex = -1;
        string[] files;
        readonly List<BackupData> dataEntries = new List<BackupData>();
        readonly MainPage mainRef;
        readonly Resizer resizeObj;
        public static bool IsActive = false;
        public BackupManager(MainPage page)
        {
            InitializeComponent();
            LoadBackups();
            mainRef = page;
            IsActive = true;
            if (mainRef.TStrpMnuItmResizing.Checked)
            {
                resizeObj = new Resizer(this);
                Load += ResizerLoad;
                Resize += ResizerResize;
                FormBorderStyle = FormBorderStyle.Sizable;
                MaximizeBox = true;
                MaximumSize = new Size(0, 0);
            }
        }

        private void ResizerLoad(object sender, EventArgs e)
        {
            resizeObj.GetInitialSize();
        }

        private void ResizerResize(object sender, EventArgs e)
        {
            resizeObj.Resize();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(searchIndex))
                return;

            string choice = Interaction.InputBox($"Confirm loading the entry at location {LstBackupItems.SelectedIndex + 1}?" +
                "\n\nType Y to continue, anything else to exit" +
                "\n\nPress X or Cancel to exit as well", "Load Entry?");
            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                BackupData data = dataEntries[searchIndex];
                mainRef.LoadTempFile(data.Location);
                if (!mainRef.TStrpMnuItmDisableMsg.Checked)
                    _ = MessageBox.Show("The entry has now been loaded in the main program!", "Backup Loaded Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(searchIndex))
                return;

            string choice = Interaction.InputBox($"Confirm deleting the entry at location {LstBackupItems.SelectedIndex + 1}?" +
                "\n\nType Y to continue, anything else to exit" +
                "\n\nPress X or Cancel to exit as well", "Delete Entry?");
            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                LoadBackups();
                LstBackupItems.Items.RemoveAt(searchIndex);
                BackupData data = dataEntries[searchIndex];
                File.Delete(data.Location);
                dataEntries.RemoveAt(searchIndex);
                if (!mainRef.TStrpMnuItmDisableMsg.Checked)
                    _ = MessageBox.Show("The entry has now been deleted!", "Backup Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackupManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsActive = false;
        }

        private void LstBackupItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBackupItems.SelectedIndex == -1)
                return;

            searchIndex = LstBackupItems.SelectedIndex;
            BackupData backup = dataEntries[searchIndex];
            List<ProgramData> data = File.ReadAllLines(backup.Location).Select(line => JsonConvert.DeserializeObject<ProgramData>(line)).ToList();
            LstPreviewArea.Items.Clear();
            foreach (ProgramData prog in data)
                LstPreviewArea.Items.Add(prog);
        }


        private bool CheckForSelection(int index)
        {
            if (index < 0 || index > LstBackupItems.Items.Count)
            {
                _ = MessageBox.Show("Please select a valid entry from the list!", "Backup Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LoadBackups()
        {
            LstBackupItems.Items.Clear();
            files = Directory.GetFiles(MainPage.Dir, "*.json");
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    string fileName = file.Substring(file.LastIndexOf("\\") + 1);
                    BackupData data = new BackupData(fileName, file);
                    dataEntries.Add(data);
                    LstBackupItems.Items.Add(data);
                }
            }
        }
    }
}
