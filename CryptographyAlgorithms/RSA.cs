using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RSA
    {
        static long PublicKey;
        static long PrivateKey;
        static long N;
        private static void CalKeys(long p,long q)
        {
            if (!IsPrime(p) || !IsPrime(q)) throw new Exception("P and/or Q not prime");

            N = p * q;
            long alpha = (p - 1) * (q - 1);
            long e = 0;
            for(int i = 2; i < alpha; i++)
            {
                if (gcd(i, alpha) == 1)
                {
                    e = i;
                    break;
                }
            }

            long d = ModInverse(e, alpha);
            PublicKey = e;
            PrivateKey = d;
            //Console.WriteLine($"Public Key : {PublicKey} \nprivate Key :{PrivateKey}");
        }
        public static String Encryption(String original, long p,long q)
        {

            CalKeys(p, q);
            StringBuilder enc = new StringBuilder();

            foreach (var ch in original)
            {

                if (ch > N) throw new Exception("m can't be greater than N");

                int indx = ch;

                long nextIndx = BinPow(indx, PublicKey, N);
                //Console.WriteLine(nextIndx);
                enc.Append((char)(nextIndx));

            }
            return enc.ToString();
        }

        public static string Decryption(String encrypted, int p, int q)
        {
            CalKeys(p, q);

            StringBuilder orig = new StringBuilder();

            foreach (var ch in encrypted)
            {
                int indx = ch;
                if (ch > N) throw new Exception("m can't be greater than N");

                long origIndex = BinPow(indx, PrivateKey, N);
             
                orig.Append((char)(origIndex));

            }
            return orig.ToString();

        }

        private static long gcd(long x, long y) { return (y == 0) ? x : gcd(y, x % y); }
        private static long ModInverse(long a, long mod)
        {
            long modInv = 0;
            for (int i = 1; i < mod; i++)
            {
                if (a * i % mod == 1)
                {
                    modInv = i;
                    break;
                }
            }
            return modInv;
        }
        private static bool IsPrime(long n)
        {
            if (n == 2 || n == 3 || n == 5)
                return true;
            if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
                return false;
            for (int i = 7; i <= Math.Sqrt(n); i += 2)
                if (n % i == 0) return false;
            return true;
        }
        static long BinPow(long x, long y, long p)
        {
            long res = 1; 
            
            x = x % p; 

            if (x == 0)
                return 0; 

            while (y > 0)
            {

                if ((y & 1) != 0)
                    res = (res * x) % p;

                y = y >> 1; 
                x = (x * x) % p;
            }
            return res;
        }
    }
}
