using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

public class IssueReport
{
    public string Location { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int RequestID { get; set; } // Changed from string to int
    public List<string> AttachedFiles { get; set; }
    public DateTime ReportDate { get; set; }

    public IssueReport(string location, string category, string description, List<string> attachedFiles, int requestId)
    {
        if (string.IsNullOrWhiteSpace(location))
            throw new ArgumentException("Location is required.");
        if (string.IsNullOrWhiteSpace(category))
            throw new ArgumentException("Category is required.");
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description is required.");

        Location = location;
        Category = category;
        Description = description;
        RequestID = requestId; // No conversion necessary
        AttachedFiles = attachedFiles ?? new List<string>();
        ReportDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Location: {Location}, Category: {Category}, Description: {Description}, Files: {string.Join(", ", AttachedFiles.Select(Path.GetFileName))}";
    }
}
