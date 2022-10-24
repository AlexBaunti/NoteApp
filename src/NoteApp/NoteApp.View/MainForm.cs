using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DateTimePickerModified_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

            private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AboutForm af = new AboutForm();
                af.Show();
        }

        private void IconButtonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
        }
    }
}
