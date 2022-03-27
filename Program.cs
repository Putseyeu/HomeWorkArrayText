using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArrayText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В прошлом посте мы делали условия на основе иерархии типов";
            string[] textArray = text.Split(' ');

            foreach (var word in textArray)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
