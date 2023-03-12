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
                Console.WriteLine($"Имя отряда: {superHeroSquad.squadName}\nГород действия: {superHeroSquad.homeTown}\nДата основания: {superHeroSquad.formed}\nСекретная база: {superHeroSquad.secretBase}\nАктивность: {superHeroSquad.active}");
                Console.WriteLine("Члены отряда:");
                superHeroSquad.ShowMemebrs();

            }
        }
    }
}