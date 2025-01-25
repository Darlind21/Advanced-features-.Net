using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvLanguages.Languages
{
    internal class Albanian : LanguageBase
    {
        public override void SayBye()
        {
            Console.WriteLine("Mirupafshim");
        }

        public override void SayHi()
        {
            Console.WriteLine("Pershendetje!");
        }
    }
}
