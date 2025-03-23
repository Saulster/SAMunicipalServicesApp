using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class ViewFilesForm : Form
    {
        private List<string> attachedFiles; // List of file paths

        public ViewFilesForm(List<string> files)
        {
            InitializeComponent();
            attachedFiles = files ?? new List<string>(); // Ensure the list is initialized
            PopulateFilesList();
        }

        private void PopulateFilesList()
        {
            filesListBox.Items.Clear(); // Clear existing items
            foreach (var file in attachedFiles)
            {
                filesListBox.Items.Add(Path.GetFileName(file)); // Add file name to the ListBox
            }
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesListBox.SelectedItem != null)
            {
                string selectedFile = filesListBox.SelectedItem.ToString();
                string filePath = attachedFiles.FirstOrDefault(path => Path.GetFileName(path) == selectedFile);

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    try
                    {
                        // Check the file type
                        string extension = Path.GetExtension(filePath).ToLower();

                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                        {
                            // Display the image in the PictureBox
                            previewPictureBox.Image = Image.FromFile(filePath);
                            previewPictureBox.Visible = true;
                            previewPanel.Visible = false; // Hide other previews
                        }
                        else if (extension == ".pdf")
                        {
                            // Handle PDF Preview (use a third-party library like Adobe Reader or PDF.js)
                            previewPictureBox.Visible = false;
                            previewPanel.Visible = true;
                            previewPanel.Controls.Clear();

                            Label pdfLabel = new Label
                            {
                                Text = "PDF preview not available in this demo.",
                                AutoSize = true,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            previewPanel.Controls.Add(pdfLabel);
                        }
                        else
                        {
                            // Handle other file types (e.g., unsupported formats)
                            previewPictureBox.Visible = false;
                            previewPanel.Visible = true;
                            previewPanel.Controls.Clear();

                            Label unsupportedLabel = new Label
                            {
                                Text = "Preview not available for this file type.",
                                AutoSize = true,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            previewPanel.Controls.Add(unsupportedLabel);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error displaying file preview: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
        }

        
    }
}
