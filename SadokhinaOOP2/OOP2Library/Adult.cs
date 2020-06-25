using System;

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
        public string PassportData { get; private set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public new int Age
        {
            get => _age;
            private set => _age = AgeValidation(value);
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
        /// Конструктор взрослый человек без параметров
        /// </summary>
        public Adult() { }

        /// <summary>
        /// Конструктор взрослый человек
        /// </summary>
        /// <param name="passportData">Пасспортные данные</param>
        /// <param name="age">Возраст</param>
        /// <param name="workPlace">Место работы</param>
        /// <param name="maritalStatus">Семейное положение</param>
        public Adult(int age, string passportData, string workPlace,
            MaritalStatus maritalStatus): base(age)
        {
            var person = RandomPerson.GetRandomPerson(true);

            FirstName = person.FirstName;
            LastName = person.LastName;
            Gender = person.Gender;
            Age = AgeValidation(age);
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
        /// Проверка ввода возраста
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns>возраст</returns>
        protected override int AgeValidation(int value)
        {
            if (value < MinAge | value > MaxAge + 1)
            {
                throw new ArgumentException($"Возраст взрослого " +
                    $"должен быть между {MinAge} и {MaxAge}");
            }
            return value;
        }

        /// <summary>
        /// Продать дом
        /// </summary>
        /// <returns>Продает дом</returns>
        public string SellHouse()
        {
            return $"{GetInfo()} продает дом.";
        }
    }
}
