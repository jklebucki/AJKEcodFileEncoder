using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJKEcodFileEncoder
{
    public partial class AppInfoForm : Form
    {
        public AppInfoForm()
        {
            InitializeComponent();
        }

        private void AppInfoForm_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tAJK File Encoder");
            sb.AppendLine("\tVersion: 1.0.0");
            sb.AppendLine("\tDeveloped by: AJK Software");
            sb.AppendLine("\tContact: j.klebucki@ajksoftware.pl");
            sb.AppendLine("\tDescription: This application encodes files and manages the AJK File Transfer Service.");
            sb.AppendLine("\tLog and config files are stored in the ProgramData directory.");

            richTextBoxAppInfo.Text = sb.ToString();
            richTextBoxAppInfo.ReadOnly = true;
            richTextBoxAppInfo.Dock = DockStyle.Fill;

            // Apply modern styling to the RichTextBox
            richTextBoxAppInfo.BackColor = Color.White;
            richTextBoxAppInfo.ForeColor = Color.Black;
            richTextBoxAppInfo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBoxAppInfo.BorderStyle = BorderStyle.None;
            richTextBoxAppInfo.Margin = new Padding(10);

            // Make the email address clickable
            richTextBoxAppInfo.LinkClicked += (s, args) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = args.LinkText,
                    UseShellExecute = true
                });
            };

            // Add the link to the RichTextBox
            richTextBoxAppInfo.Text = richTextBoxAppInfo.Text.Replace("j.klebucki@ajksoftware.pl", "mailto:j.klebucki@ajksoftware.pl");
            richTextBoxAppInfo.DetectUrls = true;
        }
    }
}
