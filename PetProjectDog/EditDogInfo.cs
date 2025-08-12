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
    public partial class EditDogInfo : Form
    {


        private Dog dogEdit;
        public EditDogInfo(Dog dogToEdit)
        {
            InitializeComponent();
            dogEdit = dogToEdit;

            txtEditName.Text = dogEdit.Name;
            txtEditAge.Text = dogEdit.Age;
            txtEditBreed.Text = dogEdit.Breed;
            txtEditColour.Text = dogEdit.Colour;
            txtEditWeight.Text = WeightToString(dogEdit.Weight);
            txtEditUnique.Text = dogEdit.SpecialFeatures;
            txtEditLastVaccination.Text = dogEdit.LastVaccination.ToString("dd.MM.yyyy");
            txtEditNextVaccination.Text = dogEdit.NextVaccination.ToString("dd.MM.yyyy");
            txtEditOwnerName.Text = dogEdit.Owner.Name;
            txtEditOwnerPhone.Text = dogEdit.Owner.PhoneNumber;
            txtEditLastWalk.Text = dogEdit.LastWalk.ToString();
            txtEditNextWalk.Text = dogEdit.NextWalk.ToString();
            if (!string.IsNullOrEmpty(dogEdit.PhotoPath) && File.Exists(dogEdit.PhotoPath))
            {
                pictureBoxPreview.Image = Image.FromFile(dogEdit.PhotoPath);
            }



        }

        public string WeightToString(double weight)
        {
            return $"{weight.ToString()} кг";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EditDogInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            using (var form = new AddNoteForm())
            {
                if (form.ShowDialog() == DialogResult.OK)

                {
                    dogEdit.Notes.Add(form.NoteText);
                    cmbEditNotes.Items.Add(form.NoteText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtEditName.Text) ||
                string.IsNullOrWhiteSpace(txtEditAge.Text) ||
                string.IsNullOrWhiteSpace(txtEditColour.Text) ||
                string.IsNullOrWhiteSpace(txtEditBreed.Text) ||
                string.IsNullOrWhiteSpace(txtEditWeight.Text) ||
                cmbEditIsFriendly.SelectedItem == null ||
                cmbEditIsVaccinated.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtEditOwnerName.Text) ||
                string.IsNullOrWhiteSpace(txtEditOwnerPhone.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля обязательные поля перед изменением.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(BackToDouble(txtEditWeight.Text), out double petWeight))
            {
                MessageBox.Show("Вес должен быть  числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (txtEditOwnerPhone.Text.Length != 11 || !txtEditOwnerPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Номер телефона должен состоять из 11 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lastVacc = ParseDate(txtEditLastVaccination, "Последняя вакцинация");
            var nextVacc = ParseDate(txtEditNextVaccination, "Следующая вакцинация");
            var lastWalk = ParseDate(txtEditLastWalk, "Последняя прогулка");
            var nextWalk = ParseDate(txtEditNextWalk, "Следующая прогулка");

            if (lastVacc == null || nextVacc == null || lastWalk == null || nextWalk == null)
                return;

            dogEdit.Name = txtEditName.Text;
            dogEdit.Age = txtEditAge.Text;
            dogEdit.Breed = txtEditBreed.Text;
            dogEdit.Colour = txtEditColour.Text;
            dogEdit.IsFriendly = cmbEditIsFriendly.SelectedItem?.ToString() == "Да";
            dogEdit.IsVaccinated = cmbEditIsVaccinated.SelectedItem?.ToString() == "Да";
            dogEdit.Owner.Name = txtEditOwnerName.Text;
            dogEdit.Owner.PhoneNumber = txtEditOwnerPhone.Text;
            dogEdit.SpecialFeatures = txtEditUnique.Text;
            dogEdit.LastVaccination = lastVacc.Value;
            dogEdit.NextVaccination = nextVacc.Value;
            dogEdit.LastWalk = lastWalk.Value;
            dogEdit.NextWalk = nextWalk.Value;
            dogEdit.DateLastUpdate = DateTime.Now;

            DataStorage.SaveDogsToFile();


            MessageBox.Show("Изменения успешно сохранены!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();




        }
        private string BackToDouble(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb = sb.Replace("кг", "");
            return sb.ToString();
        }
        private DateTime? ParseDate(TextBox textBox, string fieldName)
        {
            if (DateTime.TryParse(textBox.Text, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                MessageBox.Show($"Некорректная дата в поле \"{fieldName}\". Введите в формате ДД.ММ.ГГГГ.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var result = MessageBox.Show(
                "Вы уверены, что хотите очистить список заметок?",
                "Подтверждение очистки",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dogEdit.Notes.Clear();
                cmbEditNotes.Items.Clear();
            }

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dogEdit.PhotoPath = ofd.FileName;
                    Image img = Image.FromFile(ofd.FileName);
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBoxPreview.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnCancelEdits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
