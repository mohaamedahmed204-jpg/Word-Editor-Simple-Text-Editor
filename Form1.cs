using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// #E2E8F0 -->  أزرق فاتح مايل لرمادي
// #0284C7 -->  أزرق محيطي
// #3B82F6 -->  أزرق
// #1e1f22 -->  أزرق داكن
// #2B2D30 -->  أسود رمادي
// #424242 -->  رمادي

namespace Sixth_Project__Parctise_
{
    public partial class frmMain : Form
    {
        private Font defaultFont;
        private bool isDarkMode = true;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlStatu.BackColor = ColorTranslator.FromHtml("#2B2D30");

            defaultFont = richTxB.Font;
            richTxB.BackColor = ColorTranslator.FromHtml("#2B2D30");

            menuStrip1.BackColor = ColorTranslator.FromHtml("#2b2d30");
            menuStrip1.ForeColor = Color.White;

            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Renderer = new MyFixedDarkRenderer();

            this.BackColor = ColorTranslator.FromHtml("#1e1f22");

            foreach(Control control in this.Controls)
            {
                if(control is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#2B2D30");
                    btn.ForeColor = Color.White;
                }
                else if (control is Panel pnl)
                {
                    foreach (Control control2 in pnl.Controls)
                    {
                        if (control2 is Button btn2)
                        {
                            btn2.BackColor = ColorTranslator.FromHtml("#424242");
                            btn2.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = isDarkMode ? ColorTranslator.FromHtml("#2B2D30") : ColorTranslator.FromHtml("#E2E8F0");
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = isDarkMode ? ColorTranslator.FromHtml("#3B82F6") : ColorTranslator.FromHtml("#CBD5E1");
        }   

        private void DarkLightModeBtnBolorEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = isDarkMode ? ColorTranslator.FromHtml("#3B82F6") : ColorTranslator.FromHtml("#0369A1");
        }

        private void DarkLightModeBtnBolorLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = isDarkMode ? ColorTranslator.FromHtml("#424242") : ColorTranslator.FromHtml("#0284C7");
        }

        private void CountChars()
        {
            lblNumberOfChars.Text = Convert.ToString(richTxB.Text.Length);
        }

        private void CountWords()
        {
            string[] list = richTxB.Text.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            lblNumberOfWords.Text = Convert.ToString(list.Length);
        }

        private void richTxB_TextChanged(object sender, EventArgs e)
        {

            CountChars();
            CountWords();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxB.SelectionColor = colorDialog1.Color;
            }
        }

        private void btnChangeFontStyle_Click(object sender, EventArgs e)
        {
            if (richTxB.SelectionFont != null)
            {
                fontDialog1.Font = richTxB.SelectionFont;
            }
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxB.SelectionFont = fontDialog1.Font;
            }
        }

        private void btnRTL_Click(object sender, EventArgs e)
        {
            btnRightAlign_Click(sender, e);
        }

        private void btnLTR_Click(object sender, EventArgs e)
        {
            btnLeftAlign_Click(sender, e);
        }

