namespace LightPad
{
    partial class MainNotepadFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainNotepadFrm));
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeThroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenuLinks = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuBarOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.newDocument = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxPrint = new System.Windows.Forms.ToolStripButton();
            this.menuSaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.menuQuickSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBoxFontSize = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxColouredFont = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxCut = new System.Windows.Forms.ToolStripButton();
            this.boldFont = new System.Windows.Forms.ToolStripButton();
            this.italicFont = new System.Windows.Forms.ToolStripButton();
            this.normalFont = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxStrikeThrough = new System.Windows.Forms.ToolStripButton();
            this.RichTextBoxUnderlined = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBarUndo = new System.Windows.Forms.ToolStripButton();
            this.menuBarRedo = new System.Windows.Forms.ToolStripButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WordsLbl = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox.Location = new System.Drawing.Point(0, 49);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1200, 643);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionMenuFile,
            this.optionsMenuEdit,
            this.optionMenuFormat,
            this.optionsMenuAbout,
            this.optionMenuLinks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionMenuFile
            // 
            this.optionMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionMenuFile.Image = global::WindowsFormsApp15.Properties.Resources.Settings_icon;
            this.optionMenuFile.Name = "optionMenuFile";
            this.optionMenuFile.Size = new System.Drawing.Size(53, 20);
            this.optionMenuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newToolStripMenuItem.Text = "New Document";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::WindowsFormsApp15.Properties.Resources.Print_Icon;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // optionsMenuEdit
            // 
            this.optionsMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.optionsMenuEdit.Image = ((System.Drawing.Image)(resources.GetObject("optionsMenuEdit.Image")));
            this.optionsMenuEdit.Name = "optionsMenuEdit";
            this.optionsMenuEdit.Size = new System.Drawing.Size(55, 20);
            this.optionsMenuEdit.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // optionMenuFormat
            // 
            this.optionMenuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem,
            this.dateTimeToolStripMenuItem,
            this.wordCountToolStripMenuItem1,
            this.modeToolStripMenuItem});
            this.optionMenuFormat.Image = ((System.Drawing.Image)(resources.GetObject("optionMenuFormat.Image")));
            this.optionMenuFormat.Name = "optionMenuFormat";
            this.optionMenuFormat.Size = new System.Drawing.Size(73, 20);
            this.optionMenuFormat.Text = "Format";
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem1,
            this.fontColourToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.normalTextToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeThroughToolStripMenuItem});
            this.fontColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontColorToolStripMenuItem.Image")));
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fontColorToolStripMenuItem.Text = "Font";
            // 
            // fontSizeToolStripMenuItem1
            // 
            this.fontSizeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fontSizeToolStripMenuItem1.Image")));
            this.fontSizeToolStripMenuItem1.Name = "fontSizeToolStripMenuItem1";
            this.fontSizeToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.fontSizeToolStripMenuItem1.Text = "Font Size";
            this.fontSizeToolStripMenuItem1.Click += new System.EventHandler(this.fontSizeToolStripMenuItem1_Click);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontColourToolStripMenuItem.Image")));
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            this.fontColourToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.fontColourToolStripMenuItem.Text = "Font Colour";
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.fontColourToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // normalTextToolStripMenuItem
            // 
            this.normalTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("normalTextToolStripMenuItem.Image")));
            this.normalTextToolStripMenuItem.Name = "normalTextToolStripMenuItem";
            this.normalTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.normalTextToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.normalTextToolStripMenuItem.Text = "Normal Text";
            this.normalTextToolStripMenuItem.Click += new System.EventHandler(this.normalTextToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikeThroughToolStripMenuItem
            // 
            this.strikeThroughToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("strikeThroughToolStripMenuItem.Image")));
            this.strikeThroughToolStripMenuItem.Name = "strikeThroughToolStripMenuItem";
            this.strikeThroughToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.strikeThroughToolStripMenuItem.Text = "Strike Through";
            this.strikeThroughToolStripMenuItem.Click += new System.EventHandler(this.strikeThroughToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dateTimeToolStripMenuItem.Image")));
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dateTimeToolStripMenuItem.Text = "Date/Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // wordCountToolStripMenuItem1
            // 
            this.wordCountToolStripMenuItem1.Name = "wordCountToolStripMenuItem1";
            this.wordCountToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.wordCountToolStripMenuItem1.Text = "Word Count";
            this.wordCountToolStripMenuItem1.Click += new System.EventHandler(this.wordCountToolStripMenuItem1_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem1,
            this.normalModeToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // darkModeToolStripMenuItem1
            // 
            this.darkModeToolStripMenuItem1.Name = "darkModeToolStripMenuItem1";
            this.darkModeToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.darkModeToolStripMenuItem1.Text = "Dark Mode";
            this.darkModeToolStripMenuItem1.Click += new System.EventHandler(this.DarkModeToolStripMenuItem1_Click);
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            this.normalModeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.normalModeToolStripMenuItem.Text = "Normal Mode";
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.NormalModeToolStripMenuItem_Click);
            // 
            // optionsMenuAbout
            // 
            this.optionsMenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.linksToolStripMenuItem});
            this.optionsMenuAbout.Image = ((System.Drawing.Image)(resources.GetObject("optionsMenuAbout.Image")));
            this.optionsMenuAbout.Name = "optionsMenuAbout";
            this.optionsMenuAbout.Size = new System.Drawing.Size(61, 20);
            this.optionsMenuAbout.Text = "Extra";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("authorToolStripMenuItem.Image")));
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedInToolStripMenuItem1,
            this.gitHubToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // linkedInToolStripMenuItem1
            // 
            this.linkedInToolStripMenuItem1.Name = "linkedInToolStripMenuItem1";
            this.linkedInToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.linkedInToolStripMenuItem1.Text = "LinkedIn";
            this.linkedInToolStripMenuItem1.Click += new System.EventHandler(this.LinkedInToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // optionMenuLinks
            // 
            this.optionMenuLinks.Name = "optionMenuLinks";
            this.optionMenuLinks.Size = new System.Drawing.Size(12, 20);
            // 
            // gitHubToolStripMenuItem1
            // 
            this.gitHubToolStripMenuItem1.Name = "gitHubToolStripMenuItem1";
            this.gitHubToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // linkedInToolStripMenuItem
            // 
            this.linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarOpenFolder,
            this.newDocument,
            this.richTextBoxPrint,
            this.menuSaveAsButton,
            this.menuQuickSaveButton,
            this.toolStripSeparator,
            this.richTextBoxFontSize,
            this.richTextBoxColouredFont,
            this.richTextBoxCut,
            this.boldFont,
            this.italicFont,
            this.normalFont,
            this.richTextBoxStrikeThrough,
            this.RichTextBoxUnderlined,
            this.toolStripSeparator1,
            this.menuBarUndo,
            this.menuBarRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuBarOpenFolder
            // 
            this.menuBarOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBarOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("menuBarOpenFolder.Image")));
            this.menuBarOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBarOpenFolder.Name = "menuBarOpenFolder";
            this.menuBarOpenFolder.Size = new System.Drawing.Size(23, 22);
            this.menuBarOpenFolder.Text = "Open Document";
            this.menuBarOpenFolder.Click += new System.EventHandler(this.openDocumentRichTextBox_Click);
            // 
            // newDocument
            // 
            this.newDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDocument.Image = ((System.Drawing.Image)(resources.GetObject("newDocument.Image")));
            this.newDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDocument.Name = "newDocument";
            this.newDocument.Size = new System.Drawing.Size(23, 22);
            this.newDocument.Text = "New Document";
            this.newDocument.Click += new System.EventHandler(this.NewDoc_Click);
            // 
            // richTextBoxPrint
            // 
            this.richTextBoxPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.richTextBoxPrint.Image = ((System.Drawing.Image)(resources.GetObject("richTextBoxPrint.Image")));
            this.richTextBoxPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.richTextBoxPrint.Name = "richTextBoxPrint";
            this.richTextBoxPrint.Size = new System.Drawing.Size(23, 22);
            this.richTextBoxPrint.Text = "Print";
            this.richTextBoxPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // menuSaveAsButton
            // 
            this.menuSaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveAsButton.Image")));
            this.menuSaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSaveAsButton.Name = "menuSaveAsButton";
            this.menuSaveAsButton.Size = new System.Drawing.Size(23, 22);
            this.menuSaveAsButton.Text = "Save As";
            this.menuSaveAsButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // menuQuickSaveButton
            // 
            this.menuQuickSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("menuQuickSaveButton.Image")));
            this.menuQuickSaveButton.Name = "menuQuickSaveButton";
            this.menuQuickSaveButton.Size = new System.Drawing.Size(23, 22);
            this.menuQuickSaveButton.ToolTipText = "Quick Save";
            this.menuQuickSaveButton.Click += new System.EventHandler(this.ToolSaveButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // richTextBoxFontSize
            // 
            this.richTextBoxFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.richTextBoxFontSize.Image = ((System.Drawing.Image)(resources.GetObject("richTextBoxFontSize.Image")));
            this.richTextBoxFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.richTextBoxFontSize.Name = "richTextBoxFontSize";
            this.richTextBoxFontSize.Size = new System.Drawing.Size(23, 22);
            this.richTextBoxFontSize.Text = "Font Size";
            this.richTextBoxFontSize.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // richTextBoxColouredFont
            // 
            this.richTextBoxColouredFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.richTextBoxColouredFont.Image = ((System.Drawing.Image)(resources.GetObject("richTextBoxColouredFont.Image")));
            this.richTextBoxColouredFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.richTextBoxColouredFont.Name = "richTextBoxColouredFont";
            this.richTextBoxColouredFont.Size = new System.Drawing.Size(23, 22);
            this.richTextBoxColouredFont.Text = "Font Colour";
            this.richTextBoxColouredFont.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // richTextBoxCut
            // 
            this.richTextBoxCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.richTextBoxCut.Image = ((System.Drawing.Image)(resources.GetObject("richTextBoxCut.Image")));
            this.richTextBoxCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.richTextBoxCut.Name = "richTextBoxCut";
            this.richTextBoxCut.Size = new System.Drawing.Size(23, 22);
            this.richTextBoxCut.Text = "Cut";
            this.richTextBoxCut.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // boldFont
            // 
            this.boldFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldFont.Image = ((System.Drawing.Image)(resources.GetObject("boldFont.Image")));
            this.boldFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldFont.Name = "boldFont";
            this.boldFont.Size = new System.Drawing.Size(23, 22);
            this.boldFont.Text = "Bold";
            this.boldFont.Click += new System.EventHandler(this.menuBoldFont_Click);
            // 
            // italicFont
            // 
            this.italicFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicFont.Image = ((System.Drawing.Image)(resources.GetObject("italicFont.Image")));
            this.italicFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicFont.Name = "italicFont";
            this.italicFont.Size = new System.Drawing.Size(23, 22);
            this.italicFont.Text = "Italic";
            this.italicFont.Click += new System.EventHandler(this.FontToolButton_Click);
            // 
            // normalFont
            // 
            this.normalFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.normalFont.Image = ((System.Drawing.Image)(resources.GetObject("normalFont.Image")));
            this.normalFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.normalFont.Name = "normalFont";
            this.normalFont.Size = new System.Drawing.Size(23, 22);
            this.normalFont.Text = "Normal";
            this.normalFont.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // richTextBoxStrikeThrough
            // 
            this.richTextBoxStrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.richTextBoxStrikeThrough.Image = ((System.Drawing.Image)(resources.GetObject("richTextBoxStrikeThrough.Image")));
            this.richTextBoxStrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.richTextBoxStrikeThrough.Name = "richTextBoxStrikeThrough";
            this.richTextBoxStrikeThrough.Size = new System.Drawing.Size(23, 22);
            this.richTextBoxStrikeThrough.Text = "Strike Through";
            this.richTextBoxStrikeThrough.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // RichTextBoxUnderlined
            // 
            this.RichTextBoxUnderlined.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RichTextBoxUnderlined.Image = ((System.Drawing.Image)(resources.GetObject("RichTextBoxUnderlined.Image")));
            this.RichTextBoxUnderlined.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RichTextBoxUnderlined.Name = "RichTextBoxUnderlined";
            this.RichTextBoxUnderlined.Size = new System.Drawing.Size(23, 22);
            this.RichTextBoxUnderlined.Text = "Underline";
            this.RichTextBoxUnderlined.Click += new System.EventHandler(this.toolStripButton7_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menuBarUndo
            // 
            this.menuBarUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBarUndo.Image = ((System.Drawing.Image)(resources.GetObject("menuBarUndo.Image")));
            this.menuBarUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBarUndo.Name = "menuBarUndo";
            this.menuBarUndo.Size = new System.Drawing.Size(23, 22);
            this.menuBarUndo.Text = "Undo";
            this.menuBarUndo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // menuBarRedo
            // 
            this.menuBarRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBarRedo.Image = ((System.Drawing.Image)(resources.GetObject("menuBarRedo.Image")));
            this.menuBarRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBarRedo.Name = "menuBarRedo";
            this.menuBarRedo.Size = new System.Drawing.Size(23, 22);
            this.menuBarRedo.Text = "Redo";
            this.menuBarRedo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 48);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WordsLbl
            // 
            this.WordsLbl.AutoSize = true;
            this.WordsLbl.Location = new System.Drawing.Point(1137, 4);
            this.WordsLbl.Name = "WordsLbl";
            this.WordsLbl.Size = new System.Drawing.Size(0, 20);
            this.WordsLbl.TabIndex = 3;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainNotepadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.WordsLbl);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainNotepadFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightPad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionMenuFile;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem optionMenuFormat;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeThroughToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuBarOpenFolder;
        private System.Windows.Forms.ToolStripButton richTextBoxCut;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton richTextBoxPrint;
        private System.Windows.Forms.ToolStripButton menuSaveAsButton;
        private System.Windows.Forms.ToolStripButton menuQuickSaveButton;
        private System.Windows.Forms.ToolStripButton richTextBoxFontSize;
        private System.Windows.Forms.ToolStripButton richTextBoxColouredFont;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newDocument;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label WordsLbl;
        private System.Windows.Forms.ToolStripMenuItem wordCountToolStripMenuItem1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripButton boldFont;
        private System.Windows.Forms.ToolStripButton italicFont;
        private System.Windows.Forms.ToolStripButton normalFont;
        private System.Windows.Forms.ToolStripButton richTextBoxStrikeThrough;
        private System.Windows.Forms.ToolStripButton RichTextBoxUnderlined;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton menuBarUndo;
        private System.Windows.Forms.ToolStripButton menuBarRedo;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionMenuLinks;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
    }
}

