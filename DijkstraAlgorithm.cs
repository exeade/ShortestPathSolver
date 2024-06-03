using Priority_Queue;

namespace ShortestPathSolver
{
    internal class DijkstraAlgorithm
    {
        public static Vertex FindShortestPath(Graph graph, int startVertIndex, int endVertIndex, out int procVertices)
        {
            procVertices = 0;
            Vertex startVert = graph.Vertices[startVertIndex];
            Vertex endVert = graph.Vertices[endVertIndex];

            if (startVert == null || endVert == null)
            {
                throw new VertexNotFoundException("Одну чи обидві задані вершини не було знайдено в графі");
            }

            SimplePriorityQueue<Vertex, double> priorityQ = new SimplePriorityQueue<Vertex, double>();

            for (int i = 0; i < graph.VerticesNumber; i++)
            {
                if (i != startVert.Position)
                {
                    graph.Vertices[i].PathWeight = double.PositiveInfinity;
                }
                graph.Vertices[i].IsVisited = false;
                graph.Vertices[i].Previous = null;
            }

            startVert.PathWeight = 0;
            priorityQ.Enqueue(startVert, startVert.PathWeight);

            while (priorityQ.Count != 0 && !endVert.IsVisited)
            {
                Vertex current = priorityQ.Dequeue();
                procVertices++;
                if (current.IsVisited)
                {
                    continue;
                }

                current.IsVisited = true;
                Vertex[] neighbours = graph.GetNeighbors(current);
                foreach (Vertex neighbour in neighbours)
                {
                    if (!neighbour.IsVisited)
                    {
                        double currentWeight = current.PathWeight + graph.Weight(current, neighbour);
                        if (currentWeight < neighbour.PathWeight)
                        {
                            neighbour.PathWeight = currentWeight;
                            neighbour.Previous = current;
                            priorityQ.Enqueue(neighbour, neighbour.PathWeight);
                        }
                    }
                }
            }

            return endVert;
        }
    }
}
