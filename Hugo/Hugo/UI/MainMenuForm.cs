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
using System.Media;
namespace HugoWF
{
    public partial class MainMenuForm : Form
    {
        private SoundPlayer soundPlayer;
        public MainMenuForm()
        {
            soundPlayer = new SoundPlayer("barebear.wav");
            soundPlayer.Play();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();

            Engine engine = Engine.GetInstance();
            engine.StartGame();

            engine.Run();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateCharacterForm cch = new CreateCharacterForm();
            cch.Show();

        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            PlayingRulesForm htp = new PlayingRulesForm();
            htp.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
