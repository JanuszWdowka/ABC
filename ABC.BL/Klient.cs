﻿using Common;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        public Klient() : this(0)
        {
        }
        public Klient(int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }

        public static int Licznik { get; set; }
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }
        public string Imie { get; set; }
        public string Email { get; set; }
        public int KlientId { get; private set; }
        public List<Adres> ListaAdresow { get; set; }
        public int KlientTyp { get; set; }
        public string ImieNazwisko
        {
            get
            {
                string ImieNazwisko = Imie;
                if(!string.IsNullOrWhiteSpace(Nazwisko) && !string.IsNullOrWhiteSpace(ImieNazwisko))
                {
                    ImieNazwisko += ", ";
                }
                ImieNazwisko += Nazwisko;
                return ImieNazwisko;
            }
        }

        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko) || string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }

        public string Log()
        {
            var logTekst = KlientId + ": " + 
                           ImieNazwisko + " " + 
                           "Email: " + Email + " " + 
                           "Status: " + StanObiektu.ToString();

            return logTekst;
        }
    }
}
