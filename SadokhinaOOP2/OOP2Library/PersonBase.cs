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
            get => _firstName;
            set => _firstName = CheckRegister(value);
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
            get => _lastName;
            set => _lastName = CheckRegister(value);
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
            get => _age;
            set => _age = AgeValidation(value);
        }

        /// <summary>
        /// Свойство Пол
        /// </summary>
        public Gender Gender { get; set; }
        #endregion

        /// <summary>
        /// Человек
        /// </summary>
        /// <param name="age">Возраст</param>
        protected PersonBase(int age)
        {
            Age = age;
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
                if (eng.IsMatch(value) && rus.IsMatch(value))
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
        public string CheckRegister(string value)
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

        /// <summary>
        /// Проверка ввода возраста
        /// </summary>
        protected abstract int AgeValidation(int value);
    }
}
