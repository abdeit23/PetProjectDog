using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProjectDog
{
    public partial class AddNoteForm : Form
    {

        public string NoteText { get; private set; }

        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void AddNoteForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                NoteText = txtNote.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите текст примечания.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
