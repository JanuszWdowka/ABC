﻿using System;

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
            Object mojObiekt = new Object();
            Console.WriteLine("Objekt: " + mojObiekt.ToString());

            if (produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki do zabawy dla dzieci powyżej 3 lat";
                produkt.AktualnaCena = 199.99M;
            }

            Console.WriteLine("Produkt: " + produkt.ToString());


            return produkt;
        }

        /// <summary>
        /// Zapisujemy bierzący produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            var sukces = true;
            if(produkt.MaZmiany && produkt.DaneSaPrawidlowe)
            {
                if (produkt.JestNowy)
                {
                    //wywołuje inserta
                }
                else
                {
                    //robi update
                }

            }
            return sukces;
        }
    }
}
