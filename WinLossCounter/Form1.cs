using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLossCounter
{
    public partial class FormCounter : System.Windows.Forms.Form
    {
        WinLossCounter counter1;
        public FormCounter()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            counter1 = new WinLossCounter("max");
            UpdateDisplays();
            objectPositions();
        }

        private void winBtn_Click(object sender, EventArgs e)
        {
            counter1.AddWin();
            UpdateDisplays();
        }

        private void lossBtn_Click(object sender, EventArgs e)
        {
            counter1.AddLoss();
            UpdateDisplays();
        }

        private void removeWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter1.RemoveWin();
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            winCount.Text = counter1.Wins.ToString();
            lossCount.Text = counter1.Losses.ToString();
            winPercent.Text = $"{counter1.WinPercent:N2} %";
            if (counter1.Wins > counter1.Losses)
            {
                BackColor = Color.LightGreen;
            }
            else if (counter1.Wins == counter1.Losses)
            {
                BackColor = Color.LightYellow;
            }
            else
            {
                BackColor = Color.IndianRed;
            }
        }

        private void removeLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter1.RemoveLoss();
            UpdateDisplays();
        }

        private void addWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter1.AddWin();
            UpdateDisplays();
        }

        private void addLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter1.AddLoss();
            UpdateDisplays();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            objectPositions();
        }

        private void objectPositions()
        {
            winCountPosition();
            lossCountPosition();
            winBtnPosition();
            lossBtnPosition();
            winPercentPosition();
        }

        private void winCountPosition()
        {
            Point position = new Point(0, 40);
            winCount.Location = position;
            winCount.Width = ClientSize.Width / 2;
            winCount.Height = ClientSize.Height / 4 * 3;
            if (winCount.Height > 1)
            {
                Font fontchanged = new Font("Microsoft Sans Serif", winCount.Height / 2);
                winCount.Font = fontchanged;
            }
        }

        private void lossCountPosition()
        {
            Point position = new Point(ClientSize.Width - ClientSize.Width / 2, 40);
            lossCount.Location = position;
            lossCount.Width = ClientSize.Width / 2;
            lossCount.Height = ClientSize.Height / 4 * 3;
            if (winCount.Height > 1)
            {
                Font fontchanged = new Font("Microsoft Sans Serif", winCount.Height / 2);
                lossCount.Font = fontchanged;
            }
        }

        private void winBtnPosition()
        {
            Point position = new Point(0, winCount.Height);
            winBtn.Location = position;
            winBtn.Width = ClientSize.Width / 2;
            winBtn.Height = ClientSize.Height / 4 * 1;
            if (winCount.Height > 1)
            {
                Font fontchanged = new Font("Microsoft Sans Serif", winBtn.Height / 2);
                winBtn.Font = fontchanged;
            }
        }

        private void lossBtnPosition()
        {
            Point position = new Point(ClientSize.Width - ClientSize.Width / 2, winCount.Height);
            lossBtn.Location = position;
            lossBtn.Width = ClientSize.Width / 2;
            lossBtn.Height = ClientSize.Height / 4 * 1;
            if (winCount.Height > 1)
            {
                Font fontchanged = new Font("Microsoft Sans Serif", winBtn.Height / 2);
                lossBtn.Font = fontchanged;
            }
        }

        private void winPercentPosition()
        {
            Point position = new Point(ClientSize.Width / 2- winPercent.Width / 2, 40);
            winPercent.Location = position;
            winPercent.Width = ClientSize.Width / 2;
            winPercent.Height = ClientSize.Height / 4 * 3;
            if (winPercent.Height > 1)
            {
                Font fontchanged = new Font("Microsoft Sans Serif", 20);
                winPercent.Font = fontchanged;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter1.ResetCounter();
            UpdateDisplays();
        }
    }
}
