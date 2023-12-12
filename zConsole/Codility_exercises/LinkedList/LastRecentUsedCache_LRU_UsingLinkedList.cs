using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public class LastRecentUsedCache_LRU_UsingLinkedList
    {
        private readonly int maxCapacity;
        private readonly Dictionary<int, LinkedListNode<NodeItem>> cacheMap;
        private readonly LinkedList<NodeItem> cacheList;

        public LastRecentUsedCache_LRU_UsingLinkedList(int capacity) // LRUCache
        {
            maxCapacity = capacity;
            cacheMap = new Dictionary<int, LinkedListNode<NodeItem>>(capacity);
            cacheList = new LinkedList<NodeItem>();
        }

        public int Get(int key)
        {
            if (!cacheMap.TryGetValue(key, out var node))
            {
                return -1;
            }
            cacheList.Remove(node);
            cacheList.AddFirst(node);
            return node.Value.val;
        }

        public void Put(int key, int value)
        {
            if (!cacheMap.TryGetValue(key, out var node))
            {
                if (cacheMap.Count() >= maxCapacity)
                {
                    var lastNode = cacheList.Last;
                    cacheMap.Remove(lastNode.Value.key);
                    cacheList.RemoveLast();
                }

                var newNode = new LinkedListNode<NodeItem>(new NodeItem(key, value));
                cacheMap.Add(key, newNode);
                cacheList.AddFirst(newNode);
            }
            else
            {
                node.Value.val = value;
                cacheList.Remove(node);
                cacheList.AddFirst(node);
            }
        }

        private class NodeItem
        {
            public int key { get; }
            public int val { get; set; }

            public NodeItem(int key, int value)
            {
                this.key = key;
                val = value;
            }
        }
    }
}
