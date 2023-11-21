using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class BuildWallWithBlocks
    {
        public static int BuildWallWithBlock(int[] H)
        {
            if (H.Length == 0)
            {
                return 0;
            }
            Stack<int> stack = new Stack<int>();
            int blocksNeeded = 0;
            foreach (int height in H)
            {

                while (stack.Count > 0 && stack.Peek() > height)
                {
                    stack.Pop();
                }

                if (stack.Count == 0 || stack.Peek() < height)
                {
                    stack.Push(height);
                    blocksNeeded++;
                }
            }

            return blocksNeeded;
        }
    }
}
