namespace startHWClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите характеристики телефонов(Номер, Модель , Вес):");
            string characteristics = Console.ReadLine();
            string[] characteristicsSplit = characteristics.Split(' ',',','\\','.');

            long iphNumber = Convert.ToInt64(characteristicsSplit[0]);
            string iphModel = characteristicsSplit[1];
            int iphWeight = Convert.ToInt32(characteristicsSplit[2]);
            long samsNumber = Convert.ToInt64(characteristicsSplit[3]);
            string samsModel = characteristicsSplit[4];


            Phone iphone = new Phone(iphNumber, iphModel, iphWeight);
            Phone samsung = new Phone(samsNumber, samsModel);
            Phone huawei = new Phone();

            samsung.weight = Convert.ToInt32(characteristicsSplit[5]);

            huawei.number= string.Format("{0:# (###) ###-##-##}", Convert.ToInt64(characteristicsSplit[6]));
            huawei.model = characteristicsSplit[7];
            huawei.weight = Convert.ToInt32(characteristicsSplit[8]);
            
            
            iphone.GetCharacteristics();
            samsung.GetCharacteristics();
            huawei.GetCharacteristics();

            string nameHuawei = "Alex";
            string nameIph = "Volodya";
            string nameSams = "Andrey";

            iphone.ReceiveCall(nameHuawei);
            samsung.ReceiveCall(nameIph);
            huawei.ReceiveCall(nameSams);

            iphone.GetNumber();
            samsung.GetNumber();
            huawei.GetNumber();
        }
    }
}