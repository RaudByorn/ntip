using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace IComponent
{
    /// <summary>
    /// Вычисление комплексного сопротивления конденсатора.
    /// </summary>
    public class Capacitor : IComponent
    {
        /// <summary>
        /// Объявление номинала.
        /// </summary>
        private double _nominal;

        /// <summary>
        /// Конструктор по номиналу.
        /// </summary>
        /// <param name="nominal"></param>
        public Capacitor(double nominal)
        {
            if (nominal < 0.0)
            {
                throw new ArgumentException("---!!!Значение не может быть меньше нуля!!!");
            }
            else
            {
                _nominal = nominal;
            }
        }
        public double Nominal
        {
            get { return _nominal; }
        }
        /// <summary>
        /// Получаем комплексное значение конденсатора
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
            if (frequency < 0)
            {
                throw new ArgumentException("---!!!Значение не может быть меньше нуля!!!");
            }
            else
            {
                return new Complex(0, 1 / (2 * Math.PI * _nominal * Math.Pow(10, -6) * frequency));
            }            
        }
    }
}
