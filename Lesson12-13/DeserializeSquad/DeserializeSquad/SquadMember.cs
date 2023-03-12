using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeSquad
{
    public class SquadMember
    {
        public string name { get; set; }
        public int age { get; set; }
        public string secretIdentity { get; set; }
        public string[] powers { get; set; }
        public SquadMember() { }
        public SquadMember(string name,int age,string secretIdentity, string[] powers)
        { 
            this.powers = new string[powers.Length];
            this.name= name;
            this.age= age;
            this.secretIdentity= secretIdentity;
            Array.Copy(powers,this.powers,powers.Length);
        }
        public void ShowPowers()
        {
            foreach (var power in powers)
                Console.WriteLine($"\tСпособность:{power}");
            Console.WriteLine("");
        }
    }
}
