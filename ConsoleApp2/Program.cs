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

                choice = checked(Convert.ToInt32(Console.ReadLine()));

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
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет.");
                string color = Console.ReadLine().ToLower();

                if (color == "stop" || color == "стоп")
                {
                    Console.WriteLine("Программа завершена!");
                    break;
                }
                else if (color == "next" || color == "следующий")
                {
                    continue;
                }

                switch (color)
                {
                    case "красный":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Твой цвет красный!");
                        break;
                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Твой цвет зеленый!");
                        break;
                    case "голубой":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Твой цвет голубой!");
                        break;
                    case "red":
                        goto case "красный";
                    case "green":
                        goto case "зеленый";
                    case "cyan":
                        goto case "голубой";
                    default:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ты бетман!");
                        Console.WriteLine("00000000000000000000000000000000000000000000000000\r\n" +
                                          "0000000000000000000000_______000000000000000000000\r\n" +
                                          "0000000000000_________________________000000000000\r\n" +
                                          "0000000000____00______00__00_______00____000000000\r\n" +
                                          "0000000____0000_______000000________0000____000000\r\n" +
                                          "00000___000000________0000000_______0000000___0000\r\n" +
                                          "0000__000000000______00000000_______000000000__000\r\n" +
                                          "000_0000000000000___00000000000___000000000000___0\r\n" +
                                          "00_00000000000000000000000000000000000000000000__0\r\n" +
                                          "0__000000000000000000000000000000000000000000000_0\r\n" +
                                          "0__000000000000000000000000000000000000000000000_0\r\n" +
                                          "00_000000000000000000000000000000000000000000000_0\r\n" +
                                          "00__0000000000000000000000000000000000000000000__0\r\n" +
                                          "000__000000_____00____0000000____00_____000000__00\r\n" +
                                          "0000___0000____________0000_____________0000___000\r\n" +
                                          "000000___000____________00_____________000___00000\r\n" +
                                          "00000000___________________________________0000000\r\n" +
                                          "000000000000___________________________00000000000\r\n" +
                                          "000000000000000000_______________00000000000000000\r\n" +
                                          "00000000000000000000000000000000000000000000000000");
                        break;
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
