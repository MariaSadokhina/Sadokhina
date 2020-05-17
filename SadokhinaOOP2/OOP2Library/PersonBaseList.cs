using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Lenght
        {
            get
            {
                return _personArray.Length;
            }
        }

        #region Поиск

        /// <summary>
        /// Найти по списку индекс человека
        /// </summary>
        /// <param name="person"></param>
        /// <returns>Возвращает индекс человека</returns>
        public int InfoIndex(PersonBase person)
        {
            for (int i = 0; i < _personArray.Length; i++)
            {
                if (_personArray[i].FirstName == person.FirstName &&
                    _personArray[i].LastName == person.LastName &&
                    _personArray[i].Age == person.Age &&
                    _personArray[i].Gender == person.Gender)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Поиск человека по индексу
        /// </summary>
        /// <param name="i">Индекс человека в списке</param>
        /// <returns>Возвращает человека по индексу</returns>
        public PersonBase SearchByIndex(int i)
        {
            if (0 <= i || i < _personArray.Length)
            {
                return _personArray[i];
            }
            else
            {
                throw new ArgumentException("Такого индекса нет!");
            }
        }
        #endregion

        #region Удалить
        /// <summary>
        /// Очистить весь список людей
        /// </summary>
        public void ClearAllPerson()
        {
            Array.Resize(ref _personArray, 0);
        }

        /// <summary>
        /// Удаление человека из списка
        /// </summary>
        /// <param name="index">Индекс человека в списке</param>
        public void DeletePerson(int index)
        {
            for (int i = index; i < _personArray.Length - 1; i++)
            {
                _personArray[i] = _personArray[i + 1];
            }
            Array.Resize(ref _personArray, _personArray.Length - 1);
        }
        #endregion
    }
}
