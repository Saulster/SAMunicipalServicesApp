using System;

public class ServiceRequest
{
    public int RequestId { get; set; }
    public string Location { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
   // public string Title { get; set; }
    public string Status { get; set; }
    public DateTime SubmittedDate { get; set; }

    public ServiceRequest(int requestId, string location, string category, string description, string status= "Pending", DateTime? submittedDate = null)
    {
        RequestId = requestId;
        Location = location;
        Category = category;
        Description = description;
        Status = status;
       // Title = title;
        SubmittedDate = submittedDate ?? DateTime.Now; ;
    }
}
