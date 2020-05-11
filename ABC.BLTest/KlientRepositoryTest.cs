using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcindev@hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Nowak"
            };

            var akutalna = klientRepository.Pobierz(1);

            Assert.AreEqual(oczekiwana.KlientId, akutalna.KlientId);
            Assert.AreEqual(oczekiwana.Email, akutalna.Email);
            Assert.AreEqual(oczekiwana.Imie, akutalna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, akutalna.Nazwisko);
        }
    }
}
