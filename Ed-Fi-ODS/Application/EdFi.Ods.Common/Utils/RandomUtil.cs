﻿using System;
using System.Security.Cryptography;

namespace EdFi.Ods.Common.Utils
{
    public class RandomUtil : IRandomUtil
    {
        public string GenerateRandomString(int length)
        {
            return GenerateRandomBase64String(length)
                .Replace("+", "-") //Replace with legal query string character
                .Replace("/", "_"); //Replace with legal query string character
            ;
        }

        public static string GenerateRandomBase64String(int length)
        {
            var numBytes = Convert.ToInt32(Math.Ceiling(length*3/4.0));
            var s = GenerateRandomBase64StringFromBytes(numBytes);
            return s.Substring(0, length);
        }

        public static string GenerateRandomBase64StringFromBytes(int numBytes = 16)
        {
            var bytes = new byte[numBytes];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes, Base64FormattingOptions.None);
        }
    }
}