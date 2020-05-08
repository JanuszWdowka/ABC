using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //arrange (zaranżuj test)
            var klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";
            //act (działak)
            string aktualna = klient.ImieNazwisko;
            //assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
