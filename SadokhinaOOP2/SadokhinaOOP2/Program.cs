using System;
using OOP2Library;

namespace SadokhinaOOP2
{
    //TODO: RSDN ok
    /// <summary>
    /// Основной класс программы
    /// </summary>
    class Program
    {
        //TODO: XML ok
        /// <summary>
        /// Тестирование программы
        /// </summary>
        private static void Main()
        {
            var personList = new PersonBaseList();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (random.Next(0, 10) < 5)
                {
                    personList.AddPerson(RandomAdult.GetRandomAdult());
                }
                else
                {
                    personList.AddPerson(RandomChild.GetRandomChild());
                }
            }

            // Вывод списка персон в консоль
            for (int i = 0; i < personList.Lenght; i++)
            {
                Console.WriteLine(personList.SearchByIndex(i).GetInfo());
            }

            var unknownPerson = personList.SearchByIndex(1);
            Console.WriteLine($"Найденая персона относится к типу:" +
                $"{unknownPerson.GetType().Name}");
            switch (unknownPerson)
            {
                //TODO: Вызвать специфический для класса метод ok
                case Child child:
                    Console.WriteLine($"Информация о ребенке:" +
                        $"\n{child.GetInfo(true)}");
                    Console.WriteLine(child.SellHouse());
                    break;

                case Adult adult:
                    Console.WriteLine($"Информация о взрослом:" +
                        $"\n {adult.GetInfo(true)}");
                    Console.WriteLine(adult.SellHouse());
                    break;

                default:
                    throw new ArgumentException($"Нет такого типа " +
                        $"унаследованого от {nameof(PersonBase)}");
            }
            Console.ReadLine();
        }
    }
}
