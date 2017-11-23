using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IComponent
{
    /// <summary>
    /// Вычисление комплексного сопротивления резистора.
    /// </summary>
    public class Resistor : IComponent
    {
        /// <summary>
        /// Объявление номинала.
        /// </summary>
        private double _nominal;

        /// <summary>
        /// Конструктор по номиналу.
        /// </summary>
        /// <param name="nominal"></param>
        public Resistor(double nominal)
        {
            if (nominal < 0)
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
        /// Получаем комплексное сопротивление резистора
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
            return new Complex(_nominal, 0);
        }
    }
}
