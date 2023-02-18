namespace Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Patient Alex = new Patient(rnd.Next(0,3));
            Patient Boris = new Patient(rnd.Next(0, 3));
            Patient Vitalya = new Patient(rnd.Next(0, 3));

            Alex.DocApoitment();
            Boris.DocApoitment();
            Vitalya.DocApoitment();

        }
    }
}