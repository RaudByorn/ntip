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
        /// <summary>
        /// Список для компонентов
        /// </summary>
        private List<IComponent.IComponent> Components = new List<IComponent.IComponent>();
        /// <summary>
        /// Открытие вспомогательной формы и связь по делегату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementButtonClick(object sender, EventArgs e)
        {
            if (FrequencyTextBox.Text == "" || FrequencyTextBox.Text[0].ToString() == ",")
            {
                    var errors = "Frequency wasn't found";
                    MessageBox.Show(errors, @"Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
            {
                Add_Element newForm = new Add_Element();
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    try { 
                    var component = newForm.Component;
                    Components.Add(component);
                    ComponentsDataGrid.Rows.Add(component.GetImpedance(double.Parse(FrequencyTextBox.Text)));
                    ComponentsDataGrid.Rows[ComponentsDataGrid.Rows.Count-2].Cells[1].Value = component.Nominal;
                    }
                    catch (ArgumentException)
                    {
                        var errors = "Wrong value!";
                        MessageBox.Show(errors, @"Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Изменить номинал элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            
            if (ComponentsDataGrid.CurrentRow.Cells[0].Value == null)
            {
                var errors = "Nothing to modify";
                MessageBox.Show(errors, @"Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            { 
                IComponent.IComponent component = Components[ComponentsDataGrid.CurrentRow.Index];
                Add_Element newForm = new Add_Element();
                newForm.ModifyValue = Convert.ToDouble(ComponentsDataGrid.CurrentRow.Cells[1].Value);
                if (component is Resistor)
                {
                    newForm.ResistorModify();    
                }
                else if (component is Inductor)
                {
                    newForm.InductorModify();
                }
                else
                {
                    newForm.CapacitorModify();
                }
                newForm.ShowDialog();
                if (newForm.DialogResult == DialogResult.OK)
                {   try { 
                    component = newForm.Component;
                    ComponentsDataGrid.Rows[ComponentsDataGrid.CurrentRow.Index].Cells[0].Value = component.GetImpedance(double.Parse(FrequencyTextBox.Text));
                    ComponentsDataGrid.Rows[ComponentsDataGrid.CurrentRow.Index].Cells[1].Value = component.Nominal;
                    }
                    catch (ArgumentException)
                    {
                        var errors = "Wrong value!";
                        MessageBox.Show(errors, @"Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                };
            }
        }
        /// <summary>
        /// Удалить элемент из textBox-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteElement(object sender, EventArgs e)
        {
            if (ComponentsDataGrid.CurrentRow.Cells[0].Value == null)
            {
                var errors = "Nothing to delete";
                MessageBox.Show(errors, @"Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (DataGridViewCell cell in ComponentsDataGrid.SelectedCells)
                {
                    ComponentsDataGrid.Rows.RemoveAt(cell.RowIndex);
                }
            }
        }
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Ограничения на ввод символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrequencyTextBoxKeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Сохранить данные в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var componentsTuple = Tuple.Create(Components, FrequencyTextBox.Text);
            saveFileDialog1.ShowDialog();
            string _savefilename = saveFileDialog1.FileName;
             var jsonfile = _dataBase.Serialize(componentsTuple);
            _dataBase.savefile(_savefilename, jsonfile);
        }
        /// <summary>
        /// открыть сохраненные данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComponentsDataGrid.Rows.Clear();
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var result = _dataBase.Deserialize(openFileDialog1.FileName);
            var counter = 0;

            foreach (var item in result.Item1)
             {
                 ComponentsDataGrid.Rows.Add();
                Components.Add(item);
                 ComponentsDataGrid.Rows[counter].Cells[0].Value = item.GetImpedance(item.Nominal);
                 ComponentsDataGrid.Rows[counter].Cells[1].Value = item.Nominal;
                 counter++;
             }  
            FrequencyTextBox.Text = result.Item2.ToString();
        }
    }
}
