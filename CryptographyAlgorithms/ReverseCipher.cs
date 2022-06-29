using System.Text;

namespace Algorithms
{
    public class ReverseCipher
    {
        public static String Encryption(String original)
        {
            StringBuilder enc = new StringBuilder();  
            for (int i = original.Length-1; i >= 0; i--)
                enc.Append(original[i]);
            return enc.ToString();

        }

        public static string Decryption(String encrypted)
        {
            return Encryption(encrypted);
        }

    }
}