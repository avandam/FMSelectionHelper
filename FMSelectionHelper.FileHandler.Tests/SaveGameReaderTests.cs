using Microsoft.VisualStudio.TestTools.UnitTesting;
using FMSelectionHelper.FileHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSelectionHelper.Infra;
using FMSelectionHelper.Models;

namespace FMSelectionHelper.FileHandler.Tests
{
    [TestClass()]
    public class SaveGameReaderTests
    {
        [TestMethod()]
        public void ParseFileTest()
        {
            SaveGameReader saveGameReader = new SaveGameReader();
            List<Player> players = saveGameReader.ParseFile("test.rtf");

            Assert.AreEqual(99, players.Count);
        }

        [TestMethod]
        public void ParsePositionsGkTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("GK");

            Assert.AreEqual(1, positions.Count);
            Assert.AreEqual(Position.GK, positions[0]);
        }

        [TestMethod]
        public void ParsePositionsDWBRLTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("D/WB (RL)");

            Assert.AreEqual(4, positions.Count);
            CollectionAssert.Contains(positions, Position.DL);
            CollectionAssert.Contains(positions, Position.DR);
            CollectionAssert.Contains(positions, Position.WBL);
            CollectionAssert.Contains(positions, Position.WBR);
        }

        [TestMethod]
        public void ParsePositionsDcDMMcTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("D (C), DM, M (C)");

            Assert.AreEqual(3, positions.Count);
            CollectionAssert.Contains(positions, Position.DC);
            CollectionAssert.Contains(positions, Position.DM);
            CollectionAssert.Contains(positions, Position.MC);
        }

    }
}
