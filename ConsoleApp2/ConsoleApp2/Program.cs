using System;
using System.Linq;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Jacob\workspace\dad's exercises\2\textfile.txt");
            var splitText = text.Split(" ");
            string longWord = "";
            int maxLetters;
            maxLetters = splitText.Max(y => y.Length);
            //for(int i = 0; i < splitText.Length; i++)
            //{
            //    if(splitText[i].Length == maxLetters)
            //    {
            //        longWord = splitText[i];
            //    }
            //}
            longWord = splitText.Where(y => y.Length == maxLetters).FirstOrDefault();
            
            Console.WriteLine($"{maxLetters}, {longWord}");
            

        }
    }
}
