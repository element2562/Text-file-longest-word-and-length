using System;
using System.Linq;
using System.IO;
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
            ////////////////////////////////////////////////////////////////////////////////////////////
            string path = @"C:\Users\Jacob\workspace\dad's exercises\2\textfile.txt";
            int chunkSize = 1024;
            using (var file = File.OpenRead(path))
            {
                int offset = 0;
                int bytesRead;
                var Buffer = new Byte[chunkSize];
                while((bytesRead = file.Read(Buffer, offset, Buffer.Length)) > 0)
                {
                    offset += bytesRead;
                    string newText = Buffer.ToString();
                    var newSplitText = newText.Split(" ");
                    string newLongWord = "";
                    int newMaxLetters;
                    newMaxLetters = newSplitText.Max(y => y.Length);
                    //for(int i = 0; i < splitText.Length; i++)
                    //{
                    //    if(splitText[i].Length == maxLetters)
                    //    {
                    //        longWord = splitText[i];
                    //    }
                    //}
                    newLongWord = newSplitText.Where(y => y.Length == maxLetters).FirstOrDefault();

                    Console.WriteLine($"{newMaxLetters}, {newLongWord}");
                }

            }

        }
    }
}
