namespace Hugo.UI
{
    using Hugo.Engine;
    using Hugo.Exceptions;
    using System;
    using System.Windows.Forms;
    using Hugo.Helpers;

    public partial class CreateCharacterForm : Form
    {
        public CreateCharacterForm()
        {
            InitializeComponent();
        }

        private void SaveCharacterButton_Click(object sender, EventArgs e)
        {
            Engine engine = Engine.GetInstance();
            string playerName = nameTextBox.Text;
            Gender playerGender = maleRadioButton.Checked ? Gender.Male : Gender.Female;
            Colors color = (Colors)ColorComboBox.SelectedIndex;

            if (engine.ExistingColors.Contains(color))
            {
                MessageBox.Show("Player with " + color.ToString() + " color already exists! Please choose other color!");
                return;
            }

            engine.ExistingColors.Add(color);

            try
            {
                engine.CreatePlayer(playerName, playerGender, color);
                this.Close();
            }
            catch (InvalidNameException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
