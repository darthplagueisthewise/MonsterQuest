using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ReflectionTest
{
    public enum Members
    {
        Tiffany = 1,
        Seohyun = 2,
        Sooyoung = 3, 
        Sunny = 4,
        Taeyeon = 5,
        Yuri = 6,
        Hyoyeon = 7
    }

    class Program
    {
        public static int gInt;

        static string ReadFromFile(string o)
        {
            try
            {
                return File.ReadAllText(o);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(string);
            }
        }

        static void CharacterOccurences(string str, char c)
        {

            if (str != null)
            {
                Console.WriteLine("Number of \'{0}\'s: {1}", Char.ToUpper(c), (from s in str
                                                                               where s == Char.ToLower(c) || s == Char.ToUpper(c)
                                                                               select s).Count()
                                                                               );
            }
        }

        static int Calc(int[] Nums)
        {
            return Nums.Where(i => i % 2 == 0).Sum();
        }

        static void ParameterType(ref int Var)
        {
            Console.WriteLine(Var == gInt);
        }


        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7, 13, 14 };
            string fileName = "sample.txt";
            

            var Farkle = (from Var in numbers where Var % 2 == 0 select Var).FirstOrDefault();
            Console.WriteLine(Farkle);
            Console.WriteLine(Calc(numbers));

            double test = (double)numbers.First();

            string reall = ReadFromFile(fileName);
            Console.WriteLine(reall);

            Console.Write("Enter the character you want to find: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            CharacterOccurences(reall, ch);

           
            Console.WriteLine(Members.Seohyun);

            ParameterType(ref gInt);
            
            Console.ReadKey();
        }

    }
}
