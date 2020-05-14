using System;
using System.Collections.Generic;

namespace Common
{
    public class UlsugaLogowanie
    {
        public static void PiszDoPliku(List<ILogowanie> ZmienioneElementy)
        {
            foreach (var element in ZmienioneElementy)
            {
                Console.WriteLine(element.Log());
            }
        }
    }
}
