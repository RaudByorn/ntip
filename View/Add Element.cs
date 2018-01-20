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
        /// Геттер для компонента
        /// </summary>
        public IComponent.IComponent Component { get
            {
                return objectControl1.CalculateImpedance();
                } }
        /// <summary>
        /// геттер и сеттер для значения для модификации
        /// </summary>
        public double ModifyValue { get; set; }
        /// <summary>
        /// метод для передачи изменяемого значения сопротивления
        /// </summary>
        public void ResistorModify()
        {
            objectControl1.ModifyValue = ModifyValue;
            objectControl1.ResistorModify();
        }
        /// <summary>
        /// метод для передачи изменяемого значения индуктивности
        /// </summary>
        public void InductorModify()
        {
            objectControl1.ModifyValue = ModifyValue;
            objectControl1.InductorModify();
        }
        /// <summary>
        /// метод для передачи изменяемого значения емкости
        /// </summary>
        public void CapacitorModify()
        {
            objectControl1.ModifyValue = ModifyValue;
            objectControl1.CapacitorModify();
        }
        /// <summary>
        /// Функция для передачи значения между формами
        /// </summary>
        /// <param name="sender"></param>
        public Add_Element()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Выполнение расчетов при нажатии на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementButtonClick(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
