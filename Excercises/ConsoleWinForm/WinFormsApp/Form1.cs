using DemoLibrary1;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void combineName_Click(object sender, EventArgs e)
        {
            string fullName = PersonProcessor.JoinName(firstNameText.Text, lastNameText.Text);

            MessageBox.Show($"Your full name is {fullName}");
        }
    }
}