        private void btnLeftAlign_Click(object sender, EventArgs e)
        {
            richTxB.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnCentreAlign_Click(object sender, EventArgs e)
        {
            richTxB.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnRightAlign_Click(object sender, EventArgs e)
        {
            richTxB.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            richTxB.ReadOnly = chkReadOnly.Checked;
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richTxB.SelectionFont != null)
                richTxB.SelectionFont = new Font(richTxB.SelectionFont, richTxB.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richTxB.SelectionFont != null)
                richTxB.SelectionFont = new Font(richTxB.SelectionFont, richTxB.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (richTxB.SelectionFont != null)
                richTxB.SelectionFont = new Font(richTxB.SelectionFont, richTxB.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlStatu.Visible = !pnlStatu.Visible;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxB.SelectionFont != null)
            {
                fontDialog1.Font = richTxB.SelectionFont;
            }
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxB.SelectionFont = fontDialog1.Font;
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxB.WordWrap = !richTxB.WordWrap;
        }

        private void ResetForm()
        {
            richTxB.Clear();
            richTxB.Font = defaultFont;
        }

        private void OpenFile()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "RTF files (*.rtf)| *.rtf| Text files (*.txt)| *.txt| All files (*.*)| *.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richTxB.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTxB.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
        }

        private void SaveFile()
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.Filter = "RTF files (*.rtf)| *.rtf| Text files (*.txt)| *.txt| All files (*.*)| *.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                if (saveFileDialog1.FilterIndex == 1 || saveFileDialog1.FileName.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richTxB.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTxB.Text);
                }
            }
        }

        private void FileClick(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;

            if(item.Tag == "New")
            {
                if( MessageBox.Show("Are you sure to reset this form ?\nYour work will not be saved", "Reset form"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ResetForm();
                }
            }
            else if(item.Tag == "New Window")
            {
                frmMain frm = new frmMain();
                frm.Show();
            }
            else if (item.Tag == "Open")
            {
                OpenFile();
            }
            else if (item.Tag == "Save As")
            {
                SaveFile();
            }
            else if (item.Tag == "Exit")
            {
                this.Close();
            }
        }

        private void EditClick(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;

            if(item.Tag == "Undo")
            {
                richTxB.Undo();
            }
            else if(item.Tag == "Cut")
            {
                richTxB.Cut();
            }
            else if (item.Tag == "Copy")
            {
                richTxB.Copy();
            }
            else if (item.Tag == "Paste")
            {
                richTxB.Paste();
            }
            else if (item.Tag == "Delete")
            {
                richTxB.SelectedText = "";
            }
            else if (item.Tag == "Select All")
            {
                richTxB.SelectAll();
            }
            else if (item.Tag == "Date/Time")
            {
                richTxB.SelectedText = DateTime.Now.ToString();
            }
        }

        private void ChangeMode(object sender, EventArgs e) 
        {
            Button btnMode = (Button)sender;
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // --- Dark Mode ---
                btnMode.Text = "Dark Mode 🌙";
                btnMode.BackColor = ColorTranslator.FromHtml("#424242");
                btnMode.ForeColor = Color.White;

                this.BackColor = ColorTranslator.FromHtml("#1e1f22");
                pnlStatu.BackColor = ColorTranslator.FromHtml("#2B2D30");

                richTxB.BackColor = ColorTranslator.FromHtml("#2B2D30");
                UpdateDefaultTextColor(Color.Black, Color.White);

                menuStrip1.BackColor = ColorTranslator.FromHtml("#2b2d30");
                menuStrip1.ForeColor = Color.White;
                menuStrip1.Renderer = new MyFixedDarkRenderer();

                ApplyThemeToControls(this, ColorTranslator.FromHtml("#2B2D30"), ColorTranslator.FromHtml("#424242"), Color.White, Color.White);
            }
            else
            {
                // --- Light Mode ---
                btnMode.Text = "Light Mode ☀️";
                btnMode.BackColor = ColorTranslator.FromHtml("#0284C7");
                btnMode.ForeColor = Color.White;

                this.BackColor = ColorTranslator.FromHtml("#F3F4F6");
                pnlStatu.BackColor = ColorTranslator.FromHtml("#E2E8F0");

                richTxB.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                UpdateDefaultTextColor(Color.White, Color.Black);

                menuStrip1.BackColor = ColorTranslator.FromHtml("#F8FAFC");
                menuStrip1.ForeColor = ColorTranslator.FromHtml("#334155");
                menuStrip1.Renderer = new MyFixedLightRenderer();

                ApplyThemeToControls(this, ColorTranslator.FromHtml("#E2E8F0"), ColorTranslator.FromHtml("#E2E8F0"), ColorTranslator.FromHtml("#0F172A"), Color.Black);
            }
        }

        private void UpdateDefaultTextColor(Color oldDefaultColor, Color newDefaultColor)
        {
            //  (Flicker) 
            richTxB.SuspendLayout();

            int originalStart = richTxB.SelectionStart;
            int originalLength = richTxB.SelectionLength;

            for (int i = 0; i < richTxB.TextLength; i++)
            {
                richTxB.Select(i, 1);

                if (richTxB.SelectionColor == oldDefaultColor || richTxB.SelectionColor.ToArgb() == oldDefaultColor.ToArgb())
                {
                    richTxB.SelectionColor = newDefaultColor;
                }
            }

            // رجع الكلام لمكانوا ياض
            richTxB.Select(originalStart, originalLength);
            richTxB.ResumeLayout();

            if (lblNumberOfWords.Text == "0") richTxB.ForeColor = newDefaultColor;  
        }

        private void ApplyThemeToControls(Control parent, Color btnColor, Color panelBtnColor, Color btnForeColor, Color labelForeColor)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = btnColor;
                    btn.ForeColor = btnForeColor;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = labelForeColor;
                }
                else if (control is Panel pnl)
                {
                    foreach (Control control2 in pnl.Controls)
                    {
                        if (control2 is Button btn2)
                        {
                            btn2.BackColor = panelBtnColor;
                            btn2.ForeColor = btnForeColor;
                        }
                        else if (control2 is Label lbl2)
                        {
                            lbl2.ForeColor = labelForeColor;
                        }
                        else if(control2 is CheckBox chk)
                        {
                            chk.ForeColor = labelForeColor;
                        }
                    }
                }
            }
        }
    }

    public class MyFixedDarkRenderer : ToolStripProfessionalRenderer
    {
        public MyFixedDarkRenderer() : base() { }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#2b2d30")))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#2b2d30")))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#3B82F6")))
                {
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);
                }
            }
            else
            {
                using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#2B2D30")))
                {
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);
                }
            }

            e.Item.ForeColor = Color.White;
        }
    }

    public class MyFixedLightRenderer : ToolStripProfessionalRenderer
    {
        public MyFixedLightRenderer() : base() { }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#F8FAFC")))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#F8FAFC")))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#CBD5E1")))
                {
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);
                }
            }
            else
            {
                using (SolidBrush b = new SolidBrush(ColorTranslator.FromHtml("#F8FAFC")))
                {
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);
                }
            }

            e.Item.ForeColor = ColorTranslator.FromHtml("#334155");
        }
    }

}
