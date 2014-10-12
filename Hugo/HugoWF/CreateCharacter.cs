using Hugo.Engine;
using Hugo.Players;
using Hugo.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoWF
{
    public partial class CreateCharacter : Form
    {
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {

        }

        private void SaveCharacterButton_Click(object sender, EventArgs e)
        {
            Engine engine = Engine.GetInstance();
            string playerName=nameTextBox.Text;
            Gender playerGender = maleRadioButton.Checked ? Gender.Male : Gender.Female;           
			try
			{
				engine.CreatePlayer(playerName, playerGender);
				MessageBox.Show(playerName + "----" + playerGender);
				base.Close();
			}
			catch (InvalidNameException ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

    }
}
