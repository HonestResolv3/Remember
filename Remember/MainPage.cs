using Microsoft.VisualBasic;
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
        readonly OpenFileDialog dialog = new OpenFileDialog()
        {
            Title = "Find program to store",
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
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
            Icon icon = Icon.ExtractAssociatedIcon(fInfo.FullName);
            string name = Interaction.InputBox("What would you like to name this program shotcut? (Click X or Cancel to skip)", "Add name");
            name = string.IsNullOrWhiteSpace(name) ? fInfo.Name : name;
            string parameters = Interaction.InputBox("Would you like to add any additional parameters? (Click X or Cancel to skip)", "Add parameters");
            parameters = !string.IsNullOrWhiteSpace(parameters) ? parameters : "None";
            ProgramData prog = new ProgramData(name, fInfo.Name, fInfo.FullName, parameters, (ulong)fInfo.Length, icon);
            LstProgramList.Items.Add(prog);
            data.Add(prog);
            string jsonOutput = JsonConvert.SerializeObject(prog) + "\n";
            File.AppendAllText(dataLocation, jsonOutput);
            MessageBox.Show("Program has been added! You can see it in the list now", "Program Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dialog.FileName))
                TxtFileInput.Text = dialog.FileName;
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dialog.FileName))
                TxtLocationInput.Text = dialog.FileName;
        }

        private void BtnLaunchProgram_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection("Please select a program from the list to launch!", "Select A Program"))
                return;

            ProgramData obj = (ProgramData)LstProgramList.Items[LstProgramList.SelectedIndex];
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
            if (!CheckForSelection("Please select a program from the list to delete!", "Select A Program"))
                return;

            data.RemoveAt(LstProgramList.SelectedIndex);
            ClearContents();
            ReloadContents();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection("Please select a program from the list to edit!", "Select A Program"))
                return;

            data.ElementAt(LstProgramList.SelectedIndex).Name = !string.IsNullOrWhiteSpace(TxtNameInput.Text) ? TxtNameInput.Text : data.ElementAt(LstProgramList.SelectedIndex).Name; 
            data.ElementAt(LstProgramList.SelectedIndex).Location = File.Exists(TxtLocationInput.Text) ? TxtLocationInput.Text : data.ElementAt(LstProgramList.SelectedIndex).Location;
            data.ElementAt(LstProgramList.SelectedIndex).Parameters = !string.IsNullOrWhiteSpace(TxtParametersInput.Text) ? TxtParametersInput.Text : "None";
            data.ElementAt(LstProgramList.SelectedIndex).Icon = Icon.ExtractAssociatedIcon(data.ElementAt(LstProgramList.SelectedIndex).Location);
            FileInfo fInfo = new FileInfo(data.ElementAt(LstProgramList.SelectedIndex).Location);
            data.ElementAt(LstProgramList.SelectedIndex).Size = (ulong)fInfo.Length;
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = Bitmap.FromHicon(data.ElementAt(LstProgramList.SelectedIndex).Icon.Handle);
            ReloadContents();
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            if (!CheckForSelection("Please select a program from the list to duplicate!", "Select A Program"))
                return;

            data.Add((ProgramData)LstProgramList.Items[LstProgramList.SelectedIndex]);
            ReloadContents();
        }


        private void LstProgramList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstProgramList.SelectedIndex < 0 || LstProgramList.SelectedIndex > LstProgramList.Items.Count)
                return;

            ProgramData obj = (ProgramData)LstProgramList.Items[LstProgramList.SelectedIndex];
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = Bitmap.FromHicon(obj.Icon.Handle);
            TxtNameInput.Text = obj.Name;
            TxtFileNameInput.Text = obj.FileName;
            TxtLocationInput.Text = obj.Location;
            TxtParametersInput.Text = !string.IsNullOrWhiteSpace(obj.Parameters) ? obj.Parameters : "None";
            TxtSize.Text = GetBytesReadable(obj.Size);
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

        private bool CheckForSelection(string message, string title)
        {
            if (LstProgramList.SelectedIndex < 0 || LstProgramList.SelectedIndex > LstProgramList.Items.Count)
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

            LstProgramList.Items.Clear();
            data = File.ReadAllLines(dataLocation)
                .Select(line => JsonConvert.DeserializeObject<ProgramData>(line)).ToList();

            foreach (ProgramData prog in data)
            {
                if (prog == null)
                    continue;

                prog.Icon = Icon.ExtractAssociatedIcon(prog.Location);
                LstProgramList.Items.Add(prog);
            }
        }

        private void ClearContents()
        {
            File.WriteAllText(dataLocation, "");
            LstProgramList.Items.Clear();
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
            LstProgramList.Items.Clear();
            foreach (ProgramData prog in data)
            {
                string jsonOutput = JsonConvert.SerializeObject(prog) + "\n";
                File.AppendAllText(dataLocation, jsonOutput);
                LstProgramList.Items.Add(prog);
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
