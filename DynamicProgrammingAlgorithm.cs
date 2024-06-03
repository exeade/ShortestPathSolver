using System.Collections.Generic;

namespace ShortestPathSolver
{
    internal class DynamicProgrammingAlgorithm
    {
        public static Vertex FindShortestPath(Graph graph, int startIndex, int endIndex, out int procVertices)
        {
            int maxRecursionDepth = graph.VerticesNumber * (graph.VerticesNumber - 1);
            procVertices = 0;
            Vertex startVert = graph.Vertices[startIndex];
            Vertex endVert = graph.Vertices[endIndex];
            Dictionary<Vertex, double> distances = new Dictionary<Vertex, double>
            {
                [startVert] = 0
            };
            startVert.Previous = null;

            foreach (Vertex v in graph.Vertices)
            {
                ShortestPathDP(graph, v, distances, 0, maxRecursionDepth, ref procVertices);
            }

            endVert.PathWeight = distances[endVert];
            return endVert;
        }

        private static double ShortestPathDP(Graph graph, Vertex v, Dictionary<Vertex, double> distances,
            int depth, int maxDepth, ref int procVertices)
        {
            if (depth > maxDepth)
            {
                throw new NegativeCycleException("Неможливо знайти найкоротший шлях: на шляху присутній цикл.");
            }

            if (distances.ContainsKey(v))
            {
                return distances[v];
            }

            distances[v] = double.PositiveInfinity;
            v.Previous = null;

            foreach (Vertex u in graph.GetInverseNeighbors(v))
            {
                double newDistance = ShortestPathDP(graph, u, distances, depth + 1, maxDepth, ref procVertices);
                newDistance += graph.Weight(u, v);
                if (newDistance < distances[v])
                {
                    distances[v] = newDistance;
                    v.Previous = u;
                }
            }

            procVertices++;
            return distances[v];
        }

    }
}
