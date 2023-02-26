using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startHWClass
{
    public class Phone
    {
        public string number;
        public string model;
        public int weight;

        public Phone()
        { }

        public Phone(long numberInit, string modelInit)
        {
            number = string.Format("{0:# (###) ###-##-##}", numberInit);
            model = modelInit;
        }

        public Phone(long numberInit, string modelInit, int weightInit) : this( numberInit, modelInit) 
        {
            //number = string.Format("{0:# (###) ###-##-##}", numberInit);
            //model = modelInit;
            weight = weightInit;
        }
      
        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public void GetNumber()
        {
            Console.WriteLine($"{number}");
        }
        public void GetCharacteristics() 
        {
            Console.WriteLine($"Номер: {number}; Модель: {model}; Вес: {weight};");
        }

        public void SendMessage(params string[] numbers) 
        { 
            for(int i = 0; i < numbers.Length; i++ ) 
            {
                //string message = Console.ReadLine();
                string numberToSendMessage = string.Format("{0:+375 (##) ###-##-##}", Convert.ToInt64(numbers[i]));
                Console.WriteLine($"{numberToSendMessage}"); 
            }
        
        }
    }
}
