using System;
using System.Collections.Generic;

namespace OOP2Library
{
    //TODO: Вынести в отдельный класс ok
    //TODO: XML ok
    /// <summary>
    /// Генерация случайного взрослого
    /// </summary>
    public class RandomAdult
    {
        /// <summary>
        /// Объект рандом для работы в классе Adult
        /// </summary>
        private static Random _adultRandom = new Random();

        /// <summary>
        /// Заполнение случайной информацией
        /// </summary>
        /// <returns>экземпляр класса с заполненными полями</returns>
        public static Adult GetRandomAdult()
        {
            var random = new Random();
            var adult = new Adult(GetAge(), GetPassportData(),
                GetWorkPlace(), (MaritalStatus)_adultRandom.Next(0, 2));

            if (adult.MaritalStatus == MaritalStatus.Married)
            {
                adult.Partner = GetPartner();
            }
            return adult;

            //Получение случайного возраста
            int GetAge()
            {
                return random.Next(Adult.MinAge, Adult.MaxAge + 1);
            }
            //Получение случайного места работы
            string GetWorkPlace()
            {
                var workPlaceList = new List<string>()
                {
                    "Электроэнергетик", "IT-Специалсит",
                    "Инженер-проектировщик", "Полицейский",
                    "Врач", "Учитель"
                };
                return workPlaceList[random.Next(0, workPlaceList.Count)];
            }
            //Получение случайных паспортных данных
            string GetPassportData()
            {
                return $"{random.Next(1000, 10000)} " +
                    $"{random.Next(100000, 1000000)}";
            }
            // Получение партнера для взрослого
            Adult GetPartner()
            {
                {
                    var partner = new Adult(GetAge(), GetWorkPlace(),
                        GetPassportData(), MaritalStatus.Married);
                    while (partner.Gender == adult.Gender)
                    {
                        _ = RandomPerson.GetRandomPerson(true);
                    }
                    partner.LastName = adult.LastName;
                    partner.Partner = adult;
                    return partner;
                }
            }
        }
    }
}
