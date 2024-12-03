
using System.Text.RegularExpressions;

namespace Assignment5_2_4
{
    internal class Program
    {
        // Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
        static void Main(string[] args)
        {
            string word = "Radar";
            word = Regex.Replace(word, @"[^a-zA-Z]", "").ToLower();
            Console.WriteLine(CheckPalindromeRecursive(word));
        }

        static bool CheckPalindromeRecursive(string word)
        {
            // If length is 1 or empty it is a palindrome
            if (word.Length <= 1)
            {
                return true;
            }
            else
            {
                // If the first char and last char are Not the same it is not a palindrome
                if (word[0] != word[word.Length - 1])
                {
                    return false;
                }

                // Grab the substring index 1 to current word length - 2 index positions (Removes first and last char from the string)
                word = word.Substring(1, word.Length - 2);  

                return CheckPalindromeRecursive(word);
            }

        }
    }
}
