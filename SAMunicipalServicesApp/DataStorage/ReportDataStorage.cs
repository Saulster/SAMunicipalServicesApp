using System.Collections.Generic;

namespace PROG7312ST10202241.Data_Storage
{
    public static class ReportDataStorage
    {
        public static List<IssueReport> ReportedIssues { get; set; } = new List<IssueReport>();

        // Initialize data structures
        public static ServiceRequestRedBlackTree RedBlackTreeInstance { get; set; } = new ServiceRequestRedBlackTree();
        public static MinHeap MinHeapInstance { get; set; } = new MinHeap();
        public static ServiceRequestGraph GraphInstance { get; set; } = new ServiceRequestGraph();

        // List to hold service requests
        public static List<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
    }
}
