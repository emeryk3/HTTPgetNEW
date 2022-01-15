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
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            Console.WriteLine(response);


            Console.ReadLine();
        }

    }

    class Todo
    {
        public string categories { get; set; }
        public int id { get; set; }
        public string value { get; set; }
    }
}
