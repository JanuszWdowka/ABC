using System;

namespace ABC.BL
{
    public class Produkt
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; } //Decima? rozróznia 0 od nulla
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }

        /// <summary>
        /// Pobierz jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            return new Produkt();
        }

        /// <summary>
        /// Zapisujemy bierzący produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            return poprawne;
        }
    }
}
