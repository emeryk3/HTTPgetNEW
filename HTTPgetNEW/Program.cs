using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTPgetNEW
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.getChuckNorrisJokes();
        }

        private async Task getChuckNorrisJokes()
        {
            string response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            Console.WriteLine(response);

            Jokes jokes = JsonConvert.DeserializeObject<Jokes>(response);

            Console.ReadLine();
        }

    }


    /// <summary>
    ///  Create a class of properties to deserialise the JSON into
    /// </summary>
    class Jokes
    {
        public string[] categories { get; set; }
        public DateTime created_at { get; set; }
        public string icon_url { get; set; }
        public string Id { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}
