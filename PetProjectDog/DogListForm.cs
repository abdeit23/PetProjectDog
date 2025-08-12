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
    public partial class DogListForm : Form
    {
        public DogListForm()
        {
            InitializeComponent();
        }
        private void RefreshDogList()
        {

            listBoxDogs.Items.Clear();
            var filteredDogs = DataStorage.Dogs.OrderBy(dog => dog.Name);
            foreach (var dog in filteredDogs)
            {
                listBoxDogs.Items.Add(dog);
            }
        }
        private void DogListForm_Load(object sender, EventArgs e)
        {
            
            DataStorage.LoadDogsFromFile();   
            RefreshDogList();                 
        }

        private void listBoxDogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxDogs_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDogs.SelectedItem is Dog selectedDog)
            {
                var detailsForm = new btnBack(selectedDog);
                detailsForm.ShowDialog();
            }
        }
    }
}
