using System;
using System.ComponentModel.Design;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут? ");
            string myName = Console.ReadLine();

            Console.WriteLine("Сколько вам лет? ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли у вас питомец? Укажите 'Да' или 'Нет' ");
            string pet = Console.ReadLine();

            Console.WriteLine("Какой у вас размер ноги? ");
            float footSize = Convert.ToSingle(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Меня зовут - {myName}\n" +
                              $"Мой возраст - {years}\n" +
                              $"Есть ли у меня питомец - {pet}\n" +
                              $"Мой размер ноги - {footSize}");
        }
    }
}
