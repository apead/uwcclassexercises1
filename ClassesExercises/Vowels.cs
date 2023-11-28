using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    internal class Vowels
    {
        private static bool IsAVowel(char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int index = 0; index < vowels.Length; index++)
            {
                if (letter == vowels[index])
                {
                    return true;
                }
            }

            return false;
        }


        public static string RemoveAllTheVowels(string letters)
        {
            string returnString = "";

            for (int index = 0; index < letters.Length; index++)
            {
                char letter = letters[index];
                bool vowel = IsAVowel(letter);

                if (!vowel)
                {
                    returnString += letter;
                }


            }

            return returnString;
        }



    }
}
