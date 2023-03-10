using System;
using System.Collections.Generic;

namespace GraphsAndTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TreeNode> list = new List<TreeNode>()
            {
                new TreeNode(4, 
                new List<TreeNode>()
                {
                    new TreeNode(5),
                    new TreeNode(5),
                    new TreeNode(3,
                    new List<TreeNode>()
                    {
                        new TreeNode(1),
                        new TreeNode(1),
                        new TreeNode(9)
                    }
                    )
                }
                )
            };

            TreeNode tree = new TreeNode(10, list);

            //Values of methods should be 1
            Console.WriteLine(tree.CountOfElementViaDFS(4));
            Console.WriteLine(tree.CountOfElementViaBFS(4));
        }
    }
}
