using System;
using System.Security;

namespace Lets_Code_Somethings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            bool isPalindrom = true;
  
            word = Console.ReadLine().Replace(" ", string.Empty).ToLower();  
            for(int i =0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrom= false;
                    break;
                }
            }
            if(isPalindrom)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
        }
    }
}