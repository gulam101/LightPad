using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightPad;

namespace WindowsFormsApp15
{
    public partial class FileMenu : Form
    {
        public FileMenu()
        {
            InitializeComponent();
        } 

        private void button7_Click(object sender, EventArgs e)
        {
            var AreYouSure = MessageBox.Show("Are you you want to exit off the application? Any unsaved data will be lost!", 
                "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            {
                if(AreYouSure == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if(AreYouSure == DialogResult.No)
                {
                    MessageBox.Show("The application will not exit!");
                }
                else if (AreYouSure == DialogResult.Cancel)
                {
                    MessageBox.Show("The application will not exit!");
                }
                   
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Stops the application from exiting
            Close(); 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //declares the variable
            var newDocument = MessageBox.Show(                          
                "Are you sure you want to create a new document?",
                "Are you sure", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            //Adds information such as the yes/no button and the warning icon with two arguments

            if (newDocument == DialogResult.Yes)
            {
              //Clears the document
            }
        }
    }
}
