using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsSim
{
    internal class StatsList
    {
        private string _stat;
        private int _num;
        
        public string Stat 
        { 
            get { return _stat; } 
            set { _stat = value; }
        }

        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }
    }
}
