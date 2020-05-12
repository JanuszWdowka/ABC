﻿using System;

namespace ABC.BL
{
    public class Produkt : KlasaBazowa
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
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            return poprawne;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
