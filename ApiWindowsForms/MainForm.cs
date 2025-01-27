using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ApiWindowsForms
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBoxW(IntPtr hwnd, string text, string caption, uint type);


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string WindowName);

        static uint WM_CLOSE = 0x0010; 
        static uint WM_SETTEXT = 0x000C; 


        public MainForm()
        {
            InitializeComponent();
            MessageBoxW(IntPtr.Zero, "Hello world!", "caption", 1); //1 task
        }


        private void GuessButton_Click(object sender, EventArgs e) //2 task
        {
            int min = 0;
            int max = 100;
            bool isGuessed = false;

            while (!isGuessed)
            {
                int guess = (min + max) / 2;
                // Запрос пользователя
                int result = MessageBoxW(IntPtr.Zero, $"Ваше число {guess}?", "Угадай число", 3); // 3 = Yes/No/Cancel

                if (result == 6) // Yes
                {
                    MessageBoxW(IntPtr.Zero, "Ура! Я угадал!", "Победа", 0);
                    isGuessed = true;
                }
                else if (result == 7) // No
                {
                    result = MessageBoxW(IntPtr.Zero, "Это число больше?", "Уточнение", 3); // 3 = Yes/No/Cancel
                    if (result == 6)
                    {
                        min = guess + 1;
                    }
                    else if (result == 7)
                    {
                        max = guess - 1;
                    }
                    else 
                    {
                        break;
                    }
                }
                else // Cancel
                {
                    break;
                }
            }

        }

        private void NotepadButton_Click(object sender, EventArgs e) //3 task
        {

            IntPtr hwnd = FindWindow("Notepad", null); //  null - any window of notepad

            if (hwnd != IntPtr.Zero)
            {
                SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                Console.WriteLine("Closed notebook");
            }
            else
            {
                MessageBox.Show("Notebook isn't active");
            }
        }



        private void UpdateButton_Click(object sender, EventArgs e) //4 task
        {
            IntPtr hwnd = FindWindow("Notepad", null); 
            if (hwnd != IntPtr.Zero)
            {
                new Thread(() =>
                {
                    while (true)
                    {
                        string currentTime = DateTime.Now.ToString("HH:mm:ss");
                     
                        IntPtr time = Marshal.StringToHGlobalUni(currentTime);
                        SendMessage(hwnd, WM_SETTEXT, IntPtr.Zero, time);
                        Marshal.FreeHGlobal(time);
                        Thread.Sleep(1000); // 1 second pause  ( cause parameters is counter as milliseconds)
                    }
                }).Start();
            }
            else
            {
                MessageBox.Show("Notebook isn't active");
            }

        }
    }// End of MainForm
}
