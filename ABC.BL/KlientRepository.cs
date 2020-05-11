using System.Collections.Generic;
using System.Linq;

namespace ABC.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Pobiera jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();
            if(klientId == 1)
            {
                klient.Email = "marcindev@hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Nowak";
            }

            return klient;
        }

        /// <summary>
        /// pobiera wszystkich klientow
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }
    }
}
