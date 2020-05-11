namespace ABC.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobierz jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            Produkt produkt = new Produkt(produktId);

            if(produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki do zabawy dla dzieci powyżej 3 lat";
                produkt.AktualnaCena = 199.99M;
            }

            return produkt;
        }

        /// <summary>
        /// Zapisujemy bierzący produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}
