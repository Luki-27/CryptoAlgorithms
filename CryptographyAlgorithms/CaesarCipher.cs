using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CaesarCipher
    {
        public static String Encryption(String original, int shift)
        {
            StringBuilder enc = new StringBuilder();

            foreach (var ch in original)
            {
                if (!char.IsLetter(ch))
                    enc.Append(ch);
                else 
                {
                    char first = char.IsUpper(ch) ? 'A' : 'a';

                    int indx = ch - first;
                    int nextIndx = (indx + shift) % 26;

                    enc.Append((char)(nextIndx + first));
                }
            }
            return enc.ToString();
        }

        public static string Decryption(String encrypted, int shift)
        {
            StringBuilder orig = new StringBuilder();

            foreach (var ch in encrypted)
            {
                if (!char.IsLetter(ch))
                    orig.Append(ch);
                else
                {
                    char first = char.IsUpper(ch) ? 'A' : 'a';

                    int indx = ch - first;
                    int prvIndx = (indx - shift);
                    while (prvIndx<0)
                    {
                        prvIndx += 26;
                    }

                    orig.Append((char)(prvIndx + first));
                }
            }
            return orig.ToString();

        }

    }
}
