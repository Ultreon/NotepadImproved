using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTextEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OpenClick(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";
            dialog.DefaultExt = "txt";
            dialog.AddExtension = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            DialogResult dialogResult = dialog.ShowDialog();

            EditorForm editorForm = new EditorForm();
            editorForm.MdiParent = this;
            
            if (dialogResult == DialogResult.OK)
            {
                editorForm.OpenFile(dialog.FileName);
                editorForm.Show();
            }
        }

        private void NewClick(object sender, EventArgs e)
        {
            EditorForm editorForm = new EditorForm();
            editorForm.MdiParent = this;
            editorForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
