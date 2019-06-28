using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"text.txt", Encoding.Default);
            int maxLength = 0;
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                j++;
                if (i == text.Length - 1)
                {
                    if (maxLength < j)
                        maxLength = j;
                }
                if (text[i] == Convert.ToChar(" ") & (i != 0))
                {
                    if (maxLength < j)
                        maxLength = j - 1;
                    j = 0;
                }
            }
            j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                j++;
                if (i == text.Length - 1)
                    if (j == maxLength)
                    {
                        Console.WriteLine(text.Substring(i - j + 1, j));
                    }
                if (text[i] == Convert.ToChar(" "))
                {
                    if (j - 1 == maxLength)
                    {
                        Console.WriteLine(text.Substring(i - j + 1, j - 1));
                    }
                    j = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
