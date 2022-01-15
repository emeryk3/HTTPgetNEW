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

            Todo todo = JsonConvert.DeserializeObject<Todo>(response);

            foreach (var item in todo)
            {
                Console.WriteLine(item.value);
            }

            Console.ReadLine();
        }

    }


    /// <summary>
    ///  Create a class of properties to deserialise the JSON into
    /// </summary>
    class Todo
    {
        public string Icon_Url { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
