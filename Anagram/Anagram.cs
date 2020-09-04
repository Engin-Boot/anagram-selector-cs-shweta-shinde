using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            //Insert the correct implementation here
            char[] word1_array = word1.ToLower().ToCharArray();
            char[] word2_array = word2.ToLower().ToCharArray();
            Array.Sort(word1_array);
            Array.Sort(word2_array);
            string sortedWord1 = new string(word1_array);
            string sortedWord2 = new string(word2_array);
            if (sortedWord1 == sortedWord2)
                return true;
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here

            List<string> SelectedCandidates = new List<string>();
            foreach(string candidate in candidates)
            {
                if (WordPairIsAnagram(word, candidate))
                    SelectedCandidates.Add(candidate);
            }


            return SelectedCandidates;
        }
    }
}
