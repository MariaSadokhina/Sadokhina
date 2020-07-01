using System;

namespace Model
{
    /// <summary>
    /// Базовый абстрактный класс для геометрических фигур
    /// </summary>
    [Serializable]
    public abstract class FigureBase
    {
        /// <summary>
        /// Информация о площади
        /// </summary>
        public abstract string GetInfo();
    }
}
