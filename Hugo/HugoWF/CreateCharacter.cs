using Hugo.Engine;
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
            string playerGender=maleRadioButton.Checked?"Male":"Female";
            MessageBox.Show(playerName + "----" + playerGender);
            engine.CreatePlayer(playerName, playerGender);
        }
    }
}
