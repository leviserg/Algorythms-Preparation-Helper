namespace zConsole.Codility_exercises.Stack
{
    public class MinimalOwnStack
    {

        int curIndex;
        int initMinValue;
        List<StackNode> stackList;

        public MinimalOwnStack()
        {
            curIndex = -1;
            initMinValue = int.MaxValue;
            stackList = new List<StackNode>();
        }

        public void Push(int val)
        {
            curIndex++;
            int minVal = Math.Min(val, initMinValue);
            stackList.Add(new StackNode() { Value = val, MinValue = minVal });
            initMinValue = minVal;
        }

        public void Pop()
        {
            stackList.RemoveAt(curIndex);
            curIndex--;
            initMinValue = stackList.Count > 0 ? stackList[curIndex].MinValue : int.MaxValue;
        }

        public int Top()
        {
            return stackList[curIndex].Value;
        }

        public int GetMin()
        {
            return stackList[curIndex].MinValue;
        }

        public struct StackNode
        {
            public int Value { get; set; }
            public int MinValue { get; set; }
        }
    }
}
