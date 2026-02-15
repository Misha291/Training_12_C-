using System;

namespace tran12
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Ошибка! Строка не может быть пустой!");
                Console.ReadKey();
                return;
            }

            int count = 0;
            string glasne_all = "аеёиоуыэюяАЕЁИОУЫЭЯ";

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (glasne_all.Contains(letter))
                {
                    count++;
                } 
            }
            Console.WriteLine();

            Console.Write($"Гласных букв: {count}");
            Console.ReadKey();
        }
    }
}
