using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ApiWinForms
{
    public partial class RenamingForm : Form
    {
        public RenamingForm()
        {
            InitializeComponent();
        }

        private void RenamingUpdateButton_Click(object sender, EventArgs e)
        {
            MainForm.caption = RenameTextBox.Text;
            this.Close();
        }
    }
}
