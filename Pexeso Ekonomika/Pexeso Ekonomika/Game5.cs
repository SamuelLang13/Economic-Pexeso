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
    public partial class Game5 : Form
    {
        public Game5()
        {
            InitializeComponent();
        }

        new Random Location = new Random();
        List<Point> points = new List<Point>();
        PictureBox PendingImage1;
        PictureBox PendingImage2;
        int WinCounter = 1;
        int x = 1;

        private MainMenu MainMenu;

        private void Game5_Load(object sender, EventArgs e)
        {
            MainMenu = new MainMenu();
            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources._5CardBack;
            }
            foreach (PictureBox picture in PanelCardShow.Controls)
            {
                picture.Image = null;
            }
            x = 1;
            WinCounter = 1;
        }

        private void nováHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game5_Load(sender, e);
        }

        private void hraťZnovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            MainMenu.Show();
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            Game5_Load(sender, e);
        }

        private void CloseGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CardsStay_Tick(object sender, EventArgs e)
        {
            CardsStay.Stop();
            PendingImage1.Image = Properties.Resources._5CardBack;
            PendingImage2.Image = Properties.Resources._5CardBack;
            PendingImage1.Enabled = true;
            PendingImage2.Enabled = true;
            PendingImage1 = null;
            PendingImage2 = null;
            CardHolder.Enabled = true;
        }

        private void CardsHide_Tick(object sender, EventArgs e)
        {
            CardsHide.Stop();
            if (x == 1)
            {
                CardShow1.Image = PendingImage1.Image;
                DupShow1.Image = PendingImage2.Image;
            }
            if (x == 2)
            {
                CardShow2.Image = PendingImage1.Image;
                DupShow2.Image = PendingImage2.Image;
            }
            if (x == 3)
            {
                CardShow3.Image = PendingImage1.Image;
                DupShow3.Image = PendingImage2.Image;
            }
            if (x == 4)
            {
                CardShow4.Image = PendingImage1.Image;
                DupShow4.Image = PendingImage2.Image;
            }
            if (x == 5)
            {
                CardShow5.Image = PendingImage1.Image;
                DupShow5.Image = PendingImage2.Image;
            }
            if (x == 6)
            {
                CardShow6.Image = PendingImage1.Image;
                DupShow6.Image = PendingImage2.Image;
            }
            if (x == 7)
            {
                CardShow7.Image = PendingImage1.Image;
                DupShow7.Image = PendingImage2.Image;
            }
            if (x == 8)
            {
                CardShow8.Image = PendingImage1.Image;
                DupShow8.Image = PendingImage2.Image;
            }
            if (x == 9)
            {
                CardShow9.Image = PendingImage1.Image;
                DupShow9.Image = PendingImage2.Image;
            }
            if (x == 10)
            {
                CardShow10.Image = PendingImage1.Image;
                DupShow10.Image = PendingImage2.Image;
            }
            if (x == 11)
            {
                CardShow11.Image = PendingImage1.Image;
                DupShow11.Image = PendingImage2.Image;
            }
            x++;
            PendingImage1.Image = Properties.Resources.CardHider1;
            PendingImage2.Image = Properties.Resources.CardHider1;
            PendingImage1 = null;
            PendingImage2 = null;
            CardHolder.Enabled = true;
            WinCounter++;
        }

        private void WinTimer_Tick(object sender, EventArgs e)
        {
            WinTimer.Stop();
            if (WinCounter == 11)
            {
                MessageBox.Show("               Úspešne si to zvládol.        ");
            }
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources._5Card1;
            if (Card1.Image != Properties.Resources._5CardBack) Card1.Enabled = false;
            else Card1.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card1;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card1;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            DupCard1.Image = Properties.Resources._5DupCard1;
            if (DupCard1.Image != Properties.Resources._5CardBack) DupCard1.Enabled = false;
            else DupCard1.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard1;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard1;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources._5Card2;
            if (Card2.Image != Properties.Resources._5CardBack) Card2.Enabled = false;
            else Card2.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card2;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card2;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources._5DupCard2;
            if (DupCard2.Image != Properties.Resources._5CardBack) DupCard2.Enabled = false;
            else DupCard2.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard2;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard2;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources._5Card3;
            if (Card1.Image != Properties.Resources._5CardBack) Card3.Enabled = false;
            else Card3.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card3;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card3;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources._5DupCard3;
            if (DupCard3.Image != Properties.Resources._5CardBack) DupCard3.Enabled = false;
            else DupCard3.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard3;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard3;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources._5Card4;
            if (Card4.Image != Properties.Resources._5CardBack) Card4.Enabled = false;
            else Card4.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card4;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card4;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources._5DupCard4;
            if (DupCard4.Image != Properties.Resources._5CardBack) DupCard4.Enabled = false;
            else DupCard4.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard4;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard4;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources._5Card5;
            if (Card5.Image != Properties.Resources._5CardBack) Card5.Enabled = false;
            else Card5.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card5;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card5;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources._5DupCard5;
            if (DupCard5.Image != Properties.Resources._5CardBack) DupCard5.Enabled = false;
            else DupCard5.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard5;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard5;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources._5Card6;
            if (Card6.Image != Properties.Resources._5CardBack) Card6.Enabled = false;
            else Card6.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card6;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card6;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources._5DupCard6;
            if (DupCard6.Image != Properties.Resources._5CardBack) DupCard6.Enabled = false;
            else DupCard6.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard6;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard6;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources._5Card7;
            if (Card7.Image != Properties.Resources._5CardBack) Card7.Enabled = false;
            else Card7.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card7;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card7;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources._5DupCard7;
            if (DupCard7.Image != Properties.Resources._5CardBack) DupCard7.Enabled = false;
            else DupCard7.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard7;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard7;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources._5Card8;
            if (Card8.Image != Properties.Resources._5CardBack) Card8.Enabled = false;
            else Card8.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card8;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card8;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources._5DupCard8;
            if (DupCard8.Image != Properties.Resources._5CardBack) DupCard8.Enabled = false;
            else DupCard8.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard8;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard8;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources._5Card9;
            if (Card9.Image != Properties.Resources._5CardBack) Card9.Enabled = false;
            else Card9.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card9;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card9;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            DupCard9.Image = Properties.Resources._5DupCard9;
            if (DupCard9.Image != Properties.Resources._5CardBack) DupCard9.Enabled = false;
            else DupCard9.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard9;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard9;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources._5Card10;
            if (Card10.Image != Properties.Resources._5CardBack) Card10.Enabled = false;
            else Card10.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card10;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card10;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard10_Click(object sender, EventArgs e)
        {
            DupCard10.Image = Properties.Resources._5DupCard10;
            if (DupCard10.Image != Properties.Resources._5CardBack) DupCard10.Enabled = false;
            else DupCard10.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard10;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard10;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources._5Card11;
            if (Card11.Image != Properties.Resources._5CardBack) Card11.Enabled = false;
            else Card11.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = Card11;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = Card11;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void DupCard11_Click(object sender, EventArgs e)
        {
            DupCard11.Image = Properties.Resources._5DupCard11;
            if (DupCard11.Image != Properties.Resources._5CardBack) DupCard11.Enabled = false;
            else DupCard11.Enabled = true;
            if (PendingImage1 == null) PendingImage1 = DupCard11;
            else if (PendingImage1 != null && PendingImage2 == null) PendingImage2 = DupCard11;
            if (PendingImage1 != null && PendingImage2 != null)
            {
                CardHolder.Enabled = false;
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    CardsHide.Start();
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    WinTimer.Start();
                }
                else
                {
                    CardsStay.Start();
                }
            }
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                        Tvorcovia hry:\n\n\n        * Radovan Dulák, Samuel Lang *", "Authors");
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("             Kontakt na autorov:\n\n\n               dulak@spse-po.sk\n                lang@spse-po.sk     ", "Kontakt");
        }
    }
}
