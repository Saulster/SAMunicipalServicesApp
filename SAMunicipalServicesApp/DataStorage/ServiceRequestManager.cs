using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PROG7312ST10202241.Data_Storage
{
    public static class ServiceRequestManager
    {
        public static List<IssueReport> ReportedIssues { get; set; } = new List<IssueReport>();
        public static ServiceRequestRedBlackTree RedBlackTree { get; set; } = new ServiceRequestRedBlackTree();
        public static MinHeap MinHeap { get; set; } = new MinHeap();
        public static ServiceRequestGraph Graph { get; set; } = new ServiceRequestGraph();
        public static List<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

        private static string dataFilePath = "data.json";

        public static void SaveData()
        {
            var data = new
            {
                ReportedIssues,
                ServiceRequests
            };
            File.WriteAllText(dataFilePath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }


        public static void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                var jsonData = File.ReadAllText(dataFilePath);
                Console.WriteLine("JSON Data Loaded: " + jsonData); // Debug message

                var data = JsonConvert.DeserializeObject<dynamic>(jsonData);
                ReportedIssues = data.ReportedIssues.ToObject<List<IssueReport>>();
                ServiceRequests = data.ServiceRequests.ToObject<List<ServiceRequest>>();

                // Clear existing data structures before loading new data
                RedBlackTree = new ServiceRequestRedBlackTree();
                MinHeap = new MinHeap();
                Graph = new ServiceRequestGraph();

                foreach (var request in ServiceRequests)
                {
                    RedBlackTree.Insert(request);
                    MinHeap.Insert(request);
                }

                Console.WriteLine($"Loaded {ServiceRequests.Count} unique service requests."); // Debug message
            }
            else
            {
                Console.WriteLine("Data file not found.");
            }
        }




        public static void AddIssueReport(IssueReport issueReport)
        {
            ReportedIssues.Add(issueReport);
            SaveData();
        }

        public static void AddServiceRequest(ServiceRequest serviceRequest)
        {
            if (ServiceRequests.Any(sr => sr.RequestId == serviceRequest.RequestId))
            {
                throw new ArgumentException("Duplicate Request ID not allowed.");
            }

            ServiceRequests.Add(serviceRequest);
            RedBlackTree.Insert(serviceRequest);
            MinHeap.Insert(serviceRequest);
            SaveData();
        }

    }
}
