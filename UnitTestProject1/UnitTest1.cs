using Bruchrechner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BruchTests
    {
        [TestMethod]
        public void TestMethodKuerze()
        {
            //Arrange
            Bruch bruch = new Bruch(6, 2);

            //Act
            bruch.Kuerze();

            //Assert
            Assert.AreEqual(3, bruch.Zaehler);
            Assert.AreEqual(1, bruch.Nenner);
        }
        [TestMethod]
        public void TestMethodeMultipliziereMit()
        {
            //Arrange

            Bruch bruch1= new Bruch(6, 2);
            Bruch bruch2= new Bruch(3, 4);

            //Act
            var ergebnis = bruch1.MultipliziereMit(bruch2);

            //Asssert
            Assert.AreEqual(ergebnis.Zaehler, 18);
            Assert.AreEqual(ergebnis.Nenner, 8);
        }
        [TestMethod]
        public void TestMethodeDividiereMit()
        {
            //Arrange

            Bruch bruch1 = new Bruch(6, 2);
            Bruch bruch2 = new Bruch(3, 4);

            //Act
            var ergebnis = bruch1.DividiereMit(bruch2);

            //Assert
            Assert.AreEqual(ergebnis.Zaehler, 24);
            Assert.AreEqual(ergebnis.Nenner, 6);
        }
        [TestMethod]
        public void TestMethodeSubtrahiereMit()
        {
            //Arrange
            Bruch bruch1 = new Bruch(6, 2);
            Bruch bruch2 = new Bruch(3, 4);
            //Bruch bruch3 = new Bruch(2, 2);

            //Act
            var ergebnis = bruch1.SubtrahiereMit(bruch2);

            //Assert
            Assert.AreEqual(ergebnis.Zaehler, 18);
            Assert.AreEqual(ergebnis.Nenner, 8);
        }
    }
}
