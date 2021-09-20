using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1CSharpAndUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1CSharpAndUnitTests.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _footballPlayer;

        [TestInitialize]
        public void SetupFootballPlayer()
        {
            _footballPlayer = new FootballPlayer(1, "Deshawn", 100, 69);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Deshawn", _footballPlayer.Name);
            _footballPlayer.Name = "Jimmy-John";
            Assert.AreEqual("Jimmy-John", _footballPlayer.Name);

            try
            {
                _footballPlayer.Name = "Til";
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Name must be 4 characters or longer", ex.Message);
            }
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(100, _footballPlayer.Price);
            _footballPlayer.Price = 250;
            Assert.AreEqual(250, _footballPlayer.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPriceException()
        {
            _footballPlayer.Price = -250;
        }

        [TestMethod]
        public void TestShirtNumber()
        {
            Assert.AreEqual(69, _footballPlayer.ShirtNumber);
            _footballPlayer.ShirtNumber = 42;
            Assert.AreEqual(42, _footballPlayer.ShirtNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShirtNumberException()
        {
            _footballPlayer.ShirtNumber = 125;
        }
    }
}