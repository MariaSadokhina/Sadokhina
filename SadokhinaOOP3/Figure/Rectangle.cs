namespace Figure
{
    /// <summary>
    /// Класс описывающий прямоугольник
    /// </summary>
    public class Rectangle : FigureBase
    {
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;
        /// <summary>
        /// Длина
        /// </summary>
        private double _length;
        /// <summary>
        /// Свойство Ширины
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свтойство Длины
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свтойство площади и ее расчет
        /// </summary>
        public override double Area
        {
            get
            {
                return _width * _length;
            }
        }
        /// <summary>
        /// Конструктор прямоугольник
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }
    }
}
