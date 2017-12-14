using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using IComponent;

namespace View
{
    public partial class ImpedanceForm : Form
    {
        /// <summary>
        /// Элемент класса dataBase
        /// </summary>
        private dataBase _dataBase =  new dataBase();
        /// <summary>
        /// Инициализация класса
        /// </summary>
        public ImpedanceForm()
        {
            InitializeComponent();
        }

        private List<IComponent.IComponent> Components = new List<IComponent.IComponent>();
        /// <summary>
        /// Счетчик для DataGrid
        /// </summary>
        int _addercount = 0;
        /// <summary>
        /// Открытие вспомогательной формы и связь по делегату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                throw new ArgumentException("Value Error!");
            }
            else
            {
                Add_Element newForm = new Add_Element();
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    var component = newForm.Component;
                    Components.Add(component);
                    dataGridView1.Rows.Add(component.GetImpedance(double.Parse(textBox1.Text)));
                    dataGridView1.Rows[_addercount].Cells[1].Value = component.Nominal;
                    
                    _addercount++;
                }
            }
            
        }
        /// <summary>
        /// Удалить элемент из textBox-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Ограничения на ввод символов
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

        /// <summary>
        /// Сохранить данные в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string _savefilename = saveFileDialog1.FileName;
             var jsonfile = _dataBase.Serialize(Components);
            _dataBase.savefile(_savefilename, jsonfile);
        }

        /// <summary>
        /// открыть сохраненные данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var result = _dataBase.Deserialize(openFileDialog1.FileName);
            var counter = 0;
            
                foreach (var item in result)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[counter].Cells[0].Value = item.GetImpedance(item.Nominal);
                    dataGridView1.Rows[counter].Cells[1].Value = item.Nominal;
                    counter++;
                }  
        }

    }
}
