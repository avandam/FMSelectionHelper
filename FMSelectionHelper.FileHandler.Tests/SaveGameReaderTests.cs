using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
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
            Assert.AreEqual(14, players[0].Attributes.First(attribute => attribute.Key.Abbreviation == "Wor").Value);
        }

        [TestMethod()]
        public void ParseFile2Test()
        {
            SaveGameReader saveGameReader = new SaveGameReader();
            List<Player> players = saveGameReader.ParseFile("test2.rtf");

            Assert.AreEqual(26, players.Count);
            Assert.AreEqual(-1, players[0].ContractEndYear);
            Assert.AreEqual(3, players[0].Attributes.First(attribute => attribute.Key.Abbreviation == "Wor").Value);
        }

        [TestMethod]
        public void ParsePositionsGkTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("GK");

            Assert.AreEqual(1, positions.Count);
            Assert.AreEqual(PositionType.GK, positions[0].PositionType);
        }

        [TestMethod]
        public void ParsePositionsDwbrlTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("D/WB (RL)");

            Assert.AreEqual(4, positions.Count);
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DL));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DR));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.WBL));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.WBR));
        }

        [TestMethod]
        public void ParsePositionsDcDmMcTest()
        {
            SaveGameReader reader = new SaveGameReader();
            List<Position> positions = reader.ParsePositions("D (C), DM, M (C)");

            Assert.AreEqual(7, positions.Count);
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DC));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DCR));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DCL));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.DM));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.MC));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.MCR));
            Assert.IsTrue(positions.Any(position => position.PositionType == PositionType.MCL));
        }

    }
}
