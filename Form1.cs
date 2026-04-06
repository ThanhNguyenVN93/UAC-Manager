using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmmoduac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //display current time
            timer1.Interval = 1000; // Update every second
            timer1.Tick += timer1_Tick;
            timer1.Start();

            //detect OS
            string osInfo = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null && information.Count > 0)
                {
                    foreach (ManagementObject obj in information)
                    {
                        osInfo = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                        break; // Only need first OS info
                    }
                }
                else
                {
                    osInfo = "Unable to detect OS";
                }
            }

            osInfo = osInfo.Replace("NT 5.1.2600", "XP");
            osInfo = osInfo.Replace("NT 5.2.3790", "Server 2003");
            lblos.Text = osInfo;

            //check User Account Control is ON or OFF
            CheckUACDirect();
        }
            
            private void CheckUACDirect()
            {
                string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("EnableLUA");
                        if (value != null && value.ToString() == "1")
                        {
                            lblstatus.Text = "UAC: ON";
                            lblstatus.ForeColor = System.Drawing.Color.Green;
                            btnoff.Enabled = true;
                            btnon.Enabled = false;
                        }
                        else
                        {
                            lblstatus.Text = "UAC: OFF";
                            lblstatus.ForeColor = System.Drawing.Color.Red;
                            btnon.Enabled = true;
                            btnoff.Enabled = false;
                        }
                    }
                }
            }
        private void DisableUACCompletely()
        {
            try
            {
                string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
                        key.SetValue("ConsentPromptBehaviorAdmin", 0, RegistryValueKind.DWord);
                    }
                }

                lblstatus.Text = "UAC Status: FULLY DISABLED\n(Need to Restart)";
                lblstatus.ForeColor = Color.Red;
                MessageBox.Show("UAC and notifications have been disabled. Please restart to complete!", "Success");
                RestartComputer();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void SetUAC(bool enable)
        {
            try
            {
                string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue("EnableLUA", enable ? 1 : 0, RegistryValueKind.DWord);
                        key.SetValue("ConsentPromptBehaviorAdmin", enable ? 5 : 0, RegistryValueKind.DWord);
                    }
                }

                lblstatus.Text = "New Status: " + (enable ? "ON" : "OFF")
                  + Environment.NewLine
                  + "(Please restart your computer)";
                lblstatus.ForeColor = enable ? Color.Green : Color.Red;
                MessageBox.Show("UAC and notifications have been enabled. Please restart to complete!", "Success");
                RestartComputer();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Please run this tool with Administrator privileges!\n" + ex.Message);
            }
        }
        private void RestartComputer()
        {
            try
            {
                Process.Start(new ProcessStartInfo("shutdown.exe", "/r /t 5 /f")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                });

                lblstatus.Text = "System is restarting in 5 seconds...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to restart system.\n" + ex.Message, "Restart Failed");
            }
        }
        private void btnon_Click(object sender, EventArgs e)
        {
            SetUAC(true);
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            DisableUACCompletely();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy ngày tháng năm chuẩn dd/MM/yyyy
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

            // Lấy giờ phút giây chuẩn HH:mm:ss (H viết hoa để dùng hệ 24h)
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            // Hiển thị lên thanh tiêu đề của Form
            this.Text = $"UAC Manager | {currentDate} | {currentTime}";
        }
    }
}
