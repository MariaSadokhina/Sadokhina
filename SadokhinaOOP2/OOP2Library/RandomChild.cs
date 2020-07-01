using System;

namespace OOP2Library
{
    /// <summary>
    /// Генерация случайного ребенка
    /// </summary>
    public static class RandomChild
    {
        /// <summary>
        /// Заполнение информации о ребенке случайными значениями
        /// </summary>
        /// <returns>экземпляр класса с заполненными полями</returns>
        public static Child GetRandomChild()
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
                return random.Next(7, Child.MaxAge);
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
                var parent = RandomAdult.GetRandomAdult();
                while (parent.Gender != gender)
                {
                    parent = RandomAdult.GetRandomAdult();
                }
                return parent;
            }
        }
    }
}
