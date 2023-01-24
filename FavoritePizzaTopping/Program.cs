using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Numerics;
using System.Text.Json;

namespace FavoritePizzaTopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Topping App");

            // read file into a string and deserialize JSON to a type
            List<string> pizza = JsonConvert.DeserializeObject<List<string>>(@"C:\Users\alvin\source\repos\FavoritePizzaTopping\pizzas.json");

            Console.WriteLine(pizza);
        }
    }



}