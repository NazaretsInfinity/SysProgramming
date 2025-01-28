using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ApiWinForms
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);



        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Beep(uint freq, uint duration);


        [DllImport("user32.dll")]
        public static extern bool MessageBeep(ulong type);


        static uint WM_CLOSE = 0x0010; // look up in Windows Notifications docs
        static uint WM_SETTEXT = 0x000C; // and this one in  Windows Messages
        static uint WM_SETFONT = 0x0030;

        public static string caption; // 'for renaming

        public MainForm()
        {
            InitializeComponent();
            MessageBox(IntPtr.Zero, "Hi pookie", "caption", 1); // checked( for type of message box) 
            caption = this.Text;
        }

        private void CloseWindowButton_Click(object sender, EventArgs e) //2 
        {
            IntPtr hwnd = FindWindow(null, this.Text);
            if (hwnd != IntPtr.Zero)
            {
                SendMessage(hwnd, WM_CLOSE,IntPtr.Zero,IntPtr.Zero);
            }
        }

        private void UpdateCaptionButton_Click(object sender, EventArgs e) 
        {
            IntPtr hwnd = FindWindow(null, this.Text);
            if (hwnd != IntPtr.Zero)
            {
                RenamingForm form = new RenamingForm(); 
                form.ShowDialog();
                this.Text = caption;
            }
        }

        private void BeepButton_Click(object sender, EventArgs e) //3 
        {
            BeepButton.Enabled = false;
            for(int i = 0; i < 10; ++i) 
            {
                Beep(Convert.ToUInt32(new Random().Next(100,2000)), Convert.ToUInt32(new Random().Next(100,500)));
                MessageBeep(0); // idk, it's supposed to be right after beep but it doesn't sometimes, may use random too 
                Thread.Sleep(1000);

                #region likethis
                if (new Random().Next(0, 2) == 1)
                    Beep(Convert.ToUInt32(new Random().Next(100, 2000)), Convert.ToUInt32(new Random().Next(100, 500)));
                else
                    MessageBeep(0);
                Thread.Sleep(1000); 
                #endregion
            }
            BeepButton.Enabled=true;
        }

        private void ChangeStyleButton_Click(object sender, EventArgs e) //4 idk what styles, therefore font mb , it's a part of style , ye? 
        { 
           ChangeStyle changeStyle = new ChangeStyle();
           changeStyle.ShowDialog();
           BeepButton.Font = changeStyle.Font; // on sound button checked
        }
    }
}
