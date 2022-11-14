using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;
using Leaf.xNet;
using System.Security.Policy;
using System.Web;

namespace utils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            utils utils = new utils();

            // BUILD JSON
            ///////////
            ///

            //var dict = new Dictionary<string, object>
            //{
            //    {"operationName", "requestOtp" },
            //    {"query", "mutation requestOtp($requestOtp: RequestOtpInput!) { requestOtp (requestOtp: $requestOtp) { accepted } }"},
            //    {
            //        "variables", new Dictionary<string, object>
            //        {
            //            { "requestOtp", new Dictionary<string, object>
            //                {
            //                    { "email", "asdaf@gmail.com" },
            //                    { "reason", "Forgot Password"},
            //                } 
            //            }
            //        }
            //    }

            //};
            //string lol = utils.buildJson(dict);
            //Console.WriteLine(lol);

            /////////////
            ///

            // GET_BETWEEN EXAMPLE//
            //
            ///////

            //HttpRequest request = new HttpRequest();
            //string get = request.Get("https://restorecord.com/verify/1040870327204446279").ToString();

            //string hi = utils.GetBetween(get, "content=", "</body></html>");
            //Console.WriteLine(hi);

            ////////////////
            ///

            //GENEREATE STRING //
            //////////////
            /////

            //string ex = "?d?d?d?u?d?u?d?s?u?l?s?s?s?d?s?d?s";
            //string result = utils.randomString(ex);
            //Console.WriteLine(result);

            /////////////////////
            /////////


            ////////// TO FORMDATA

            //var dict = new Dictionary<string, object>
            //{
            //    { "device_type", "com.crunchyroll.manga.android" },
            //    { "device_id", "996f20f5e235e2b6" },
            //    { "access_token", "FLpcfZH4CbW4muO&api_ver=1.0" },
            //    { "account", "asdf@gmail.com" },
            //    { "password", "password" },

            //};
            //string form_Data = utils.ToFormData(dict);
            //var response = request.Post(url, form_Data, "application/x-www-form-urlencoded");

            //////////////////

            //////////// BASE 64 ENCODING DECODING

            //string lol = "hi mom";
            //string encoded = utils.Base64Encode(lol);
            //string decoded = utils.Base64Decode(encoded);
            //Console.WriteLine($"Plain text: {lol}, Encoded: {encoded} Decoded: {decoded}");

            ///////////////
            Console.ReadLine();
        }
    }
}
