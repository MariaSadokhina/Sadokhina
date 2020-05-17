using System;
using OOP2Library;

namespace SadokhinaOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBaseList personList = new PersonBaseList();
            Random mainRandom = new Random();
            int counter = mainRandom.Next(1, 6);
            for (int i = 0; i < counter; i++)
            {
                personList.AddPerson(Adult.GetRandomAdult());
            }
            for (int i = 0; i < 7 - counter; i++)
            {
                personList.AddPerson(Child.GetRandomChild());
            }
            // Вывод списка персон в консоль
            for (int i = 0; i < personList.Lenght; i++)
            {
                Console.WriteLine(personList.SearchByIndex(i).GetInfo());
            }
            var unknownPerson = personList.SearchByIndex(4);
            Console.WriteLine($"Найденая персона относится к типу:{unknownPerson.GetType().Name}");
            switch (unknownPerson)
            {
                case Child child:
                    Console.WriteLine($"Информация о ребенке:\n{child.GetInfo(true)}");
                    break;

                case Adult adult:
                    Console.WriteLine($"Информация о взрослом:\n {adult.GetInfo(true)}");
                    break;
                default:
                    throw new ArgumentException($"Нет такого типа " +
                        $"унаследованого от {nameof(PersonBase)}");
            }
            Console.ReadLine();
        }
    }
}
