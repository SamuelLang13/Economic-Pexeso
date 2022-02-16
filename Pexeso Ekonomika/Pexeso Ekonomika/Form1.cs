using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pexeso_Ekonomika
{
    public partial class MainMenu : Form
    {
        private Game1 Game1;
        private Game2 Game2;
        private Game3 Game3;
        private Game4 Game4;
        private Game5 Game5;
        private Game6 Game6;
        private Game7 Game7;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game1 = new Game1();
            Game2 = new Game2();
            Game3 = new Game3();
            Game4 = new Game4();
            Game5 = new Game5();
            Game6 = new Game6();
            Game7 = new Game7();
        }

        private bool ButtonWasClicked = false;

        private void DropdownMenu_Click(object sender, EventArgs e)
        {
            DropdownMenu.Visible = false;
            DropupMenu.Visible = true;
            PanelShower.Visible = true;
            ButtonWasClicked = true;
        }

        private void DropupMenu_Click(object sender, EventArgs e)
        {
            DropupMenu.Visible = false;
            DropdownMenu.Visible = true;
            PanelShower.Visible = false;
            ButtonWasClicked = false;
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                        Tvorcovia hry:\n\n\n        * Radovan Dulák, Samuel Lang *", "Authors");
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("             Kontakt na autorov:\n\n\n               dulak@spse-po.sk\n                lang@spse-po.sk     ", "Kontakt");
        }

        private void CreateGame_Click(object sender, EventArgs e)
        {
            if (GameBtn1.Checked && ButtonWasClicked)
            {
                Hide();
                Game1.Show();
            }
            else if (GameBtn2.Checked && ButtonWasClicked)
            {
                Hide();
                Game2.Show();
            }
            else if (GameBtn3.Checked && ButtonWasClicked)
            {
                Hide();
                Game3.Show();
            }
            else if (GameBtn4.Checked && ButtonWasClicked)
            {
                Hide();
                Game4.Show();
            }
            else if (GameBtn5.Checked && ButtonWasClicked)
            {
                Hide();
                Game5.Show();
            }
            else if (GameBtn6.Checked && ButtonWasClicked)
            {
                Hide();
                Game6.Show();
            }
            else if (GameBtn7.Checked && ButtonWasClicked)
            {
                Hide();
                Game7.Show();
            }
        }

        private void ukončiťHruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Game1.Show();
        }

        private void hraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Game2.Show();
        }

        private void hraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            Game3.Show();
        }

        private void hospodárenieSPeniazmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Game4.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            Game5.Show();
        }

        private void sporenieAInvestovanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Game6.Show();
        }

        private void úverADlhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Game7.Show();
        }
    }
}
