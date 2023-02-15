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
        public Phone(long numberInit, string modelInit, int weightInit) 
        {
        number = string.Format("{0:# (###) ###-##-##}",numberInit);
         model = modelInit;
         weight = weightInit;
        }
        public Phone(long numberInit, string modelInit)
        { 
        number= string.Format("{0:# (###) ###-##-##}", numberInit);
        model= modelInit;
        }
        public Phone()
        { }
    }
}
