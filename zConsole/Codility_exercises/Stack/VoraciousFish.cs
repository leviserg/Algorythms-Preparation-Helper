using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class VoraciousFish
    {
        public static int VoraciousFishAlive(int[] A, int[] B)
        {
            Stack<int> downstreamFish = new Stack<int>();
            int aliveFishCount = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    // Fish is going downstream, push its size onto the stack
                    downstreamFish.Push(A[i]);
                }
                else
                {
                    // Fish is going upstream
                    while (downstreamFish.Count > 0)
                    {
                        int downstreamSize = downstreamFish.Pop();

                        if (A[i] > downstreamSize)
                        {
                            // The upstream fish is larger and eats the downstream fish
                            continue;
                        }
                        else
                        {
                            // The downstream fish is larger and eats the upstream fish
                            downstreamFish.Push(downstreamSize);
                            break; // Stop comparing with remaining downstream fish
                        }
                    }

                    // If the stack is empty, the upstream fish survives
                    if (downstreamFish.Count == 0)
                    {
                        aliveFishCount++;
                    }
                }
            }

            // Add the remaining downstream fish to the count
            aliveFishCount += downstreamFish.Count;

            return aliveFishCount;
        }
    }
}
