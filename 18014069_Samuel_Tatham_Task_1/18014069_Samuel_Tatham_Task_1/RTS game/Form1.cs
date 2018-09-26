using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS_game
{
    public partial class RTSGame : Form
    {
        

        public RTSGame()
        {
            InitializeComponent();
            Globals.BF.initiliseMap();
        }

        public void clocker()
        {

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = Convert.ToString(count++);
        }

        private void RTSGame_Load(object sender, EventArgs e)
        {
        }

        private void radioFury_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioCourage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioCalm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioFear_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {

        }

        private void btnKill_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPause.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnPause.Enabled = true;
            Globals.BF.PlaceUnits();
            lblMapDisplay.Text += Globals.BF.RedrawMap();
        }

        private void btnSaveStats_Click(object sender, EventArgs e)
        {

        }

    }

    static class Globals
    {
        public static Map BF = new Map();
        public static GameEngine GE = new GameEngine();
    }
}
