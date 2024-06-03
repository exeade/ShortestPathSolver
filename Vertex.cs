namespace ShortestPathSolver
{
    public class Vertex
    {
        public int Position { get; }
        public double PathWeight { get; set; }
        public Vertex Previous { get; set; }
        public bool IsVisited { get; set; }

        public Vertex(int position)
        {
            Position = position;
        }
    }
}
