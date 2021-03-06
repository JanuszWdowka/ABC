﻿using Common;
using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
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
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;
            return poprawne;
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

        public string Log()
        {
            var logTekst = ZamowienieId + ": " +
                           "Data: " + DataZamowienia.Value.Date + " " +
                           "Status: " + StanObiektu.ToString();

            return logTekst;
        }
    }
}
