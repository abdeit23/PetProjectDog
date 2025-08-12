namespace PetProjectDog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistationForm();
            registrationForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var ourDogs = DataStorage.Dogs;
            var ourOwners = DataStorage.Owners;

            if (ourDogs.Count == 0)
            {
                MessageBox.Show("Пока не зарегистрированно ни одной собаки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ourDogsForm = new DogListForm();
            ourDogsForm.ShowDialog();




        }
    }
}

