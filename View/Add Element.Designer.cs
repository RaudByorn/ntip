namespace View
{
    partial class Add_Element
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddElementButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.objectControl1 = new View.ObjectControl();
            this.SuspendLayout();
            // 
            // AddElementButton
            // 
            this.AddElementButton.Location = new System.Drawing.Point(191, 162);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(75, 23);
            this.AddElementButton.TabIndex = 1;
            this.AddElementButton.Text = "Ok";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(27, 162);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // objectControl1
            // 
            this.objectControl1.Location = new System.Drawing.Point(12, 12);
            this.objectControl1.ModifyValue = 0D;
            this.objectControl1.Name = "objectControl1";
            this.objectControl1.Size = new System.Drawing.Size(270, 173);
            this.objectControl1.TabIndex = 1;
            // 
            // Add_Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 196);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.objectControl1);
            this.Name = "Add_Element";
            this.Text = "Add Element";
            this.ResumeLayout(false);

        }

        #endregion
        private ObjectControl objectControl1;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Button CloseButton;
    }
}