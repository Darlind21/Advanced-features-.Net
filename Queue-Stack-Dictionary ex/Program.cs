using System;
namespace Queue_Stack_Dictinary_ex
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void GetDigits()
        {
            Console.WriteLine("Vendosni nje nr qe doni ta ndani sipas cdo digit");
            int input = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            while (input > 0)
            {
                stack.Push(input % 10);
                input = input / 10;
            }

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }

        static string sentence = "Write whatever you want here if you want to do it here";

        List<string> words = sentence.Split(' ').ToList(); //ToList- e konverton arrrayn ne liste sepse spliti() e ndan ne array

            bool FindWord (string word)
            {
                bool found = false;
                foreach (string element in words)
                {
                    if (string.Equals(element, word, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }
                return found;
            }

            void PrintWords(List <string> words)
            {
                foreach (string element in words)
                {
                    Console.WriteLine(element);
                }
            }

        List<string> OrderWords(List<string> words, string direction)
        {
            var list = new List<string>();
            foreach (var element in words)
            {
                list.Add(element);
            }
            if (direction == "asc")
            {
                list.Sort();
            }
            else if (direction == "desc")
            {
                list.Sort();
                list.Reverse();
            }
            return list;
        }

        Dictionary<string, int> CreateDictionary(List<string> words)// krijon dictionary dhe numron sa her eshte nje fjal ne te
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                bool success = dictionary.TryAdd(word, 1);
                //.Add dhe TryAdd--- Add nqs ne vendosim 2 her t njejtin key
                //gjeneron exception
                //Tryadd ben njeher verifikim dhe nqs ekziston e shton 

                if (!success)
                {
                    dictionary[word]++;
                    //[word] ne kete rast celesi pra word na sherben si index dhe me shprehjen n line72
                    //shtojme valuen pra sa her eshte perseritur ajo fjal 
                }
            }
            return dictionary;


        }
    }
}