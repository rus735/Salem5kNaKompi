using System.Text.Json;
using System.Text.Json.Serialization;
using static ConsoleApp1.Class1;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://informer.dop.proplast.ru/api/index/pet/?moment=24%20month3&range=2020-01-15%2000:00:00,2024-10-15%2023:59:59");
                var responseText = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseText);
                int a  = responseText.LastIndexOf('>');
                responseText = responseText.Remove(0, a + 1);
                Rootobject root = JsonSerializer.Deserialize<Rootobject>(responseText);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}