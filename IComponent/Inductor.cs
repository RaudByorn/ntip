using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IComponent
{
    /// <summary>
    /// Вычисление комплексного сопротивления индуктивности.
    /// </summary>
    public class Inductor : IComponent
    {
        /// <summary>
        /// номинал
        /// </summary>
        double _nominal;

        /// <summary>
        /// Конструктор по номиналу.
        /// </summary>
        /// <param name="nominal"></param>
        public Inductor(double nominal)
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
        /// Получаем комплексное сопротивление для индуктивности
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public Complex GetImpedance(double frequency)
        {
           return new Complex(0, (2 * Math.PI * _nominal * Math.Pow(10, -3) * frequency));
        }
    }
}
