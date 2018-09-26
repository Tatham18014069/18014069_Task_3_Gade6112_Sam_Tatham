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
        GameEngine ge = new GameEngine();

        public RTSGame()
        {
            InitializeComponent();
            ge.initialiseMap();
        }

        int countS = 0;
        int countSS = 0;
        int countM = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = "Time:" + Environment.NewLine + Convert.ToString(countM) + ":" + Convert.ToString(countS) + Convert.ToString(countSS++);
            if (countSS == 10)
            {
                countS++;
                countSS = 0;
            }
            if (countS == 6)
            {
                countM++;
                countS = 0;
            }
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
            TxtMapDisplay.Text += Globals.BF.RedrawMap();
        }

        private void conFile_Opening(object sender, CancelEventArgs e)
        {
            ge.Load();
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ge.Load();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = MessageBox.Show("Would you like to save?",
            "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

            }

            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ge.Save();
        }
    }

    static class Globals
    {
        public static Map BF = new Map();
        public static GameEngine GE = new GameEngine();
    }
}
