using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConwaysGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_Cell()
        {
            var cell = new Cell();
            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void Cell_Is_Alive_When_Created()
        {
            var cell = new Cell();
            Assert.AreEqual(true,cell.CellIsAlive);
        }

        [TestMethod]
        public void Cell_Is_Revived_When_3_Neighbors()
        {
            var cell = new Cell();
            
            Assert.AreEqual(true, cell.Determine_Cell_IsAlive(3));
        }

        [TestMethod]
        public void Cell_Neighbors_Are_Created()
        {
            var cell = new Cell();
            cell.Neighbors = 3;
            Assert.AreEqual(3, cell.Neighbors);
        }
    }
}
