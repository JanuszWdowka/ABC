using System;

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

        /// <summary>
        /// Pobierz jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisujemy bierzące zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

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
