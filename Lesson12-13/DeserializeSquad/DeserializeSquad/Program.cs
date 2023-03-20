using System.Numerics;
using System.Text.Json;

namespace DeserializeSquad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new FileStream("data.json", FileMode.Open))
            {
                var superHeroSquad = JsonSerializer.Deserialize<Squad>(fs);
            }
        }
    }
}