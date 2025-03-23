using System;
using System.Collections.Generic;

namespace PROG7312ST10202241
{
    // Binary Search Tree for Service Requests
    public class ServiceRequestBST
    {
        private class Node
        {
            public ServiceRequest Request { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(ServiceRequest request)
            {
                Request = request;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        // Insert a new ServiceRequest into the BST
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

            return node;
        }

        // Search for a ServiceRequest by ID
        public ServiceRequest Search(int requestId)
        {
            return SearchRecursive(root, requestId);
        }

        private ServiceRequest SearchRecursive(Node node, int requestId)
        {
            if (node == null) return null;

            if (requestId == node.Request.RequestId)
                return node.Request;

            if (requestId < node.Request.RequestId)
                return SearchRecursive(node.Left, requestId);
            else
                return SearchRecursive(node.Right, requestId);
        }

        // In-order traversal to retrieve all requests in sorted order
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
