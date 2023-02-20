using System.Collections.Generic;

namespace GraphsAndThrees
{
    public class TreeNode
    {
        protected TreeNode()
        {
        }
        public TreeNode(int value)
        {
            Value = value;
        }
        public TreeNode(int value, List<TreeNode> children)
        {
            Value = value;
            Children = children;
        }

        public int Value { get; private set; }
        public List<TreeNode> Children { get; private set; }

        public int CountOfElementViaDFS(int findedValue)
        {
            int count = 0;
            if (this.Children != null)
            {
                foreach (var item in this.Children)
                {
                    if (item.Value == findedValue)
                    {
                        count++;
                    }
                    count += item.CountOfElementViaDFS(findedValue);
                }
            }
            return count;
        }

        public int CountOfElementViaBFS(int findedValue)
        {
            int count = 0;

            if (this.Children != null)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();

                foreach (var item in this.Children)
                {
                    if (item.Value == findedValue)
                    {
                        count++;
                    }
                    queue.Enqueue(item);
                }

                while (queue.Count != 0)
                {
                    count += queue.Dequeue().CountOfElementViaBFS(findedValue);
                }
            }

            return count;
        }
    }
}
