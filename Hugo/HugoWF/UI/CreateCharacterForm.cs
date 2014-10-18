namespace Hugo.UI
{
    using Hugo.Engine;
    using Hugo.Exceptions;
    using System;
    using System.Windows.Forms;
    using Hugo.Helpers;
    using System.Drawing;

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
            Color color = InputPreviewColor.BackColor;

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

		private void InputPreviewColor_TextChanged(object sender, EventArgs e)
		{

		}

		private void ButtonPickColor_Click(object sender, EventArgs e)
		{
			DialogResult result = this.DialogPickColor.ShowDialog();
			// See if user pressed ok.
			if (result == DialogResult.OK)
			{
				// Set form background to the selected color.
				this.InputPreviewColor.BackColor = DialogPickColor.Color;
			}
		}
    }
}
