using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    public partial class EnterDataForm : Form, IWindow
    {
        private Point lastPoint;
        public EnterDataForm()
        {
            InitializeComponent();

            MatrixSizeField.Text = "5";
            MatrixSizeField.ForeColor = Color.Gray;
            Manually.Checked = true;
        }

        private void MatrixSizeField_Enter(object sender, EventArgs e)
        {
            if (MatrixSizeField.Text == "5")
            {
                MatrixSizeField.Text = "";
                MatrixSizeField.ForeColor = Color.Black;
            }
        }

        private void MatrixSizeField_Leave(object sender, EventArgs e)
        {
            if (MatrixSizeField.Text == "")
            {
                MatrixSizeField.Text = "5";
                MatrixSizeField.ForeColor = Color.Gray;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MethodSelect.SelectedIndex == -1)
            {
                string message = "Будь ласка, оберіть метод розв'язання.";
                MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrEmpty(MatrixSizeField.Text))
            {
                string message = "Будь ласка, введіть розмірність матриці.";
                MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(MatrixSizeField.Text, out int size) || size < 2 || size > 20)
            {
                string message = "Будь ласка, введіть коректну розмірність матриці.";
                MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
            MatrixInputForm matrixForm = new MatrixInputForm(size, MethodSelect.SelectedItem.ToString(), ShowWeights.Checked, Manually.Checked);
            matrixForm.Show();
        }

        public void ButtonToExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        public void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
