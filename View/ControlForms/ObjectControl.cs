using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IComponent;

namespace View
{
    public partial class ObjectControl : UserControl
    {
        /// <summary>
        /// геттер и сеттер для изменяемого значения
        /// </summary>
        public double ModifyValue { get; set; }
        /// <summary>
        /// конструктор класса
        /// </summary>
        public ObjectControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// метод запрещающий ввод значения не выбранных элементов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseElement(object sender, EventArgs e)
        {           
            if (ElementComboBox.SelectedIndex == 0)
            {
                ResistorTextBox.ReadOnly = false;
                CapacitorTextBox.ReadOnly = InductorTextBox.ReadOnly = true;
            }
            else if (ElementComboBox.SelectedIndex == 1)
            {
                CapacitorTextBox.ReadOnly = false;
                ResistorTextBox.ReadOnly = InductorTextBox.ReadOnly = true;
            }
            else if (ElementComboBox.SelectedIndex == 2)
            {
                InductorTextBox.ReadOnly = false;
                CapacitorTextBox.ReadOnly = ResistorTextBox.ReadOnly = true;
            }
        }
        /// <summary>
        /// список элементов для ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectControl_Enter(object sender, EventArgs e)
        {
            ElementComboBox.Items.AddRange(new string[] { "Resistor", "Capacitor", "Inductor" });
        }

        /// <summary>
        /// метод для передачи изменяемого значения сопротивления
        /// </summary>
        public void ResistorModify()
        {
            ResistorTextBox.Text = ModifyValue.ToString();
            ElementComboBox.Text = "Resistor";
            CapacitorTextBox.ReadOnly = InductorTextBox.ReadOnly = true;
        }
        /// <summary>
        /// метод для передачи изменяемого значения емкости
        /// </summary>
        public void CapacitorModify()
        {
            CapacitorTextBox.Text = ModifyValue.ToString();
            ElementComboBox.Text = "Capacitor";
            ResistorTextBox.ReadOnly = InductorTextBox.ReadOnly = true;
        }
        /// <summary>
        /// метод для передачи изменяемого значения индуктивности
        /// </summary>
        public void InductorModify()
        {
            InductorTextBox.Text = ModifyValue.ToString();
            ElementComboBox.Text = "Inductor";
            CapacitorTextBox.ReadOnly = ResistorTextBox.ReadOnly = true;
        }
        /// <summary>
        /// Метод возвращающий номинал элемента
        /// </summary>
        /// <returns></returns>
        public IComponent.IComponent CalculateImpedance()
        {
                if (ElementComboBox.Text == "Resistor")
                {
                    if (ResistorTextBox.Text == "" || ResistorTextBox.Text[0].ToString() == ",")
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var resistor = new Resistor(Convert.ToDouble(ResistorTextBox.Text));
                        return resistor;
                    }
                }
                else if (ElementComboBox.Text == "Capacitor")
                {
                    if (CapacitorTextBox.Text == "" || CapacitorTextBox.Text[0].ToString() == ",")
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var capacitor = new Capacitor(Convert.ToDouble(CapacitorTextBox.Text));
                        return capacitor;
                    }
                }
                else if (ElementComboBox.Text == "Inductor")
                {
                    if (InductorTextBox.Text == "" || InductorTextBox.Text[0].ToString() == ",")
                    {
                        throw new ArgumentException("Value Error!");
                    }
                    else
                    {
                        var inductor = new Inductor(Convert.ToDouble(InductorTextBox.Text));
                        return inductor;
                    }
                }
                else return null;
            }
        /// <summary>
        /// метод запрещающий ввод некорректных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResistorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }
                if (e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                    }
                    else if ((sender as TextBox).Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
    }


