using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTextEditor
{
    public partial class EditorForm : Form
    {
        private string fileName = null;
        private string originalText;
        private List<string> history = new List<string>();
        private int historyIndex = -1;
        private bool historyChanging;
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        private bool settingsLock;

        public TextBox TextBox {
            get {
                return Editor;
            }
        }

        public bool UnsavedChanges { get; private set; }

        private void DocumentPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Editor.Text, Editor.Font, new SolidBrush(Editor.ForeColor), 20, 20);
        }

        public EditorForm()
        {
            InitializeComponent();
            UnsavedChanges = true;
            document.PrintPage += new PrintPageEventHandler(DocumentPrintPage);
            EditorStatusLabel.Text = unsavedChangesString;

            NewFile();
        }

        private void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitClick(object sender, EventArgs e)
        {
            CloseEditor();
            Close();
        }

        private void CloseEditor()
        {
            if (UnsavedChanges)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to your document.\nDo you want to save it?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    if (!Save())
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void Open(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";
            dialog.DefaultExt = "txt";
            dialog.AddExtension = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.ShowDialog();

            OpenFile(dialog.FileName);
        }

        internal void OpenFile(string fileName)
        {
            // Open file stream.
            FileStream stream = null;
            try
            {
                stream = File.Open(fileName, FileMode.OpenOrCreate);

                // Read data.
                StreamReader reader = new StreamReader(stream);
                string data = reader.ReadToEnd();

                // Close stream.
                stream.Close();

                // Set data in text box.
                originalText = data;
                Editor.Text = data;

                this.fileName = fileName;
                EditorStatusLabel.Text = changesSavedString;
                UnsavedChanges = false;
            }
            catch (Exception e)
            {
                if (e is ArgumentException)
                {
                    if (((ArgumentException)e).HResult == -0x7FF8_FFA9)
                    {
                        return;
                    }
                }
                if (stream != null)
                {
                    try
                    {
                        stream.Close();
                    }
                    catch (Exception)
                    {

                    }
                }
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            Save();
        }

        public bool Save()
        {
            if (fileName == null)
            {
                return SaveAs();
            }

            return SaveFile(fileName);
        }

        private bool SaveFile(string fileName)
        {
            FileStream stream = null;
            try
            {
                // Open file stream.
                stream = File.Open(fileName, FileMode.OpenOrCreate);

                // Write, flush data.
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(Editor.Text);
                writer.Flush();

                // Close stream.
                stream.Close();

                this.fileName = fileName;
                originalText = Editor.Text;
                EditorStatusLabel.Text = changesSavedString;
                UnsavedChanges = false;
                return true;
            }
            catch (Exception e)
            {
                if (e is ArgumentException)
                {
                    if (((ArgumentException)e).HResult == -0x7FF8_FFA9)
                    {
                        return false;
                    }
                }
                if (stream != null)
                {
                    try
                    {
                        stream.Close();
                    }
                    catch (Exception)
                    {

                    }
                }
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /**
         * param name="e" the event arguments.
         * param name="sender" the event sender.
         */
        private void SaveAs(object sender, EventArgs e)
        {
            SaveAs();
        }

        private bool SaveAs()
        {
            // Show save file dialog.
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";
            dialog.DefaultExt = "txt";
            dialog.AddExtension = true;
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Save data.
                return SaveFile(dialog.FileName);
            }
            else
            {
                return false;
            }
        }

        private void SetWordWrap(object sender, EventArgs e)
        {
            // Change word weap state based on the menu-item checked state.
            Editor.WordWrap = wordWrapMenuItem.Checked;
        }

        private void CopyText(object sender, EventArgs e)
        {
            // Copy text.
            Editor.Copy();
        }

        private void CutText(object sender, EventArgs e)
        {
            // Cut text.
            Editor.Cut();
        }

        private void PasteText(object sender, EventArgs e)
        {
            // Paste text.
            Editor.Paste();
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            // Show font dialog.
            FontDialog dialog = new FontDialog();
            dialog.Font = Editor.Font;
            dialog.ShowEffects = true;
            dialog.ShowApply = true;
            dialog.Apply += new EventHandler((_1, _2) => ChangeFont(dialog));
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ChangeFont(dialog);
            }
        }

        private void ChangeFont(FontDialog dialog)
        {
            // Change the text box font to the one from the dialog..
            Editor.Font = dialog.Font;
        }

        private void SettingsWindow(object sender, EventArgs e)
        {
            if (!settingsLock)
            {
                Settings settings = new Settings(this);
                settings.MdiParent = MdiParent;
                settingsLock = true;
                settingsMenuItem.Enabled = false;
                settings.Show();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }

        internal void UnlockSettings()
        {
            settingsLock = false;
            settingsMenuItem.Enabled = true;
        }

        private void New(object sender, EventArgs e)
        {
            CloseEditor();
            NewFile();
        }

        private void NewFile()
        {
            fileName = null;
            originalText = "";
            Editor.Text = "";

            EditorStatusLabel.Text = changesSavedString;
            UnsavedChanges = false;
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (originalText == null)
            {
                EditorStatusLabel.Text = unsavedChangesString;
                UnsavedChanges = true;
                return;
            }
            else if (originalText != Editor.Text)
            {
                EditorStatusLabel.Text = unsavedChangesString;
                UnsavedChanges = true;
            }
            else
            {
                EditorStatusLabel.Text = changesSavedString;
                UnsavedChanges = false;
            }

            Console.WriteLine(history.Count);
        }

        private void PrintMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                        (PDPrintPage);
                    pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // The PrintPage event is raised for each page to be printed.
        private void PDPrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            Font font = Editor.Font;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
                font.GetHeight(ev.Graphics);

            StringReader reader = new StringReader(Editor.Text);

            //Rectangle pageBounds = ev.PageBounds;
            Rectangle pageBounds = ev.MarginBounds;

            // Print each line of the file.
            while (count < linesPerPage &&
                ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                    font.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, font, new SolidBrush(Editor.ForeColor),
                    pageBounds, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void SelectAllMenuItemClick(object sender, EventArgs e)
        {
            Editor.SelectAll();
        }

        private void FormattingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangeForegroundColorMenuItemClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Editor.ForeColor;
            dialog.ShowHelp = true;
            dialog.FullOpen = true;
            dialog.AllowFullOpen = true;
            dialog.SolidColorOnly = true;
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Editor.ForeColor = dialog.Color;
            }
        }

        private void ChangeBackgroundColorMenuItemClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Editor.BackColor;
            dialog.ShowHelp = true;
            dialog.FullOpen = true;
            dialog.AllowFullOpen = true;
            dialog.SolidColorOnly = true;
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Editor.BackColor = dialog.Color;
            }
        }

        private void EditorMain_Load(object sender, EventArgs e)
        {

        }
    }
}
