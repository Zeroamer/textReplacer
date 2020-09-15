using System;
using System.Reflection.Metadata.Ecma335;

namespace textReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my word replacer!");

            Console.Write("What's the sentence you want to replacify?: ");
            string text = Console.ReadLine();
            Console.Write("Tell me what you want to replace: ");
            string replacedText = Console.ReadLine().ToLower();
            Console.Write("Tell me the what you want to replace it with: ");
            string replacerText = Console.ReadLine();

            Console.WriteLine(text.Replace(replacedText, replacerText));    
        }
    }
}
