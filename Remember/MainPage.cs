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
        List<ProgramData> data;
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
            if (string.IsNullOrWhiteSpace(TxtFileInput.Text) || !File.Exists(TxtFileInput.Text))
            {
                MessageBox.Show("Please enter a valid program path!", "Program Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fInfo = new FileInfo(TxtFileInput.Text);
            Icon icon = Icon.ExtractAssociatedIcon(fInfo.FullName);
            string parameters = Interaction.InputBox("Would you like to add any additional parameters? (Click X or Cancel to skip)", "Add parameters");
            parameters = !string.IsNullOrWhiteSpace(parameters) ? parameters : "None";
            string name = Interaction.InputBox("What would you like to name this program shotcut? (Click X or Cancel to skip)", "Add name");
            name = string.IsNullOrWhiteSpace(parameters) ? fInfo.Name : name;
            MessageBox.Show(name);
            ProgramData prog = new ProgramData(name, fInfo.Name, fInfo.FullName, parameters, fInfo.Length, icon);
            LstProgramList.Items.Add(prog);
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CallLoadFile();
        }

        private void BtnLaunchProgram_Click(object sender, EventArgs e)
        {
            if (LstProgramList.SelectedIndex < 0 || LstProgramList.SelectedIndex > LstProgramList.Items.Count)
            {
                MessageBox.Show("Please select a program from the list to launch!", "Select A Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void LstProgramList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstProgramList.SelectedIndex < 0 || LstProgramList.SelectedIndex > LstProgramList.Items.Count)
                return;

            ProgramData obj = (ProgramData)LstProgramList.Items[LstProgramList.SelectedIndex];
            if (PBoxIcon.Image != null)
                PBoxIcon.Image.Dispose();
            PBoxIcon.Image = Bitmap.FromHicon(obj.Icon.Handle);
            LblName.Text = "Name: " + obj.Name;
            LblFileName.Text = "File Name: " + obj.FileName;
            LblLocation.Text = "Location: " + obj.Location;
            LblParameters.Text = "Parameters: " + (!string.IsNullOrWhiteSpace(obj.Parameters) ? obj.Parameters : "None");
            LblSize.Text = "Size: " + GetBytesReadable(obj.Size);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            CallLoadFile();
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
                prog.Icon = Icon.ExtractAssociatedIcon(prog.Location);
                LstProgramList.Items.Add(prog);
            }
        }

        /**
         * Credit to user from StackOverflow: https://stackoverflow.com/users/553396/humbads
         * Post from site: https://www.somacon.com/p576.php
         */
        private string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = " EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = " PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = " TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = " GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = " MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
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
