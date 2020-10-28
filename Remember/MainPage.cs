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
        readonly string dataLocation = Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf("\\")) + "\\programdata.json";

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TxtFileInput.Text))
            {
                MessageBox.Show("Please enter a valid program path!", "Program Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fInfo = new FileInfo(TxtFileInput.Text);
            string name = Interaction.InputBox("What would you like to name this program shotcut? (Click X or Cancel to skip)", "Add name");
            name = string.IsNullOrWhiteSpace(name) ? fInfo.Name : name;
            string parameters = Interaction.InputBox("Would you like to add any additional parameters? (Click X or Cancel to skip)", "Add parameters");
            parameters = !string.IsNullOrWhiteSpace(parameters) ? parameters : "None";
            ProgramData prog = new ProgramData(name, fInfo.Name, fInfo.FullName, parameters, (ulong)fInfo.Length);
            ImgLstIcons.Images.Add(prog.Name, Bitmap.FromHicon(prog.Icon.Handle));
            LstVewPrograms.Items.Add(prog.Name, prog.Name);
            data.Add(prog);
            string jsonOutput = $"{JsonConvert.SerializeObject(prog)}\n";
            File.AppendAllText(dataLocation, jsonOutput);
            MessageBox.Show("Program has been added! You can see it in the list now", "Program Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ProgramData obj = data[search];
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
                MessageBox.Show("You do not have an application associated with this file!", "Program Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CallLoadFile();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to delete!", "Select A Program"))
                return;

            data.RemoveAt(search);
            ClearContents();
            ReloadContents();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to edit!", "Select A Program"))
                return;

            if (!File.Exists(TxtLocationInput.Text))
            {
                MessageBox.Show("Please enter in a valid program directory!", "Program Location Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fInfo = new FileInfo(TxtLocationInput.Text);
            data.ElementAt(search).Name = !string.IsNullOrWhiteSpace(TxtNameInput.Text) ? TxtNameInput.Text : data.ElementAt(search).Name; 
            data.ElementAt(search).Location = File.Exists(TxtLocationInput.Text) ? TxtLocationInput.Text : data.ElementAt(search).Location;
            data.ElementAt(search).Parameters = !string.IsNullOrWhiteSpace(TxtParametersInput.Text) ? TxtParametersInput.Text : "None";
            data.ElementAt(search).Icon = Icon.ExtractAssociatedIcon(data.ElementAt(search).Location);
            data.ElementAt(search).FileName = fInfo.Name;
            data.ElementAt(search).Size = (ulong)fInfo.Length;
            ImgLstIcons.Images.SetKeyName(search, data.ElementAt(search).Name);
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = Bitmap.FromHicon(data.ElementAt(search).Icon.Handle);
            ListViewItem item = LstVewPrograms.Items[search];
            LstVewPrograms.Items.RemoveAt(search);
            LstVewPrograms.Items.Insert(search, item);
            ReloadContents();
            MessageBox.Show("Program shortcut edited successfully!", "Program Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection(search, "Please select a program from the list to duplicate!", "Select A Program"))
                return;

            ProgramData obj = new ProgramData(data[search]);
            obj.Icon = Icon.ExtractAssociatedIcon(obj.Location);
            data.Add(obj);
            ReloadContents();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
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
                    LstVewPrograms.Items.Add(prog.Name, prog.Name);
            }
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            LstVewPrograms.Items.Clear();
            foreach (ProgramData prog in data)
                LstVewPrograms.Items.Add(prog.Name, prog.Name);
        }

        private void LstVewPrograms_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.ItemIndex < 0 || e.ItemIndex > LstVewPrograms.Items.Count)
                return;

            ProgramData obj = data[e.ItemIndex];
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = Bitmap.FromHicon(obj.Icon.Handle);
            TxtNameInput.Text = obj.Name;
            TxtFileNameInput.Text = obj.FileName;
            TxtLocationInput.Text = obj.Location;
            TxtParametersInput.Text = !string.IsNullOrWhiteSpace(obj.Parameters) ? obj.Parameters : "None";
            TxtSize.Text = GetBytesReadable(obj.Size);
            search = e.ItemIndex;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            CallLoadFile();
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
            MessageBox.Show("This program was created by KoukoCocoa, it lets you store programs with locations and parameters, then load said programs", "About the program");
        }

        private void MnuItmExport_Click(object sender, EventArgs e)
        {
            if (folderChooserDialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(folderChooserDialog.FileName))
            {
                string location = $"{folderChooserDialog.FileName}\\export.json";
                ExportInformation(location);
                MessageBox.Show($"The data has now been exported to {location}!", "Data Exported Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckForSelection(int index, string message, string title)
        {
            if (index < 0 || index > LstVewPrograms.Items.Count)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CallLoadFile()
        {
            try
            {
                LoadFile();
            }
            catch (Exception)
            {
                // Here an error happened with the .json, unfortunately this means the programs data is lost
            }
        }

        private void LoadFile()
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
                ImgLstIcons.Images.Add(prog.Name, Bitmap.FromHicon(prog.Icon.Handle));
                LstVewPrograms.Items.Add(prog.Name, prog.Name);
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

        private void ReloadContents()
        {
            File.WriteAllText(dataLocation, "");
            LstVewPrograms.Items.Clear();
            ImgLstIcons.Images.Clear();
            foreach (ProgramData prog in data)
            {
                ImgLstIcons.Images.Add(prog.Name, Bitmap.FromHicon(prog.Icon.Handle));
                string jsonOutput = JsonConvert.SerializeObject(prog) + "\n";
                File.AppendAllText(dataLocation, jsonOutput);
                LstVewPrograms.Items.Add(prog.Name, prog.Name);
            }
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

        /**
         * Credit to user from StackOverflow: https://stackoverflow.com/users/553396/humbads
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
