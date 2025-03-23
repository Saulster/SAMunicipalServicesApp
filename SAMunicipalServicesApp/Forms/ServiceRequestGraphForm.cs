using PROG7312ST10202241.Data_Storage;
using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestGraphForm : Form
    {
        private ServiceRequestRedBlackTree redBlackTree;
        private MinHeap minHeap;
        private ServiceRequestGraph serviceRequestGraph;
        private ResourceManager resourceManager;

        public ServiceRequestGraphForm()
        {
            InitializeComponent();
            ServiceRequestManager.LoadData();

            // Initialize data structures
            redBlackTree = ServiceRequestManager.RedBlackTree;
            minHeap = ServiceRequestManager.MinHeap;
            serviceRequestGraph = ServiceRequestManager.Graph;

            Console.WriteLine($"ServiceRequestManager.ServiceRequests count: {ServiceRequestManager.ServiceRequests.Count}");

            // Populate tree structures
            foreach (var request in ServiceRequestManager.ServiceRequests)
            {
                try
                {
                    redBlackTree.Insert(request);
                    minHeap.Insert(request);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Insert error: {ex.Message}");
                }
            }

            // Display data
            LoadServiceRequests();

            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(ServiceRequestGraphForm).Assembly);
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            lblSearchId.Text = resourceManager.GetString("lblSearchId");
            lblNewStatus.Text = resourceManager.GetString("lblNewStatus");
            btnSearch.Text = resourceManager.GetString("btnSearch");
            btnUpdateStatus.Text = resourceManager.GetString("btnUpdateStatus");
            btnSearch.Text = resourceManager.GetString("btnSearch");
            closeBtn.Text = resourceManager.GetString("closeBtn");
            this.Text = resourceManager.GetString("ServiceRequestGraphFormTitle");
        }

        private void LoadServiceRequests()
        {
            // Clear and reload requests
            dataGridViewRequests.DataSource = null;

            var requests = GetInOrderRequests();
            Console.WriteLine($"Requests to display: {requests.Count}");
            if (requests.Count > 0)
            {
                dataGridViewRequests.DataSource = requests.Select(r => new
                {
                    r.RequestId,
                    r.Location,
                    r.Category,
                    r.Description,
                    r.Status,
                    r.SubmittedDate
                }).ToList();
            }
            else
            {
                MessageBox.Show(resourceManager.GetString("NoServiceRequestsFound"));
            }
        }

        private List<ServiceRequest> GetInOrderRequests()
        {
            var results = new List<ServiceRequest>();
            redBlackTree.InOrderTraversal(results);
            Console.WriteLine($"InOrderTraversal results count: {results.Count}"); // Debug message
            return results;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int requestId = int.Parse(txtSearchId.Text);
                var rbRequest = redBlackTree.Search(requestId);

                if (rbRequest != null)
                {
                    string message = $"Service Request Found in Red-Black Tree:\nRequestId: {rbRequest.RequestId}\nLocation: {rbRequest.Location}\nCategory: {rbRequest.Category}\nDescription: {rbRequest.Description}\nStatus: {rbRequest.Status}\nSubmittedDate: {rbRequest.SubmittedDate}";
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Service Request Not Found in Red-Black Tree");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int requestId = int.Parse(txtSearchId.Text);
                var rbRequest = redBlackTree.Search(requestId);

                if (rbRequest != null)
                {
                    rbRequest.Status = txtNewStatus.Text; // Update the status
                    MessageBox.Show($"Status for Request ID {requestId} updated to '{txtNewStatus.Text}'.");

                    // Persist changes
                    ServiceRequestManager.SaveData();

                    // Refresh the DataGridView
                    LoadServiceRequests();
                }
                else
                {
                    MessageBox.Show("Service Request Not Found in Red-Black Tree");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnShowHeap_Click(object sender, EventArgs e)
        {
            try
            {
                var heapRequests = minHeap.GetAll();
                var message = resourceManager.GetString("HeapElementsMessage");
                foreach (var request in heapRequests)
                {
                    message += string.Format(resourceManager.GetString("HeapElementFormat"), request.RequestId, request.SubmittedDate);
                }
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(resourceManager.GetString("ErrorMessage"), ex.Message));
            }
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            var graphEdges = serviceRequestGraph.GetEdges();
            var message = resourceManager.GetString("GraphEdgesMessage");
            foreach (var edge in graphEdges)
            {
                message += string.Format(resourceManager.GetString("GraphEdgeFormat"), edge.From, edge.To);
            }
            MessageBox.Show(message);
        }

        private void btnShowMST_Click(object sender, EventArgs e)
        {
            MST mstCalculator = new MST();

            // Example edges
            mstCalculator.AddEdge(1, 2, 3);
            mstCalculator.AddEdge(1, 3, 1);
            mstCalculator.AddEdge(2, 4, 5);
            mstCalculator.AddEdge(3, 4, 4);

            var mstEdges = mstCalculator.GetMinimumSpanningTree();
            // lstMSTDisplay.Items.Clear();
            foreach (var edge in mstEdges)
            {
                // lstMSTDisplay.Items.Add($"From {edge.From} to {edge.To}, Weight: {edge.Weight}");
            }
        }

        private void btnGraphTraversal_Click(object sender, EventArgs e)
        {
            try
            {
                // Example graph traversal code
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(resourceManager.GetString("ErrorMessage"), ex.Message));
            }
        }

        private List<int> PerformDFS(int startNode, Dictionary<int, List<int>> graph)
        {
            var visited = new HashSet<int>();
            var result = new List<int>();
            var stack = new Stack<int>();

            stack.Push(startNode);

            while (stack.Count > 0)
            {
                int node = stack.Pop();

                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    result.Add(node);

                    if (graph.ContainsKey(node))
                    {
                        foreach (var neighbor in graph[node])
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }

            return result;
        }

        private void btnSetRoot_Click(object sender, EventArgs e)
        {
            try
            {
                // Example set root node code
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(resourceManager.GetString("ErrorMessage"), ex.Message));
            }
        }

        private void ServiceRequestGraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
