using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobierz jedno pozycje zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// Zapisujemy bierzącą pozycje zamowienia
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
            if (Ilosc <= 0 || ProduktId <= 0 || CenaZakupu == null)
                poprawne = false;
            return poprawne;
        }
    }
}
