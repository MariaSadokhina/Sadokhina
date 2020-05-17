using System;
using System.Text.RegularExpressions;

namespace OOP2Library
{
    /// <summary>
    /// Класс Человек
    /// </summary>
    public abstract class PersonBase
    {
        #region Свойства и поля класса Person
        /// <summary>
        /// Имя человека
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Свойство Имя
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = CheckRegister(value);
            }
        }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Свойство Фамилия
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = CheckRegister(value);
            }
        }

        /// <summary>
        /// Возраст человека
        /// </summary>
        private int _age;

        /// <summary>
        /// Свойство Возраст
        /// </summary>
        public int Age
        {
            get { return _age; }
        }

        /// <summary>
        /// Свойство Пол
        /// </summary>
        public Gender Gender { get; set; }

        protected PersonBase(int age)
        {
            _age = AgeValidation(age);
        }
        #endregion

        /// <summary>
        /// Объект рандом для работы в классе BasePerson
        /// </summary>
        private static Random _baseRandom = new Random();

        /// <summary>
        /// Генерация случайной персоны
        /// </summary>
        /// <returns>Новыю персону</returns>
        public void GetRandomPerson()
        {
            string[] maleFirstNames = new string[]
{
                "Андрей", "Алексей", "Артем", "Сергей",
                "Максим", "Дмитрий", "Василий", "Александр"
};
            string[] femaleFirstNames = new string[]
            {
                "Анна", "Анастасия", "Мария", "Юлия",
                "Дарья", "Татьяна", "Виталина", "Елена"
            };
            string[] lastNames = new string[]
            {
                "Андрейченко", "Евтушенко", "Питько", "Фоменко",
                "Гневко", "Жук", "Давидян", "Маргарян"
            };
            var random = new Random();
            var addGender = Gender.Male;
            switch (random.Next(1, 3))
            {
                case 1:
                    addGender = Gender.Male;
                    break;
                case 2:
                    addGender = Gender.Female;
                    break;
            }
            string firstNames =
                addGender == Gender.Male
                ? maleFirstNames[random.Next(maleFirstNames.Length)]
                : femaleFirstNames[random.Next(femaleFirstNames.Length)];

            LastName = lastNames[random.Next(lastNames.Length)];
        }

        /// <summary>
        /// Метод проверки на наличие только русских или английских символов
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns>Корректная строка</returns>
        private string CheckString(string value)
        {
            if (value == string.Empty)
            {
                throw new Exception("Вы ничего не ввели. Повторите! ");
            }
            else
            {
                var eng = new Regex(@"[A-z ]+[A-z- ]+");
                var rus = new Regex(@"[А-я ]+[А-я- ]+");
                var numbers = new Regex(@"[0-9]");
                if ((eng.IsMatch(value) && rus.IsMatch(value)))
                {
                    throw new ArgumentException("Имя/ Фамилия только на " +
                        "'Английском' или 'Русском' языке! Повторите: ");
                }
                if (numbers.IsMatch(value))
                {
                    throw new ArgumentException("Имя/ Фамилия недолжно " +
                        "содержать цифр! Повторите: ");
                }
                else
                {
                    return value;
                }
            }
        }
        /// <summary>
            /// Преобразвание в правильные регистры
            /// </summary>
            /// <returns>Возвращает строку в с правильными регистрами</returns>
        private string CheckRegister(string value)
        {
            CheckString(value);
            string FirstLetterUp(string word)
            {
                return word.Substring(0, 1).ToUpper() +
                    word.Substring(1, word.Length - 1).ToLower();
            }
            var symbols = new[] { "-", " " };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    string[] words = value.Split(symbol.ToCharArray()[0]);
                    return words.Length > 1
                        ? $"{FirstLetterUp(words[0])}{symbol}{FirstLetterUp(words[1])}"
                        : FirstLetterUp(value);
                }
            }
            return FirstLetterUp(value);
        }
        /// <summary>
        /// Получение информации о персоне
        /// </summary>
        /// <param name="optionalParameter">необходимость вывода дополнительных данных</param>
        /// <returns>информация о персоне</returns>
        public abstract string GetInfo(bool optionalParameter = true);
        protected abstract int AgeValidation(int value);
    }
}
