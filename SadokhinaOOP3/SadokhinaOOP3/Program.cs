﻿using System;
using System.Text;
using Figure;

namespace SadokhinaOOP3
{
    //TODO: RSDN ok
    /// <summary>
    /// Основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Тестирование программы
        /// </summary>
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome!");
            Console.WriteLine("\nВыберите действие:\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Расчет площади треугольника;");
                    Console.WriteLine("2 - Расчет площади прямоугольника;");
                    Console.WriteLine("3 - Расчет площади круга;");
                    Console.WriteLine("4 - Выход из приложения.");
                    var keyMenu = Console.ReadLine();
                    switch (keyMenu)
                    {
                        //TODO: RSDN ok
                        case "1":
                        {
                            GetInfo(new Triangle
                                (GetCorrectDouble("Основание треугольника:"),
                                GetCorrectDouble("Высота треугольника:")));
                            break;
                        }
                        case "2":
                            {
                                GetInfo(new Rectangle
                                    (GetCorrectDouble("Высота " +
                                    "прямоугольника:"),
                                    GetCorrectDouble("Ширина " +
                                    "прямоугольника:")));
                                break;
                            }
                        case "3":
                            {
                                GetInfo(new Circle
                                    (GetCorrectDouble("Радиус круга:")));
                                break;
                            }
                        case "4":
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.WriteLine("Ошибка! " +
                                "Такого действия нет.");
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        /// <summary>
        /// Проверка на наличие букв
        /// </summary>
        /// /// <returns>Проверенное введенное измерение</returns>
        private static double GetCorrectDouble(string message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    return Validation.MeasurementValidation
                        (Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Ошибка!" +
                        " Введите неотрицательное число.");
                }
            }
        }

        /// <summary>
        /// Вывод рассчитанной площади в консоль
        /// </summary>
        private static void GetInfo(FigureBase figureBase)
        {
            Console.WriteLine($"Площадь фигуры = {figureBase.Area}\n");
        }
    }
}
