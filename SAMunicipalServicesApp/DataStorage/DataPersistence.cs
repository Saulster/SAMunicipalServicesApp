using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PROG7312ST10202241.Data_Storage;

namespace PROG7312ST10202241.Data_Storage
{
    public static class DataPersistence
    {
        private static string dataFilePath = "data.json";

        public static void SaveData()
        {
            var data = new
            {
                ReportedIssues = ReportDataStorage.ReportedIssues,
                ServiceRequests = ReportDataStorage.ServiceRequests
            };
            File.WriteAllText(dataFilePath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        public static void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                var data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(dataFilePath));
                ReportDataStorage.ReportedIssues = data.ReportedIssues.ToObject<List<IssueReport>>();
                ReportDataStorage.ServiceRequests = data.ServiceRequests.ToObject<List<ServiceRequest>>();

                // Repopulate the tree and heap structures
                ReportDataStorage.RedBlackTreeInstance = new ServiceRequestRedBlackTree();
                ReportDataStorage.MinHeapInstance = new MinHeap();
                ReportDataStorage.GraphInstance = new ServiceRequestGraph();

                foreach (var request in ReportDataStorage.ServiceRequests)
                {
                    ReportDataStorage.RedBlackTreeInstance.Insert(request);
                    ReportDataStorage.MinHeapInstance.Insert(request);
                    // Add edges to the graph if needed
                }
            }
        }
    }
}
