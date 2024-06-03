using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShortestPathSolver
{
    internal class WriteInFile
    {
        private readonly string _fileName;

        public WriteInFile(string fileName)
        {
            _fileName = fileName;
        }

        public bool WriteToFile(double[,] adjacencyMatrix, List<Vertex> vertices, List<Tuple<Vertex, Vertex, double>> edges,
            double shortestPathWeight, string method)
        {
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(_fileName, true, Encoding.UTF8))
                {
                    fileWriter.WriteLine("Вагова матриця суміжності:");

                    fileWriter.Write("        ");
                    for (int i = 0; i < adjacencyMatrix.GetLength(1); i++)
                    {
                        fileWriter.Write($"{Convert.ToChar(i + 'A')}\t");
                    }

                    fileWriter.WriteLine();

                    for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
                    {
                        fileWriter.Write($"{Convert.ToChar(i + 'A')}\t");
                        for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)
                        {
                            fileWriter.Write(adjacencyMatrix[i, j] + "\t");
                        }
                        fileWriter.WriteLine();
                    }
                    fileWriter.WriteLine();

                    fileWriter.WriteLine($"Стартова вершина: {Convert.ToChar(vertices[0].Position + 'A')}");
                    fileWriter.WriteLine($"Кінцева вершина: {Convert.ToChar(vertices[vertices.Count - 1].Position + 'A')}");
                    fileWriter.WriteLine();

                    fileWriter.WriteLine($"Метод знаходження найкоротшого шляху: {method}");

                    fileWriter.WriteLine($"Вага найкоротшого шляху: {shortestPathWeight}");
                    fileWriter.WriteLine("Найкоротший шлях:");

                    StringBuilder pathText = new StringBuilder();
                    foreach (Vertex v in vertices)
                    {
                        pathText.Append(Convert.ToChar(v.Position + 'A')).Append(" -> ");
                    }
                    pathText.Remove(pathText.Length - 4, 4);

                    fileWriter.WriteLine(pathText.ToString());

                    StringBuilder edgesText = new StringBuilder();
                    foreach (var edge in edges)
                    {
                        char startVertex = Convert.ToChar(edge.Item1.Position + 'A');
                        char endVertex = Convert.ToChar(edge.Item2.Position + 'A');
                        double weight = edge.Item3;
                        edgesText.AppendFormat("{0} -> {1} (Вага: {2})", startVertex, endVertex, weight).Append("\n");
                    }

                    fileWriter.WriteLine(edgesText.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
