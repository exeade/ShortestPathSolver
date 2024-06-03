using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    public partial class GraphVisualization : Form, IWindow
    {
        private readonly double[,] _adjacencyMatrix;
        private readonly int _vertexCount;
        private readonly bool _shouldShowW;
        private readonly string _method;
        private Point lastPoint;

        public GraphVisualization(int vertexCount, double[,] adjacencyMatrix, bool shouldShowW, string method)
        {
            InitializeComponent();
            _vertexCount = vertexCount;
            _adjacencyMatrix = adjacencyMatrix;
            _shouldShowW = shouldShowW;
            _method = method;
            graphPanel.Paint += new PaintEventHandler(DrawGraph);
            CreateRadioButtons();
        }

        private void CreateRadioButtons()
        {
            int startY = 20;
            int endY = 20;

            int radioButtonHeight = 25;
            int maxRadioButtons = 20;
            int totalHeight = _vertexCount * radioButtonHeight + 146;

            MainPanel.Height = EndVertPanel.Height = StartVertPanel.Height = Math.Min(totalHeight, maxRadioButtons * radioButtonHeight
                + 146);

            for (int i = 0; i < _vertexCount; i++)
            {
                RadioButton startVertex = new RadioButton
                {
                    Text = Convert.ToString(Convert.ToChar('A' + i)),
                    Location = new Point(10, startY),
                    Size = new Size(120, 20),
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.White
                };

                RadioButton endVertex = new RadioButton
                {
                    Text = Convert.ToString(Convert.ToChar('A' + i)),
                    Location = new Point(10, endY),
                    Size = new Size(120, 20),
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.White
                };

                StartVertPanel.Controls.Add(startVertex);
                EndVertPanel.Controls.Add(endVertex);

                startY += 25;
                endY += 25;
            }
        }

        private void DrawGraph(object sender, PaintEventArgs e)
        {
            List<Tuple<int, int>> drawnEdges = new List<Tuple<int, int>>();
            Graphics g = e.Graphics;
            Pen edgePen = new Pen(Color.Blue, 2);
            Brush vertexBrush = Brushes.BlueViolet;
            Brush textBrush;
            Pen pen;
            Font font = new Font("Segoe UI", 9);

            int radius = 20;
            Point[] vertexPositions = new Point[_vertexCount];
            int centerX = graphPanel.Width / 2;
            int centerY = graphPanel.Height / 2;
            int maxRadius = Math.Min(graphPanel.Width, graphPanel.Height) / 2 - radius - 10;

            for (int i = 0; i < _vertexCount; i++)
            {
                int x = (int)(centerX + maxRadius * Math.Cos(2 * Math.PI * i / _vertexCount));
                int y = (int)(centerY + maxRadius * Math.Sin(2 * Math.PI * i / _vertexCount));
                vertexPositions[i] = new Point(x, y);
            }

            for (int i = 0; i < _vertexCount; i++)
            {
                for (int j = 0; j < _vertexCount; j++)
                {
                    if (_adjacencyMatrix[i, j] != 0 && !drawnEdges.Contains(new Tuple<int, int>(i, j)))
                    {
                        if (i == j)
                        {
                            pen = new Pen(Color.MediumVioletRed, 2);
                            textBrush = Brushes.DarkRed;
                            DrawLoop(g, vertexPositions[i], _adjacencyMatrix[i, j].ToString(), font, textBrush, pen, _shouldShowW);
                            drawnEdges.Add(new Tuple<int, int>(j, i));
                            drawnEdges.Add(new Tuple<int, int>(i, j));
                        }
                        else
                        {
                            if (_adjacencyMatrix[j, i] != 0 && !drawnEdges.Contains(new Tuple<int, int>(j, i)))
                            {
                                pen = new Pen(Color.Magenta, 2);
                                textBrush = Brushes.DarkViolet;
                                DrawCurve(g, vertexPositions[j], vertexPositions[i], radius + 20, _adjacencyMatrix[j, i].ToString(),
                                    font, textBrush, pen, _shouldShowW);
                                drawnEdges.Add(new Tuple<int, int>(j, i));
                            }

                            DrawArrow(g, edgePen, vertexPositions[i], vertexPositions[j], radius + 1);

                            if (_shouldShowW)
                            {
                                textBrush = Brushes.Black;
                                int midX = (vertexPositions[i].X + vertexPositions[j].X) / 2;
                                int midY = (vertexPositions[i].Y + vertexPositions[j].Y) / 2;
                                g.DrawString(_adjacencyMatrix[i, j].ToString(), font, textBrush, midX, midY);
                            }
                            drawnEdges.Add(new Tuple<int, int>(i, j));
                        }
                    }
                }
            }

            for (int i = 0; i < _vertexCount; i++)
            {
                g.FillEllipse(vertexBrush, vertexPositions[i].X - radius, vertexPositions[i].Y - radius, 2 * radius, 2 * radius);
                char label = Convert.ToChar('A' + i);

                SizeF textSize = g.MeasureString(Convert.ToString(label), font);

                float labelX = vertexPositions[i].X - textSize.Width / 2;
                float labelY = vertexPositions[i].Y - textSize.Height / 2;

                textBrush = Brushes.Black;
                g.DrawString(Convert.ToString(label), font, textBrush, labelX, labelY);
            }
        }

        public static void DrawLoop(Graphics g, Point position, string label, Font font, Brush textBrush,
            Pen pen, bool showWeights)
        {
            int loopRadius = 20;
            int loopOffset = 10;

            Rectangle loopRect = new Rectangle(position.X - loopRadius - loopOffset, position.Y - loopRadius - loopOffset,
                                               2 * loopRadius, 2 * loopRadius);
            g.DrawArc(pen, loopRect, 0, 360);

            if (showWeights)
            {
                int labelX = position.X - loopRadius - loopOffset - 10;
                int labelY = position.Y - loopRadius - loopOffset - 10;
                g.DrawString(label, font, textBrush, labelX, labelY);
            }
        }

        public static void DrawCurve(Graphics g, Point p1, Point p2, int offset, string label, Font font, Brush textBrush,
            Pen pen, bool showWeights)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            double sin = dy / length;
            double cos = dx / length;

            int midX = (p1.X + p2.X) / 2;
            int midY = (p1.Y + p2.Y) / 2;

            Point arcPoint = new Point(
                (int)(midX + offset * sin),
                (int)(midY - offset * cos));

            Point[] curvePoints = { new Point(p1.X - (int)((offset - 20) * cos), p1.Y - (int)((offset - 20) * sin)), arcPoint,
                new Point(p2.X - (int)((offset - 20) * cos), p2.Y - (int)((offset - 20) * sin)) };

            g.DrawCurve(pen, curvePoints);

            Point adjustedPoint = new Point(
                p2.X - (int)((offset - 20) * cos),
                p2.Y - (int)((offset - 20) * sin));

            const int arrowSize = 12;
            const double angle = Math.PI / 6;

            Point arrowPoint1 = new Point(
                adjustedPoint.X - (int)(arrowSize * (cos * Math.Cos(angle) - sin * Math.Sin(angle))) + 2,
                adjustedPoint.Y - (int)(arrowSize * (sin * Math.Cos(angle) + cos * Math.Sin(angle))) + 2
                );

            Point arrowPoint2 = new Point(
                adjustedPoint.X - (int)(arrowSize * (cos * Math.Cos(-angle) - sin * Math.Sin(-angle))) + 2,
                adjustedPoint.Y - (int)(arrowSize * (sin * Math.Cos(-angle) + cos * Math.Sin(-angle))) + 2
                );

            g.DrawLine(pen, adjustedPoint, arrowPoint1);
            g.DrawLine(pen, adjustedPoint, arrowPoint2);

            if (showWeights)
            {
                int labelX = midX + (int)(1.25 * offset * sin);
                int labelY = midY - (int)(1.25 * offset * cos);
                g.DrawString(label, font, textBrush, labelX, labelY);
            }
        }

        public static void DrawArrow(Graphics g, Pen pen, Point p1, Point p2, int offset)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            double sin = dy / length;
            double cos = dx / length;

            Point adjustedPoint = new Point(
                p2.X - (int)(offset * cos),
                p2.Y - (int)(offset * sin));

            g.DrawLine(pen, p1, adjustedPoint);

            const int arrowSize = 12;
            const double angle = Math.PI / 6;

            Point arrowPoint1 = new Point(
                adjustedPoint.X - (int)(arrowSize * (cos * Math.Cos(angle) - sin * Math.Sin(angle))),
                adjustedPoint.Y - (int)(arrowSize * (sin * Math.Cos(angle) + cos * Math.Sin(angle))));

            Point arrowPoint2 = new Point(
                adjustedPoint.X - (int)(arrowSize * (cos * Math.Cos(-angle) - sin * Math.Sin(-angle))),
                adjustedPoint.Y - (int)(arrowSize * (sin * Math.Cos(-angle) + cos * Math.Sin(-angle)))
                );

            g.DrawLine(pen, adjustedPoint, arrowPoint1);
            g.DrawLine(pen, adjustedPoint, arrowPoint2);
            g.DrawLine(pen, adjustedPoint, p2);
        }

        public void ButtonToExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton selectedStart = StartVertPanel.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
                RadioButton selectedEnd = EndVertPanel.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                if (selectedStart == null || selectedEnd == null)
                {
                    throw new InvalidOperationException("Будь ласка, оберіть стартову та кінцеву вершини.");
                }

                int startVertexIndex = selectedStart.Text[0] - 'A';
                int endVertexIndex = selectedEnd.Text[0] - 'A';

                if (startVertexIndex == endVertexIndex)
                {
                    throw new InvalidOperationException("Будь ласка, оберіть різні стартову та кінцеву вершини.");
                }

                Graph graph = new Graph(_adjacencyMatrix);
                try
                {
                    Stopwatch stopwatch = new Stopwatch();
                    int processedVerticesCount;
                    Vertex resultVert = null;

                    if (_method == "Метод Дейкстри")
                    {
                        stopwatch.Start();
                        resultVert = DijkstraAlgorithm.FindShortestPath(graph, startVertexIndex, endVertexIndex, out processedVerticesCount);
                        stopwatch.Stop();
                    }
                    else if (_method == "Метод Беллмана-Форда")
                    {
                        stopwatch.Start();
                        resultVert = BellmanFordAlgorithm.FindShortestPath(graph, startVertexIndex, endVertexIndex, out processedVerticesCount);
                        stopwatch.Stop();
                    }
                    else
                    {
                        stopwatch.Start();
                        resultVert = DynamicProgrammingAlgorithm.FindShortestPath(graph, startVertexIndex, endVertexIndex, out processedVerticesCount);
                        stopwatch.Stop();
                    }
                    double? shortestPathWeigh = resultVert.PathWeight;
                    List<Vertex> vertices = graph.RecreatePathVertices(resultVert);
                    List<Tuple<Vertex, Vertex, double>> edges = graph.RecreatePathEdges(resultVert);
                    if (shortestPathWeigh == null || shortestPathWeigh == 0 || vertices == null || edges == null
                        || vertices.Count == 0)
                    {
                        throw new PathNotFoundException("Шляху між заданими вершинами не існує.");
                    }
                    long executionTime = stopwatch.ElapsedTicks;
                    stopwatch.Reset();
                    SolutionForm solution = new SolutionForm((double)shortestPathWeigh, vertices, edges, _vertexCount,
                        _adjacencyMatrix, _shouldShowW, _method, executionTime, processedVerticesCount);
                    this.Close();
                    solution.Show();
                }
                catch (PathCannotBeRecreatedException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (VertexNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PathNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NegativeCycleException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Невідома помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
