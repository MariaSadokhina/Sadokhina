using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OOP2Library
{
    /// <summary>
    /// Взрослый
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public const int MinAge = 18;
        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int MaxAge = 130;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Паспортные данные
        /// </summary>
        public string PassportData
        { get; private set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public new int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                _age = AgeValidation(value);
            }
        }

        /// <summary>
        /// Место работы
        /// </summary>
        public string WorkPlace { get; set; }

        /// <summary>
        /// Семейный статус
        /// </summary>      
        public MaritalStatus MaritalStatus { get; private set; }

        /// <summary>
        /// Партнер
        /// </summary>       
        public Adult Partner { get; set; }

        /// <summary>
        /// Объект рандом для работы в классе Adult
        /// </summary>
        private static Random _adultRandom = new Random();


        /// <summary>
        /// Конструктор взрослый человек
        /// </summary>
        /// <param name="passportData">Пасспортные данные</param>
        /// <param name="age">Возраст</param>
        /// <param name="workPlace">Место работы</param>
        /// <param name="maritalStatus">Семейное положение</param>
        public Adult(int age, string passportData, string workPlace, MaritalStatus maritalStatus) : base(age)
        {
            GetRandomPerson();
            PassportData = passportData;
            WorkPlace = workPlace;
            MaritalStatus = maritalStatus;
        }

        /// <summary>
        /// Получение информации о взрослом
        /// </summary>
        /// <param name="isShowingPartner">Необходимость вывода партнера</param>
        /// <returns>информация о взрослом</returns>
        public override string GetInfo(bool isShowingPartner = true)
        {
            var info = $"Имя: {FirstName}\n" +
                $"Фамилия: {LastName}\n" +
                $"Возраст: {Age}\n" +
                $"Пол: {Gender}\n" +
                $"Паспортне данные: {PassportData}\n";
            info += WorkPlace != null
                ? $"Место работы: {WorkPlace}\n"
                : $"Место работы: Безработный\n";
            if (isShowingPartner)
            {
                info += Partner != null
                    ? $"Партнер: \n{Partner.GetInfo(false)}"
                    : $"Партнер: Отсутствует\n";
            }
            return info;
        }

        /// <summary>
        /// Заполнение случайной информацией
        /// </summary>
        /// <returns>экземпляр класса с заполненными полями</returns>
        static public Adult GetRandomAdult()
        {
            var random = new Random();
            var adult = new Adult(GetAge(), GetPassportData(), GetWorkPlace(), (MaritalStatus)_adultRandom.Next(0, 2));
            if (adult.MaritalStatus == MaritalStatus.Married)
            {
                adult.Partner = GetPartner();
            }
            return adult;

            //Получение случайного возраста
            int GetAge()
            {
                return random.Next(18, MaxAge + 1);
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
                        partner.GetRandomPerson();
                    }
                    partner.LastName = adult.LastName;
                    partner.Partner = adult;
                    return partner;
                }
            }
        }

        /// <summary>
        /// Проверка ввода возраста
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns>возраст</returns>
        protected override int AgeValidation(int value)
        {
            if (value < MinAge | value > MaxAge + 1)
            {
                throw new ArgumentException($"Возраст взрослого должен быть между {MinAge} и {MaxAge}");
            }
            return value;
        }

    }
}
