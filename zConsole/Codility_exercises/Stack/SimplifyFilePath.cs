using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class SimplifyFilePath
    {
        public static string SimplifyPath(string path)
        {
            Stack<string> folderStack = new Stack<string>();
            List<string> pathItems = path.Split('/').ToList();

            for (int i = 0; i < pathItems.Count; i++)
            {
                if (pathItems[i].Equals(".."))
                {
                    if (folderStack.Count > 0)
                    {
                        folderStack.Pop();
                    }
                }
                else if (!string.IsNullOrEmpty(pathItems[i]) && !pathItems[i].Equals("."))
                {
                    folderStack.Push(pathItems[i]);
                }
            }

            StringBuilder sb = new StringBuilder();
            while (folderStack.Count > 0)
            {
                sb.Insert(0, "/" + folderStack.Pop());
            }
            return sb.Length == 0 ? "/" : sb.ToString();
        }
    }
}
