using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201561041
{
    internal class Team
    {
        public string Coach { get; set; }
        private int players;
        public int Players
        {
            get { return players; }
            set
            {
                if (value >= 11 && value <= 22)
                {
                    players = value;
                }                
                else { throw new Exception("Моля въведете стойност между 11 и 22 "); }
            }
        }

        public int AvgAge { get; set; }
    }
}
