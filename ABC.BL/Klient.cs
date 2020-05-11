using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient
    {
        public Klient()
        {

        }
        public Klient(int klientId)
        {
            KlientId = klientId;
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

        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko) || string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }
        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns>Zwraca true jeżeli zapisało lub false jeśli się to nie udało</returns>
        public bool Zapisz()
        {
            return true;
        }

        public Klient Pobierz(int klientId)
        {
            return new Klient();
        }

        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }
    }
}
