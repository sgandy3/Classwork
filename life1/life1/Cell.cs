using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life1
{
    public class Cell
    {
        public bool IsAlive { get; set; }

        public bool BringCellToLife(Cell cell)
        {
             return cell.IsAlive = true;
        }

        public bool KillCell (Cell cell)
        {
            return cell.IsAlive = false;
        }
    }
}
