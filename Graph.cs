using System;
using System.Collections.Generic;

namespace ShortestPathSolver
{
    internal class Graph
    {

        private readonly int maxLoop;
        public int VerticesNumber { get; }
        private double[,] AdjacencyMatrix { get; }

        public Vertex[] Vertices { get; }

        public Graph(double[,] adjacencyMatrix)
        {
            VerticesNumber = adjacencyMatrix.GetLength(0);
            maxLoop = VerticesNumber;
            AdjacencyMatrix = adjacencyMatrix;
            List<Vertex> vertices = new List<Vertex>();
            for (int i = 0; i < VerticesNumber; i++)
            {
                vertices.Add(new Vertex(i));
            }

            Vertices = vertices.ToArray();
        }

        public Vertex[] GetNeighbors(Vertex vertex)
        {
            List<Vertex> neighbours = new List<Vertex>();
            for (int i = 0; i < VerticesNumber; i++)
            {
                if (AdjacencyMatrix[vertex.Position, i] != 0)
                {
                    neighbours.Add(Vertices[i]);
                }
            }

            return neighbours.ToArray();
        }

        public Vertex[] GetInverseNeighbors(Vertex vertex)
        {
            List<Vertex> inverseNeighbours = new List<Vertex>();
            for (int i = 0; i < VerticesNumber; i++)
            {
                if (AdjacencyMatrix[i, vertex.Position] != 0)
                {
                    inverseNeighbours.Add(Vertices[i]);
                }
            }

            return inverseNeighbours.ToArray();
        }

        public double Weight(Vertex v1, Vertex v2)
        {
            return AdjacencyMatrix[v1.Position, v2.Position];
        }

        public List<Vertex> RecreatePathVertices(Vertex endVertex)
        {
            int loopCount = 0;
            if (endVertex.Previous == null || endVertex.PathWeight == double.PositiveInfinity)
            {
                return null;
            }
            List<Vertex> shortestPathVertices = new List<Vertex>
            {
                endVertex
            };
            Vertex previous = endVertex.Previous;
            while (previous != null && loopCount < maxLoop)
            {
                loopCount++;
                Vertex vertex = previous;
                shortestPathVertices.Add(vertex);
                previous = vertex.Previous;
            }
            if (loopCount >= maxLoop)
            {
                throw new PathCannotBeRecreatedException("Не вдалося відтворити шлях між вершинами");
            }
            shortestPathVertices.Reverse();
            return shortestPathVertices;
        }
        public List<Tuple<Vertex, Vertex, double>> RecreatePathEdges(Vertex endVertex)
        {
            int loopCount = 0;
            if (endVertex.Previous == null)
            {
                return null;
            }

            List<Tuple<Vertex, Vertex, double>> shortestPathEdges = new List<Tuple<Vertex, Vertex, double>>();
            Vertex current = endVertex;

            while (current.Previous != null && loopCount < maxLoop)
            {
                loopCount++;
                Vertex previous = current.Previous;
                double weight = Weight(previous, current);
                shortestPathEdges.Add(new Tuple<Vertex, Vertex, double>(previous, current, weight));
                current = previous;
            }
            if (loopCount >= maxLoop)
            {
                throw new PathCannotBeRecreatedException("Не вдалося відтворити шлях між вершинами");
            }

            shortestPathEdges.Reverse();

            return shortestPathEdges;
        }

        public List<Tuple<Vertex, Vertex, double>> GetAllEdges()
        {
            List<Tuple<Vertex, Vertex, double>> allEdges = new List<Tuple<Vertex, Vertex, double>>();

            int size = VerticesNumber;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (AdjacencyMatrix[i, j] != 0)
                    {
                        allEdges.Add(new Tuple<Vertex, Vertex, double>(Vertices[i], Vertices[j], AdjacencyMatrix[i, j]));
                    }
                }
            }

            return allEdges;
        }

    }
}
