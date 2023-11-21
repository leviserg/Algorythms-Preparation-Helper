using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public static class RotateArrayKtimes
    {
        public static int[] RotateArray(int[] A, int K)
        {
            if (A.Length == 0 || K == 0 || K % A.Length == 0 || A.Distinct().Count() == 1)
            {
                return A;
            }

            LinkedList<int> list = new LinkedList<int>(A);
            K = K % A.Length;
            for (int i = 0; i < K; i++)
            {
                list.AddFirst(list.Last.Value);
                list.RemoveLast();
            }

            var head = list.First;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = head.Value;
                head = head.Next;
            }
            return A;
        }
    }
}
