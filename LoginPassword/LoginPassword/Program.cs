namespace LoginPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                bool registrationDone = UserRegistration.UserRegistrationIn("AbraCobraDabra","VifiWideCodGl1", "VifiWideCodGl1");
                if (registrationDone) Console.WriteLine("Вы зарегестрировались");
            }
            catch(WrongLoginException ex) { Console.WriteLine(ex.Message); }
            catch (WrongPasswordException ex) { Console.WriteLine(ex.Message); }
           
        }
    }
}