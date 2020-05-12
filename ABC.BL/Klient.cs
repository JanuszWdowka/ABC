using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient
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
    }
}
