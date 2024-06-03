using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    public partial class SolutionForm : Form, IWindow
    {
        private readonly double _ShortestPathWeight;
        private readonly List<Vertex> _vertices;
        private readonly List<Tuple<Vertex, Vertex, double>> _edges;
        private readonly int _vertexNum;
        private readonly double[,] _adjMatrix;
        private readonly string _solutionMethod;
        private readonly bool _showWeights;
        private readonly int randomNumber = (new Random()).Next(0, 10000);
        private readonly long _algorithmTime;
        private readonly int _procVerticesCount;
        private Point lastPoint;

        public SolutionForm(double shortestPathWeight, List<Vertex> vertices, List<Tuple<Vertex, Vertex, double>> edges,
            int vertexNum, double[,] adjMatrix, bool showWeights, string solutionMethod, long algorithmTime,
            int procVerticesCount)
        {
            InitializeComponent();
            TimeComplPanel.Hide();
            SuccessLabel.Hide();
            _ShortestPathWeight = shortestPathWeight;
            _vertices = vertices;
            _edges = edges;
            _solutionMethod = solutionMethod;
            _adjMatrix = adjMatrix;
            _vertexNum = vertexNum;
            _showWeights = showWeights;
            _algorithmTime = algorithmTime;
            _procVerticesCount = procVerticesCount;

            PathValueLabel.Text = _ShortestPathWeight.ToString();
            TimeLabel.Text = _algorithmTime.ToString();
            VertsDoneLabel.Text = _procVerticesCount.ToString();
            TimeComplPanel.Show();

            StringBuilder pathText = new StringBuilder();
            foreach (Vertex v in vertices)
            {
                pathText.Append(Convert.ToChar(v.Position + 'A')).Append(" -> ");
            }

            pathText.Remove(pathText.Length - 4, 4);

            PathVertsLabel.Text = pathText.ToString();

            StringBuilder edgesText = new StringBuilder();
            foreach (var edge in _edges)
            {
                char startVertex = Convert.ToChar(edge.Item1.Position + 'A');
                char endVertex = Convert.ToChar(edge.Item2.Position + 'A');
                double weight = edge.Item3;
                edgesText.AppendFormat("{0} -> {1} (Вага: {2})", startVertex, endVertex, weight).Append("\n");
            }

            PathVertsLabel.Text += "\n" + edgesText.ToString();

            graphPathPanel.Paint += new PaintEventHandler(DrawPath);
        }

        private void DrawDifferentEdges(Graphics g, Pen pen, Brush textBrush, int indexI, int indexJ, Font font,
            List<Tuple<int, int>> drawnEdges, Point[] vertexPositions, int radius)
        {
            if (indexI == indexJ)
            {
                GraphVisualization.DrawLoop(g, vertexPositions[indexI], _adjMatrix[indexI, indexJ].ToString(), font, textBrush,
                    pen, _showWeights);
                drawnEdges.Add(new Tuple<int, int>(indexJ, indexI));
                drawnEdges.Add(new Tuple<int, int>(indexI, indexJ));
            }
            else
            {
                if (drawnEdges.Contains(new Tuple<int, int>(indexJ, indexI)))
                {
                    GraphVisualization.DrawCurve(g, vertexPositions[indexI], vertexPositions[indexJ], radius + 20,
                        _adjMatrix[indexI, indexJ].ToString(), font, textBrush, pen, _showWeights);
                    drawnEdges.Add(new Tuple<int, int>(indexI, indexJ));
                }
                else
                {
                    GraphVisualization.DrawArrow(g, pen, vertexPositions[indexI], vertexPositions[indexJ], radius + 1);

                    if (_showWeights)
                    {
                        int midX = (vertexPositions[indexI].X + vertexPositions[indexJ].X) / 2;
                        int midY = (vertexPositions[indexI].Y + vertexPositions[indexJ].Y) / 2;
                        g.DrawString(_adjMatrix[indexI, indexJ].ToString(), font, textBrush, midX, midY);
                    }
                    drawnEdges.Add(new Tuple<int, int>(indexI, indexJ));
                }
            }
        }

        private void DrawPath(object sender, PaintEventArgs e)
        {
            List<Tuple<int, int>> drawnEdges = new List<Tuple<int, int>>();
            Graphics g = e.Graphics;
            Brush textBrush;
            Font font = new Font("Segoe UI", 9);
            HashSet<int> pathVertices = new HashSet<int>(_vertices.Select(v => v.Position));
            Pen pen;

            int radius = 20;
            Point[] vertexPositions = new Point[_vertexNum];
            int centerX = graphPathPanel.Width / 2;
            int centerY = graphPathPanel.Height / 2;
            int maxRadius = Math.Min(graphPathPanel.Width, graphPathPanel.Height) / 2 - radius - 10;

            for (int i = 0; i < _vertexNum; i++)
            {
                int x = (int)(centerX + maxRadius * Math.Cos(2 * Math.PI * i / _vertexNum));
                int y = (int)(centerY + maxRadius * Math.Sin(2 * Math.PI * i / _vertexNum));
                vertexPositions[i] = new Point(x, y);
            }

            for (int i = 0; i < _vertexNum; i++)
            {
                for (int j = 0; j < _vertexNum; j++)
                {
                    if (_adjMatrix[i, j] != 0 && !drawnEdges.Contains(new Tuple<int, int>(i, j)))
                    {
                        bool isEdgeInPath = _edges.Any(edge =>
                        edge.Item1.Position == i && edge.Item2.Position == j && edge.Item3 == _adjMatrix[i, j]);
                        if (!isEdgeInPath)
                        {
                            pen = new Pen(Color.LightPink, 2);
                            textBrush = Brushes.Salmon;
                            DrawDifferentEdges(g, pen, textBrush, i, j, font, drawnEdges, vertexPositions, radius);
                        }
                    }
                }
            }

            for (int i = 0; i < _vertexNum; i++)
            {
                if (!pathVertices.Contains(i))
                {
                    Brush vertexBrush = Brushes.LightPink;
                    textBrush = Brushes.DarkSalmon;

                    g.FillEllipse(vertexBrush, vertexPositions[i].X - radius, vertexPositions[i].Y - radius, 2 * radius, 2 * radius);
                    char label = Convert.ToChar('A' + i);

                    SizeF textSize = g.MeasureString(Convert.ToString(label), font);

                    float labelX = vertexPositions[i].X - textSize.Width / 2;
                    float labelY = vertexPositions[i].Y - textSize.Height / 2;

                    g.DrawString(Convert.ToString(label), font, textBrush, labelX, labelY);
                }
            }

            for (int i = 0; i < _vertexNum; i++)
            {
                for (int j = 0; j < _vertexNum; j++)
                {
                    if (_adjMatrix[i, j] != 0 && !drawnEdges.Contains(new Tuple<int, int>(i, j)))
                    {
                        bool isEdgeInPath = _edges.Any(edge =>
                        edge.Item1.Position == i && edge.Item2.Position == j && edge.Item3 == _adjMatrix[i, j]);
                        if (isEdgeInPath)
                        {
                            pen = new Pen(Color.Red, 2);
                            textBrush = Brushes.Black;

                            DrawDifferentEdges(g, pen, textBrush, i, j, font, drawnEdges, vertexPositions, radius);
                        }
                    }
                }
            }

            foreach (var vertex in _vertices)
            {
                int i = vertex.Position;
                Brush vertexBrush = Brushes.DarkRed;
                textBrush = Brushes.LightPink;

                g.FillEllipse(vertexBrush, vertexPositions[i].X - radius, vertexPositions[i].Y - radius, 2 * radius, 2 * radius);
                char label = Convert.ToChar('A' + i);

                SizeF textSize = g.MeasureString(Convert.ToString(label), font);

                float labelX = vertexPositions[i].X - textSize.Width / 2;
                float labelY = vertexPositions[i].Y - textSize.Height / 2;

                g.DrawString(Convert.ToString(label), font, textBrush, labelX, labelY);
            }
        }


        public void ButtonToExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is MatrixInputForm)
                {
                    form.Close();
                    break;
                }
            }
            StartForm startForm = new StartForm();
            startForm.Show();
        }

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

        private void AnotherPathButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GraphVisualization graphVizualisation = new GraphVisualization(_vertexNum, _adjMatrix, _showWeights, _solutionMethod);
            graphVizualisation.Show();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Зберегти файл як";
                saveFileDialog.FileName = $"ShortestPath{randomNumber}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    WriteInFile write = new WriteInFile(fileName);
                    bool isSuccess = write.WriteToFile(_adjMatrix, _vertices, _edges, _ShortestPathWeight, _solutionMethod);
                    if (!isSuccess)
                    {
                        MessageBox.Show("Не вдалося записати дані у файл.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SuccessLabel.Show();
                        AnotherPathButton.Show();
                        RepeatButton.Show();
                        WriteButton.Enabled = false;
                    }
                }
            }
        }
    }
}
