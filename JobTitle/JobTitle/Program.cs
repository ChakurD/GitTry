namespace JobTitle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director IvanPetrovich = new Director(3);
            Accountant ElizavetaVasilievna = new Accountant(7);
            Worker BorisFederov = new Worker(4);
            IvanPetrovich.TittleJobOut();
            ElizavetaVasilievna.TittleJobOut();
            BorisFederov.TittleJobOut();
        }
    }
}