using System;
using System.Text.RegularExpressions;

namespace AdvGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group<string>();
            group.Elements.Add("Monday");

            group.Print(group.Elements);


            var swapper = new Swapper<string>();
            swapper.Ana = "Ana";
            swapper.Andi = " Andi";

            swapper.Swap(swapper.Ana , swapper.Andi);

        }
    }
}



