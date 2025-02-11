using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///Обработанные исключения/ошибки пользователя:
        ///попытка ввести в значения матрицы только , или -
        ///невведённые значения каких-либо textbox
        ///нули в размерности матрицы
        ///попытка сохранить файл до генерации матрицы
        ///попытка открыть файл с неверным содержимым
        ///попытка прочитать описание/выполнить задания, не отметив ни одного
        ///попытка выполнить задание "на своей" матрице, не создав при этом саму матрицу
        ///запуск задания 24, 25 "на своей матрице", которая не соответствует условию задания 
        ///попытка нажатия выполнить задания, при этом не выбрав ни одного из списка
        /// </summary>
        private double[,] matrix1;
        private int Rows;
        private int Cols;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void matrixgeneration(int rows, int cols, double matmin, double matmax) // для заданий
        {
            Rows = rows;
            Cols = cols;
            double[,] matrix = new double[rows, cols];
            dgv1.Rows.Clear();
            dgv1.Columns.Clear();
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowCount = Rows;
            dgv1.ColumnCount = Cols;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Math.Round(rnd.NextDouble() * (matmax - matmin) + matmin, 2);
                    dgv1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            matrix1 = matrix;
        }

        private void z1meth() // zad1 *******************************************************************************
        {
            double minSum = double.MaxValue;
            double maxSum = double.MinValue;
            int minRow = -1;
            int maxRow = -1;

            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                double sum = 0;
                for (int j = 0; j < dgv1.Columns.Count; j++)
                {
                    sum += Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    minRow = i;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                }
            }
            TaskOutput.Text = Convert.ToString("Минимальная сумма элементов в строке " + (minRow + 1) + ", сумма равна " + minSum + "\n" + "Максимальная сумма элементов в строке " + (maxRow + 1) + ", сумма равна " + maxSum);
        }
        private void z2meth() //zad2
        {
            {

                double maxRow = double.MinValue;
                double minColumn = double.MaxValue;
                double value;

                for (int i = 0; i < dgv1.RowCount; i++) // poisk
                {
                    for (int j = 0; j < dgv1.ColumnCount; j++)
                    {
                        value = Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);

                        if (i % 2 == 0 && value > maxRow)
                        {
                            maxRow = value;
                        }

                        if (j % 2 != 0 && value < minColumn)
                        {
                            minColumn = value;
                        }
                    }
                }

                double otn = maxRow / minColumn;

                for (int i = 0; i < dgv1.RowCount; i++) // delenie
                {
                    for (int j = 0; j < dgv1.ColumnCount; j++)
                    {
                        value = Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);

                        if (j % 2 == 0)
                        {
                            dgv1.Rows[i].Cells[j].Value = value / otn;
                        }
                    }
                }

                TaskOutput.Text = Convert.ToString("Отношение максимального элемента всех четных строк к минимальному элементу нечетных столбцов: " + otn);
            }
        }
        private void z3meth()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgv1);
            double value;

            for (int j = 0; j < dgv1.ColumnCount; j++)
            {
                double product = 1;

                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    value = Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);
                    product *= value;
                }

                newRow.Cells[j].Value = product;
            }

            dgv1.Rows.Add(newRow);
        }
        private void z4meth()
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (i % 2 == 0) // chetnaya
                {
                    double[] values = new double[dgv1.Columns.Count];
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        values[j] = Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);
                    }
                    Array.Sort(values);
                    Array.Reverse(values);
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        dgv1.Rows[i].Cells[j].Value = values[j];
                    }
                }
                else // nechet
                {
                    double[] values = new double[dgv1.Columns.Count];
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        values[j] = Convert.ToDouble(dgv1.Rows[i].Cells[j].Value);
                    }
                    Array.Sort(values);
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        dgv1.Rows[i].Cells[j].Value = values[j];
                    }
                }
            }
        }
        private void z5meth()
        {
            for (int i = 0; i < dgv1.Columns.Count; i=i+2) //chetnie stolbci 
            {
                    for (int j = 0; j < dgv1.Rows.Count; j++)
                    {
                        var temp = dgv1.Rows[j].Cells[i].Value;
                        dgv1.Rows[j].Cells[i].Value = dgv1.Rows[j].Cells[i + 1].Value;
                        dgv1.Rows[j].Cells[i + 1].Value = temp;
                    }
            }
        }
        // конец заданий ***********************************************************************************************
        private bool forz3meth(object dgv)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                for (int j = 0; j < dgv1.ColumnCount; j++)
                {
                    if (Convert.ToDouble(dgv1.Rows[i].Cells[j].Value) < -2 || Convert.ToDouble(dgv1.Rows[i].Cells[j].Value) > 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_rows_KeyPress(object sender, KeyPressEventArgs e) // str
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_cols_KeyPress(object sender, KeyPressEventArgs e) //stolb
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void matrixmax_KeyPress(object sender, KeyPressEventArgs e)// maximum random
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch!=109 && e.KeyChar == 39 && e.KeyChar == 190)
            {
                e.Handled = true;
            }
        }
        private void matrixmin_KeyPress(object sender, KeyPressEventArgs e) // min random
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && e.KeyChar==39 && e.KeyChar==190)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // кнопка создания матрицы
        {
            if ((tb_rows.TextLength == 0 || tb_cols.TextLength == 0) || (int.Parse(tb_rows.Text) == 0 || int.Parse(tb_cols.Text) == 0))
            {
                MessageBox.Show("Введено некорректное значение строк (не введено, либо 0)");
            }
            else if (matrixmin.TextLength == 0 || matrixmax.TextLength == 0) MessageBox.Show("Не введено(ы) значение(я) матрицы");
            else
            {
                try
                {
                    {
                        matrixgeneration(int.Parse(tb_rows.Text), int.Parse(tb_cols.Text), int.Parse(matrixmin.Text), (int.Parse(matrixmax.Text)));
                    }
                }
                catch { MessageBox.Show("В значения матрицы введено неккоректное значение(невозможно преобразовать заданное значение в число)"); }
            }
        }

        private void save_Click(object sender, EventArgs e) //matrix1  , save
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && dgv1.RowCount > 0 && dgv1.ColumnCount>0 && dgv1.Size.Width>0)
            {
                string filePath = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(filePath, false);
                sw.WriteLine(int.Parse(tb_rows.Text));
                sw.WriteLine(int.Parse(tb_cols.Text));
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        sw.Write(matrix1[i, j] + "\t");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            else if (dgv1.RowCount==0) MessageBox.Show("Невозможно сохранить несуществующую матрицу, сначала задайте значения матрицы и её размерность");
        }

        private void open_Click(object sender, EventArgs e) // open
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string FilePath = openFileDialog.FileName;
                    StreamReader sr = new StreamReader(FilePath);
                    Rows = int.Parse(sr.ReadLine());
                    tb_rows.Text = Rows.ToString();
                    Cols = int.Parse(sr.ReadLine());
                    tb_cols.Text = Cols.ToString();
                    matrix1 = new double[Rows, Cols];
                    dgv1.Rows.Clear();
                    dgv1.Columns.Clear();
                    dgv1.RowHeadersVisible = false;
                    dgv1.ColumnHeadersVisible = false;
                    dgv1.RowCount = Rows;
                    dgv1.ColumnCount = Cols;
                    dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    for (int j = 0; j < Rows; j++)
                    {
                        string[] matrixo = sr.ReadLine().Split('\t');
                        for (int k = 0; k < Cols; k++)
                        {
                            matrix1[j, k] = double.Parse(matrixo[k]);
                        }

                    }
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Cols; j++)
                        {
                            dgv1.Rows[i].Cells[j].Value = String.Format("{0:0.00}", matrix1[i, j]);
                        }
                    }
                }
                catch { MessageBox.Show("Содержимое файла невозможно распознать, как матрицу"); } 
            }
        }



        private void DoTask_Click(object sender, EventArgs e) // zadaniya random matrica    **************************************
        {
            if (z1.Checked==false && z2.Checked==false && z3.Checked==false && z4.Checked==false && z5.Checked==false)
            {
                MessageBox.Show("Сначала выберите одно из заданий.");
            }
            else
            {
                if (z1.Checked)
                {
                    matrixgeneration(rnd.Next(5, 20), rnd.Next(5, 20), -100, 100);
                    z1meth();
                }
                if (z2.Checked)
                {
                    matrixgeneration(rnd.Next(5, 20), rnd.Next(5, 20), -100, 100);
                    z2meth();
                }
                if (z3.Checked)
                {
                    int kvmatr = rnd.Next(5, 20);
                    matrixgeneration(kvmatr, kvmatr, -2, 2);
                    z3meth();
                }
                if (z4.Checked)
                {
                    int r1=rnd.Next(5, 20);
                    int r2=rnd.Next(5, 20);
                    while (r2==r1)
                    {
                        r2=rnd.Next(5, 20);
                    }
                    matrixgeneration(r1, r2, -100, 100);
                    z4meth();

                }
                if (z5.Checked)
                {
                    int r3=rnd.Next(5, 20);
                    while (r3%2!=0)
                    {
                        r3= rnd.Next(5, 20); 
                    }
                    matrixgeneration(rnd.Next(5,20), r3, -100, 100);
                    z5meth();
                }
            }
        }
        //**********************************************************************************************




        private void button3_Click(object sender, EventArgs e) // opisanie
        {
                if (z1.Checked)
                {
                    MessageBox.Show("Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными). Определить номер строки с минимальной и максимальной суммой элементов. Вывести номер строки с минимальной и максимальной суммой, а также два значения суммы элементов.");
                }
                else if (z2.Checked)
                {
                    MessageBox.Show("Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными). Определить отношение максимального элемента всех четных строк к минимальному элементу нечетных столбцов. Разделить элементы четных столбцов на полученное отношение.");
                }
                else if (z3.Checked)
                {
                    MessageBox.Show("Сгенерировать квадратную (N≥5, M≥5) матрицу и заполнить вещественными числами (положительными и отрицательными) в диапазоне от -2 до 2 Найти произведение элементов каждого столбца и вывести их в виде дополнительной строки матрицы.");
                }
                else if (z4.Checked)
                {
                    MessageBox.Show("Сгенерировать матрицу (N != M) и заполнить вещественными числами (положительными и отрицательными). Отсортировать элементы четных строк по убыванию, а элементы нечетных строк по возрастанию.");
                }
                else if (z5.Checked)
                {
                    MessageBox.Show("Сгенерировать матрицу с четным количеством столбцов и заполнить вещественными числами (положительными и отрицательными). Поменять местами элементы четных и нечетных столбцов.");
                }
                else { MessageBox.Show("Чтобы увидеть описание задания, для начала выберите его из списка"); }
        }

        private void TaskOutput_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // zadaniya svoya matrica *************************
        {
            if (dgv1.RowCount == 0)
            {
                MessageBox.Show("Сначала создайте матрицу. Задайте значения в левом верхнем углу и нажмите 'создать матрицу'");
            }
            else if(z1.Checked == false && z2.Checked == false && z3.Checked == false && z4.Checked == false && z5.Checked == false)
            {
                MessageBox.Show("Сначала выберите одно из заданий.");
            }
            
            else
            {
                if (z1.Checked)
                {
                    z1meth();
                }
                if (z2.Checked)
                {
                    z2meth();
                }
                if (z3.Checked)
                {
                    if (forz3meth(dgv1)==false)
                    {
                        MessageBox.Show("Матрица не соответствует условиям задания. Значения должны быть в диапазоне (-2,2)");
                    }
                    if (dgv1.RowCount < 5 || dgv1.ColumnCount < 5)
                    {
                        MessageBox.Show("Матрица не соответствует условиям задания. Количество строк и столбцов должно равняться 5 или более");
                    }
                    else if (dgv1.RowCount != dgv1.ColumnCount)
                    {
                        MessageBox.Show("Матрица не соответствует условиям задания. Количество строк должно быть равно количеству столбцов");
                    }
                    else
                    {
                        z3meth();
                    }
                }
                if (z4.Checked)
                {
                    if (dgv1.RowCount!=dgv1.ColumnCount)
                    z4meth();
                    else
                    {
                        MessageBox.Show("Матрица не соответствует условиям задания. Количество строк не должно быть равно количеству столбцов");
                    }
                }
                if (z5.Checked)
                {
                    if (dgv1.ColumnCount % 2 == 0) z5meth();
                    else MessageBox.Show("Матрица не соответствует условиям задания. Количество столбцов должно быть чётным.");
                }
            }
        } // ************************************************************************************ 

        private void matrixmin_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
