namespace DataStructures
{
    internal class GraphNode
    {
        internal int val;
        internal GraphNode[] children;
        internal bool visited;

        internal GraphNode(int val = 0)
        {
            this.val = val;
        }

    }
}
