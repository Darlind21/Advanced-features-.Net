using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvGenerics
{
    internal class Group<T>
    {
        public  int Count { get; set; }
        public List<T> Elements { get; set; } = new List<T>();
        // <T> i thot compilerit qe eshte nje list me dicka cfaredo
        // <T> eshte pakashum si placeholder kur nuk e dim me ca type do punojm 
        //Klasa queht generic qe ka nevoj per nje type

        public void Print (List<T> list)
        {
            foreach (T element in list)
            {
                Console.WriteLine ($"Elementet ne listen Elements jane: {element}");
            }
        }
    }
}
