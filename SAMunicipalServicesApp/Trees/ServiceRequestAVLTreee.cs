using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class ServiceRequestAVLTree
    {
        private class Node
        {
            public ServiceRequest Request { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Height { get; set; }

            public Node(ServiceRequest request)
            {
                Request = request;
                Height = 1; // Initial height
            }
        }

        private Node root;

        public void Insert(ServiceRequest request)
        {
            root = InsertRecursive(root, request);
        }

        private Node InsertRecursive(Node node, ServiceRequest request)
        {
            if (node == null)
                return new Node(request);

            if (request.RequestId < node.Request.RequestId)
                node.Left = InsertRecursive(node.Left, request);
            else if (request.RequestId > node.Request.RequestId)
                node.Right = InsertRecursive(node.Right, request);
            else
                throw new ArgumentException("Duplicate Request ID is not allowed.");

            // Update height and balance
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            return Balance(node);
        }

        private Node Balance(Node node)
        {
            int balanceFactor = GetBalanceFactor(node);

            // Left-heavy
            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(node.Left) < 0)
                    node.Left = RotateLeft(node.Left); // Left-Right case
                return RotateRight(node); // Left-Left case
            }

            // Right-heavy
            if (balanceFactor < -1)
            {
                if (GetBalanceFactor(node.Right) > 0)
                    node.Right = RotateRight(node.Right); // Right-Left case
                return RotateLeft(node); // Right-Right case
            }

            return node;
        }

        private Node RotateLeft(Node node)
        {
            var newRoot = node.Right;
            node.Right = newRoot.Left;
            newRoot.Left = node;

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            newRoot.Height = 1 + Math.Max(GetHeight(newRoot.Left), GetHeight(newRoot.Right));
            return newRoot;
        }

        private Node RotateRight(Node node)
        {
            var newRoot = node.Left;
            node.Left = newRoot.Right;
            newRoot.Right = node;

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            newRoot.Height = 1 + Math.Max(GetHeight(newRoot.Left), GetHeight(newRoot.Right));
            return newRoot;
        }

        private int GetHeight(Node node) => node?.Height ?? 0;

        private int GetBalanceFactor(Node node) => node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);

        public ServiceRequest Search(int requestId)
        {
            return SearchRecursive(root, requestId);
        }

        private ServiceRequest SearchRecursive(Node node, int requestId)
        {
            if (node == null) return null;

            if (requestId == node.Request.RequestId)
                return node.Request;

            return requestId < node.Request.RequestId
                ? SearchRecursive(node.Left, requestId)
                : SearchRecursive(node.Right, requestId);
        }

        public List<ServiceRequest> InOrderTraversal()
        {
            var result = new List<ServiceRequest>();
            InOrderTraversalRecursive(root, result);
            return result;
        }

        private void InOrderTraversalRecursive(Node node, List<ServiceRequest> result)
        {
            if (node == null) return;

            InOrderTraversalRecursive(node.Left, result);
            result.Add(node.Request);
            InOrderTraversalRecursive(node.Right, result);
        }
    }
}
