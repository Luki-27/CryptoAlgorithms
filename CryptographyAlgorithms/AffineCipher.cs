using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class AffineCipher
    {
        public static String Encryption(String original, int a,int b)
        {
            if (!IsCoprime(a, 26)) throw new Exception("a,b aren't Coprime");

            StringBuilder enc = new StringBuilder();

            foreach (var ch in original)
            {
                if (!char.IsLetter(ch))
                    enc.Append(ch);
                else 
                {
                    char first = char.IsUpper(ch) ? 'A' : 'a';

                    int indx = (ch - first) ;

                    int nextIndx = ((indx * a) + b) % 26;

                    enc.Append((char)(nextIndx + first));
                }
            }
            return enc.ToString();
        }
        public static string Decryption(String encrypted, int a, int b)
        {
            if (!IsCoprime(a, 26)) throw new Exception("a,b aren't Coprime");

            StringBuilder orig = new StringBuilder();

            foreach (var ch in encrypted)
            {
                if (!char.IsLetter(ch))
                    orig.Append(ch);
                else
                {
                    char first = char.IsUpper(ch) ? 'A' : 'a';

                    int indx = ch - first;

                    int prvIndx = (indx - b) * ModInverse(a);

                    while (prvIndx<0)
                    {
                        prvIndx += 26;
                    }
                    prvIndx %= 26;
                    orig.Append((char)(prvIndx + first));
                }
            }
            return orig.ToString();

        }
        private static bool IsCoprime(int a, int b)
        {
            return gcd(a, b) == 1;
        }
        private static long gcd(int x, int y) { return (y == 0) ? x : gcd(y, x % y); }
        private static int ModInverse(int a)
        {
            int modInv = 0;
            for (int i = 1; i < 26; i++)
            {
                if (a * i % 26 == 1)
                {
                    modInv = i;
                    break;
                }
            }
            return modInv;
        }
    }
}
