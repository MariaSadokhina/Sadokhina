using System;

namespace OOP2Library
{
    public class Child : PersonBase
    {
        /// <summary>
        /// Персона: Отец
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Персона: Мать
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Название школы
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Максимальный возраст ребенка
        /// </summary>
        public const int MaxAge = 18;


        /// <summary>
        /// Конструктор ребенка без параметров
        /// </summary>
        public Child() : base(0) { }

        /// <summary>
        /// Конструктор ребенка
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <param name="school">//TODO: ?</param>
        /// <param name="mother">Мать</param>
        /// <param name="father">Отец</param>
        public Child(int age, string school, Adult mother, Adult father)
            : base(age)
        {
            var person = RandomPerson.GetRandomPerson(false);

            FirstName = person.FirstName;
            LastName = person.LastName;
            Gender = person.Gender;
            School = school;
            Mother = mother;
            Father = father;
        }

        /// <summary>
        /// Получение информации о ребенке
        /// </summary>
        /// <param name="isShowingParents">Информация о родителях</param>
        /// <returns>Информация о ребенке</returns>
        public override string GetInfo(bool isShowingParents = true)
        {
            var info = $"Имя: {FirstName}\n " +
                $"Фамилия: {LastName}\n " +
                $"Возраст: {Age}\n " +
                $"Пол: {Gender}\n" +
                $"Школа: {School}\n";
            if (isShowingParents)
            {
                info += Father != null
                    ? $"Отец:\n{Father.GetInfo(false)}"
                    : string.Empty;
                info += Mother != null
                    ? $"Мать:\n{Mother.GetInfo(false)}"
                    : string.Empty;
            }
            return info;
        }

        /// <summary>
        /// Проверка ввода возраста
        /// </summary>
        /// <param name="value">возраст</param>
        /// <returns>возраст</returns>
        protected override int AgeValidation(int value)
        {
            if (value >= MaxAge)
            {
                throw new ArgumentException($"Возраст ребенка должен " +
                    $"быть не больше {MaxAge}");
            }
            return value;
        }

        /// <summary>
        /// Продать дом
        /// </summary>
        /// <returns>Не получится продать дом самостоятельно</returns>
        public string SellHouse()
        {
            return $"{GetInfo()} не может продать дом самостоятельно, " +
                $"так как ещё слишком молод.";
        }
    }
}
