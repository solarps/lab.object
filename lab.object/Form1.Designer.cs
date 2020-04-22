namespace lab.obj
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
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutA2 = new System.Windows.Forms.TextBox();
            this.OutA3 = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutModul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_exit.Location = new System.Drawing.Point(692, 404);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(96, 34);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "A1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutA1
            // 
            this.OutA1.Enabled = false;
            this.OutA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutA1.Location = new System.Drawing.Point(199, 20);
            this.OutA1.Name = "OutA1";
            this.OutA1.ReadOnly = true;
            this.OutA1.Size = new System.Drawing.Size(68, 26);
            this.OutA1.TabIndex = 2;
            this.OutA1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "A2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(389, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "A3:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OutA2
            // 
            this.OutA2.Enabled = false;
            this.OutA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutA2.Location = new System.Drawing.Point(315, 20);
            this.OutA2.Name = "OutA2";
            this.OutA2.ReadOnly = true;
            this.OutA2.Size = new System.Drawing.Size(68, 26);
            this.OutA2.TabIndex = 7;
            this.OutA2.TextChanged += new System.EventHandler(this.OutputA2_TextChanged);
            // 
            // OutA3
            // 
            this.OutA3.Enabled = false;
            this.OutA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutA3.Location = new System.Drawing.Point(431, 20);
            this.OutA3.Name = "OutA3";
            this.OutA3.ReadOnly = true;
            this.OutA3.Size = new System.Drawing.Size(68, 26);
            this.OutA3.TabIndex = 8;
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_generate.Location = new System.Drawing.Point(12, 12);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(123, 42);
            this.button_generate.TabIndex = 9;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modul:";
            // 
            // OutModul
            // 
            this.OutModul.Enabled = false;
            this.OutModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutModul.Location = new System.Drawing.Point(76, 134);
            this.OutModul.Multiline = true;
            this.OutModul.Name = "OutModul";
            this.OutModul.ReadOnly = true;
            this.OutModul.Size = new System.Drawing.Size(233, 32);
            this.OutModul.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutModul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.OutA3);
            this.Controls.Add(this.OutA2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutA1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutA2;
        private System.Windows.Forms.TextBox OutA3;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutModul;
    }
}

