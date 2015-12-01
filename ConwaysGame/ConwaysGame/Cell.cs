using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame
{
    public class Cell
    {
        public bool CellIsAlive
        {
            get; set;
        }

        public Cell()
        {
            CellIsAlive = true;
        }
       
        public int Neighbors { get; set; }

        public bool Determine_Cell_IsAlive(int Neighbors)
        {
            if (Neighbors == 3)
            {
                return true;
            }
            return false;
        }
    }

}
