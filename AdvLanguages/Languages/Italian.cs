using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvLanguages.Languages
{
    internal class Italian : LanguageBase
    {
        public override void SayBye()
        {
            Console.WriteLine("Arriverderci!");
        }

        public override void SayHi()
        {
            Console.WriteLine("Ciao!");
        }
    }
}
