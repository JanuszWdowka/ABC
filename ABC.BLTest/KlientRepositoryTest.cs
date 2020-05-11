using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcindev@hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Nowak",
                ListaAdresow = new List<Adres>()
                {
                    new Adres(1)
                    {
                        AdresTyp = 1,
                        Ulica = "Goscina",
                        Miasto = "Katowice",
                        KodPocztowy = "40-476",
                        Kraj = "Polska"
                    },
                    new Adres(1)
                    {
                        AdresTyp = 2,
                        Ulica = "Kosmiczna",
                        Miasto = "Krakow",
                        KodPocztowy = "40-212",
                        Kraj = "Polska"
                    }
                }
            };

            var akutalna = klientRepository.Pobierz(1);

            Assert.AreEqual(oczekiwana.KlientId, akutalna.KlientId);
            Assert.AreEqual(oczekiwana.Email, akutalna.Email);
            Assert.AreEqual(oczekiwana.Imie, akutalna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, akutalna.Nazwisko);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, akutalna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, akutalna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, akutalna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, akutalna.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, akutalna.ListaAdresow[i].Kraj);
            }
        }
    }
}
