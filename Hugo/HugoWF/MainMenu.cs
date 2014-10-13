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
    public partial class MainMenu : Form
    {
        private SoundPlayer soundPlayer;
        public MainMenu()
        {
            soundPlayer = new SoundPlayer("barebear.wav");
            soundPlayer.Play();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            
            Engine engine = Engine.GetInstance();
            engine.StartGame();
            
            GameField gf = new GameField();
            gf.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateCharacter cch = new CreateCharacter();
            cch.Show();

        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            htp.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
