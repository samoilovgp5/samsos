namespace proga5
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Butnkal1 = new System.Windows.Forms.Button();
            this.Butnkal2 = new System.Windows.Forms.Button();
            this.TextKala = new System.Windows.Forms.TextBox();
            this.BoxKala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Butnkal1
            // 
            this.Butnkal1.Location = new System.Drawing.Point(101, 77);
            this.Butnkal1.Name = "Butnkal1";
            this.Butnkal1.Size = new System.Drawing.Size(151, 115);
            this.Butnkal1.TabIndex = 0;
            this.Butnkal1.Text = "УРА ПУТИНУ";
            this.Butnkal1.UseVisualStyleBackColor = true;
            this.Butnkal1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Butnkal2
            // 
            this.Butnkal2.Location = new System.Drawing.Point(271, 77);
            this.Butnkal2.Name = "Butnkal2";
            this.Butnkal2.Size = new System.Drawing.Size(151, 115);
            this.Butnkal2.TabIndex = 1;
            this.Butnkal2.Text = "взорвать америку!!!!!!!!!!!!!!!!!";
            this.Butnkal2.UseVisualStyleBackColor = true;
            this.Butnkal2.Click += new System.EventHandler(this.Butnkal2_Click);
            // 
            // TextKala
            // 
            this.TextKala.Location = new System.Drawing.Point(101, 232);
            this.TextKala.Name = "TextKala";
            this.TextKala.Size = new System.Drawing.Size(321, 20);
            this.TextKala.TabIndex = 2;
            this.TextKala.Text = "ХУЙ";
            // 
            // BoxKala
            // 
            this.BoxKala.FormattingEnabled = true;
            this.BoxKala.Items.AddRange(new object[] {
            "ПЕТУШАРА",
            "Я",
            "ТЫ"});
            this.BoxKala.Location = new System.Drawing.Point(101, 278);
            this.BoxKala.Name = "BoxKala";
            this.BoxKala.Size = new System.Drawing.Size(321, 21);
            this.BoxKala.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxKala);
            this.Controls.Add(this.TextKala);
            this.Controls.Add(this.Butnkal2);
            this.Controls.Add(this.Butnkal1);
            this.Name = "Form1";
            this.Text = "ФОРМА ЖОПЫ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butnkal1;
        private System.Windows.Forms.Button Butnkal2;
        private System.Windows.Forms.TextBox TextKala;
        private System.Windows.Forms.ComboBox BoxKala;
    }
}

