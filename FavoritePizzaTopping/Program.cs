using Newtonsoft.Json;
using System.Text.Json;

namespace FavoritePizzaTopping
{
    public class Pizza
    {
        public List<string> Toppings { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Topping App");


            // read file into a string and deserialize JSON to a type
            var allPizzas = JsonConvert.DeserializeObject<List<Pizza>>(File.ReadAllText(@"C:\Users\alvin\source\repos\FavoritePizzaTopping\FavoritePizzaTopping\Assets\pizzas.json"));

            Dictionary<string, int> pizzaCounter = new Dictionary<string, int>();
            
            foreach (Pizza slice in allPizzas)
            {
                var toppingsAsString = String.Join("," , slice.Toppings);

                if (pizzaCounter.ContainsKey(toppingsAsString))
                {
                pizzaCounter[toppingsAsString] += 1;
                }
                else { pizzaCounter[toppingsAsString] = 1; }

            }

            var mostCommonPizzas = pizzaCounter.OrderByDescending(p => p.Value).Take(20);


            foreach (var item in mostCommonPizzas)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }
    }



}