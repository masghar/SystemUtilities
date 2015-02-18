using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkUtil
{
    public partial class frmMain : Form
    {
        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdapters_Click(object sender, EventArgs e)
        {
           
            proc.FileName = @"C:\Windows\System32\rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL ncpa.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
           
            proc.FileName = @"C:\Windows\System32\control.exe";
            proc.Arguments = "inetcpl.cpl,,4";
            System.Diagnostics.Process.Start(proc);
            SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/deryaikhan");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.FileName = @"C:\Windows\System32\control.exe";         
            System.Diagnostics.Process.Start(proc2);
        }
        private void button2_Click(object sender, EventArgs e)     {
            proc.FileName = @"C:\Windows\System32\rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL firewall.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            proc.FileName = @"C:\Windows\System32\control.exe";
            proc.Arguments = "system";
            System.Diagnostics.Process.Start(proc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proc.FileName = @"C:\Windows\System32\rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL hdwwiz.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.FileName = @"C:\Windows\System32\notepad.exe";
            System.Diagnostics.Process.Start(proc2);
        }

        private void word_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "WINWORD.EXE";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch(Exception ex){
                MessageBox.Show("MS Word Application Has not been Installed","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }

        private void excel_Click(object sender, EventArgs e)
        {
            try{
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "excel.exe";
            // startInfo.Arguments = file;
            Process.Start(startInfo);
        }
             catch(Exception ex){
                MessageBox.Show("MS Excel Application Has not been Installed","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void outlook_Click(object sender, EventArgs e)
        {try{
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "outlook.exe";
            // startInfo.Arguments = file;
            Process.Start(startInfo);
            }
             catch(Exception ex){
                MessageBox.Show("MS Outlook Application Has not been Installed","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/deryaikhan");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ding Dong.......:)...");
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            proc.FileName = @"C:\Windows\System32\rundll32.exe";
            proc.Arguments = "url.dll,FileProtocolHandler wuapp.exe";
            System.Diagnostics.Process.Start(proc);
        }
    }
}
