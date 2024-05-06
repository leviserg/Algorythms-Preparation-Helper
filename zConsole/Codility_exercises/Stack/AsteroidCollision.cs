using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class AsteroidCollision
    {
        public static int[] GetSurvivedAstroids(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                int asteroid = asteroids[i];
                if (asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                { // negative
                    while (stack.Any() &&
                        stack.Peek() > 0 &&
                        stack.Peek() < -asteroid // head of stack less then current negative asteroid
                    )
                    {
                        stack.Pop(); // remove from stack till found bigger positive one than current or empty stack
                    }
                    if (!stack.Any() || stack.Peek() < 0) // stack is empty or head is negative 
                    {
                        stack.Push(asteroid); // push negative
                    }
                    else if (stack.Peek() == -asteroid) // explode both current and head stack if equal
                    {
                        stack.Pop();
                    }
                }

            }

            return stack.Reverse().ToArray();
        }
    }
}
