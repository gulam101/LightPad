using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp15
{
    public partial class SaveFunc : Form
    {
        public SaveFunc()
        {
            InitializeComponent();
        }

        private void openFileCmd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                
                //SaveFunc.Text = File.ReadAllText(label1.Text);
            }
        }
    }
}
