using System;
using System.Collections.Generic;

namespace Common
{
    public class UslugaLogowanie
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
