using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_features_SDA
{
    internal class Person
    {
        //deklarim i konstruktorit-- e zem sikur esht nje konstruktor me posht

        //nqs deklarojm ne nj konstrk konstruktori default qe cdo klas trashgon nga system.object nuk esht me i vlefshem
        //kur kemi inicaializuar konstruktor me paramentra cdo klase qe trashegon nga klasa person do therrasi konstruktorin 
        //e klases prind ne fillim  sepse klasa prind inicializohet e para e me pas femijet me " : base " 
        //shiko slide 13 

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public char Gender { get; set; }


        //property e re q kombinon name dhe surnamee e t jet vetem get
        public string FullName
        {
            get
            {
                string fullname = $"{Name} {Surname}";
                return fullname ;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthday.Year;

                if ( DateTime.Now.Month >= Birthday.Month && DateTime.Now.Day >= Birthday.Day )
                {

                }
                else
                {
                    age--;
                }
                return age;
            }
        }

        //day 2 excercises for adv features
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
