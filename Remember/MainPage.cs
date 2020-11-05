using Microsoft.VisualBasic;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Remember
{
    public partial class MainPage : Form
    {
        List<ProgramData> data = new List<ProgramData>();
        int search = 0;
        bool searchIsActive = false;
        public static string Dir = Path.Combine(Path.GetTempPath(), "Remember_Backups");
        readonly string dataLocation = Path.Combine(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf("\\")), "programdata.json");
        readonly Resizer resizeObj;
        readonly List<ProgramData> searchInformation = new List<ProgramData>();
        readonly CommonOpenFileDialog fileChooserDialog = new CommonOpenFileDialog()
        {
            Title = "Find program to store",
            EnsureFileExists = true,
            EnsurePathExists = true,
            IsFolderPicker = false,
            RestoreDirectory = true
        };
        readonly CommonOpenFileDialog folderChooserDialog = new CommonOpenFileDialog()
        {
            Title = "Export data to folder",
            EnsurePathExists = true,
            IsFolderPicker = true,
            RestoreDirectory = true
        };

        public MainPage()
        {
            InitializeComponent();
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            ChangeTimerSelection(-1);
            TmrSaveData.Start();
            resizeObj = new Resizer(this);
            Load += ResizerLoad;
            Resize += ResizerResize;
        }

        private void ResizerLoad(object sender, EventArgs e)
        {
            resizeObj.GetInitialSize();
        }

        private void ResizerResize(object sender, EventArgs e)
        {
            resizeObj.Resize();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TxtFileInput.Text))
            {
                _ = MessageBox.Show("Please enter a valid program path!", "Program Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddElement(false);
        }

        public void AddElement(bool skipPrompts)
        {
            if (!File.Exists(TxtLocationInput.Text) && skipPrompts)
            {
                _ = MessageBox.Show("Please enter a valid program path!", "Program Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fInfo = new FileInfo(TxtLocationInput.Text);
            ProgramData prog = new ProgramData(data[search].Name, fInfo.Name, fInfo.FullName, data[search].Parameters, (ulong)fInfo.Length);
            if (!skipPrompts)
            {
                string name = Interaction.InputBox("What would you like to name this program shotcut? (Click X or Cancel to skip)", "Add name");
                name = string.IsNullOrWhiteSpace(name) ? fInfo.Name : name;
                string parameters = Interaction.InputBox("Would you like to add any additional parameters? (Click X or Cancel to skip)", "Add parameters");
                parameters = !string.IsNullOrWhiteSpace(parameters) ? parameters : "None";
                prog = new ProgramData(name, fInfo.Name, fInfo.FullName, parameters, (ulong)fInfo.Length);
            }
            ImgLstIcons.Images.Add(prog.UniqueName, Bitmap.FromHicon(prog.Icon.Handle));
            LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
            data.Add(prog);
            string jsonOutput = $"{JsonConvert.SerializeObject(prog)}\n";
            File.AppendAllText(dataLocation, jsonOutput);
            if (!TStrpMnuItmDisableMsg.Checked)
                _ = MessageBox.Show("Program has been added! You can see it in the list now", "Program Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            if (fileChooserDialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fileChooserDialog.FileName))
                TxtFileInput.Text = fileChooserDialog.FileName;
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            if (fileChooserDialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fileChooserDialog.FileName))
                TxtLocationInput.Text = fileChooserDialog.FileName;
        }

        private void BtnLaunchProgram_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to launch!", "Select A Program"))
                return;

            ProgramData obj = GetSelectedObject(search);
            string parameters = !obj.Parameters.Equals("None", StringComparison.OrdinalIgnoreCase) ? obj.Parameters : "";
            ProcessStartInfo procStart = new ProcessStartInfo(obj.Location, parameters)
            {
                WindowStyle = ProcessWindowStyle.Normal,
            };

            try
            {
                Process.Start(procStart);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                _ = MessageBox.Show("You do not have an application associated with this file!", "Program Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to delete!", "Select A Program"))
                return;

            string choice = Interaction.InputBox($"Confirm deleting the entry at location {search + 1}?" +
                "\n\nType Y to continue, anything else to exit" +
                "\n\nPress X or Cancel to exit as well", "Delete Entry?");
            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                data.RemoveAt(search);
                ClearContents();
                ReloadContents(false);
                if (!TStrpMnuItmDisableMsg.Checked)
                    _ = MessageBox.Show("The entry has now been deleted!", "Backup Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to edit!", "Select A Program"))
                return;

            if (!File.Exists(TxtLocationInput.Text))
            {
                _ = MessageBox.Show("Please enter in a valid program directory!", "Program Location Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fInfo = new FileInfo(TxtLocationInput.Text);
            ProgramData obj = GetSelectedObject(search);
            obj.Name = !string.IsNullOrWhiteSpace(TxtNameInput.Text) ? TxtNameInput.Text : obj.Name;
            obj.Location = File.Exists(TxtLocationInput.Text) ? TxtLocationInput.Text : obj.Location;
            obj.Parameters = !string.IsNullOrWhiteSpace(TxtParametersInput.Text) ? TxtParametersInput.Text : "None";
            obj.Icon = Icon.ExtractAssociatedIcon(obj.Location);
            obj.FileName = fInfo.Name;
            obj.Size = (ulong)fInfo.Length;
            ImgLstIcons.Images.RemoveAt(search);
            ImgLstIcons.Images.Add(obj.UniqueName, obj.Icon);
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = obj.Icon.ToBitmap();
            ListViewItem item = LstVewPrograms.Items[search];
            LstVewPrograms.Items.RemoveAt(search);
            LstVewPrograms.Items.Insert(search, item);
            ReloadContents(false);
            if (searchIsActive)
                DoSearch();
            if (!TStrpMnuItmDisableMsg.Checked)
                _ = MessageBox.Show("Program shortcut edited successfully!", "Program Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to duplicate!", "Select A Program"))
                return;

            AddElement(true);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            LstVewPrograms.Items.Clear();
            foreach (ProgramData prog in data)
                LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
            searchIsActive = false;
        }

        private void LstVewPrograms_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.ItemIndex < 0 || e.ItemIndex > LstVewPrograms.Items.Count)
                return;

            ProgramData obj = GetSelectedObject(e.ItemIndex);

            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = obj.Icon.ToBitmap();
            TxtNameInput.Text = obj.Name;
            TxtFileNameInput.Text = obj.FileName;
            TxtLocationInput.Text = obj.Location;
            TxtParametersInput.Text = !string.IsNullOrWhiteSpace(obj.Parameters) ? obj.Parameters : "None";
            TxtSize.Text = GetBytesReadable(obj.Size);
            search = e.ItemIndex;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            CallDefaultLoadFile();
        }

        private void MnuItmRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MnuItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuItmQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuItmAbout_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("This program was created by KoukoCocoa, it lets you store programs with locations and parameters, then load said programs", "About the program");
        }

        private void MnuItmExport_Click(object sender, EventArgs e)
        {
            if (folderChooserDialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(folderChooserDialog.FileName))
            {
                string location = $"{folderChooserDialog.FileName}\\export.json";
                ExportInformation(location);
                if (!TStrpMnuItmDisableMsg.Checked)
                    _ = MessageBox.Show($"The data has now been exported to {location}!", "Data Exported Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TStrpMnuItmResizing_Click(object sender, EventArgs e)
        {
            CheckForResizeSelection();
        }

        private void TStrpMnuItmDisableMsg_Click(object sender, EventArgs e)
        {
            if (!TStrpMnuItmDisableMsg.Checked)
                TStrpMnuItmDisableMsg.Checked = true;
            else
                TStrpMnuItmDisableMsg.Checked = false;
        }


        private void TStrpMnuItmBackupUI_Click(object sender, EventArgs e)
        {
            if (!BackupManager.IsActive)
            {
                BackupManager manager = new BackupManager(this);
                manager.ShowDialog();
            }
        }


        private void TStrpMnuItmOff_Click(object sender, EventArgs e)
        {
            ChangeTimerSelection(-1);
        }

        private void TStrpMnuItm15Timer_Click(object sender, EventArgs e)
        {
            ChangeTimerSelection(0);
        }

        private void TStrpMnuItm30Timer_Click(object sender, EventArgs e)
        {
            ChangeTimerSelection(1);
        }

        private void TStrpMnuItm60Timer_Click(object sender, EventArgs e)
        {
            ChangeTimerSelection(2);
        }

        private void TStrpMnuItmCustomTimer_Click(object sender, EventArgs e)
        {
            ChangeTimerSelection(3);
        }

        private void TmrSaveData_Tick(object sender, EventArgs e)
        {
            if (File.Exists(dataLocation))
            {
                try
                {
                    if (File.Exists(Path.Combine(Dir, $"backup{Properties.Settings.Default.CurrentBackupCount}.json")))
                    {
                        Remember.Properties.Settings.Default.CurrentBackupCount++;
                        return;
                    }

                    File.Copy(dataLocation, Path.Combine(Dir, "programdata.json"));
                    FileSystem.Rename(Path.Combine(Dir, "programdata.json"), Path.Combine(Dir, $"backup{Properties.Settings.Default.CurrentBackupCount}.json"));
                }
                catch (IOException)
                {
                    // If the file already exists, do not do anything, I will make a label telling the user there's an error as well if they modify the files
                }
            }
        }

        private void CheckForResizeSelection()
        {
            if (!TStrpMnuItmResizing.Checked)
            {
                TStrpMnuItmResizing.Checked = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                MaximizeBox = true;
                MaximumSize = new Size(0, 0);
            }
            else
            {
                TStrpMnuItmResizing.Checked = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                MaximizeBox = false;
                MaximumSize = new Size(890, 386);
            }
        }

        private bool CheckForSelection(int index, string message, string title)
        {
            if (index < 0 || index >= LstVewPrograms.Items.Count)
            {
                _ = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CallDefaultLoadFile()
        {
            try
            {
                LoadDefaultFile();
            }
            catch (Exception)
            {
                // Here an error happened with the .json, unfortunately this means the programs data is lost
            }
        }

        private void LoadDefaultFile()
        {
            if (!File.Exists(dataLocation))
                return;

            LstVewPrograms.Items.Clear();
            ImgLstIcons.Images.Clear();
            data = File.ReadAllLines(dataLocation)
                .Select(line => JsonConvert.DeserializeObject<ProgramData>(line)).ToList();

            foreach (ProgramData prog in data)
            {
                if (prog == null)
                    continue;

                prog.Icon = Icon.ExtractAssociatedIcon(prog.Location);
                ImgLstIcons.Images.Add(prog.UniqueName, prog.Icon);
                LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
            }
        }

        private void LoadTempFile()
        {
            //if (!File.Exists())
                //return;

            LstVewPrograms.Items.Clear();
            ImgLstIcons.Images.Clear();
            data = File.ReadAllLines(dataLocation)
                .Select(line => JsonConvert.DeserializeObject<ProgramData>(line)).ToList();

            foreach (ProgramData prog in data)
            {
                if (prog == null)
                    continue;

                prog.Icon = Icon.ExtractAssociatedIcon(prog.Location);
                ImgLstIcons.Images.Add(prog.UniqueName, prog.Icon);
                LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
            }
        }

        private void ClearContents()
        {
            File.WriteAllText(dataLocation, "");
            LstVewPrograms.Items.Clear();
            TxtNameInput.Clear();
            TxtFileInput.Clear();
            TxtFileNameInput.Clear();
            TxtLocationInput.Clear();
            TxtParametersInput.Clear();
            TxtSize.Clear();
        }

        private void ChangeTimerSelection(int value)
        {
            switch (value)
            {
                case -1:
                    TStrpMnuItmOff.Checked = true;
                    TStrpMnuItm15Timer.Checked = false;
                    TStrpMnuItm30Timer.Checked = false;
                    TStrpMnuItm60Timer.Checked = false;
                    TStrpMnuItmCustomTimer.Checked = false;
                    TmrSaveData.Stop();
                    break;
                case 0:
                    TStrpMnuItmOff.Checked = false;
                    TStrpMnuItm15Timer.Checked = true;
                    TStrpMnuItm30Timer.Checked = false;
                    TStrpMnuItm60Timer.Checked = false;
                    TStrpMnuItmCustomTimer.Checked = false;
                    TmrSaveData.Interval = 900000;
                    TmrSaveData.Start();
                    break;
                case 1:
                    TStrpMnuItmOff.Checked = false;
                    TStrpMnuItm15Timer.Checked = false;
                    TStrpMnuItm30Timer.Checked = true;
                    TStrpMnuItm60Timer.Checked = false;
                    TStrpMnuItmCustomTimer.Checked = false;
                    TmrSaveData.Interval = 1800000;
                    TmrSaveData.Start();
                    break;
                case 2:
                    TStrpMnuItmOff.Checked = false;
                    TStrpMnuItm15Timer.Checked = false;
                    TStrpMnuItm30Timer.Checked = false;
                    TStrpMnuItm60Timer.Checked = true;
                    TStrpMnuItmCustomTimer.Checked = false;
                    TmrSaveData.Interval = 3600000;
                    TmrSaveData.Start();
                    break;
                case 3:
                    string timerInput = Interaction.InputBox("Enter the time interval backups are saved at" +
                        "\n\nEnter the time in minutes (I.e.: 20, 75, 120, etc.)" +
                        "\n\nNOTE: Lower times = more CPU usage", "Enter Custom Timer");
                    if (!double.TryParse(timerInput, out double TimerValue) && TimerValue > 0)
                    {
                        _ = MessageBox.Show("Please enter in a valid number for the timer!", "Timer Set Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        TmrSaveData.Interval = (int) (TimerValue * 60000);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        _ = MessageBox.Show("Please enter in a valid number for the timer!", "Timer Set Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception)
                    {
                        _ = MessageBox.Show("An error occured when trying to add the custom timer", "Timer Set Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!TStrpMnuItmDisableMsg.Checked)
                        _ = MessageBox.Show($"The backup save timer is now set to run every {TimerValue} minutes", "Timer Set Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TStrpMnuItm15Timer.Checked = false;
                    TStrpMnuItm30Timer.Checked = false;
                    TStrpMnuItm60Timer.Checked = false;
                    TStrpMnuItmCustomTimer.Checked = true;
                    break;
            }
        }

        private void ReloadContents(bool skipWrite)
        {
            if (!skipWrite)
                File.WriteAllText(dataLocation, "");
            LstVewPrograms.Items.Clear();
            ImgLstIcons.Images.Clear();
            foreach (ProgramData prog in data)
            {
                ImgLstIcons.Images.Add(prog.UniqueName, prog.Icon);
                if (!skipWrite)
                {
                    string jsonOutput = JsonConvert.SerializeObject(prog) + "\n";
                    File.AppendAllText(dataLocation, jsonOutput);
                }
                LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
            }
        }

        private void DoSearch()
        {
            searchInformation.Clear();
            if (!string.IsNullOrWhiteSpace(TxtSearchInput.Text))
            {
                foreach (ProgramData prog in data)
                {
                    if (prog.Name.IndexOf(TxtSearchInput.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        searchInformation.Add(prog);
                }
            }
            if (searchInformation.Count > 0)
            {
                LstVewPrograms.Items.Clear();
                foreach (ProgramData prog in searchInformation)
                    LstVewPrograms.Items.Add(prog.Name, prog.UniqueName);
                searchIsActive = true;
            }
            else
                searchIsActive = false;
        }

        private void ExportInformation(string location)
        {
            if (File.Exists(location))
                File.WriteAllText(location, "");
            foreach (ProgramData prog in data)
            {
                string jsonOutput = JsonConvert.SerializeObject(prog) + "\n";
                File.AppendAllText(location, jsonOutput);
            }
        }

        private ProgramData GetSelectedObject(int index)
        {
            ProgramData obj;
            if (!searchIsActive)
                obj = data[index];
            else
                obj = searchInformation[index];
            return obj;
        }

        /**
         * Credit to this user from StackOverflow: https://stackoverflow.com/users/553396/humbads
         * Post from site: https://www.somacon.com/p576.php
         */
        private string GetBytesReadable(ulong i)
        {
            // Get absolute value
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (i >= 0x1000000000000000) // Exabyte
            {
                suffix = " EB";
                readable = (i >> 50);
            }
            else if (i >= 0x4000000000000) // Petabyte
            {
                suffix = " PB";
                readable = (i >> 40);
            }
            else if (i >= 0x10000000000) // Terabyte
            {
                suffix = " TB";
                readable = (i >> 30);
            }
            else if (i >= 0x40000000) // Gigabyte
            {
                suffix = " GB";
                readable = (i >> 20);
            }
            else if (i >= 0x100000) // Megabyte
            {
                suffix = " MB";
                readable = (i >> 10);
            }
            else if (i >= 0x400) // Kilobyte
            {
                suffix = " KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable /= 1024;
            // Return formatted number with suffix
            return readable.ToString("0.##") + suffix;
        }
    }
}
