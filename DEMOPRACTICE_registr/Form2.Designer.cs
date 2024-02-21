namespace DEMOPRACTICE_registr
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 125);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 11;
            label2.Text = "Логин должен:\r\n- Быть уникальным\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 54F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(451, 96);
            label1.TabIndex = 10;
            label1.Text = "Регистрация";
            // 
            // button1
            // 
            button1.Location = new Point(180, 317);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 9;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 264);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 158);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 31);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 201);
            label4.Name = "label4";
            label4.Size = new Size(370, 60);
            label4.TabIndex = 13;
            label4.Text = "Пароль должен:\r\n- Быть длиннее 8 символов\r\n- Содержать буквы верхнего и нижнего регистра\r\n- Пароль должен содержать специальные символы: !; @; #; $; %...\r\n";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 352);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximumSize = new Size(533, 391);
            MinimumSize = new Size(533, 391);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
    }
}