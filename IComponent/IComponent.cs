using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IComponent
{
    /// <summary>
    /// Объявление интерфейса
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Метод для поиска комплексного сопротивления.
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        Complex GetImpedance(double frequency);

        /// <summary>
        /// Объявление свойства интерфейса.
        /// </summary>
        double Nominal { get; }
    }
}
