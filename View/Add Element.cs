using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using IComponent;

namespace View
{
    public partial class Add_Element : Form
    {
        /// <summary>
        /// Функция для передачи значения между формами
        /// </summary>
        /// <param name="sender"></param>
        public Add_Element()
        {
            InitializeComponent();
        }
        public IComponent.IComponent Component { get
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text == "" || double.Parse(textBox1.Text) == 0)
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var resistor = new Resistor(Convert.ToDouble(textBox1.Text));
                        return resistor;
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox2.Text == "" || double.Parse(textBox2.Text) == 0)
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var capacitor = new Capacitor(Convert.ToDouble(textBox2.Text));
                        return capacitor;
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (textBox3.Text == "" || double.Parse(textBox3.Text) == 0)
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var inductor = new Inductor(Convert.ToDouble(textBox3.Text));
                        return inductor;
                    }
                }
                else return null;
            } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.ReadOnly = textBox3.ReadOnly = true;
                textBox1.ReadOnly = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.ReadOnly = textBox3.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.ReadOnly = textBox2.ReadOnly = true;
                textBox3.ReadOnly = false;
            }
        }
        /// <summary>
        /// Добавление элементов в comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Резистор", "Конденсатор", "Индуктивность" });
        }
        /// <summary>
        /// Выполнение расчетов при нажатии на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Ограничения на ввод в textBox-ы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
