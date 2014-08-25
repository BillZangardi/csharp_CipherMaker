using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherMidterm
{
    class Cipher
    {
        private static int letterShift;
        private char[] alphabetUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] alphabetLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public string EncryptWord(string enteredWord, string enteredShift)
        {
            bool result = Int32.TryParse(enteredShift, out letterShift);
            if (!result)
            {
                return "Invalid";
            }
            char[] word = enteredWord.ToCharArray();
            StringBuilder encryptedWord = new StringBuilder();
            int wordLength = enteredWord.Length;
            int currentIndex;
            int newIndex;
            char currentLetter;
            char newLetter;
            bool letterUpper = true;
            for (int i = 0; i < wordLength; i++)
            {
                currentLetter= word[i];
                letterUpper = true;
                currentIndex = Array.IndexOf(alphabetUpper, currentLetter);
                if (currentIndex == -1)
                {
                    currentIndex = Array.IndexOf(alphabetLower, currentLetter);
                    letterUpper = false;
                }
                if (currentIndex + letterShift > 26)
                {
                    newIndex=currentIndex + letterShift - 26;
                }
                else
                {
                    newIndex = currentIndex + letterShift;
                }
                if (letterUpper)
                {
                    newLetter = alphabetUpper[newIndex];
                    encryptedWord.Append(newLetter);
                }
                else
                {
                    newLetter = alphabetLower[newIndex];
                    encryptedWord.Append(newLetter);
                }

            }
            return encryptedWord.ToString();
        }

        public string DecryptWord(string enteredWord, string enteredShift)
        {
            bool result = Int32.TryParse(enteredShift, out letterShift);
            if (!result)
            {
                return "Invalid";
            }
            char[] word = enteredWord.ToCharArray();
            StringBuilder decryptedWord = new StringBuilder();
            int wordLength = enteredWord.Length;
            int currentIndex;
            int newIndex;
            char currentLetter;
            char newLetter;
            bool letterUpper = true;
            for (int i = 0; i < wordLength; i++)
            {
                currentLetter = word[i];
                currentIndex = Array.IndexOf(alphabetUpper, currentLetter);
                if (currentIndex == -1)
                {
                    currentIndex = Array.IndexOf(alphabetLower, currentLetter);
                    letterUpper = false;
                }
                if (currentIndex - letterShift < 0)
                {
                    newIndex = currentIndex - letterShift + 26;
                }
                else
                {
                    newIndex = currentIndex - letterShift;
                }
                if (letterUpper)
                {
                    newLetter = alphabetUpper[newIndex];
                    decryptedWord.Append(newLetter);
                }
                else
                {
                    newLetter = alphabetLower[newIndex];
                    decryptedWord.Append(newLetter);
                }

            }
            return decryptedWord.ToString();
        }

    }
}
