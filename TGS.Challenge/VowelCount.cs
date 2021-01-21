using System;
using System.Linq;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        private char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

        public int Count(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("You must add a value to count the vowels");
            }

            return value.ToLower().Count(c => vowels.Contains(c));
        }
    }
}
