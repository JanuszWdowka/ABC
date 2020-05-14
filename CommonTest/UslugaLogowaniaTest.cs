using System;
using System.Collections.Generic;
using ABC.BL;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowaniaTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            var zmienioneElementy = new List<ILogowanie>();

            var klinet = new Klient(1)
            {
                Email = "admin@dev.pl",
                Imie = "Mariusz",
                Nazwisko = "Kowal",
                ListaAdresow = null
            };
            zmienioneElementy.Add(klinet as ILogowanie);

            var produkt = new Produkt(2)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki do zabawy",
                AktualnaCena = 120M
            };
            zmienioneElementy.Add(produkt as ILogowanie);

            var zamownie = new Zamowienie(3)
            {
                DataZamowienia = new DateTime(2018, 9, 21)
            };
            zmienioneElementy.Add(zamownie as ILogowanie);
            //act

            UslugaLogowanie.PiszDoPliku(zmienioneElementy);
        }
    }
}
