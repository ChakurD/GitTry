using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    public class GenericArray<T>
    {
        private T[] array;
        private int fillIndex;
        public GenericArray() 
        {
            array = new T[10];
            fillIndex = 0;
        }
        public void AddElem(T elem) 
        {
            try
            {
                array.SetValue(elem, fillIndex);
                fillIndex++;
            }
            catch (IndexOutOfRangeException) { Console.WriteLine("fillIndex не может быть больше 10");}
        }
        public T GetEllement(int index) 
        {
         return (T)array.GetValue(index);
        }
        public void CountElements()
        {
            Console.WriteLine($"Количество элементов в массиве: {fillIndex}");
        }
    }
}
