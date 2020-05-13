using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";

            var aktualna = zrodlo.WstawSpacje();

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            var zrodlo = "Klocki Lego";
            var oczekiwana = "Klocki Lego";

            var aktualna = zrodlo.WstawSpacje();

            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
