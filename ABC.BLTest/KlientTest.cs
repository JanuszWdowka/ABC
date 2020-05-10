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

        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            //arrange (zaranżuj test)
            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";
            //act (działak)
            string aktualna = klient.ImieNazwisko;
            //assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        
        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste()
        {
            //arrange (zaranżuj test)
            var klient = new Klient();
            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";
            //act (działak)
            string aktualna = klient.ImieNazwisko;
            //assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            //arrange (zaranżuj test)
            var klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Licznik += 1;

            var klient2 = new Klient();
            klient2.Imie = "Jacek";
            Klient.Licznik += 1;

            var klient3 = new Klient();
            klient3.Imie = "Marek";
            Klient.Licznik += 1;

            Assert.AreEqual(3, Klient.Licznik);
        }

        [TestMethod]
        public void ZwalidujTest()
        {
            var klient = new Klient();

            klient.Nazwisko = "Nowak";
            klient.Email = "tomek@dev.hobby.pl";

            Assert.AreEqual(true, klient.Zwaliduj());
        }

        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            var klient = new Klient();

            klient.Email = "tomek@dev.hobby.pl";

            Assert.AreEqual(false, klient.Zwaliduj());
        }
    }
}
