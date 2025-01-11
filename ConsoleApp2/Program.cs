using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;

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
                       "5 - Кортежи;\n" +
                       "6 - ВЫХОД";

                select = CheckingTheSelection(info, 5);

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
                        I_amTuples();
                        break;
                    case 6:
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
        private static string ToUpperFirstLetter(string info)
        {
            char[] letters = info.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);

            return new string(letters);
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
        private static void I_amTuples()
        {
            (string name, string lastName, string login, int loginCount, bool pet, int age, string[] favoritColor) User;

            User.pet = false;
            User.favoritColor = null;

            string[] favoritColor = new string[3];
            bool on = true;
            int j = 0;

            while (j < 3)
            {
                j++;

                Console.Write("Введите имя: ");
                User.name = Console.ReadLine().ToLower();
                User.name = ToUpperFirstLetter(User.name);

                Console.Write("Введите фамилию: ");
                User.lastName = Console.ReadLine().ToLower();
                User.lastName = ToUpperFirstLetter(User.lastName);

                Console.Write("Введите логин: ");
                User.login = Console.ReadLine();
                User.loginCount = User.login.Length;

                while (on)
                {
                    Console.Write("Есть ли у вас питомец: ");
                    string pet = Console.ReadLine().ToLower();

                    if (pet == "да" || pet == "yes")
                    {
                        User.pet = true;
                        on = false;
                    }
                    else if (pet == "нет" || pet == "no")
                    {
                        on = false;
                    }
                    else
                    {
                        Console.WriteLine("Некоректный ввод. Повторите ввод еще раз...");
                    }
                }

                Console.Write("Введите ваш возраст: ");
                User.age = checked(int.Parse(Console.ReadLine()));

                Console.WriteLine("Введите три ваших любимых цвета из представленных: ");
                Console.WriteLine("1 - Черный\n" +
                                  "2 - Белый\n" +
                                  "3 - Синий\n" +
                                  "4 - Красный\n" +
                                  "5 - Зеленый\n" +
                                  "6 - Серый\n" +
                                  "7 - Пурпурный\n" +
                                  "8 - Желтый\n" +
                                  "9 - Голубой\n");

                on = true;

                while (on)
                {
                    int i = 0;

                    while (i < 3)
                    {
                        Console.Write("Введите цвет: ");
                        string color = Console.ReadLine().ToLower();

                        switch (color)
                        {
                            case "черный":
                                favoritColor[i] = "Черный";
                                i++;
                                break;
                            case "белый":
                                favoritColor[i] = "Белый";
                                i++;
                                break;
                            case "синий":
                                favoritColor[i] = "Синий";
                                i++;
                                break;
                            case "красный":
                                favoritColor[i] = "Красный";
                                i++;
                                break;
                            case "зеленый":
                                favoritColor[i] = "Зеленый";
                                i++;
                                break;
                            case "серый":
                                favoritColor[i] = "Серый";
                                i++;
                                break;
                            case "пурпурный":
                                favoritColor[i] = "Пурпурный";
                                i++;
                                break;
                            case "желтый":
                                favoritColor[i] = "Желтый";
                                i++;
                                break;
                            case "голубой":
                                favoritColor[i] = "Голубой";
                                i++;
                                break;
                            case "black":
                                goto case "черный";
                            case "white":
                                goto case "белый";
                            case "blue":
                                goto case "синий";
                            case "red":
                                goto case "красный";
                            case "green":
                                goto case "зеленый";
                            case "grey":
                                goto case "серый";
                            case "magenta":
                                goto case "пурпурный";
                            case "yellow":
                                goto case "желтый";
                            case "cyan":
                                goto case "голубой";
                            case "1":
                                goto case "черный";
                            case "2":
                                goto case "белый";
                            case "3":
                                goto case "красный";
                            case "4":
                                goto case "синий";
                            case "5":
                                goto case "зеленый"; ;
                            case "6":
                                goto case "серый";
                            case "7":
                                goto case "пурпурный";
                            case "8":
                                goto case "желтый";
                            case "9":
                                goto case "голубой";
                            default:
                                Console.WriteLine("К сожалению я такого цвета не знаю...");
                                break;
                        }

                        User.favoritColor = favoritColor;
                        on = false;
                    }
                }

                Console.WriteLine("\n\nНажмите любую клавшу для продолжения...");
                Console.ReadKey();
                Console.Clear();

                Console.SetCursorPosition(50, 0);
                Console.WriteLine($"Информация пользователя {j}");
                Console.WriteLine(new string('_', 120));

                Console.WriteLine($"Имя: {User.name}\n" +
                                  $"Фамилия: {User.lastName}\n" +
                                  $"Логин: {User.login}\n" +
                                  $"Кол-во символов в логине: {User.loginCount}\n" +
                                  $"Питомец: {User.pet}\n" +
                                  $"Возраст: {User.age}");
                Console.Write("Любимые цвета: ");

                for (int i = 0; i < User.favoritColor.Length; i++)
                {
                    char point;

                    if (i == (User.favoritColor.Length - 1))
                    {
                        point = '.';
                    }
                    else
                    {
                        point = ',';
                    }
                    Console.Write(User.favoritColor[i] + point + " ");
                }

                Console.SetCursorPosition(50, 9);
                Console.Write("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
