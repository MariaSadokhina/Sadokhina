using System;

namespace OOP2Library
{
    /// <summary>
    /// Класс, описывающий список людей
    /// </summary>
    public class PersonBaseList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        private PersonBase[] _personArray = new PersonBase[0];

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Человек</param>
        public void AddPerson(PersonBase person)
        {
            Array.Resize(ref _personArray, _personArray.Length + 1);
            _personArray[_personArray.Length - 1] = person;
        }

        /// <summary>
        /// Возврат количества людей в списке
        /// </summary>
        public int Lenght => _personArray.Length;

        #region Поиск

        /// <summary>
        /// Поиск человека по индексу
        /// </summary>
        /// <param name="i">Индекс человека в списке</param>
        /// <returns>Возвращает человека по индексу</returns>
        public PersonBase SearchByIndex(int i)
        {
            if (_personArray.Length > i)
            {
                var searchElement = _personArray[i];
                return searchElement;
            }
            else
            {
                throw new ArgumentException($"Индекс не существует!");
            }
        }
        #endregion
    }
}
