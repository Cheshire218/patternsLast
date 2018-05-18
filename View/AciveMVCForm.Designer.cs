namespace ActiveMVC
{
    partial class ActiveMVCForm
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonIncrementValue = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 36);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(214, 20);
            this.textBoxValue.TabIndex = 0;
            // 
            // buttonIncrementValue
            // 
            this.buttonIncrementValue.Location = new System.Drawing.Point(12, 75);
            this.buttonIncrementValue.Name = "buttonIncrementValue";
            this.buttonIncrementValue.Size = new System.Drawing.Size(214, 35);
            this.buttonIncrementValue.TabIndex = 1;
            this.buttonIncrementValue.Text = "Добавить строку в список строк";
            this.buttonIncrementValue.UseVisualStyleBackColor = true;
            this.buttonIncrementValue.Click += new System.EventHandler(this.ButtonAddString_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(9, 20);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(89, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Введите строку:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(260, 36);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(334, 108);
            this.listBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список строк:";
            // 
            // ActiveMVCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonIncrementValue);
            this.Controls.Add(this.textBoxValue);
            this.Name = "ActiveMVCForm";
            this.Text = "ActiveMVC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonIncrementValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
    }
}

