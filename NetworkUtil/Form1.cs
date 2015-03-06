using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ScreenShot;
using System.Drawing.Imaging;


namespace NetworkUtil
{
    public partial class frmMain : Form
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("user32")]
        public static extern void LockWorkStation();
        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
        string systemDir = Environment.SystemDirectory;
       
        public frmMain()
        {
           InitializeComponent();
           Helper.ControlMover.Init(this.btnAdapters);
           Helper.ControlMover.Init(this.btnProxy);
           //var c = GetAll(this, typeof(Button));
          // int totalControls = c.Count();
          // MessageBox.Show("Total Controls: " + totalControls);
           
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void btnAdapters_Click(object sender, EventArgs e)
        {

            proc.FileName = systemDir+"/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL ncpa.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
           
            proc.FileName = systemDir+"/control.exe";
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
            proc2.FileName = systemDir + "/control.exe";       
            System.Diagnostics.Process.Start(proc2);
        }
        private void button2_Click(object sender, EventArgs e)     {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL firewall.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnAdapters.Location = Properties.Settings.Default.loc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/control.exe";
            proc.Arguments = "system";
            System.Diagnostics.Process.Start(proc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "shell32.dll,Control_RunDLL hdwwiz.cpl";
            System.Diagnostics.Process.Start(proc);
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc2 = new System.Diagnostics.ProcessStartInfo();
            proc2.FileName = systemDir + "/notepad.exe";
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
        {
            try{
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
            MessageBox.Show("Ding Dong.......:)...m.muhammad.asghar@gmail.com");
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            proc.FileName = systemDir + "/rundll32.exe";
            proc.Arguments = "url.dll,FileProtocolHandler wuapp.exe";
            System.Diagnostics.Process.Start(proc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "taskmgr.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "services.msc";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "msinfo32";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             proc.FileName = systemDir + "/SndVol.exe";
            proc.Arguments = "-f 49825268";
            System.Diagnostics.Process.Start(proc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "explorer.exe";
                // startInfo.Arguments = file;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS Outlook Application Has not been Installed", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sure?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(r==DialogResult.Yes){
            Process.Start("shutdown", "/s /t 0");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("Sure?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

             if (r == DialogResult.Yes)
             {
                 Process.Start("shutdown",
     "/r /t 0");
             }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("Sure?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

             if (r == DialogResult.Yes)
             {
                 ExitWindowsEx(0, 0);
             }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        { DialogResult r = MessageBox.Show("Sure?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

        if (r == DialogResult.Yes)
        {
            LockWorkStation();
        }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.loc = btnAdapters.Location;
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MessageBox.Show("m.muhammad.asghar@gmail.com");
            Process.Start("mailto:m.muhammad.asghar@gmail.com");
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            ScreenShot.ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // display image in a Picture control named imageDisplay
           // this.imageDisplay.Image = img;
            // capture this window, and save it
            string name = DateTime.Now.ToString();
            name = name.Replace(':','-');
            sc.CaptureScreenToFile(@"D:\" + name + ".png", ImageFormat.Png);
        }

    }
}
