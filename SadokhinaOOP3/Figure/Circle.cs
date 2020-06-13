using System;

namespace Figure
{
    /// <summary>
    /// Класс описывающий круг
    /// </summary>
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
        /// Свтойство площади и ее расчет
        /// </summary>
        public override double Area
        {
            get
            {
                return (Math.Pow(_radius, 2) * Math.PI);
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
    }
}
