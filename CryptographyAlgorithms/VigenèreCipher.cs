using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class VigenèreCipher
    {
        public static String Encryption(String original, string key)
        {
            
            StringBuilder enc = new StringBuilder();
            int keyIndx= 0;
            foreach (var ch in original)
            {
                if (!char.IsLetter(ch))
                    enc.Append(ch);
                else 
                {
                    char firstOr = char.IsUpper(ch) ? 'A' : 'a';
                    char firstKe = char.IsUpper(key[keyIndx]) ? 'A' : 'a';

                    int indx = ch - firstOr;
                    int shift = key[keyIndx] - firstKe;

                    int nextIndx = (indx + shift) % 26;

                    keyIndx = (keyIndx + 1) % key.Length;

                    enc.Append((char)(nextIndx + firstOr));
                }
            }
            return enc.ToString();
        }

        public static string Decryption(String encrypted, string key)
        {

            StringBuilder orig = new StringBuilder();
            int keyIndx = 0;

            foreach (var ch in encrypted)
            {
                if (!char.IsLetter(ch))
                    orig.Append(ch);
                else
                {
                    char firstOr = char.IsUpper(ch) ? 'A' : 'a';
                    char firstKe = char.IsUpper(key[keyIndx]) ? 'A' : 'a';

                    int indx = ch - firstOr;

                    int shift = key[keyIndx] - firstKe;

                    int prvIndx = (indx - shift);

                    while (prvIndx<0)
                    {
                        prvIndx += 26;
                    }

                    keyIndx = (keyIndx + 1) % key.Length;

                    orig.Append((char)(prvIndx + firstOr));
                }
            }
            return orig.ToString();

        }

    }
}
