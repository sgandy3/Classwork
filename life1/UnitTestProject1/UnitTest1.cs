using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using life1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanCreateBoard()
        {
            var Board = new TheConwayBoard();
            Assert.IsNotNull(Board);
        }

        [TestMethod]
        public void CanCreateCell()
        {
            var cell = new Cell();
            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void CanDictateBoardSize()
        {
            var board = new TheConwayBoard();
            
            var listCount = board.PopulateBoard(10, 10);

            Assert.AreEqual(10, listCount);
        }

        [TestMethod]
        public void CanCheckIfCellIsAlive()
        {
            var cell = new Cell();

            cell.IsAlive = cell.BringCellToLife(cell);

            Assert.AreEqual(cell.IsAlive, true);
        }

        [TestMethod]
        public void CanCheckIfCellIsDead()
        {
            var cell = new Cell();

            cell.IsAlive = cell.KillCell(cell);

            Assert.AreEqual(cell.IsAlive, false);
        }

    }
}
