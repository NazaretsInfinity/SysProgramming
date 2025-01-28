using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HW_ApiWinForms
{


    public partial class ChangeStyle : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, bool lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr parent, IntPtr kid, string lpClass, string Name);

        private const int WM_SETFONT = 0x0030;
        public IntPtr Hfont;

        public ChangeStyle()
        {
            InitializeComponent();
            LoadFonts();
        }

        private void LoadFonts()
        {
            string[] fonts = Directory.EnumerateFiles(@"C:\Windows\Fonts").ToArray();
            foreach (string font in fonts)
                FontBox.Items.Add(font.Split('\\').Last());
        }

        private void ChangeStyle_FormClosed(object sender, FormClosedEventArgs e)
        {
            string FilePath = $"C:\\Windows\\Fonts\\{FontBox.SelectedItem.ToString()}";
            if (FontBox.SelectedIndex != -1)
            {
                PrivateFontCollection fontscol = new PrivateFontCollection();
                fontscol.AddFontFile(FilePath);
                Hfont = new Font(fontscol.Families[0], 15).ToHfont();
                SendMessage( IntPtr.Zero ,WM_SETFONT, Hfont, true);
                
            }
        }
    }
}
