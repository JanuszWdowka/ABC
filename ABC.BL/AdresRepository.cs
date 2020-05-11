using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    class AdresRepository
    {
        /// <summary>
        /// Pobiera jeden adres
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            Adres adres = new Adres(adresId);

            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
            }

            return adres;
        }

        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Goscina",
                Miasto = "Katowice",
                KodPocztowy = "40-476",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            adres = new Adres(1)
            {
                AdresTyp = 2,
                Ulica = "Kosmiczna",
                Miasto = "Krakow",
                KodPocztowy = "40-212",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            return adresList;
        }

        /// <summary>
        /// Zapisujemy aktualny adres
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
