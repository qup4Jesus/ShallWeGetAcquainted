using System;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string info;
                int select;

                info = "Выберите интересуешее задание:\n\n" +
                       "1 - Знакомство;\n" +
                       "2 - Твой любимый цвет;\n" +
                       "3 - Реверс твоего имени;\n" +
                       "4 - Сортировка массивов;\n" +
                       "5 - ВЫХОД";

                select = CheckingTheSelection(info, 4);

                switch (select)
                {
                    case 1:
                        Acquaintance();
                        break;
                    case 2:
                        ComparisonOperation();
                        break;
                    case 3:
                        ReverseName();
                        break;
                    case 4:
                        SortArray();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу...");

                Console.ReadKey();
                Console.Clear();
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
            DismemberName(myName);
            Console.WriteLine();

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
                Console.WriteLine("Напишите свой любимый цвет.\n" +
                                  "Для выхода в основное меню напишите стоп СТОП.\n" +
                                  "Для пропуска напишите СЛЕДУЮЩИЙ.");

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

                        Console.WriteLine("00000000000000000000000000000000000000000000000000\n" +
                                          "0000000000000000000000_______000000000000000000000\n" +
                                          "0000000000000_________________________000000000000\n" +
                                          "0000000000____00______00__00_______00____000000000\n" +
                                          "0000000____0000_______000000________0000____000000\n" +
                                          "00000___000000________0000000_______0000000___0000\n" +
                                          "0000__000000000______00000000_______000000000__000\n" +
                                          "000_0000000000000___00000000000___000000000000___0\n" +
                                          "00_00000000000000000000000000000000000000000000__0\n" +
                                          "0__00000000000000000Ты бетман!000000000000000000_0\n" +
                                          "0__000000000000000000000000000000000000000000000_0\n" +
                                          "00_000000000000000000000000000000000000000000000_0\n" +
                                          "00__0000000000000000000000000000000000000000000__0\n" +
                                          "000__000000_____00____0000000____00_____000000__00\n" +
                                          "0000___0000____________0000_____________0000___000\n" +
                                          "000000___000____________00_____________000___00000\n" +
                                          "00000000___________________________________0000000\n" +
                                          "000000000000___________________________00000000000\n" +
                                          "000000000000000000_______________00000000000000000\n" +
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
        private static void DismemberName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");

                if (i == name.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Последняя буква вашего имени: {name[i]}");
                }
            }
        }
        private static void ReverseName()
        {
            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
                Console.Write(name[i] + " ");
        }
        private static void SortArray()
        {
            int numPositive = 0;
            int summ = 0;
            int temp;
            int minValue = int.MaxValue;

            int[] array = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }
            Console.WriteLine("Минимальное значение: " + minValue);

            Console.WriteLine("Сортировка массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 13));

                foreach (int item in array)
                    Console.Write(item + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            Console.WriteLine("\n\nСумма всех элементов массива: " + summ);

            int[][] arr = new int[3][];

            arr[0] = new int[2] { 1, 2 };
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int[] line in arr)
            {
                Console.WriteLine();

                foreach (int item in line)
                {
                    Console.Write(item + " ");
                }
            }

            int[,] arr1 =
            {
                { -5, 6, 9, 1, 2, -3 },
                { -8, 8, 1, 1, 2, -3 }
            };

            Console.WriteLine("\n\nМассив чисел: ");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] > 0)
                        numPositive++;
                }
            }
            Console.WriteLine("\n\nКоличество положительных чисел в массиве: " + numPositive);

            int[,] arr2 =
            {
                { -5, 6, 9, 1, 2, -3 },
                { -8, 8, 1, 1, 2, -3 }
            };

            Console.WriteLine("\n\nМассив чисел: ");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nОтсортированный массив чисел: ");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr2.GetLength(1); k++)
                    {
                        if (arr2[i, j] > arr2[i, k])
                        {
                            temp = arr2[i, k];
                            arr2[i, k] = arr2[i, j];
                            arr2[i, j] = temp;
                        }
                    }
                }

                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
