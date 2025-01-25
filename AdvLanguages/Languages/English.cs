using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvLanguages.Languages
{
    internal class English : LanguageBase
    {
        public override void SayBye()
        {
            Console.WriteLine("Goodbye!");
        }

        public override void SayHi()
        {
            Console.WriteLine("Hello!");
        }
    }
}
