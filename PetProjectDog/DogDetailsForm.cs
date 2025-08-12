using Microsoft.VisualBasic.Logging;
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

    public partial class btnBack : Form
    {
        private Dog _dog;
        public btnBack(Dog dog)
        {
            InitializeComponent();
            _dog = dog;
            RefreshDogInfo();








        }


        private void RefreshDogInfo()
        {
            lblPetName.Text = _dog.Name;
            lblPetAge.Text = _dog.Age;
            lblPetWeight.Text = WeightToString(_dog.Weight);
            lblPetBreed.Text = _dog.Breed;
            lblPetColour.Text = _dog.Colour;
            lblPetIsVaccined.Text = IsStringVaccined(_dog.IsVaccinated);
            lblPetIsFriendly.Text = IsFriendlyOrNot(_dog.IsFriendly);
            lblPetOwnerName.Text = _dog.Owner.Name;
            lblPetOwnerPhone.Text = _dog.Owner.PhoneNumber;
            lblPetUnique.Text = _dog.SpecialFeatures;
            RefreshNotes();
            lblPetLastVacation.Text = _dog.LastVaccination.ToString("dd.MM.yyyy");
            lblPetNextVacation.Text = _dog.NextVaccination.ToString("dd.MM.yyyy");
            lblPetLastWalk.Text = _dog.LastWalk.ToString();
            lblPetNextWalk.Text = _dog.NextWalk.ToString();
            lblDateLastUpdate.Text = _dog.DateLastUpdate.ToString();
            if (!string.IsNullOrEmpty(_dog.PhotoPath) && File.Exists(_dog.PhotoPath))
            {
                pictureDog.Image = Image.FromFile(_dog.PhotoPath);
            }
            else
            {
                pictureDog.Image = null;
            }

        }

        public string WeightToString(double weight)
        {
            return $"{weight.ToString()} кг";
        }
        public string IsFriendlyOrNot(bool yes)
        {
            if (yes == true)
            {
                return "Да";
            }
            else
                return "Нет";

        }


        public string IsStringVaccined(bool yes)
        {
            if (yes == true)
            {
                return "Да";
            }
            else
                return "Нет";
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            using (var form = new AddNoteForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    cmbNotes.Items.Add(form.NoteText);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editDogInfo = new EditDogInfo(_dog);
            var result = editDogInfo.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshDogInfo(); // здесь логику обновлеия данных добавил после изменения на форме Edit
            }


        }
        private void RefreshNotes()
        {
            cmbNotes.Items.Clear();
            foreach (var note in _dog.Notes)
            {
                cmbNotes.Items.Add(note);
            }
            if (cmbNotes.Items.Count > 0)
            {
                cmbNotes.SelectedIndex = 0;
            }


        }

        private void pictureDog_Click(object sender, EventArgs e)
        {

        }

        private void DogDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
