using HttpHelperApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpHelperApp
{
    public partial class MainForm : Form
    {
        private int wId = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("Kernel32.dll")]
        private static extern bool AllocConsole(); //启动窗口  
        [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
        private static extern bool FreeConsole();      //释放窗口，即关闭  
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        extern static IntPtr FindWindow(string lpClassName, string lpWindowName);//找出运行的窗口  

        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert); //取出窗口运行的菜单  

        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        extern static IntPtr RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags); //灰掉按钮 d);

        [DllImport("kernel32.dll")]
        public static extern bool SetConsoleTitle(string strMessage);


        private void btnGo_Click(object sender, EventArgs e)
        {
            var cof = new HttpConfig
            {
                Url = tbUrl.Text,
                SendData = rtbData.Text,
                Timeout = ((int)nupTimeout.Value) * 1000,
                Method = cbMethod.SelectedItem.ToString(),
                ContentType = tbContentType.Text,
                Referer = tbReferer.Text,
                UserAgent = tbUserAgent.Text
            };
            if (string.IsNullOrEmpty(cof.Url))
            {
                MessageBox.Show("Need url");
                tbUrl.Focus();
                return;
            }
            var hep = new HttpHelper(cof, $"{wId++}");
            if (cbShowResult.Checked)
            {
                hep.HandelRes+= a =>
                {
                    rtbRes.BeginInvoke(new Action(() =>
                    {
                        rtbRes.Text = a;
                    }));
                };
                AllocConsole();
                IntPtr windowHandle = FindWindow(null, Process.GetCurrentProcess().MainModule.FileName);
                IntPtr closeMenu = GetSystemMenu(windowHandle, IntPtr.Zero);
                uint SC_CLOSE = 0xF060;
                RemoveMenu(closeMenu, SC_CLOSE, 0x0);
                SetConsoleTitle("Log");
            }
            else
            {
                hep.HandelRes = a => { };
            }
            hep.DoWork((int)nudThreadCount.Value, (int)nudSingleCount.Value);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();
            tbUrl.Text = set.Url;
            rtbData.Text = set.Data;
            nupTimeout.Value = set.TimeOut;
            cbMethod.SelectedIndex = set.Method < 0 ? 0 : set.Method;
            nudThreadCount.Value = set.ThreadCount;
            nudSingleCount.Value = set.SingleCount;
            tbContentType.Text = set.ContentType;
            tbUserAgent.Text = set.UserAgent;
            tbUserAgent.Text = set.Referer;
            cbShowResult.Checked = set.ShowResult;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings set = new Settings();
            set.Url = tbUrl.Text;
            set.Data = rtbData.Text;
            set.TimeOut = nupTimeout.Value;
            set.Method = cbMethod.SelectedIndex;
            set.ThreadCount = nudThreadCount.Value;
            set.SingleCount = nudSingleCount.Value;
            set.ContentType = tbContentType.Text;
            set.UserAgent = tbUserAgent.Text;
            set.Referer = tbUserAgent.Text;
            set.ShowResult = cbShowResult.Checked;
            set.Save();
        }
    }
}
