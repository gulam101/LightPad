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
using LightPad;
using System.Diagnostics;
using WindowsFormsApp15;

//namespace WindowsFormsApp15
namespace LightPad
{
    public partial class MainNotepadFrm : Form
    {
        //Declare var
        int start;
        public bool WordWrap { get; set; }
        //end

        public MainNotepadFrm()
        {
            InitializeComponent();
        }

        #region Exit-Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Closes the application
        }
        #endregion

        #region Author
        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Gulam Qasim", "Author"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information); 
            /*
             * This text box shows a message box
             */
        }
        #endregion

        #region New-Document
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declares the variable
            var newDocument = MessageBox.Show(
                //Displays the text
                "Are you sure you want to create a new document?", 
                "Are you sure", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            //Adds information such as the yes/no button and the warning icon with two arguments

            if (newDocument == DialogResult.Yes)
            {
                SearchCmd.Clear();
            }
        }
        #endregion

        #region Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Undo(); //Undo's the text in the box
            undoToolStripMenuItem.Enabled = false; //The option is disabled by default 
            //But when a user wants to undo then this option is enabled
            redoToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Redo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true; //The option is disabled by default 
            //But when a user wants to redo this then option is enabled
        }
        #endregion

        #region Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Cut();
        }
        #endregion

        #region Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Copy();
        }
        #endregion

        #region Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.Paste();
        }
        #endregion

        #region Open-File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //Creates a var and assigns it a value 
            if (op.ShowDialog() == DialogResult.OK)
                SearchCmd.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }
        #endregion

        #region RichText-Box
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
            #endregion

        #region Context-Menu

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

        #region Control-Menu
        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declares the variable
            var controlsMenu = new controlsMenu(); 
            //Activates the new form
            controlsMenu.Show(); 
        }
        #endregion

        #region Select-All

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

        #region Font-Bold
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
        }
        #endregion

        #region Font-Italic
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
        }
        #endregion

        #region Font-Regular
        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
        }
        #endregion

        #region Font-Colour
        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            {
                cd.ShowDialog();
                SearchCmd.SelectionColor = cd.Color;
            }
        }
        #endregion

        #region Font-Underlined
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Underline);
        }
        #endregion

        #region Font-Strike
        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
        }
        #endregion

        #region SaveAs
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentSaved = "Document saved successfully!";
            string documentNotSaved = "Document has not saved!";

            //Casts into BOOl
            bool save = bool.Parse(documentSaved);
            bool notSaved = bool.Parse(documentNotSaved);

            if(save == true)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
                    if (sv.ShowDialog() == DialogResult.OK)
                        SearchCmd.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                        Text = sv.FileName;
                //WordsLbl.Text = documentNotSaved;
                MessageBox.Show("Test", "Test");

            } else if (notSaved == true)
            {
                //WordsLbl.Text = documentNotSaved;
                MessageBox.Show("Test", "Test");
            }
        }
        #endregion

        #region Font-Bold
        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Font-Italic
        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Normal-Font
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Strike
        private void strikeThroughToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Cut
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SearchCmd.Cut();
            MessageBox.Show("Test", "Test");
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

        #region New-Document
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

        #region Insert-New-Document

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

        #region Date-And-Time
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

                //Unfished/Test
                WordsLbl.Text = "Document has been untouched!";
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

        #region Font-Size
        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                SearchCmd.Font = fd.Font;
            }
        }
        #endregion

        #region Test-Menu
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

        #region Word-Count
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
                    Process.Start("https://github.com/gulam101");
                }
            }

        }

        #endregion

        #region Find-Next
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

        #region Word-Count
        private void wordCountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string WordCount = SearchCmd.Text;
            char[] seperator = {' '};
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

        #region Font-Dialog
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                SearchCmd.Font = fd.Font;
            }
        }
        #endregion

        #region Search-Cmd
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
                    Process.Start("https://github.com/gulam101");
                }
            }
        }
        #endregion

        #region LinkedIn
        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LinkedIn = MessageBox.Show("Make sure you check out my LinkedIn and follow me",
               "LinkedIn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (LinkedIn == DialogResult.OK)
                {
                    Process.Start("https://www.linkedin.com/in/gulam-qasim-8a8b0816b/");
                }
            }
        }
        #endregion

        #region Printer-Icon
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            PrintDialog Printer = new PrintDialog();
            {
                Printer.ShowDialog();
            }
        }
        #endregion

        #region Search-Cmd
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Bold);
        }
        #endregion

        #region Font-Italic
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Italic);
        }
        #endregion

        #region Font-Regular
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Regular);
        }
        #endregion

        #region Font-Strikeout
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Strikeout);
        }
        #endregion

        #region Font-underline
        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            SearchCmd.SelectionFont = new Font(SearchCmd.Font, FontStyle.Underline);
        }
        #endregion

        #region Search-Cmd-Undo
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

        #region Search-Cmd-Redo
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