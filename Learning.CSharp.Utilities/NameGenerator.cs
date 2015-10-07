using System;
using System.Text;

namespace Learning.CSharp.Utilities
{
    public class NameGenerator
    {

        #region Private Variables.
        static readonly string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        static readonly string[] Vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        static readonly Random RandomObject = new Random();
        static readonly StringBuilder Name = new StringBuilder(100);
        #endregion

        #region Methods.
        public static string GenerateName(int length = 8)
        {
            GetNamePart(length/2);
            AddSpaceInName();
            GetNamePart(length/2);

            return Name.ToString();
        }

        private static void GetNamePart(int length)
        {
            GetFirstPart();
            GetRemainingName(length);
        }

        private static void GetRemainingName(int length)
        {
            var iCtr = 0;
            while (iCtr <= length)
            {
                Name.Append(GetConsonant());
                Name.Append(GetVowel());
                iCtr += 2;
            }
        }

        private static void GetFirstPart()
        {
            Name.Append(GetConsonant(true));
            Name.Append(GetVowel());
        }

        private static void AddSpaceInName()
        {
            Name.Append(" ");
        }
        #endregion

        #region Methods.
        private static string GetConsonant(bool isUpperCase = false)
        {
            var consonantsLength = Consonants.Length;
            return isUpperCase ? Consonants[RandomObject.Next(consonantsLength)].ToUpper() : Consonants[RandomObject.Next(consonantsLength)];
        }

        private static string GetVowel()
        {
            var vowelsLength = Vowels.Length;
            return Vowels[RandomObject.Next(vowelsLength)];
        }
        #endregion
    }
}