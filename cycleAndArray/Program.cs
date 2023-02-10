using System;
using System.Drawing;

namespace cycleAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 100; num++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine($"{num}");
                }
            }

            //----------------------------------------------------
            for (int descendNum = 5; descendNum > 0; descendNum--)
            {
                Console.WriteLine($"{descendNum}");
            }

            //-----------------------------------------------------

            Console.WriteLine("Введите любое целое положительное число: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int seqOfNum = 0; seqOfNum <= userNum; seqOfNum++)
            {
                sum += seqOfNum; 
            }
            Console.WriteLine($"Сумма равна: {sum}");

            //-----------------------------------------------------

            int factor = 1;
            while (factor <= 14)
            {
                int subsequence = 7;
                subsequence *= factor;
                Console.Write($"{subsequence} ");
                factor++;
            }
            Console.WriteLine();

            //-----------------------------------------------------

            int Seq = 1;
            int negVal = 0;
            while (Seq < 11)
            {
                Console.Write($"{negVal} ");
                negVal -= 5;
                Seq++;
            }
            Console.WriteLine();

            //-----------------------------------------------------

            int squareNum = 1;
            int Value = 10;
            while (Value <= 20)
            {
                squareNum = Value * Value;
                Value++;
                Console.WriteLine($"{squareNum}");
            }

            //-----------------------------------------------------

            //Массивы
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool coincidence = false;
            Console.WriteLine("Введите число: ");
            int entNum = Convert.ToInt32(Console.ReadLine());
            foreach (var elem in array1)
            {
                if (entNum == elem) { coincidence = true; }
            }
            Console.WriteLine(coincidence==true? $"{entNum} входит в массив" : $"{entNum} не входит в массив") ;

            //-----------------------------------------------------

            int[] array2 = { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8};
            Console.WriteLine("Введите число: ");
            int entVal = Convert.ToInt32(Console.ReadLine());
            bool coincidence2 = false;
            bool Count = true;
            while (Count)
            {
                int firstEnter = Array.FindIndex(array2, numeric => numeric == entVal);
                if (firstEnter >= 0)
                {
                    // Array.Clear(array2, firstEnter, 1);

                    for (int interv = firstEnter; interv < array2.Length - 1; interv++)
                    {
                        array2[interv] = array2[interv + 1];
                    }
                    Array.Resize(ref array2, array2.Length - 1);
                    coincidence2 = true;
                }
                else { Count = false; }
                
            }
            if (coincidence2 != true) { Console.WriteLine($"Число {entVal} не входит в массив"); }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
            }

            //-----------------------------------------------------

            Console.WriteLine("Введите размер массива:");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array3=new int[] { };
            Array.Resize<int>(ref array3, arraySize);
            Random rand = new Random();
            for (int elem = 0; elem < arraySize; elem++)
            {
                array3[elem] = rand.Next(1, 100);
                Console.Write($"{array3[elem]} ");
            }
            Console.WriteLine();
            int min, max, averVal;
            min = array3[0];
            max = array3[0];
            for (int i = 1; i < array3.Length; i++)
            {
                if (array3[i] < min)
                { min = array3[i]; }
                if (array3[i] > max)
                { max = array3[i]; }
            }
            averVal = ((min + max) / 2);
            Console.WriteLine($"Максимальное значение: {max}\nМинимальное начение: {min}\nСреднее значение: {averVal}");

            //-----------------------------------------------------

            int[] averArr1 = { 4, 10, 3, 6, 13 };
            int[] averArr2 = { 5, 7, 11, 9, 16 };
            int sumArr1 = 0;
            int sumArr2 = 0;
            for (int ArrVal = 0; ArrVal < averArr1.Length; ArrVal++)
            {
                Console.Write($"{averArr1[ArrVal]} ");
                sumArr1 += averArr1[ArrVal];
            }
            Console.WriteLine();
            for(int ArrVal = 0; ArrVal < averArr1.Length; ArrVal++)
            {
                Console.Write($"{averArr2[ArrVal]} ");
                sumArr2 += averArr2[ArrVal];
            }
            Console.WriteLine();
            double averVal1 = Convert.ToDouble(sumArr1 / averArr1.Length);
            double averVal2 = Convert.ToDouble(sumArr2 / averArr2.Length);
            Console.WriteLine($"Среденее арифметическое значение 1-го массива: {averVal1} " +
                $"\nСреденее арифметическое значение 2-го массива: {averVal2}");
            if (averVal1 > averVal2) { Console.WriteLine("Среденее арифметическое значение 1-го массива больше"); }
            else if (averVal2 > averVal1) { Console.WriteLine("Среденее арифметическое значение 2-го массива больше"); }
            else { Console.WriteLine("Среденее арифметическое значение массивов равны"); }

            //-----------------------------------------------------

            int Fibonachi = 1;
            int subsequFibonachi = 0;
            int fibonachiCount = 0;
            int prevValue = 0;
            Console.Write($"{Fibonachi} ");
            while (fibonachiCount <= 11)
            {
                prevValue = Fibonachi;
                Fibonachi += subsequFibonachi;
                fibonachiCount++;
                subsequFibonachi = prevValue;
                Console.Write($"{Fibonachi} ");
            }
            Console.WriteLine();

            //-----------------------------------------------------

            int monthCount = 1;
            Console.WriteLine("Введите сумму вкалада:");
            float summary = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число месяцев: ");
            int numOfMonth = Convert.ToInt32(Console.ReadLine());
            while (monthCount <= numOfMonth)
            {
                summary += (summary * 0.07F);
                monthCount++;
            }
            Console.WriteLine($"После {numOfMonth} месяцев на вашем вкладе бдует {summary}");

            //-----------------------------------------------------

            Console.WriteLine("Введите размер массива:");
            int arraySizeExtr = Convert.ToInt32(Console.ReadLine());
            if (arraySizeExtr < 5 || arraySizeExtr > 10)
            {
                Console.WriteLine("Размер не удовлетворяет условию, введите пожалуйста новый размер от 5 до 10:");
                arraySizeExtr = Convert.ToInt32(Console.ReadLine());
            }
            int[] arrayExtr = new int[] { };
            Array.Resize<int>(ref arrayExtr, arraySizeExtr);
            Random randNew = new Random();
            for (int elem = 0; elem < arrayExtr.Length; elem++)
            {
                arrayExtr[elem] = randNew.Next(1, 100);
                Console.Write($"{arrayExtr[elem]} ");
            }
            Console.WriteLine();
            int[] secArrayExtr = new int[] { };
            int[] matchMatchedArray = Array.FindAll(arrayExtr,match=> match % 2 == 0);
            for (int par = 0; par < matchMatchedArray.Length; par++)
            {
                if(matchMatchedArray[par]!=0) Console.Write($"{matchMatchedArray[par]} ");
                else Console.WriteLine("В массиве нету четных элементов");

            }
            Console.WriteLine("");

            //-----------------------------------------------------

            Console.WriteLine("Введите размер массива:");
            int arraySizeExerc5 = Convert.ToInt32(Console.ReadLine());
            int[] arrayExerc5 = new int[] { };
            Array.Resize<int>(ref arrayExerc5, arraySizeExerc5);
            for (int elem = 0; elem < arrayExerc5.Length; elem++)
            {
                arrayExerc5[elem] = Convert.ToInt32(Console.ReadLine());
            }
            for (int arrayOutput = 0; arrayOutput < arrayExerc5.Length; arrayOutput++)
            {
                Console.Write($"{arrayExerc5[arrayOutput]} ");
            }
            Console.WriteLine("");
            for (int oddSearch = 0; oddSearch < arrayExerc5.Length; oddSearch++)
            {
                if (oddSearch % 2 != 0) arrayExerc5[oddSearch] = 0;
                Console.Write($"{arrayExerc5[oddSearch]} ");
            }
            Console.WriteLine("");

            //-----------------------------------------------------

            string[] arrayNames = new string[] { "Tom", "Anatoliy", "Leonard", "Nikita", "Victor", "Vanya", "Egor" };
            for (int i = 0; i < arrayNames.Length; i++)
            {
                Console.Write($"{arrayNames[i]} ");
            }
            Console.WriteLine("");
            for (int leftBorder = 0; leftBorder < arrayNames.Length; leftBorder++)
            {
                bool swapFlag = false;
                // pass from left to right
                for (var j = leftBorder; j < arrayNames.Length - 1; j++)
                {
                    if (arrayNames[j].CompareTo(arrayNames[j + 1])>0)
                    {
                        var temp = arrayNames[j];
                        arrayNames[j] = arrayNames[j + 1];
                        arrayNames[j + 1] = temp;
                        swapFlag = true;
                    }
                }
                // pass from right to left
                for (var j = arrayNames.Length- 1; j > leftBorder; j--)
                {
                    if (arrayNames[j - 1].CompareTo(arrayNames[j])>0)
                    {
                        var temp = arrayNames[j];
                        arrayNames[j] = arrayNames[j - 1];
                        arrayNames[j - 1] = temp;
                        swapFlag = true;
                    }
                }

                //if there were no exchanges, exit
                if (!swapFlag)
                {
                    break;
                }

            }
            for (int i = 0; i < arrayNames.Length; i++)
            {
                Console.Write($"{arrayNames[i]} ");
            }
            Console.WriteLine("");

            //-----------------------------------------------------

            int[] beforeBuuble = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < beforeBuuble.Length; i++)
            {
                Console.Write($"{beforeBuuble[i]} ");
            }
            Console.WriteLine("");
            for (int i = 0; i < beforeBuuble.Length-1; i++)
            {
                for (int j = 0; j < beforeBuuble.Length - i - 1; j++)
                {
                    if (beforeBuuble[j] > beforeBuuble[j + 1])
                    {
                        var temp = beforeBuuble[j];
                        beforeBuuble[j] = beforeBuuble[j + 1];
                        beforeBuuble[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < beforeBuuble.Length; i++)
            {
                Console.Write($"{beforeBuuble[i]} ");
            }
            Console.WriteLine("");
        }
    }
}