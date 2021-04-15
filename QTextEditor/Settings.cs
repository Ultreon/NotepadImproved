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

namespace QTextEditor
{
    public partial class Settings : Form
    {
        private string fileName;
        private EditorForm main;

        // Boolean values.
        public bool EditorHideSelection { get; private set; }
        public bool IsRightToLeft { get; private set; }
        public Font EditorFont { get; private set; }
        public Color EditorForeColor { get; private set; }
        public Color EditorBackColor { get; private set; }

        public Settings(EditorForm main)
        {
            this.main = main;
            InitializeComponent();

            checkHideSelection.Checked = EditorHideSelection = main.TextBox.HideSelection;
            EditorFont = main.TextBox.Font;
            foreColorBtn.ForeColor = backColorBtn.ForeColor = EditorForeColor = main.TextBox.ForeColor;
            foreColorBtn.BackColor = backColorBtn.BackColor = EditorBackColor = main.TextBox.BackColor;
            switch (main.TextBox.RightToLeft)
            {
                case RightToLeft.Yes:
                    checkRightToLeft.Checked = IsRightToLeft = true;
                    break;
                case RightToLeft.No:
                case RightToLeft.Inherit:
                default:
                    checkRightToLeft.Checked = IsRightToLeft = false;
                    break;
            }
        }

        private void CheckedHideSelectionChanged(object sender, EventArgs e)
        {
            EditorHideSelection = checkHideSelection.Checked;
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void ApplyChanges()
        {
            main.TextBox.HideSelection = EditorHideSelection;
            main.TextBox.Font = EditorFont;
            main.TextBox.ForeColor = EditorForeColor;
            main.TextBox.BackColor = EditorBackColor;
            if (IsRightToLeft) {
                main.TextBox.RightToLeft = RightToLeft.Yes;
            } 
            else
            {
                main.TextBox.RightToLeft = RightToLeft.Inherit;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButtonClick(object sender, EventArgs e)
        {
            ApplyChanges();
            Close();
        }

        private void CheckedRightToLeftChanged(object sender, EventArgs e)
        {
            IsRightToLeft = checkRightToLeft.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeFontClick(object sender, EventArgs e)
        {
            // Show font dialog.
            FontDialog dialog = new FontDialog();
            dialog.Font = EditorFont;
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
            EditorFont = dialog.Font;
        }

        private void ChangeForeColorClick(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            dialog.Color = EditorForeColor;
            dialog.ShowHelp = true;
            dialog.FullOpen = true;
            dialog.AllowFullOpen = true;
            dialog.SolidColorOnly = true;
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                foreColorBtn.ForeColor = backColorBtn.ForeColor = EditorForeColor = dialog.Color;
            }
        }

        private void ChangeBackColorClick(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            dialog.Color = EditorBackColor;
            dialog.ShowHelp = true;
            dialog.FullOpen = true;
            dialog.AllowFullOpen = true;
            dialog.SolidColorOnly = true;
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                foreColorBtn.BackColor = backColorBtn.BackColor = EditorBackColor = dialog.Color;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void OnSettingsClosed(object sender, FormClosedEventArgs e)
        {
            main.UnlockSettings();
        }
    }
}
