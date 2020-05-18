using System;

namespace OOP2Library
{
    public class Child : PersonBase
    {

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

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
        private const int MaxAge = 18;

        /// <summary>
        /// Возраст
        /// </summary>
        public new int Age
        {
            get => _age;
            private set => _age = AgeValidation(value);
        }

        /// <summary>
        /// Конструктор ребенка
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <param name="mother">Мать</param>
        /// <param name="father">Отец</param>
        public Child(int age, string school, Adult mother, Adult father)
            : base(age)
        {
            GetRandomPerson();
            Age = AgeValidation(age);
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
        /// Заполнение информации о ребенке случайными значениями
        /// </summary>
        /// <returns>экземпляр класса с заполненными полями</returns>
        static public Child GetRandomChild()
        {
            var random = new Random();
            var child = new Child(GetAge(), GetSchoolName(), 
                GetParent(Gender.Female), GetParent(Gender.Male))
            {
                School = GetSchoolName()
            };
            return child;

            //Получение случайного возраста
            int GetAge()
            {
                return random.Next(7, MaxAge);
            }

            //Получение название школы
            string GetSchoolName()
            {
                var school = $"Школа №{random.Next(1, 999)}";
                return school;
            }

            //Получение родителей ребенка
            Adult GetParent(Gender gender)
            {
                var parent = Adult.GetRandomAdult();
                while (parent.Gender != gender)
                {
                    parent = Adult.GetRandomAdult();
                }
                return parent;
            }
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
    }
}
