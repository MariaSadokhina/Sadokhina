﻿using System;

namespace Model
{
    /// <summary>
    /// Класс описывающий треугольник
    /// </summary>
    [Serializable]
    public class Triangle : FigureBase
    {
        /// <summary>
        /// Основание треугольника
        /// </summary>
        private double _triangleBase;
        /// <summary>
        /// Высота
        /// </summary>
        private double _heigth;
        /// <summary>
        /// Свойство основания трегуольника
        /// </summary>
        public double TriangleBase
        {
            get
            {
                return _triangleBase;
            }
            set
            {
                _triangleBase = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свойство высоты треугольника
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = Validation.MeasurementValidation(value);
            }
        }
       
        
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area
        {
            get
            {
                return (_triangleBase * _heigth) / 2;
            }
        }
        /// <summary>
        /// Конструктор треугольник
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="heigth">Высота</param>
        public Triangle(double triangleBase, double heigth)
        {
            Heigth = heigth;
            TriangleBase = triangleBase;
        }
        /// <summary>
        ///  Информация о площади
        /// </summary>
        public override string GetInfo()
        {
            return String.Format("{0};{1};{2}",
                Heigth, TriangleBase, Area);
        }
    }
}