using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class KeysandRooms
    {
        IList<IList<int>> rooms;
        public KeysandRooms()
        {
            //[[1,3],[3,0,1],[2],[0]]
            rooms = new List<IList<int>>();
            rooms.Add(new List<int>());
            rooms.Add(new List<int>());
            rooms.Add(new List<int>());
            rooms.Add(new List<int>());
            rooms[0].Add(1);
            rooms[0].Add(3);
            rooms[1].Add(3);
            rooms[1].Add(0);
            rooms[1].Add(1);
            rooms[2].Add(2);
            rooms[3].Add(0);
        }

        public KeysandRooms(IList<IList<int>> rooms)
        {
            this.rooms = rooms;
        }

        public bool CanVisitAllRooms()
        {
            bool[] visited = new bool[rooms.Count];

            BFS(ref visited);

            for (int i = 0; i < visited.Length; i++)
                if (!visited[i])
                    return false;

            return true;
        }

        private void BFS(ref bool[] visited)
        {
            Queue<int> keys = new Queue<int>();
            keys.Enqueue(0);

            while (keys.Count() > 0)
            {
                int curKey = keys.Dequeue();
                if (visited[curKey])
                    continue;
                Console.WriteLine(curKey);
                visited[curKey] = true;
                for (int i = 0; i < rooms[curKey].Count; i++)
                {
                    if (!visited[rooms[curKey][i]])
                        keys.Enqueue(rooms[curKey][i]);
                }
            }
        }
    }
}
