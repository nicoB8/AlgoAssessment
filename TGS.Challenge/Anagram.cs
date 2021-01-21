using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            bool areAnagrams = true;

            ClearWord(ref word1);
            ClearWord(ref word2);

            if(word1.Length == word2.Length)
            {
                var processedChars = new List<char>();
                var charArray = word1.ToCharArray();
                var i = 0;
                while(i < charArray.Length && areAnagrams)
                {
                    var currentChar = charArray[i];
                    if (!processedChars.Contains(currentChar))
                    {
                        var charCountInWord1 = word1.Count(letter => letter == currentChar);
                        var charCountInWord2 = word2.Count(letter => letter == currentChar);

                        if (charCountInWord1 != charCountInWord2)
                            areAnagrams = false;

                        processedChars.Add(currentChar);
                    }

                    i++;
                }
            } else
            {
                areAnagrams = false;
            }

            return areAnagrams;
        }

        private void ClearWord(ref string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new System.ArgumentException("Word is required");
            }

            word = word.Trim();

            var sb = new StringBuilder();
            foreach (char c in word)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            word = sb.ToString().ToLower();
        }
    }
}
