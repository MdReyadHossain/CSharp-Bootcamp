using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SecretKey
    {
        private static readonly int[] arr = new int[16];

        public static void SeivePrime()
        {
            for (int i = 2; i < 16; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = 2; i * j < 16; j++)
                    {
                        arr[i * j] = 1;
                    }
                }
            }
        }

        public static long HexToDec(string hexNum)
        {
            return long.Parse(hexNum, System.Globalization.NumberStyles.HexNumber);
        }

        public static string Encrypt(string uid)
        {
            SeivePrime();
            string xLastDigit = uid[^6..];
            string hexUid = Convert.ToInt64(Convert.ToInt64(uid) * Convert.ToInt64(xLastDigit)).ToString("X");

            long primeStep = 0;
            if (arr[HexToDec(hexUid[^1].ToString())] == 0)
            {
                primeStep = Convert.ToInt64(xLastDigit) + 6;
            }
            else
            {
                primeStep = Convert.ToInt64(xLastDigit) + 3;
            }

            string salt = (primeStep * 9).ToString();
            string saltP = Convert.ToInt32(salt[..^2]).ToString("X");
            string saltQ = Convert.ToInt32(salt.Substring(salt.Length - 2)).ToString("X");

            string encryptData = saltP + hexUid.Substring(0, 2) + 'O' + hexUid[2..^1] + 'O' + hexUid.Substring(hexUid.Length - 1) + saltQ;

            return encryptData;
        }
    }
}
