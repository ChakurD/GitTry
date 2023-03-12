using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeSquad
{
    public class Squad
    {
        public string squadName { get; set; }
        public string homeTown { get; set; }
        public int formed { get; set; }
        public string secretBase { get; set; }
        public bool active { get; set; }
        public SquadMember[] members { get; set; }

        public Squad() { }

        public Squad(string squadName,string homeTown, int yearOfForm, string secretBase, bool active, SquadMember[] members)
        {
            this.members = new SquadMember[members.Length];
            this.squadName = squadName;
            this.homeTown = homeTown;
            this.secretBase = secretBase;
            this.active = active;
            formed = yearOfForm;
            Array.Copy(members, this.members, members.Length);
        }

        public void ShowMemebrs()
        {
            foreach (var member in members)
            {
                Console.WriteLine($"\tИмя: {member.name}\n\tВозраст: {member.age}\n\tСекретная личность: {member.secretIdentity}");
                member.ShowPowers();
            }

        }
    }
}
