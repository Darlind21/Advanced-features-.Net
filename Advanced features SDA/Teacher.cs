using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_features_SDA
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }

        //day 2 excercises for adv features
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
    }
}
