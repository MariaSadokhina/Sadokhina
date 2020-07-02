using System;

namespace Model
{
    /// <summary>
    /// Класс описывающий круг
    /// </summary>
    [Serializable]
    public class Circle : FigureBase
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;
        /// <summary>
        /// Свойство Радиуса
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area
        {
            get
            {
                return  Math.Round((Math.Pow(_radius, 2) * Math.PI),3);
            }
        }

        /// <summary>
        /// Конструктор круг
        /// </summary>
        /// <param name="radius">радиус</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        ///  Информация о площади
        /// </summary>
        public override string GetInfo()
        {
            return String.Format("{0};{1};{2}",
                Radius, Radius, Area);
        }
    }
}
