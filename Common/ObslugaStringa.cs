using System;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (Char.IsUpper(litera))
                        wynik += " ";
                    wynik += litera;
                }
            }
            return wynik;
        }
    }
}
