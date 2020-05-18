using System;
using OOP2Library;

namespace SadokhinaOOP2
{
    class Program
    {
        private static void Main()
        {
            var personList = new PersonBaseList();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (random.Next(0, 10) < 5)
                {
                    personList.AddPerson(Adult.GetRandomAdult());
                }
                else
                {
                    personList.AddPerson(Child.GetRandomChild());
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
                case Child child:
                    Console.WriteLine($"Информация о ребенке:" +
                        $"\n{child.GetInfo(true)}");
                    break;

                case Adult adult:
                    Console.WriteLine($"Информация о взрослом:" +
                        $"\n {adult.GetInfo(true)}");
                    break;

                default:
                    throw new ArgumentException($"Нет такого типа " +
                        $"унаследованого от {nameof(PersonBase)}");
            }
            Console.ReadLine();
        }
    }
}
