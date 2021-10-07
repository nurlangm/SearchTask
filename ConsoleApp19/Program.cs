using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringnew1 = Console.ReadLine();
            string stringnew2 = Console.ReadLine();
            Console.WriteLine(stringnew1.Search(stringnew2));
        }
    }
    static class Extension
    {   
        public static bool Search(this string str, string letter)
        {
            int let=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToLower() == letter[0].ToString().ToLower())
                {
                    for (int n = i + 1, m = 1; n < letter.Length; n++, m++)
                    {
                        if (str[n].ToString().ToLower() == letter[m].ToString().ToLower())
                        {
                            let++;
                        }
                    }
                }
            }
            if (let == letter.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
}