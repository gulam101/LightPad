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


namespace LightPad
{
    public partial class MainNotepadFrm : Form
    {
        //Declare var
        int start;

        public bool WordWrap { get; set; }
        public RichTextBox richtext { get; private set; }

        //public static bool Cancel { get; private set; }

        //end

        public class DoubleClickButton : Button
        {
            public DoubleClickButton()
            {
                SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            }
        }

        public MainNotepadFrm()
        {
            InitializeComponent();
            //FontToolButton_Click.DoubleClick += new EventHandler(FontToolButton_Click);
        }

        #region Exit-Application
        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            //Exits application using the button in the menu
            Application.Exit();
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
                TextBox.Clear();
            }
        }
        #endregion

        #region Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo's the text in the box
            TextBox.Undo();
            //The option is disabled by default 
            undoToolStripMenuItem.Enabled = false; 
            //But when a user wants to undo then this option is enabled
            redoToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Redo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Redo();
            //The option is disabled by default 
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true; 
            //But when a user wants to redo this then option is enabled
        }
        #endregion

        #region Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }
        #endregion

        #region Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }
        #endregion

        #region Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }
        #endregion

        #region Open-File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //Creates a var and assigns it a value 
            if (op.ShowDialog() == DialogResult.OK)
                TextBox.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                Text = op.FileName;
        }
        #endregion

        #region RichText-Box
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //If the text is greater than zero
            if (TextBox.Text.Length > 0) 
            {
                //Then undo is enabled
                undoToolStripMenuItem.Enabled = true; 
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
            }
            else
            {
                // else if the text isn't greater than zero thzn undo is false
                undoToolStripMenuItem.Enabled = false; 
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
            }
            #endregion

        #region Context-Menu
            //Declares the variable
            ContextMenu cm = new ContextMenu();
            //Lists the first item using the variable
            cm.MenuItems.Add("Cut", new EventHandler(cutToolStripMenuItem_Click));
            //Lists the second item using the variable
            cm.MenuItems.Add("Copy", new EventHandler(copyToolStripMenuItem_Click));
            //Lists the third item using the variable
            cm.MenuItems.Add("Paste", new EventHandler(pasteToolStripMenuItem_Click));
            //Lists the fourth item using the variable
            cm.MenuItems.Add("Word Count", new EventHandler(wordCountToolStripMenuItem_Click));
            //Lists the fifth item using the variable
            cm.MenuItems.Add("Undo", new EventHandler(undoToolStripMenuItem_Click));
            //Lists the sixith item using the variable
            cm.MenuItems.Add("Redo", new EventHandler(redoToolStripMenuItem_Click));
            //Lists the seventh item using the variable
            cm.MenuItems.Add("Print", new EventHandler(printToolStripMenuItem_Click));
            //Refers back to the object
            TextBox.ContextMenu = cm; 
        }

        #endregion

        #region Select-All

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }
        #endregion

        #region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                TextBox.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
        }
        #endregion

        #region Font-Bold
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Bold);
        }
        #endregion

        #region Font-Italic
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Italic);
        }
        #endregion

        #region Font-Regular
        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Regular);
        }
        #endregion

        #region Font-Colour
        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            {
                cd.ShowDialog();
                TextBox.SelectionColor = cd.Color;
            }
        }
        #endregion

        #region Font-Underlined
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Underline);
        }
        #endregion

        #region Font-Strike
        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Strikeout);
        }
        #endregion

        #region SaveAs
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
                if (sv.ShowDialog() == DialogResult.OK)
                   TextBox.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                   Text = sv.FileName;
        }
        #endregion

        #region Font-Bold
        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Bold);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Font-Italic
        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Italic);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Normal-Font
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Regular);
            //Used as a test
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Strike
        private void strikeThroughToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Strikeout);
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Cut
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
            MessageBox.Show("Test", "Test");
        }
        #endregion

        #region Open Document
        private void openDocumentRichTextBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewFolder = new OpenFileDialog();
                NewFolder.Title = "Open";
                NewFolder.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.* ";
            if (NewFolder.ShowDialog() == DialogResult.OK)
                TextBox.LoadFile(NewFolder.FileName, RichTextBoxStreamType.PlainText);
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
                Application.Restart();
            }
        }
        #endregion

        #region SaveAs
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                TextBox.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            Text = sv.FileName;
        }
        #endregion

        #region Date-And-Time
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AreYouSure = MessageBox.Show("Are you sure you want to insert this item?",
                "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (AreYouSure == DialogResult.Yes)
            {
                string value = TextBox.Text;
                TextBox.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" +
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

        #region Font-Size
        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TextBox.Font = fd.Font;
            }
        }
        #endregion

        #region Word Count
        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string WordCount = TextBox.Text;
            //Inlcudes spaces within the text
            char[] seperator = new char[] { ' ', '\n', '\r' };
            int WordsCounted = WordCount.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Length;
            //Converts the int into string
            WordsLbl.Text = WordsCounted.ToString();
            //Changes the colour to black 
            WordsLbl.ForeColor = Color.Black;   
        }
        #endregion

        #region GitHub

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GitHub = MessageBox.Show("Make sure you check out my GitHub Projects",
                "GitHub", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if(GitHub == DialogResult.OK)
                {
                    //Links it to the web page
                    Process.Start("https://github.com/gulam101");
                }
            }

        }

        #endregion

        #region Find-Next
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Return value is set to false
            int returnValue = 0; 

            //specifices the string location
            if (Text.Length > 0 && StartPosition >= 0)
            {
                //Obtains the location of the string in the textbox
                int indexToText = TextBox.Find(Text, start, RichTextBoxFinds.MatchCase);

                if(indexToText >= 0) 
                {
                    //Changes the colour to black
                    returnValue = indexToText; 
                }
            }
        }
        #endregion

        #region Word-Count
        private void wordCountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string WordCount = TextBox.Text;
            char[] seperator = {' '};
            int WordsCounted = WordCount.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Length;
            WordsLbl.Text = WordsCounted.ToString();
            {
                //Changes the colour to black
                WordsLbl.ForeColor = Color.Black;             
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
                TextBox.Font = fd.Font;
            }
        }
        #endregion

        #region Search-Cmd
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            {
                cd.ShowDialog();
                TextBox.SelectionColor = cd.Color;
            }
        }
        #endregion

        #region Printer Menu Icon
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            PrintDialog Printer = new PrintDialog();
            {
                Printer.ShowDialog();
            }
        }
        #endregion

        #region BoldMenuTab
        private void menuBoldFont_Click(object sender, EventArgs e)
        {
            bool boldText = false;

             void OnClick(EventArgs args)  
            {
                //boldText = !boldText;

                if (boldText == true)
                {
                    //Changes the font to bold
                    TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Bold);
                } else if (boldText == false)
                {
                    //Reverts back to the orginal font
                    TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Regular);

                }
            };
        }
        #endregion

        #region Font-Italic
        private void FontToolButton_Click(object sender, EventArgs e)
        {
            //TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Italic);

           
        }
        #endregion

        #region Font-Regular
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Regular);
        }
        #endregion

        #region Font-Strikeout
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Strikeout);
        }
        #endregion

        #region Font-underline
        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            TextBox.SelectionFont = new Font(TextBox.Font, FontStyle.Underline);
        }
        #endregion

        #region Undo-Button-On-Menubar
        private void toolMenuUndo(object sender, EventArgs e)
        {
            //Undo's the text in the box
            TextBox.Undo();
            //The option is disabled by default
            redoToolStripMenuItem.Enabled = false;
            //But when a user wants to undo then this option is enabled
            undoToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Redo-Button-On-Menubar
        private void toolMenuRedo(object sender, EventArgs e)
        {
            TextBox.Redo();
            //The option is disabled by default 
            undoToolStripMenuItem.Enabled = false;
            //But when a user wants to redo this then option is enabled
            redoToolStripMenuItem.Enabled = true; 
        }
        #endregion

        #region QuickSaveButton
        private void ToolSaveButton_Click(object sender, EventArgs e)
        {
            //Using as placeholder
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "New LightPad Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
                TextBox.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            Text = sv.FileName;
        }
        #endregion

        #region ExitApplication
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure you want to exit the application? Any unsaved work will be lost!";
            const string caption = "Exit application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            } 
        }
        #endregion

        #region Dark mode
        private void DarkModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool CheckDarkMode = true;
            bool CheckWhiteMode = true;

            if (CheckDarkMode == true)
            {
                //Creates a darkmode
                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.White;
            }
            else if (CheckWhiteMode == true)
            {
                //If clicked again then reverts back to the original
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Light Mode
        private void NormalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes back to original settings
            TextBox.BackColor = Color.White;
            TextBox.ForeColor = Color.DarkSlateGray;
        }
        #endregion

        #region LinkedIn
        private void LinkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //Links to my LinkedIn page
           Process.Start("https://www.linkedin.com/in/gulam-qasim-8a8b0816b/");
        }

        #endregion

        #region GitHub
        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Loads the default browser links to my GitHub Page
           Process.Start("https://github.com/gulam101");
        }
        #endregion
    }
}