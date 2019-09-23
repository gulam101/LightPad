using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class controlsMenu : Form
    {
        public controlsMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var MainNotepadFrm = new MainNotepadFrm();
            this.Close();
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MainNotepadFrm = MessageBox.Show(                     //declares the variable
                "Are you sure you want to create a new document?", //Displays the text
                "Are you sure", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning); //Adds information such as the yes/no button and the warning icon with two arguments

            if (MainNotepadFrm == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }
    }
}
