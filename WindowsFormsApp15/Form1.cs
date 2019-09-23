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
    public partial class MainNotepadFrm : Form
    {
        //Declaring variables
        int start;
        public bool WordWrap { get; set; }
        //Close

        public MainNotepadFrm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }
        
        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Gulam Qasim", "Author"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information); /*
             * This text box shows a message box
             */
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newDocument = MessageBox.Show(                          //declares the variable
                "Are you sure you want to create a new document?", //Displays the text
                "Are you sure", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            //Adds information such as the yes/no button and the warning icon with two arguments

            if (newDocument == DialogResult.Yes)
            {
                SearchCmd.Clear();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Undo(); //Undo's the text in the box
            undoToolStripMenuItem.Enabled = false; //The option is disabled by default 
            //But when a user wants to undo then this option is enabled
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true; //The option is disabled by default 
            //But when a user wants to redo this then option is enabled
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //Creates a var and assigns it a value 
            if (op.ShowDialog() == DialogResult.OK)
                SearchCmd.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (SearchCmd.Text.Length > 0) //If the text is greater than zero
            {
                undoToolStripMenuItem.Enabled = true; //Then undo is enabled
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false; // else if the text isn't greater than zero thzn undo is false
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
            }

        #region ContextMenu

            ContextMenu cm = new ContextMenu(); //Declares the variable
            cm.MenuItems.Add("Cut", new EventHandler(cutToolStripMenuItem_Click)); //Lists the second item using the variable
            cm.MenuItems.Add("Copy", new EventHandler(copyToolStripMenuItem_Click)); //Lists the third item using the variable
            cm.MenuItems.Add("Paste", new EventHandler(pasteToolStripMenuItem_Click)); //Lists the fourth item using the variable
            cm.MenuItems.Add("Word Count", (wordCountToolStripMenuItem_Click));
            cm.MenuItems.Add("Undo", (undoToolStripMenuItem_Click));
            cm.MenuItems.Add("Redo", (redoToolStripMenuItem_Click));
            cm.MenuItems.Add("Print", (printToolStripMenuItem_Click));
            SearchCmd.ContextMenu = cm; //Refers back to the object
        }

        #endregion

        #region ControlMenu
        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declares the variable
            var controlsMenu = new controlsMenu(); 
            //Activates the new form
            controlsMenu.Show(); 
        }
        #endregion

        #region selectall

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectAll();
        }
        #endregion

        #region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                SearchCmd.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
        }
        #endregion

        #region Bold
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
        }
        #endregion

        #region Italic
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
        }
        #endregion

        #region Regular
        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
        }
        #endregion

        #region FontColour
        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            {
                cd.ShowDialog();
                SearchCmd.SelectionColor = cd.Color;
            }
        }
        #endregion

        #region underline
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Underline);
        }
        #endregion

        #region strike
        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
        }
        #endregion

        #region saveas
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                SearchCmd.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
        }
        #endregion

        #region Bold
        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
        }
        #endregion

        #region font Italic
        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
        }
        #endregion

        #region Normal Font
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
        }
        #endregion

        #region Strike
        private void strikeThroughToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
        }
        #endregion

        #region Cut
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SearchCmd.Cut();
        }
        #endregion

        #region NewFolder
        private void newFolderCmd_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewFolder = new OpenFileDialog();
            //Creates a var and assigns it a value 
                NewFolder.Title = "Open";
                NewFolder.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.* ";
            if (NewFolder.ShowDialog() == DialogResult.OK)
                SearchCmd.LoadFile(NewFolder.FileName, RichTextBoxStreamType.PlainText);
            #region Check
            //this.Text = NewFolder.FileName;
            {
                //Adds in alogrithm to check for empty documents
                //if (!string.IsNullOrEmpty(NewFolder.FileName))
                {
             //       SearchCmd.LoadFile(NewFolder.FileName);
                }
            }
            #endregion
        }
        #endregion

        #region NewDocument
        private void NewDoc_Click(object sender, EventArgs e)
        {
            var newDocument = MessageBox.Show(                     //declares the variable
               "Are you sure you want to create a new document?", //Displays the text
               "Are you sure", MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
            //Adds information such as the yes/no button and the warning icon with two arguments

            if (newDocument == DialogResult.Yes)
            {
                SearchCmd.Clear();
            }
        }
        #endregion

        #region SaveAs
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                SearchCmd.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
        }
        #endregion

        #region Unfinished

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry this feature is not yet avaliable, please try again later",
                "Please try again later!",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Warning);
        }

        #endregion

        #region InseertNewDocument

        private void insertNewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InsertNewDocument = MessageBox.Show("Sorry this feature is not yet avaliable, please try again later",
                   "Please try again later!",
                   MessageBoxButtons.AbortRetryIgnore,
                   MessageBoxIcon.Warning);

            if (InsertNewDocument == DialogResult.Retry)
            {
                MessageBox.Show("LightPad tried to retry again but failed",
                "Sorry it still doesn't work",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region DateAndTime
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AreYouSure = MessageBox.Show("Are you sure you want to insert this item?",
                "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (AreYouSure == DialogResult.Yes)
            {
                string value = SearchCmd.Text;
                SearchCmd.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" +
                DateTime.Now.Second.ToString() + "  " + DateTime.Now.Date.ToString() + value;
            }
            if (AreYouSure == DialogResult.No)
            {
                MessageBox.Show("Your document has been untouched",
                "Not changed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (AreYouSure == DialogResult.Cancel)
            {
                MessageBox.Show("You cancelled the operation",
                "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region Select

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select();
        }

        #endregion

        #region Error
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry about that, this feature is not avalible", "Sorry about that",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);    
        }
        #endregion

        #region fontsize
        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                SearchCmd.Font = fd.Font;
            }
        }
        #endregion

        #region TestMenu
        private void newMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewMenu = new FileMenu();
            NewMenu.Show();
        }
        #endregion

        #region Test
        private void ToolBar()
        {
            //ToolBar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
        }
        #endregion

        #region wordcount
        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string WordCount = SearchCmd.Text;
            char[] seperator = {' '};
                int WordsCounted = WordCount.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Length;
                WordsLbl.Text = WordsCounted.ToString();
                {
                    {
                        WordsLbl.ForeColor = Color.Black; //Changes the colour to black
                    }
                }
        }
        #endregion

        #region GitHub

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GitHub = MessageBox.Show("Make sure you check out my GitHub Projects (:",
                "GitHub", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if(GitHub == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://github.com/gulam101");
                }
            }

        }

        #endregion

        #region findnext
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int returnValue = 0; //Return value is set to false

            //specifices the string location
            if (Text.Length > 0 && StartPosition >= 0)
            {
                //Obtains the location of the string in the textbox
                int indexToText = SearchCmd.Find(Text, start, RichTextBoxFinds.MatchCase);

                if(indexToText >= 0) 
                {
                    returnValue = indexToText; //Changes the colour to black
                }
            }
        }
        #endregion

        #region wordCount
        private void wordCountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string WordCount = SearchCmd.Text;
            char[] seperator = { ' ' };
            int WordsCounted = WordCount.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Length;
            WordsLbl.Text = WordsCounted.ToString();
            {
                WordsLbl.ForeColor = Color.Black; //Changes the colour to black               
            }
        }
        #endregion

        #region Printer
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog Printer = new PrintDialog();
            {
                Printer.ShowDialog();
            }
        }
        #endregion

        #region fontDialog
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                SearchCmd.Font = fd.Font;
            }
        }
        #endregion

        #region searchCmd
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            {
                cd.ShowDialog();
                SearchCmd.SelectionColor = cd.Color;
            }
        }
        #endregion

        #region GitHub
        private void gitHubToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var GitHub = MessageBox.Show("Make sure you check out my GitHub Projects (:",
                "GitHub", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (GitHub == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://github.com/gulam101");
                }
            }
        }
        #endregion

        #region LinkedIn
        /*Under LinkedIn there is a mistake that gives the user 
       the wrong title
       fix by changing it*/
        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LinkedIn = MessageBox.Show("Make sure you check out my LinkedIn and follow me",
               "GitHub", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (LinkedIn == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://www.linkedin.com/in/gulam-qasim-8a8b0816b/");
                }
            }
        }
        #endregion

        #region PrinterIcon
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            PrintDialog Printer = new PrintDialog();
            {
                Printer.ShowDialog();
            }
        }
        #endregion

        #region SearchCmd
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
        }
        #endregion

        #region font
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
        }
        #endregion

        #region font
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
        }
        #endregion

        #region font
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
        }
        #endregion

        #region font
        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Underline);
        }
        #endregion

        #region SearchCmd Undo
        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            //Undo's the text in the box
            SearchCmd.Undo();
            //The option is disabled by default
            undoToolStripMenuItem.Enabled = false;  
            //But when a user wants to undo then this option is enabled
            redoToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region SearchCmd Redo
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SearchCmd.Redo();
            //The option is disabled by default 
            redoToolStripMenuItem.Enabled = false;
            //But when a user wants to redo this then option is enabled
            undoToolStripMenuItem.Enabled = true; 
        }
        #endregion
    }
}