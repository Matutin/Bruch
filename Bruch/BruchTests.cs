using System;
using System.Collections.Generic;
using System.Text;
using Bruchrechner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BruchProjekt
{
    [TestClass]
    class BruchTests
    {
        [TestMethod]

        public void BruchKuerzen_6_2_mit_Ergebnis_3_1()
        {

            //Arrange
            Bruch bruch = new Bruch(6, 2);

            //Act
            bruch.Kuerze();

            //Assert
            Assert.AreEqual(3, bruch.Zaehler);
            Assert.AreEqual(1, bruch.Nenner);
        }
    }
}
