using System;
namespace DataStructures.Recursion
{
    public class FindtheWinneroftheCircularGame
    {
        int[] arr;
        int nuOfStillPlayers;
        int res;
        public int FindTheWinner(int n, int k)
        {
            arr = new int[n];
            nuOfStillPlayers = n;
            findRes(0, k - 1);
            return res;
        }

        private void findRes(int startPos, int count)
        {
            Console.WriteLine(startPos + "," + count);
            if (nuOfStillPlayers == 1)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != -1)
                    {
                        res = i;
                        return;
                    }
            }
            else
            {
                if (arr[startPos + count] == 0)
                {
                    arr[startPos + count] = -1;
                    nuOfStillPlayers--;
                    findRes(startPos + count, count);
                }
                else
                {
                    int cp = startPos + count;
                    while (arr[cp] != 0)
                    {
                        cp++;
                        if (cp == arr.Length)
                            cp = 0;
                    }
                    arr[cp] = -1;
                    nuOfStillPlayers--;
                    findRes(cp, count);
                }
            }
        }
    }
}
