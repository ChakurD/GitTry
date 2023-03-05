namespace GenericArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericArray<string> array= new GenericArray<string>();
            array.AddElem("tilt");
            array.AddElem("proof");
            array.AddElem("apple");
            array.AddElem("cheese");
            array.AddElem("people");
            array.AddElem("greed");
            array.AddElem("grif");
            array.AddElem("gum");
            array.AddElem("fear");
            array.AddElem("pure");
            array.AddElem("ferocity");
            Console.WriteLine(array.GetEllement(5));
            array.CountElements();

            Console.WriteLine(MaxAmongVal<int>.MaxValue(10,5,15));

        }
    }
}