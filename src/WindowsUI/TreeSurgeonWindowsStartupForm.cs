using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TreeSurgeon.Core;

namespace TreeSurgeon.WindowsUI
{
    public partial class TreeSurgeonWindowsStartupForm : Form
    {
        public TreeSurgeonWindowsStartupForm()
        {
            InitializeComponent();
            SetButtonEnabledState();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.codeplex.com/treesurgeon");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetButtonEnabledState();
        }

        private void SetButtonEnabledState()
        {
            if (projectNameTextBox.Text.Length > 0)
            {
                generateButton.Enabled = true;
            }
            else
            {
                generateButton.Enabled = false;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            messagesTextBox.Text = String.Format("\r\nStarting Tree Generation for {0}", projectNameTextBox.Text);
            Application.DoEvents();

            var version = getVersion();

            try
            {
                var outputPath =
                    new TreeSurgeonFrontEnd(
                        Path.GetDirectoryName(
                            Assembly.GetExecutingAssembly().Location), version).
                        GenerateDevelopmentTree(projectNameTextBox.Text, getUnitTestName());
                messagesTextBox.Text +=
                    string.Format("\r\nTree Generation complete.\r\nFiles can be found at\r\n{0}", outputPath);
            }
            catch (Exception exc)
            {
                messagesTextBox.Text +=
                    string.Format("\r\nUnhandled Exception thrown. Details follow:\r\n{0}\r\n{1}", exc.Message,
                                  exc.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private string getUnitTestName()
        {
            var unitTestName = nunitRadionButton.Text;
            if (mbunitRadioButton.Checked)
                unitTestName = mbunitRadioButton.Text;
            return unitTestName;
        }

        private string getVersion()
        {
            var version = version2003RadioButton.Text;
            if (version2005RadioButton.Checked)
                version = version2005RadioButton.Text;
            else if (version2008RadioButton.Checked)
                version = version2008RadioButton.Text;
            return version;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}