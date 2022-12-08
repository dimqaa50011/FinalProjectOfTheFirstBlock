namespace FinalProject
{
    namespace finalproject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Введите слова через пробел: ");
            string? userAnswer = Console.ReadLine();
            string[] wordsArray = userAnswer.Split(" ");
            string[] elementsOfTreeOrLessChar = new string[GetLengthResultArray(wordsArray)];

            FillResultArray(wordsArray, elementsOfTreeOrLessChar);

            System.Console.WriteLine("Исходный массив");
            PrintArray(wordsArray);
            
            System.Console.WriteLine("Массив с элементами длиной 3 или менее символов");
            PrintArray(elementsOfTreeOrLessChar);
        }
        private static int GetLengthResultArray(string[] words)
        {
            int count = 0;
            foreach (var item in words)
            {
                if (item.Length <= 3)
                    count++;
            }
            return count;
        }
        private static void FillResultArray(string[] words, string[] result)
        {
            int resultIdex = 0;
            foreach (var item in words)
                if (item.Length <= 3)
                    result[resultIdex++] = item;
        }
        private static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                System.Console.Write($"{arr[i]}, ");
            }
            System.Console.Write($"{arr[arr.Length - 1]}");
            System.Console.WriteLine();
        }
    }
}
}