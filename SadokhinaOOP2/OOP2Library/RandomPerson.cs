using System;

namespace OOP2Library
{
    //TODO: Переименовать и поменять модификатор доступа ?
    //TODO: Вынести в отдельный класс ?

    /// <summary>
    /// Генерация случайной персоны
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Генерация имени и фамилии
        /// </summary>
        /// <returns>Новыю персону</returns>
        public static PersonBase GetRandomPerson(bool isAdult)
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

            string name =
                addGender == Gender.Male
                ? maleFirstNames[random.Next(maleFirstNames.Length)]
                : femaleFirstNames[random.Next(femaleFirstNames.Length)];

            PersonBase generatedPerson = isAdult ? new Adult() : (PersonBase)new Child();
            generatedPerson.FirstName = name;
            generatedPerson.LastName = lastNames[random.Next(lastNames.Length)];

            return generatedPerson;
        }
    }
}
