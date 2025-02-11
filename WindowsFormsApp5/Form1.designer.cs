namespace WindowsFormsApp5
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
            this.tb_rows = new System.Windows.Forms.TextBox();
            this.matrixmin = new System.Windows.Forms.TextBox();
            this.matrixmax = new System.Windows.Forms.TextBox();
            this.tb_cols = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.DoTask = new System.Windows.Forms.Button();
            this.z5 = new System.Windows.Forms.RadioButton();
            this.z4 = new System.Windows.Forms.RadioButton();
            this.z3 = new System.Windows.Forms.RadioButton();
            this.z2 = new System.Windows.Forms.RadioButton();
            this.z1 = new System.Windows.Forms.RadioButton();
            this.TaskOutput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_rows
            // 
            this.tb_rows.Location = new System.Drawing.Point(169, 31);
            this.tb_rows.Name = "tb_rows";
            this.tb_rows.Size = new System.Drawing.Size(57, 22);
            this.tb_rows.TabIndex = 0;
            this.tb_rows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rows_KeyPress);
            // 
            // matrixmin
            // 
            this.matrixmin.Location = new System.Drawing.Point(286, 62);
            this.matrixmin.Name = "matrixmin";
            this.matrixmin.Size = new System.Drawing.Size(53, 22);
            this.matrixmin.TabIndex = 1;
            this.matrixmin.TextChanged += new System.EventHandler(this.matrixmin_TextChanged);
            this.matrixmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixmin_KeyPress);
            // 
            // matrixmax
            // 
            this.matrixmax.Location = new System.Drawing.Point(382, 62);
            this.matrixmax.Name = "matrixmax";
            this.matrixmax.Size = new System.Drawing.Size(53, 22);
            this.matrixmax.TabIndex = 2;
            this.matrixmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixmax_KeyPress);
            // 
            // tb_cols
            // 
            this.tb_cols.Location = new System.Drawing.Point(169, 59);
            this.tb_cols.Name = "tb_cols";
            this.tb_cols.Size = new System.Drawing.Size(57, 22);
            this.tb_cols.TabIndex = 3;
            this.tb_cols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cols_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество строк:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество столбцов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значения матрицы";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "от:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "до:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_rows);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.matrixmax);
            this.groupBox1.Controls.Add(this.matrixmin);
            this.groupBox1.Controls.Add(this.tb_cols);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "Создать матрицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 128);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(870, 482);
            this.dgv1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.open);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 110);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(10, 64);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(178, 23);
            this.open.TabIndex = 12;
            this.open.Text = "Открыть из файла";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 24);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(178, 23);
            this.save.TabIndex = 11;
            this.save.Text = "Сохранить в файл";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.DoTask);
            this.groupBox3.Controls.Add(this.z5);
            this.groupBox3.Controls.Add(this.z4);
            this.groupBox3.Controls.Add(this.z3);
            this.groupBox3.Controls.Add(this.z2);
            this.groupBox3.Controls.Add(this.z1);
            this.groupBox3.Location = new System.Drawing.Point(917, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 451);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Описание задания";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DoTask
            // 
            this.DoTask.Location = new System.Drawing.Point(6, 217);
            this.DoTask.Name = "DoTask";
            this.DoTask.Size = new System.Drawing.Size(181, 100);
            this.DoTask.TabIndex = 5;
            this.DoTask.Text = "Выполнить с новой(случайно сгенерированной) матрицей";
            this.DoTask.UseVisualStyleBackColor = true;
            this.DoTask.Click += new System.EventHandler(this.DoTask_Click);
            // 
            // z5
            // 
            this.z5.AutoSize = true;
            this.z5.Location = new System.Drawing.Point(25, 139);
            this.z5.Name = "z5";
            this.z5.Size = new System.Drawing.Size(102, 20);
            this.z5.TabIndex = 4;
            this.z5.TabStop = true;
            this.z5.Text = "Задание 41";
            this.z5.UseVisualStyleBackColor = true;
            // 
            // z4
            // 
            this.z4.AutoSize = true;
            this.z4.Location = new System.Drawing.Point(25, 113);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(102, 20);
            this.z4.TabIndex = 3;
            this.z4.TabStop = true;
            this.z4.Text = "Задание 25";
            this.z4.UseVisualStyleBackColor = true;
            // 
            // z3
            // 
            this.z3.AutoSize = true;
            this.z3.Location = new System.Drawing.Point(25, 87);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(102, 20);
            this.z3.TabIndex = 2;
            this.z3.TabStop = true;
            this.z3.Text = "Задание 24";
            this.z3.UseVisualStyleBackColor = true;
            // 
            // z2
            // 
            this.z2.AutoSize = true;
            this.z2.Location = new System.Drawing.Point(25, 61);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(102, 20);
            this.z2.TabIndex = 1;
            this.z2.TabStop = true;
            this.z2.Text = "Задание 17";
            this.z2.UseVisualStyleBackColor = true;
            // 
            // z1
            // 
            this.z1.AutoSize = true;
            this.z1.Location = new System.Drawing.Point(25, 35);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(95, 20);
            this.z1.TabIndex = 0;
            this.z1.TabStop = true;
            this.z1.Text = "Задание 2";
            this.z1.UseVisualStyleBackColor = true;
            // 
            // TaskOutput
            // 
            this.TaskOutput.Location = new System.Drawing.Point(12, 628);
            this.TaskOutput.Name = "TaskOutput";
            this.TaskOutput.Size = new System.Drawing.Size(870, 93);
            this.TaskOutput.TabIndex = 10;
            this.TaskOutput.UseVisualStyleBackColor = true;
            this.TaskOutput.Click += new System.EventHandler(this.TaskOutput_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 100);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выполнить с существующей матрицей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 733);
            this.Controls.Add(this.TaskOutput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "РГР Халиманов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rows;
        private System.Windows.Forms.TextBox matrixmin;
        private System.Windows.Forms.TextBox matrixmax;
        private System.Windows.Forms.TextBox tb_cols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton z5;
        private System.Windows.Forms.RadioButton z4;
        private System.Windows.Forms.RadioButton z3;
        private System.Windows.Forms.RadioButton z2;
        private System.Windows.Forms.RadioButton z1;
        private System.Windows.Forms.Button DoTask;
        private System.Windows.Forms.Button TaskOutput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

