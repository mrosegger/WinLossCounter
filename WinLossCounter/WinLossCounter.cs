using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLossCounter
{
    class WinLossCounter
    {
        //Fields
        int wins = 0;
        int losses = 0;
        string name;

        //Consturctor
        public WinLossCounter(string name)
        {
            if (name != "")
            {
                this.name = name;
            }
        }

        //Properties
        public int Wins
        {
            get
            {
                return wins;
            }
        }

        public int Losses
        {
            get
            {
                return losses;
            }
        }

        public double WinPercent
        {
            get
            {
                if (losses > 0)
                {
                    return (double)wins / (losses + wins) * 100;
                }
                else if (wins > 0)
                {
                    return 100;
                }
                else
                {
                    return 0;
                }
            }
        }

        //Methods
        public void AddWin()
        {
            wins++;
        }

        public void AddLoss()
        {
            losses++;
        }

        public void RemoveWin()
        {
            if (wins > 0)
            {
                wins--;
            }
        }

        public void RemoveLoss()
        {
            if (losses > 0)
            {
                losses--;
            }
        }

    }
}
