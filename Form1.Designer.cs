namespace Sixth_Project__Parctise_
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTxB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRTL = new System.Windows.Forms.Button();
            this.btnLTR = new System.Windows.Forms.Button();
            this.btnCentreAlign = new System.Windows.Forms.Button();
            this.btnLeftAlign = new System.Windows.Forms.Button();
            this.btnRightAlign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblNumberOfWords = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.lblChars = new System.Windows.Forms.Label();
            this.lblNumberOfChars = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.btnChangeFontStyle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlStatu = new System.Windows.Forms.Panel();
            this.DarkLightModebtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlStatu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1164, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(303, 28);
            this.newToolStripMenuItem.Tag = "New";
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.FileClick);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(303, 28);
            this.newWindowToolStripMenuItem.Tag = "New Window";
            this.newWindowToolStripMenuItem.Text = "New &Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.FileClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(303, 28);
            this.openToolStripMenuItem.Tag = "Open";
            this.openToolStripMenuItem.Text = "&Open......";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.FileClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(303, 28);
            this.saveAsToolStripMenuItem.Tag = "Save As";
            this.saveAsToolStripMenuItem.Text = "&Save As....";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.FileClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(300, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(303, 28);
            this.exitToolStripMenuItem.Tag = "Exit";
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.FileClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectAllToolStripMenuItem,
            this.dateTimeToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.undoToolStripMenuItem.Tag = "Undo";
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.cutToolStripMenuItem.Tag = "Cut";
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.copyToolStripMenuItem.Tag = "Copy";
            this.copyToolStripMenuItem.Text = "Co&py";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.pasteToolStripMenuItem.Tag = "Paste";
            this.pasteToolStripMenuItem.Text = "Pas&te";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.deleteToolStripMenuItem.Tag = "Delete";
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.selectAllToolStripMenuItem.Tag = "Select All";
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.dateTimeToolStripMenuItem.Tag = "Date/Time";
            this.dateTimeToolStripMenuItem.Text = "Date/&Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.EditClick);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.AutoSize = false;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Checked = true;
            this.wordToolStripMenuItem.CheckOnClick = true;
            this.wordToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.wordToolStripMenuItem.Text = "&Word Wrap";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.fontToolStripMenuItem.Text = "&Font Style";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.AutoSize = false;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // richTxB
            // 
            this.richTxB.AcceptsTab = true;
            this.richTxB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.richTxB.ForeColor = System.Drawing.Color.White;
            this.richTxB.Location = new System.Drawing.Point(67, 181);
            this.richTxB.Name = "richTxB";
            this.richTxB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTxB.Size = new System.Drawing.Size(1030, 466);
            this.richTxB.TabIndex = 2;
            this.richTxB.Text = "";
            this.richTxB.TextChanged += new System.EventHandler(this.richTxB_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(974, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word Editor";
            // 
            // btnRTL
            // 
            this.btnRTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnRTL.ForeColor = System.Drawing.Color.Black;
            this.btnRTL.Location = new System.Drawing.Point(67, 123);
            this.btnRTL.Name = "btnRTL";
            this.btnRTL.Size = new System.Drawing.Size(71, 43);
            this.btnRTL.TabIndex = 5;
            this.btnRTL.TabStop = false;
            this.btnRTL.Text = "RTL";
            this.btnRTL.UseVisualStyleBackColor = true;
            this.btnRTL.Click += new System.EventHandler(this.btnRTL_Click);
            this.btnRTL.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnRTL.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnLTR
            // 
            this.btnLTR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnLTR.ForeColor = System.Drawing.Color.Black;
            this.btnLTR.Location = new System.Drawing.Point(144, 123);
            this.btnLTR.Name = "btnLTR";
            this.btnLTR.Size = new System.Drawing.Size(71, 43);
            this.btnLTR.TabIndex = 6;
            this.btnLTR.TabStop = false;
            this.btnLTR.Text = "LTR";
            this.btnLTR.UseVisualStyleBackColor = true;
            this.btnLTR.Click += new System.EventHandler(this.btnLTR_Click);
            this.btnLTR.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnLTR.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnCentreAlign
            // 
            this.btnCentreAlign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCentreAlign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCentreAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnCentreAlign.ForeColor = System.Drawing.Color.Black;
            this.btnCentreAlign.Location = new System.Drawing.Point(321, 123);
            this.btnCentreAlign.Name = "btnCentreAlign";
            this.btnCentreAlign.Size = new System.Drawing.Size(71, 43);
            this.btnCentreAlign.TabIndex = 6;
            this.btnCentreAlign.TabStop = false;
            this.btnCentreAlign.Text = "Centre";
            this.btnCentreAlign.UseVisualStyleBackColor = true;
            this.btnCentreAlign.Click += new System.EventHandler(this.btnCentreAlign_Click);
            this.btnCentreAlign.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnCentreAlign.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnLeftAlign
            // 
            this.btnLeftAlign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeftAlign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnLeftAlign.ForeColor = System.Drawing.Color.Black;
            this.btnLeftAlign.Location = new System.Drawing.Point(244, 123);
            this.btnLeftAlign.Name = "btnLeftAlign";
            this.btnLeftAlign.Size = new System.Drawing.Size(71, 43);
            this.btnLeftAlign.TabIndex = 5;
            this.btnLeftAlign.TabStop = false;
            this.btnLeftAlign.Text = "Left";
            this.btnLeftAlign.UseVisualStyleBackColor = true;
            this.btnLeftAlign.Click += new System.EventHandler(this.btnLeftAlign_Click);
            this.btnLeftAlign.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnLeftAlign.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnRightAlign
            // 
            this.btnRightAlign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightAlign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnRightAlign.ForeColor = System.Drawing.Color.Black;
            this.btnRightAlign.Location = new System.Drawing.Point(396, 123);
            this.btnRightAlign.Name = "btnRightAlign";
            this.btnRightAlign.Size = new System.Drawing.Size(71, 43);
            this.btnRightAlign.TabIndex = 7;
            this.btnRightAlign.TabStop = false;
            this.btnRightAlign.Text = "Right";
            this.btnRightAlign.UseVisualStyleBackColor = true;
            this.btnRightAlign.Click += new System.EventHandler(this.btnRightAlign_Click);
            this.btnRightAlign.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnRightAlign.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text Direction";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(285, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text Alignment";
            // 
            // lblWords
            // 
            this.lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWords.AutoSize = true;
            this.lblWords.BackColor = System.Drawing.Color.Transparent;
            this.lblWords.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.lblWords.ForeColor = System.Drawing.Color.White;
            this.lblWords.Location = new System.Drawing.Point(13, 18);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(76, 31);
            this.lblWords.TabIndex = 10;
            this.lblWords.Text = "Words:";
            // 
            // lblNumberOfWords
            // 
            this.lblNumberOfWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumberOfWords.AutoSize = true;
            this.lblNumberOfWords.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfWords.Font = new System.Drawing.Font("Akhbar MT", 10F);
            this.lblNumberOfWords.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfWords.Location = new System.Drawing.Point(95, 18);
            this.lblNumberOfWords.Name = "lblNumberOfWords";
            this.lblNumberOfWords.Size = new System.Drawing.Size(24, 29);
            this.lblNumberOfWords.TabIndex = 11;
            this.lblNumberOfWords.Text = "0";
            // 
            // lblSeperator
            // 
            this.lblSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.BackColor = System.Drawing.Color.Transparent;
            this.lblSeperator.Font = new System.Drawing.Font("Akhbar MT", 13F);
            this.lblSeperator.ForeColor = System.Drawing.Color.White;
            this.lblSeperator.Location = new System.Drawing.Point(164, 12);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(21, 35);
            this.lblSeperator.TabIndex = 12;
            this.lblSeperator.Text = "|";
            // 
            // lblChars
            // 
            this.lblChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChars.AutoSize = true;
            this.lblChars.BackColor = System.Drawing.Color.Transparent;
            this.lblChars.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.lblChars.ForeColor = System.Drawing.Color.White;
            this.lblChars.Location = new System.Drawing.Point(203, 16);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(111, 31);
            this.lblChars.TabIndex = 13;
            this.lblChars.Text = "Characters:";
            // 
            // lblNumberOfChars
            // 
            this.lblNumberOfChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumberOfChars.AutoSize = true;
            this.lblNumberOfChars.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfChars.Font = new System.Drawing.Font("Akhbar MT", 10F);
            this.lblNumberOfChars.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfChars.Location = new System.Drawing.Point(311, 18);
            this.lblNumberOfChars.Name = "lblNumberOfChars";
            this.lblNumberOfChars.Size = new System.Drawing.Size(24, 29);
            this.lblNumberOfChars.TabIndex = 14;
            this.lblNumberOfChars.Text = "0";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkReadOnly.ForeColor = System.Drawing.Color.White;
            this.chkReadOnly.Location = new System.Drawing.Point(902, 17);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(117, 26);
            this.chkReadOnly.TabIndex = 15;
            this.chkReadOnly.TabStop = false;
            this.chkReadOnly.Text = "Read Only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // btnChangeFontStyle
            // 
            this.btnChangeFontStyle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeFontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnChangeFontStyle.ForeColor = System.Drawing.Color.Black;
            this.btnChangeFontStyle.Location = new System.Drawing.Point(497, 123);
            this.btnChangeFontStyle.Name = "btnChangeFontStyle";
            this.btnChangeFontStyle.Size = new System.Drawing.Size(112, 43);
            this.btnChangeFontStyle.TabIndex = 16;
            this.btnChangeFontStyle.TabStop = false;
            this.btnChangeFontStyle.Text = "Change Font";
            this.btnChangeFontStyle.UseVisualStyleBackColor = true;
            this.btnChangeFontStyle.Click += new System.EventHandler(this.btnChangeFontStyle_Click);
            this.btnChangeFontStyle.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnChangeFontStyle.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(501, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Font Style";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(619, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Font color";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnChangeColor.ForeColor = System.Drawing.Color.Black;
            this.btnChangeColor.Location = new System.Drawing.Point(615, 123);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(112, 43);
            this.btnChangeColor.TabIndex = 18;
            this.btnChangeColor.TabStop = false;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            this.btnChangeColor.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnChangeColor.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBold
            // 
            this.btnBold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnBold.ForeColor = System.Drawing.Color.Black;
            this.btnBold.Location = new System.Drawing.Point(777, 123);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(99, 43);
            this.btnBold.TabIndex = 20;
            this.btnBold.TabStop = false;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            this.btnBold.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnBold.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnItalic
            // 
            this.btnItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnItalic.ForeColor = System.Drawing.Color.Black;
            this.btnItalic.Location = new System.Drawing.Point(882, 123);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(99, 43);
            this.btnItalic.TabIndex = 21;
            this.btnItalic.TabStop = false;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            this.btnItalic.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnItalic.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnUnderline.ForeColor = System.Drawing.Color.Black;
            this.btnUnderline.Location = new System.Drawing.Point(987, 123);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(99, 43);
            this.btnUnderline.TabIndex = 22;
            this.btnUnderline.TabStop = false;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            this.btnUnderline.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.btnUnderline.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Akhbar MT", 11F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(847, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "Effect Text Style";
            // 
            // pnlStatu
            // 
            this.pnlStatu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatu.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatu.Controls.Add(this.DarkLightModebtn);
            this.pnlStatu.Controls.Add(this.lblWords);
            this.pnlStatu.Controls.Add(this.lblNumberOfWords);
            this.pnlStatu.Controls.Add(this.lblSeperator);
            this.pnlStatu.Controls.Add(this.lblChars);
            this.pnlStatu.Controls.Add(this.lblNumberOfChars);
            this.pnlStatu.Controls.Add(this.chkReadOnly);
            this.pnlStatu.Location = new System.Drawing.Point(67, 664);
            this.pnlStatu.Name = "pnlStatu";
            this.pnlStatu.Size = new System.Drawing.Size(1030, 67);
            this.pnlStatu.TabIndex = 24;
            // 
            // DarkLightModebtn
            // 
            this.DarkLightModebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkLightModebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DarkLightModebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkLightModebtn.Location = new System.Drawing.Point(746, 8);
            this.DarkLightModebtn.Name = "DarkLightModebtn";
            this.DarkLightModebtn.Size = new System.Drawing.Size(117, 46);
            this.DarkLightModebtn.TabIndex = 25;
            this.DarkLightModebtn.Text = "Light Mode🔅";
            this.DarkLightModebtn.UseVisualStyleBackColor = true;
            this.DarkLightModebtn.Click += new System.EventHandler(this.ChangeMode);
            this.DarkLightModebtn.MouseEnter += new System.EventHandler(this.DarkLightModeBtnBolorEnter);
            this.DarkLightModebtn.MouseLeave += new System.EventHandler(this.DarkLightModeBtnBolorLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1164, 753);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnChangeFontStyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRightAlign);
            this.Controls.Add(this.btnLTR);
            this.Controls.Add(this.btnCentreAlign);
            this.Controls.Add(this.btnLeftAlign);
            this.Controls.Add(this.btnRTL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxB);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlStatu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Simple Text Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStatu.ResumeLayout(false);
            this.pnlStatu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRTL;
        private System.Windows.Forms.Button btnLTR;
        private System.Windows.Forms.Button btnRightAlign;
        private System.Windows.Forms.Button btnCentreAlign;
        private System.Windows.Forms.Button btnLeftAlign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblNumberOfWords;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.Label lblNumberOfChars;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnChangeFontStyle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlStatu;
        private System.Windows.Forms.Button DarkLightModebtn;
    }
}

