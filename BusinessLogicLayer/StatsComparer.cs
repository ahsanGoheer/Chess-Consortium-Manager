using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class StatsComparer:IComparer
    {
        public int Compare(object x,object y)
        {
            PlayerStats _x = (PlayerStats)x;
            PlayerStats _y = (PlayerStats)y;
            return _x.TotalGamesWon.CompareTo(_y.TotalGamesWon);
        }
    }
}
