using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; } // ? oznacza że może być przypisana wartość null, ten typ stosuje do strefu czasowej
        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

        /// <summary>
        /// Sprawdza dane zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;
            return poprawne;
        }
    }
}
