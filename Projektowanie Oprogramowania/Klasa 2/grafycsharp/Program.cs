namespace grafycsharp;

class Program
{
    class Vertex
    {
        List<int> neighbours = new List<int>();
        public void AddNeighbour(int nei) {neighbours.Add(nei);}
        public void displayneighbours()
        {
            foreach (var item in neighbours)
            {
                System.Console.Write(item + " ");
            }
        }
        
    }
    class Graph
    {
        int n;
        List<Vertex> vertices = new List<Vertex>();
        public Graph(int n)
        {
            for (int i = 0; i <= n; i++) vertices.Add(new Vertex());
            this.n = n;
        }

        public void AddNeighbours(int v, int nei)
        {
            vertices[v].AddNeighbour(nei);
            vertices[nei].AddNeighbour(v);
        }

        public void displayGraph()
        {
            for (int i = 1; i <= n; i++)
            {
                System.Console.Write(i + "-");
                vertices[i].displayneighbours();
                System.Console.WriteLine();
            }
        }

    }
    static void Main(string[] args)
    {
        int a,b;
        List<string> list = Console.ReadLine().Split().ToList();
        int n = int.Parse(list[0]);
        int m = int.Parse(list[1]);

        Graph graph = new Graph(n);

        for (int i = 0; i < m; i++)
        {
            list = Console.ReadLine().Split().ToList();
            a = int.Parse(list[0]);
            b = int.Parse(list[1]);
            graph.AddNeighbours(a,b);
        }
        graph.displayGraph();
    }
}
