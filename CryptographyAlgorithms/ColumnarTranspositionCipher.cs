using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ColumnarTranspositionCipher
    {
        public static String Encryption(String original, string key)
        {     
            original = CharsOnly(original);

            List<List<char>> matrix = new List<List<char>>();
            int origIndx = 0, 
                rows = (int)Math.Ceiling((double)original.Length / key.Length);
            
            for (int i = 0; i < rows; i++)
            {
                List<char> list = new List<char>();
                for (int j = 0; j < key.Length; j++)
                {
                    if (origIndx < original.Length)
                        list.Add(original[origIndx++]);
                    else
                        list.Add(' ');
                }
                matrix.Add(list);
            }

            StringBuilder enc = new StringBuilder();

            string OrdKey = String.Concat(key.OrderBy(c => c));

            for (int i = 0; i < OrdKey.Length; i++)
            {
                int col = key.IndexOf(OrdKey[i]);
             
                for (int j = 0; j < rows; j++)
                    if (matrix[j][col] != ' ')
                        enc.Append(matrix[j][col]);
            }

            return enc.ToString();
        }

        private static string CharsOnly(string original)
        {
            StringBuilder str = new StringBuilder();
            foreach (char ch in original)
            {
                if (char.IsLetter(ch))
                    str.Append(ch);
            }
            return str.ToString();
        }

        public static string Decryption(String encrypted, string key)
        {
            encrypted = CharsOnly(encrypted);

            int encIndx = 0,
                rows = (int)Math.Ceiling((double)encrypted.Length / key.Length),
                cols = key.Length,
                empty = (rows * cols) - encrypted.Length;
                ;

            var matrix = new List<List<char>>();

            for (int i = 0; i < rows; i++)
            {
                List<char> list = new List<char>();
                for (int j = 0; j < cols; j++)
                    list.Add(' ');
                matrix.Add(list);
            }

            int k = cols - 1;
            while (empty > 0)
            {
                matrix[rows - 1][k--] = '?';
                empty--;
            }

            int indxEmpty = key.Length - empty;

            string OrdKey = String.Concat(key.OrderBy(c => c));

            for (int i = 0; i < OrdKey.Length; i++)
            {
                int col = key.IndexOf(OrdKey[i]);

                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j][col] != '?')
                        matrix[j][col] = encrypted[encIndx++];

                    //if (j == rows - 1 && col >= indxEmpty) continue;

                    //matrix[j][col] = encrypted[encIndx++];

                }
            }


            StringBuilder orig = new StringBuilder();

            for (int i= 0;i< rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] != '?')
                        orig.Append(matrix[i][j]);
                    //Console.WriteLine(matrix[i][j]);
                }
                //Console.WriteLine();
            }

            

            return orig.ToString();
        }



    }
}
