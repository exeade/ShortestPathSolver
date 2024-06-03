using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    public partial class StartForm : Form, IWindow
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public void ButtonToExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterDataForm enterDataForm = new EnterDataForm();
            enterDataForm.Show();
        }

        Point lastPoint;

        public void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
