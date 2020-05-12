using System;
using System.Collections.Generic;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienie()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            var aktualna = zamowienieRepository.Pobierz(10);

            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietlenia()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Marcin",
                Nazwisko = "Nowak",
                DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Kato",
                    KodPocztowy = "00-215",
                    Kraj = "Polska"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzeslo",
                        IloscZamowienia = 4,
                        CenaZakupu = 119.77M
                    },
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stolik",
                        IloscZamowienia = 7,
                        CenaZakupu = 249M
                    }
                }
            };

            var aktualna = zamowienieRepository.PobierzZamowienieDoWysiwetlenia(10);

            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia, aktualna.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);
            }

        }
    }
}
