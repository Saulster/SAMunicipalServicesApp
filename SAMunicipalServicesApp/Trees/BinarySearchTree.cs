using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode<T> InsertRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
                return new TreeNode<T>(value);

            if (value.CompareTo(node.Value) < 0)
                node.Left = InsertRecursive(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(root);
        }

        private void InOrderRecursive(TreeNode<T> node)
        {
            if (node == null) return;

            InOrderRecursive(node.Left);
            Console.WriteLine(node.Value);
            InOrderRecursive(node.Right);
        }

        public void PreOrderTraversal()
        {
            PreOrderRecursive(root);
        }

        private void PreOrderRecursive(TreeNode<T> node)
        {
            if (node == null) return;

            Console.WriteLine(node.Value);
            PreOrderRecursive(node.Left);
            PreOrderRecursive(node.Right);
        }

        public void PostOrderTraversal()
        {
            PostOrderRecursive(root);
        }

        private void PostOrderRecursive(TreeNode<T> node)
        {
            if (node == null) return;

            PostOrderRecursive(node.Left);
            PostOrderRecursive(node.Right);
            Console.WriteLine(node.Value);
        }

        public void MultiThreadedTraversal()
        {
            List<Task> tasks = new List<Task>
        {
            Task.Run(() => { Console.WriteLine("In-order Traversal:"); InOrderTraversal(); }),
            Task.Run(() => { Console.WriteLine("Pre-order Traversal:"); PreOrderTraversal(); }),
            Task.Run(() => { Console.WriteLine("Post-order Traversal:"); PostOrderTraversal(); })
        };

            Task.WaitAll(tasks.ToArray());
        }
    }
}