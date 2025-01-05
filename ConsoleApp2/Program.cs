using System;
using System.ComponentModel.Design;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info;
            int select;

            info = "Выберите интересуешее задание:\n\n" +
                   "1 - Знакомство\n" +
                   "2 - Логические операции";

            select = CheckingTheSelection(info, 2);

            switch (select)
            {
                case 1:
                    Acquaintance();
                    Environment.Exit(0);
                    break;
                case 2:
                    ComparisonOperation();
                    Environment.Exit(0);
                    break;
            }
        }

        private static int CheckingTheSelection(string information, int numberTheSelection)
        {
            bool on = true;
            int char1 = 0;
            int choice = 0;
            string info = information;

            while (on)
            {
                for (int i = 0; i < info.Length; i++)
                    if (info[i] == ':')
                        char1 = i + 2;

                Console.WriteLine(info);
                Console.SetCursorPosition(char1, 0);

                choice = checked (Convert.ToInt32(Console.ReadLine()));

                if (choice > 0 && choice <= numberTheSelection)
                {
                    on = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некоректный ввод! Повторите попытку. \n\n\n" +
                                      "Нажмите любую клавишу чтобы продолжить...");
                    Console.ReadKey();
                }

                Console.Clear();
            }
            return choice;
        }
        private static void Acquaintance()
        {
            Console.WriteLine("Как вас зовут? ");
            string myName = Console.ReadLine();

            Console.WriteLine("Сколько вам лет? ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли у вас питомец? Укажите 'Да' или 'Нет' ");
            string pet = Console.ReadLine();

            Console.WriteLine("Какой у вас размер ноги? ");
            float footSize = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите дату вашего рождения: ");
            string birthDay = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Меня зовут - {myName}\n" +
                              $"Мой возраст - {years}\n" +
                              $"Есть ли у меня питомец - {pet}\n" +
                              $"Мой размер ноги - {footSize}\n" +
                              $"День моего рождения: {birthDay}");
        }
        private static void ComparisonOperation()
        {
            Console.WriteLine("Напишите свой любимый цвет.");

            string color = Console.ReadLine().ToLower();

            if (color == "red" || color == "красный")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твой цвет красный");
            }
            else if (color == "green" || color == "зеленый")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Твой цвет зеленый");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Твой цвет голубой");
            }
        }

    }
}
