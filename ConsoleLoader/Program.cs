using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using IComponent;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("------МЕНЮ------\n");
            Console.Write("Расчет комплексного сопротивления для различных элементов\n");
            Console.Write("1.Резистор\n2.Конденсатор\n3.Катушка индуктивности\n0.Выход\n");
            int switchCase;
            bool fl = true;
            while (fl == true)
            {
                Console.Write("Выберите элемент: ");
                switchCase = int.Parse(Console.ReadLine());
                switch (switchCase)
                {
                    case 1:
                        Console.Write("---Введите значение для сопротивления резистора: ");
                        var r = new IComponent.Resistor(double.Parse(Console.ReadLine()));
                        r.GetImpedance(0);
                        break;
                    case 2:
                        Console.Write("---Введите значение для ёмкости конденсатора (нФ): ");
                        var nominal = double.Parse(Console.ReadLine());
                        var c = new IComponent.Capacitor(nominal);
                        Console.Write("---Введите значение частоты (Гц): ");
                        var _c = c.GetImpedance(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"{_c}");
                        break;
                    case 3:
                        Console.Write("---Введите значение для индуктивности (мГН): ");
                        var l = new IComponent.Inductor(double.Parse(Console.ReadLine()));
                        Console.Write("---Введите значение частоты (Гц): ");
                        l.GetImpedance(double.Parse(Console.ReadLine()));
                        break;
                    case 0:
                        fl = false;
                        break;
                    default:
                        Console.WriteLine("Command not found!");
                        break;
                }
            }
        }
    }
}
