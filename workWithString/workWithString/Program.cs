namespace workWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randString = Console.ReadLine();
            string[] subStrings = randString.Split(' ');
            int wordLengthMax = 0, wordIndexMax=0, wordLenghtMin=0, wordIndexMin=0;
            wordLengthMax = subStrings[0].Length; 
            wordLenghtMin = subStrings[0].Length; 
            for (int i = 0; i < subStrings.Length; i++)
            {
                
                if (wordLengthMax <= subStrings[i].Length)
                {
                    wordLengthMax = subStrings[i].Length;
                    wordIndexMax = i;
                }
                
                if (wordLenghtMin >= subStrings[i].Length)
                {
                    wordLenghtMin = subStrings[i].Length;
                    wordIndexMin = i;
                }
            }
            Console.WriteLine($"Самое Короткое слово:{subStrings[wordIndexMin]}\n Самое длинное слово:{subStrings[wordIndexMax]}");

            //--------------------------------------------------------------
            string strUniq = Console.ReadLine();
            string[] subStrUniq = strUniq.Split(' ');
            HashSet<char> s = new HashSet<char>();
            int wordIndex = 0, countSymb = 0;
            for (int i = 0; i < subStrUniq.Length; i++)
            {
                string checkedWord = subStrUniq[i];
                for (int j = 0; j < subStrUniq[i].Length; j++)
                {
                    s.Add(checkedWord[j]);
                }
                if (i == 0 || countSymb > s.Count) { countSymb = s.Count; wordIndex = i; }
                s.Clear();
            }
            Console.WriteLine($"{subStrUniq[wordIndex]}");

            //--------------------------------------------------------------

            string polindrom = "Reverse all baab worlds peer maybe help you ";
            Console.WriteLine(polindrom);
            Console.WriteLine("Введите номер слова");
            int numWord = Convert.ToInt32(Console.ReadLine());
            string[] polindromCheck = polindrom.Split(" ");
            string examin = polindromCheck[numWord];
            bool isPalindrom = false;
            if (numWord >= polindromCheck.Length)
            {
                Console.WriteLine("Слово под таким номером не существует. Введите новый номер");
                numWord = Convert.ToInt32(Console.ReadLine());
            }
            for (int first = 0, last = examin.Length - 1; first < last; ++first, --last)
            {
                isPalindrom = examin[first] != examin[last];
                Console.WriteLine("Слово не является полиндромом");
                     
            }
            if(isPalindrom) Console.WriteLine("Слово является полиндромом");

            //--------------------------------------------------------------

            Console.WriteLine("Введите текст: ");
            string insertStr = Console.ReadLine();
            for (int i = 0; i < insertStr.Length ; i++)
            {
                insertStr=insertStr.Insert(i, char.ToString(insertStr[i]));
                i++;
            }
            Console.WriteLine(insertStr);
        }
    }
}