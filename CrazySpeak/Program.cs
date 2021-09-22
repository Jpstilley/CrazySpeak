using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CrazySpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            string[] swansonQuotes = new string[5];

            string[] yeezyQuotes = new string[5];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ron: " + JArray.Parse(client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result)
                    .ToString().Replace('[', ' ').Replace(']', ' ').Replace('\"', ' ').Trim());
                Console.WriteLine("Yeezy: " + JObject.Parse(client.GetStringAsync("https://api.kanye.rest").Result).GetValue("quote") + "\n");
            }
        }
    }
}
