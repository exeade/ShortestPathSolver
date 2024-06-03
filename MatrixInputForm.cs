using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    public partial class MatrixInputForm : Form
    {
        private readonly int _size;
        private TextBox[,] matrixTextBoxes;
        private Button submitButton;
        private readonly Button resetButton;
        private readonly Button regenerateButton;
        private readonly string selectedMethod;
        private readonly bool _showWeights;
        private readonly bool _isManually;

        public MatrixInputForm(int size, string method, bool showWeights, bool isManually)
        {
            InitializeComponent();
            _size = size;
            selectedMethod = method;
            _showWeights = showWeights;
            _isManually = isManually;

            MatrixInitialize();
            if (isManually == true)
            {
                resetButton = new Button
                {
                    Text = "Заново",
                    ForeColor = Color.White,
                    Size = new Size(100, 25),
                    Location = new Point(85, 35 * _size + 10)
                };
                resetButton.Click += new EventHandler(ResetButton_Click);
                this.Controls.Add(resetButton);
            }
            else
            {
                double[,] generatedMatrix = selectedMethod == "Метод Дейкстри" ? GeneratePositiveMatrix(_size) : GenerateDAGMatrix(_size);
                MatrixShow(generatedMatrix);
                regenerateButton = new Button
                {
                    Text = "Перегенерувати",
                    ForeColor = Color.White,
                    Size = new Size(100, 25),
                    Location = new Point(85, 35 * _size + 10)
                };
                regenerateButton.Click += new EventHandler(RegenerateButton_Click);
                this.Controls.Add(regenerateButton);
            }
        }

        private void MatrixInitialize()
        {
            this.Text = "Вагова матриця суміжності";
            this.BackColor = Color.DarkMagenta;
            this.ForeColor = Color.Black;
            this.ControlBox = false;
            this.Size = new Size(45 * _size + 40, 35 * _size + 80);

            matrixTextBoxes = new TextBox[_size, _size];

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    matrixTextBoxes[i, j] = new TextBox
                    {
                        ForeColor = Color.DarkBlue,
                        Size = new Size(40, 3),
                        Location = new Point(10 + 45 * j, 10 + 35 * i),
                        MaxLength = 6
                    };
                    this.Controls.Add(matrixTextBoxes[i, j]);
                }
            }

            submitButton = new Button
            {
                Text = "Підтвердити",
                ForeColor = Color.White,
                Size = new Size(80, 25),
                Location = new Point(5, 35 * _size + 10)
            };
            submitButton.Click += new EventHandler(SubmitButton_Click);
            this.Controls.Add(submitButton);
        }

        private void MatrixShow(double[,] genMatrix)
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    matrixTextBoxes[i, j].Text = genMatrix[i, j].ToString();
                    matrixTextBoxes[i, j].Enabled = false;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[_size, _size];

            try
            {
                for (int i = 0; i < _size; i++)
                {
                    for (int j = 0; j < _size; j++)
                    {
                        if (matrixTextBoxes[i, j].Text == null)
                        {
                            throw new FormatException();
                        }
                        double? value = double.Parse(matrixTextBoxes[i, j].Text);

                        if (selectedMethod == "Метод Дейкстри" && value < 0)
                        {
                            throw new ArgumentException("Від'ємні ваги ребер неприйнятні для алгоритму Дейкстри.");
                        }
                        if (value < -10000 || value > 10000)
                        {
                            throw new ArgumentException("Деякі значення матриці не входять у заданий діапазон.");
                        }
                        if (value == null)
                        {
                            throw new FormatException();
                        }
                        matrix[i, j] = (double)value;
                    }
                }
                GraphVisualization graph = new GraphVisualization(matrix.GetLength(1), matrix, _showWeights, selectedMethod);
                graph.Show();
                submitButton.Enabled = false;
                foreach (TextBox textBox in matrixTextBoxes)
                {
                    textBox.Enabled = false;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                MatrixInputForm newMatrixInputForm = new MatrixInputForm(_size, selectedMethod, _showWeights, _isManually);
                newMatrixInputForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для всіх елементів матриці: всі значення повинні бути цифрами.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                MatrixInputForm newMatrixInputForm = new MatrixInputForm(_size, selectedMethod, _showWeights, _isManually);
                newMatrixInputForm.Show();
            }
        }

        private void ResetMatrix()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GraphVisualization)
                {
                    form.Close();
                    break;
                }
            }
            foreach (TextBox textBox in matrixTextBoxes)
            {
                textBox.Text = string.Empty;
            }

            foreach (TextBox textBox in matrixTextBoxes)
            {
                textBox.Enabled = true;
            }

            submitButton.Enabled = true;
        }

        private void RegenerateMatrix()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GraphVisualization)
                {
                    form.Close();
                    break;
                }
            }
            foreach (TextBox textBox in matrixTextBoxes)
            {
                textBox.Text = string.Empty;
            }

            double[,] newGenMatrix = selectedMethod == "Метод Дейкстри" ? GeneratePositiveMatrix(_size) : GenerateDAGMatrix(_size);

            MatrixShow(newGenMatrix);
            submitButton.Enabled = true;
        }

        private void RegenerateButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SolutionForm)
                {
                    form.Close();
                    break;
                }
            }
            RegenerateMatrix();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SolutionForm)
                {
                    form.Close();
                    break;
                }
            }
            ResetMatrix();
        }

        private static double[,] GeneratePositiveMatrix(int size)
        {
            Random rand = new Random();
            double[,] genMatrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (rand.NextDouble() < 0.25)
                    {
                        genMatrix[i, j] = rand.Next(0, 1000);
                    }
                    else
                    {
                        genMatrix[i, j] = 0;
                    }
                }
            }

            return genMatrix;
        }

        private static double[,] GenerateDAGMatrix(int size)
        {
            double[,] adjMatrix = new double[size, size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (random.NextDouble() < 0.4)
                    {
                        adjMatrix[i, j] = random.Next(-1000, 1000);
                    }
                    else
                    {
                        adjMatrix[i, j] = 0;
                    }
                }
            }

            return adjMatrix;
        }
    }
}