using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SimpleScoclScriptCompiler
{
    public partial class Main : Form
    {

        #region Constructor
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        private void compileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check is stuff is valid
                if (string.IsNullOrWhiteSpace(inputSourceFileTextBox.Text))
                {
                    MessageBox.Show("Please enter a path to the sco source file.", "Simple Scocl Script Compiler");
                    return;
                }
                if (string.IsNullOrWhiteSpace(outputDirTextBox.Text))
                {
                    MessageBox.Show("Please enter a path to the output directory where the sco will be compiled to.", "Simple Scocl Script Compiler");
                    return;
                }
                if (string.IsNullOrWhiteSpace(versionComboBox.Text))
                {
                    MessageBox.Show("Please select or enter a version.", "Simple Scocl Script Compiler");
                    return;
                }

                // Check if stuff exists
                if (!File.Exists("scocl.exe"))
                {
                    MessageBox.Show("Could not find the 'scocl.exe' file. Make sure it is within the current directory.", "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!File.Exists(inputSourceFileTextBox.Text))
                {
                    MessageBox.Show("The given input soruce file does not exists.", "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists(outputDirTextBox.Text))
                {
                    switch (MessageBox.Show("The given output directory does not exists. Do you want it to be created?", "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {
                        case DialogResult.Yes:

                            try
                            {
                                Directory.CreateDirectory(outputDirTextBox.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(string.Format("Failed to create directory! Details: {0}", ex), "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            break;
                        case DialogResult.No:
                            MessageBox.Show("Not compiling sco script.", "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }
                }

                // Clear output textbox
                richTextBox1.Clear();

                // Build options string
                string options = "";

                if (GlobalSegFlagCheckBox.Checked)
                    options = options + "GLOBALSEG ";
                if (KeepTempFlagCheckBox.Checked)
                    options = options + "KEEPTEMP ";
                if (DebugOutputFlagCheckBox.Checked)
                    options = options + "DEBUGOUTPUT ";

                // Start scocl.exe process
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "scocl.exe";
                p.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                p.StartInfo.Arguments = string.Format("{0} \"{1}\" \"{2}\" {3}", versionComboBox.Text, inputSourceFileTextBox.Text, outputDirTextBox.Text + "\\", options.TrimEnd());
                p.Start();

                // Read output
                richTextBox1.Text = p.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occured while trying to compile sco script! Details: {0}", ex), "Simple Scocl Script Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseSourceFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "c source files (*.c)|*.c|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputSourceFileTextBox.Text = ofd.FileName;
                }
            }
        }
        private void selectOutputDirButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    outputDirTextBox.Text = fbd.SelectedPath;
                }
            }
        }

    }
}
