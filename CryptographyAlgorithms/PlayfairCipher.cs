using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    struct CharLocation
    {
        public int row, col;
        public CharLocation(int r, int c)
        {
            row = r;
            col = c;
        }
    }
    public class PlayfairCipher
    {
        private static Dictionary<char,CharLocation> dict = new Dictionary<char,CharLocation>();
        public static String Encryption(String original, string key)
        {     
            StringBuilder enc = new StringBuilder();

            List<List<char>> matrix = GenerateMatrix(key);
            

            original = original.ToLower();
            original = CharsOnly(original);


            if ((original.Length & 1) == 1)
                original.Append('z');

            int i = 0;
            while(i+1 < original.Length)
            {
                char ch1 = original[i] != 'j' ? original[i] : 'i';
                char ch2 = original[i + 1] != 'j' ? original[i + 1] : 'i';

                if(ch1 == ch2)
                {
                    int indx = ((ch1 - 'a') + 1) % 26;
                    if (indx+'a' == 'j') indx = (indx + 1) % 26;
                    ch2 = (char)(indx + 'a');
                    i--;
                }
                if(dict[ch1].row == dict[ch2].row)
                {
                    int indx1 = (dict[ch1].col + 1) % 5;
                    int indx2 = (dict[ch2].col + 1) % 5;
                    enc.Append(matrix[dict[ch1].row][indx1]);
                    enc.Append(matrix[dict[ch2].row][indx2]);
                }
                else if(dict[ch1].col== dict[ch2].col)
                {
                    int indx1 = (dict[ch1].row + 1) % 5;
                    int indx2 = (dict[ch2].row + 1) % 5;

                    enc.Append(matrix[indx1][dict[ch1].col]);
                    enc.Append(matrix[indx2][dict[ch2].col]);
                }
                else
                {
                    enc.Append(matrix[dict[ch1].row][dict[ch2].col]);
                    enc.Append(matrix[dict[ch2].row][dict[ch1].col]);
                }
                i += 2;

            }
            return enc.ToString();
        }

        private static string CharsOnly(string original)
        {
            StringBuilder str = new StringBuilder();
            foreach (char ch in original)
            {
                if (char.IsLetter(ch))
                {
                    if (ch == 'j')
                        str.Append('i');
                    else
                        str.Append(ch);
                }
            }
            return str.ToString();
        }

        public static List<List<char>> GenerateMatrix(string key)
        {
            List<List<char>> matrix = new List<List<char>>();
            key = key.ToLower();
            bool[] frq = new bool[26];
            int keyIndx = 0, charIndx = 0;
            for(int i = 0; i < 5; i++)
            {
                List<char> list = new List<char>();
                for(int j = 0; j < 5; j++)
                {
                    while (keyIndx < key.Length && (frq[key[keyIndx] - 'a'] != false || key[keyIndx] == 'j'))
                    {
                        keyIndx++;
                    }
                    if (keyIndx < key.Length)
                    {
                        dict[key[keyIndx]] = new CharLocation(i, j);
                        frq[key[keyIndx] - 'a'] = true;
                        list.Add(key[keyIndx]);
                    }
                    else
                    {
                        while (frq[charIndx] || charIndx + 'a' == 'j')
                        {
                            charIndx++;
                        }
                        dict[(char)(charIndx + 'a')] = new CharLocation(i, j);
                        frq[charIndx] = true;
                        list.Add((char)(charIndx + 'a'));
                    }
                }
                matrix.Add(list);
            }

            return matrix;
        }

        public static string Decryption(String encrypted,string key)
        {
            
            StringBuilder orig = new StringBuilder();
            
            List<List<char>> matrix = GenerateMatrix(key);


            encrypted = encrypted.ToLower();
            int i = 0;
            while (i + 1 < encrypted.Length)
            {
                char ch1 = encrypted[i];
                char ch2 = encrypted[i + 1];

                if (ch1 == ch2)
                {
                    int indx = ch1 - 'a' - 1;
                    if (indx == 'j') indx--;

                    if (indx < 0) indx += 26;

                    ch2 = (char)(indx + 'a');
                    i--;
                }
                if (dict[ch1].row == dict[ch2].row)
                {
                    int indx1 = dict[ch1].col - 1;
                    if (indx1 < 0) indx1 += 5;

                    int indx2 = dict[ch2].col - 1;
                    if (indx2 < 0) indx2 += 5;

                    orig.Append(matrix[dict[ch1].row][indx1]);
                    orig.Append(matrix[dict[ch2].row][indx2]);
                }
                else if (dict[ch1].col == dict[ch2].col)
                {
                    int indx1 = dict[ch1].row - 1;
                    if (indx1 < 0) indx1 += 5;

                    int indx2 = dict[ch2].row - 1;
                    if (indx2 < 0) indx2 += 5;

                    orig.Append(matrix[indx1][dict[ch1].col]);
                    orig.Append(matrix[indx2][dict[ch2].col]);
                }
                else
                {
                    orig.Append(matrix[dict[ch1].row][dict[ch2].col]);
                    orig.Append(matrix[dict[ch2].row][dict[ch1].col]);
                }
                i += 2;

            }
            return orig.ToString();
        }

        
    }
}
