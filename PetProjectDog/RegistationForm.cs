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
    public partial class RegistationForm : Form
    {


        public RegistationForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPetName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtBreed.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                cmbFriendly.SelectedItem == null ||
                cmbVaccinated.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtOwnerName.Text) ||
                string.IsNullOrWhiteSpace(txtOwnerPhone.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед регистрацией.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!double.TryParse(txtWeight.Text, out double petWeight))
            {
                MessageBox.Show("Вес должен быть  числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (txtOwnerPhone.Text.Length != 11 || !txtOwnerPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Номер телефона должен состоять из 11 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string petName = txtPetName.Text;
            string petAge = txtAge.Text;

            string color = txtColor.Text;
            string breed = txtBreed.Text;
            bool isFriendly = cmbFriendly.SelectedItem?.ToString() == "Да";
            bool isVaccinated = cmbVaccinated.SelectedItem?.ToString() == "Да";
            string ownerName = txtOwnerName.Text;
            string ownerPhone = txtOwnerPhone.Text;

            Dog dog = new Dog(petName, petAge, petWeight, color, breed, isFriendly,
                isVaccinated);
            dog.Owner.Name = ownerName;
            dog.Owner.PhoneNumber = ownerPhone;

            MessageBox.Show($"Питомец: {petName}\nХозяин: {ownerName}\nУспешно зарегистрированы в системе",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataStorage.Dogs.Add(dog);
            DataStorage.SaveDogsToFile();






            ClearFormFields();
        }

        private void ClearFormFields()
        {
            txtPetName.Text = "";
            txtAge.Text = "";
            txtWeight.Text = "";
            txtColor.Text = "";
            txtBreed.Text = "";
            cmbFriendly.SelectedIndex = -1;
            cmbVaccinated.SelectedIndex = -1;
            txtOwnerName.Text = "";
            txtOwnerPhone.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void txtBreed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
