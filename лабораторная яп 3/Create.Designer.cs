namespace лабораторная_яп_3
{
    partial class Create
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
            label_create = new Label();
            label_info = new Label();
            label_key = new Label();
            textBox_info = new TextBox();
            textBox_key = new TextBox();
            label_last = new Label();
            button_yes = new Button();
            button_no = new Button();
            label1 = new Label();
            label_exeption = new Label();
            SuspendLayout();
            // 
            // label_create
            // 
            label_create.AutoSize = true;
            label_create.Font = new Font("Segoe UI", 10F);
            label_create.Location = new Point(284, 34);
            label_create.Name = "label_create";
            label_create.Size = new Size(179, 23);
            label_create.TabIndex = 0;
            label_create.Text = "Создание дерева №1";
            // 
            // label_info
            // 
            label_info.AutoSize = true;
            label_info.Font = new Font("Segoe UI", 10F);
            label_info.Location = new Point(136, 135);
            label_info.Name = "label_info";
            label_info.Size = new Size(306, 23);
            label_info.TabIndex = 1;
            label_info.Text = "Введите информационное поле узла:";
            // 
            // label_key
            // 
            label_key.AutoSize = true;
            label_key.Font = new Font("Segoe UI", 10F);
            label_key.Location = new Point(136, 179);
            label_key.Name = "label_key";
            label_key.Size = new Size(162, 23);
            label_key.TabIndex = 2;
            label_key.Text = "Введите ключ узла:";
            // 
            // textBox_info
            // 
            textBox_info.Font = new Font("Segoe UI", 10F);
            textBox_info.Location = new Point(481, 132);
            textBox_info.Name = "textBox_info";
            textBox_info.Size = new Size(81, 30);
            textBox_info.TabIndex = 3;
            textBox_info.Click += textBox_info_Click;
            // 
            // textBox_key
            // 
            textBox_key.Font = new Font("Segoe UI", 10F);
            textBox_key.Location = new Point(338, 176);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(81, 30);
            textBox_key.TabIndex = 4;
            textBox_key.Click += textBox_key_Click;
            // 
            // label_last
            // 
            label_last.AutoSize = true;
            label_last.Font = new Font("Segoe UI", 10F);
            label_last.Location = new Point(266, 311);
            label_last.Name = "label_last";
            label_last.Size = new Size(216, 23);
            label_last.TabIndex = 5;
            label_last.Text = "Продолжить добавление?";
            // 
            // button_yes
            // 
            button_yes.Font = new Font("Segoe UI", 10F);
            button_yes.Location = new Point(266, 350);
            button_yes.Name = "button_yes";
            button_yes.Size = new Size(95, 43);
            button_yes.TabIndex = 6;
            button_yes.Text = "ДА";
            button_yes.UseVisualStyleBackColor = true;
            button_yes.Click += button_yes_Click;
            // 
            // button_no
            // 
            button_no.Font = new Font("Segoe UI", 10F);
            button_no.Location = new Point(387, 350);
            button_no.Name = "button_no";
            button_no.Size = new Size(95, 43);
            button_no.TabIndex = 7;
            button_no.Text = "НЕТ";
            button_no.UseVisualStyleBackColor = true;
            button_no.Click += button_no_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(257, 255);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 8;
            label1.Text = "Поля не могут быть пустыми!";
            // 
            // label_exeption
            // 
            label_exeption.AutoSize = true;
            label_exeption.Font = new Font("Segoe UI", 10F);
            label_exeption.ForeColor = Color.Red;
            label_exeption.Location = new Point(217, 255);
            label_exeption.Name = "label_exeption";
            label_exeption.Size = new Size(331, 23);
            label_exeption.TabIndex = 9;
            label_exeption.Text = "Введено некорректное значение ключа!";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 453);
            Controls.Add(label_exeption);
            Controls.Add(label1);
            Controls.Add(button_no);
            Controls.Add(button_yes);
            Controls.Add(label_last);
            Controls.Add(textBox_key);
            Controls.Add(textBox_info);
            Controls.Add(label_key);
            Controls.Add(label_info);
            Controls.Add(label_create);
            Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_create;
        private Label label_info;
        private Label label_key;
        private TextBox textBox_info;
        private TextBox textBox_key;
        private Label label_last;
        private Button button_yes;
        private Button button_no;
        private Label label1;
        private Label label_exeption;
    }
}