using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life1
{
    public class TheConwayBoard
    {
        public List<List<Cell>> Board { get; set; }

        public int PopulateBoard(int rows, int columns)
        {
            var board = new TheConwayBoard();
            board.Board = new List<List<Cell>>();
            int listCount = 0;
            for (int i = 0; i < columns; i++)
            {
                listCount++;
                board.Board.Add(new List<Cell>());
            }
            return listCount;
        }



    }
}
