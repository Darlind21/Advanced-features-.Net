using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvGenerics
{
    internal class Swapper<T>
    {
        public T? Ana {get; set;} 
        public T? Andi {get; set;}
        //E mira eshte tvendosim T? me ? nga mbrapa se n varesi t applikacionit vlera T merr defaultin e typit 
        //dhe mund te na prishi pun -- duhet kujdes i vecant


        public void Swap<T> (T Ana, T Andi)
        {
            T temp = Ana;
            Ana = Andi;
            Andi = temp;

            Console.WriteLine($"Ana tani eshte {Ana}, ndersa Andi tani eshte {Andi}");
        }
    }
}
