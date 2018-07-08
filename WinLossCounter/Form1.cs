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
    public partial class Form : System.Windows.Forms.Form
    {
        WinLossCounter counter1;
        public Form()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            counter1 = new WinLossCounter("max");
            UpdateDisplays();
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
            winPercent.Text = $"{counter1.WinPercent} %";
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
            winCount.Width = ClientSize.Width / 2;
            winBtn.Width = ClientSize.Width / 2;
        }
    }
}
