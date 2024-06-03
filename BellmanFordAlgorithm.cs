using System;
using System.Collections.Generic;

namespace ShortestPathSolver
{
    internal class BellmanFordAlgorithm
    {
        public static Vertex FindShortestPath(Graph graph, int startVertIndex, int endVertIndex, out int procVertices)
        {
            Vertex start = graph.Vertices[startVertIndex];
            Vertex end = graph.Vertices[endVertIndex];
            List<Tuple<Vertex, Vertex, double>> edges = graph.GetAllEdges();
            procVertices = 0;

            if (start == null || end == null)
            {
                throw new VertexNotFoundException("Одну чи обидві задані вершини не було знайдено в графі");
            }

            for (int i = 0; i < graph.VerticesNumber; i++)
            {
                if (i != start.Position)
                {
                    graph.Vertices[i].PathWeight = double.PositiveInfinity;
                }
                graph.Vertices[i].Previous = null;
            }

            start.PathWeight = 0.0;

            for (int i = 0; i < graph.VerticesNumber - 1; i++)
            {
                foreach (Tuple<Vertex, Vertex, double> edge in edges)
                {
                    if (edge.Item1.PathWeight != double.PositiveInfinity &&
                        edge.Item2.PathWeight > edge.Item1.PathWeight + edge.Item3)
                    {
                        edge.Item2.PathWeight = edge.Item1.PathWeight + edge.Item3;
                        edge.Item2.Previous = edge.Item1;
                        procVertices++;
                    }
                }
            }
            foreach (Tuple<Vertex, Vertex, double> edge in edges)
            {
                if (edge.Item1.PathWeight != double.PositiveInfinity &&
                    edge.Item2.PathWeight > edge.Item1.PathWeight + edge.Item3)
                {
                    throw new NegativeCycleException("Неможливо знайти найкоротший шлях: у графі присутній цикл від'ємної ваги");
                }
            }

            return end;
        }
    }
}
