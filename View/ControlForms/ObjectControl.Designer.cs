namespace View
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElementComboBox = new System.Windows.Forms.ComboBox();
            this.ResistorTextBox = new System.Windows.Forms.TextBox();
            this.CapacitorTextBox = new System.Windows.Forms.TextBox();
            this.InductorTextBox = new System.Windows.Forms.TextBox();
            this.ElementTypeLabel = new System.Windows.Forms.Label();
            this.ResistorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ElementComboBox
            // 
            this.ElementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementComboBox.FormattingEnabled = true;
            this.ElementComboBox.Location = new System.Drawing.Point(131, 29);
            this.ElementComboBox.Name = "ElementComboBox";
            this.ElementComboBox.Size = new System.Drawing.Size(121, 21);
            this.ElementComboBox.TabIndex = 0;
            this.ElementComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseElement);
            // 
            // ResistorTextBox
            // 
            this.ResistorTextBox.Location = new System.Drawing.Point(131, 55);
            this.ResistorTextBox.Name = "ResistorTextBox";
            this.ResistorTextBox.Size = new System.Drawing.Size(121, 20);
            this.ResistorTextBox.TabIndex = 1;
            this.ResistorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResistorTextBox_KeyPress);
            // 
            // CapacitorTextBox
            // 
            this.CapacitorTextBox.Location = new System.Drawing.Point(131, 81);
            this.CapacitorTextBox.Name = "CapacitorTextBox";
            this.CapacitorTextBox.Size = new System.Drawing.Size(121, 20);
            this.CapacitorTextBox.TabIndex = 2;
            // 
            // InductorTextBox
            // 
            this.InductorTextBox.Location = new System.Drawing.Point(131, 107);
            this.InductorTextBox.Name = "InductorTextBox";
            this.InductorTextBox.Size = new System.Drawing.Size(121, 20);
            this.InductorTextBox.TabIndex = 3;
            // 
            // ElementTypeLabel
            // 
            this.ElementTypeLabel.AutoSize = true;
            this.ElementTypeLabel.Location = new System.Drawing.Point(12, 32);
            this.ElementTypeLabel.Name = "ElementTypeLabel";
            this.ElementTypeLabel.Size = new System.Drawing.Size(45, 13);
            this.ElementTypeLabel.TabIndex = 4;
            this.ElementTypeLabel.Text = "Element";
            // 
            // ResistorLabel
            // 
            this.ResistorLabel.AutoSize = true;
            this.ResistorLabel.Location = new System.Drawing.Point(12, 58);
            this.ResistorLabel.Name = "ResistorLabel";
            this.ResistorLabel.Size = new System.Drawing.Size(89, 13);
            this.ResistorLabel.TabIndex = 5;
            this.ResistorLabel.Text = "Resistance (ohm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacitance (nF)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inductance (mcH)";
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResistorLabel);
            this.Controls.Add(this.ElementTypeLabel);
            this.Controls.Add(this.InductorTextBox);
            this.Controls.Add(this.CapacitorTextBox);
            this.Controls.Add(this.ResistorTextBox);
            this.Controls.Add(this.ElementComboBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(273, 149);
            this.Enter += new System.EventHandler(this.ObjectControl_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ElementComboBox;
        public System.Windows.Forms.TextBox ResistorTextBox;
        public System.Windows.Forms.TextBox CapacitorTextBox;
        public System.Windows.Forms.TextBox InductorTextBox;
        private System.Windows.Forms.Label ElementTypeLabel;
        private System.Windows.Forms.Label ResistorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
