using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            RmvSpace(out text);
        }
        static void RmvSpace(out string text)
        {
            string name = "Made in Heaven";
            string newtext = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    continue;
                }
                newtext += name[i];
            }
            text = newtext;
            Console.WriteLine(text);
        }
    }
}