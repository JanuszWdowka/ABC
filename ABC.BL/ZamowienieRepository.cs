using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobierz jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if(zamowienieId == 10)
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            return zamowienie;
        }

        /// <summary>
        /// Wyswietla jedno zamowienei od wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWysiwetlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            //kod kotyry pobiera zdefiniowane pola zamowienia

            //tymaczowe dane zakodowane na stałe
            if(zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Marcin";
                wyswietlanieZamowienia.Nazwisko = "Nowak";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Kato",
                    KodPocztowy = "00-215",
                    Kraj = "Polska"
                };
            }

            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();
            //kod który pobiera elementy zamowienia

            //tymczasowe dane zakodane na stałe

            if(zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Krzeslo",
                    IloscZamowienia = 4,
                    CenaZakupu = 119.77M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Stolik",
                    IloscZamowienia = 7,
                    CenaZakupu = 249M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
            }

            return wyswietlanieZamowienia;
        }

        /// <summary>
        /// Zapisujemy bierzące zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}
