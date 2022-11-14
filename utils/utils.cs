using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace utils
{
    internal class utils
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRESTUVQXYZ";
        string symbols = "·‑‒–—―‗‘’‚‛“”„‟•‣․‥…‧′″‴‵‶‷❛❜❝❞ʹʺʻʼʽʾʿˀˁ˂˃˄˅ˆˇˈˉˊˋˌˍˎˏːˑ˒˓˔˕˖˗˘˙˚˛˜˝ˠˡ～¿﹐﹒﹔﹕！＃＄％＆＊，．：；？＠、。〃〝〞︰";
        string any = "ABCDEFGHIJKLMNOPQRESTUVQXYZabcdefghijklmnopqrestuvqxyz0123456789·‑‒–—―‗‘’‚‛“”„‟•‣․‥…‧′″‴‵‶‷❛❜❝❞ʹʺʻʼʽʾʿˀˁ˂˃˄˅ˆˇˈˉˊˋˌˍˎˏːˑ˒˓˔˕˖˗˘˙˚˛˜˝ˠˡ～¿﹐﹒﹔﹕！＃＄％＆＊，．：；？＠、。〃〝〞︰";
        Random random = new Random();

        public string buildJson(Dictionary<string, object> dict)
        {
            var javaScriptSerializer = new JavaScriptSerializer();
            var serialized = javaScriptSerializer.Serialize(dict);
            
            return serialized;
        }


        public string shuffleString(string str)
        {
            char[] array = str.ToCharArray();
            var rng = random;
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        public string GetBetween(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        public string randomString(string decoded)
        {
            int index = 0;
            string result = "";

            foreach (char letter in decoded)
            {
                decoded = decoded.Replace("?", "");

                if (letter == 'd')
                {
                    result += char.Parse(random.Next(0, 9).ToString());
                }
                if (letter == 'u')
                {
                    string leter = alphabet[random.Next(0, alphabet.Length)].ToString().ToUpper();
                    result += leter;
                }

                if (letter == 'l')
                {
                    string leter = alphabet[random.Next(0, alphabet.Length)].ToString().ToLower();
                    result += leter;
                }
                if (letter == 'a')
                {
                    string leter = shuffleString(any[random.Next(0, any.Length)].ToString());
                    result += leter;
                }
                if (letter == 's')
                {
                    string leter = shuffleString(symbols[random.Next(0, symbols.Length)].ToString());
                    result += leter;
                }
                index++;
            }
            return result;
        }

        public string ToFormData(IDictionary<string, object> dict)
        {
            var list = new List<string>();

            foreach (var item in dict)
                list.Add(item.Key + "=" + item.Value);

            return string.Join("&", list);
        }

        public string Base64Encode(string plainText)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
        }

        public string Base64Decode(string encoded)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encoded));
        }

        public string CurrentUnixTime()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        }

        public string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public string UUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
