namespace PROG7312ST10202241
{
    partial class ReportIssuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssuesForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.AttachMediaBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.DescriptionRTxt = new System.Windows.Forms.RichTextBox();
            this.CategoryLBox = new System.Windows.Forms.ListBox();
            this.backlbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewReportsFormBtn = new System.Windows.Forms.Button();
            this.locationSuggestionsListBox = new System.Windows.Forms.ListBox();
            this.attachedFilesListBox = new System.Windows.Forms.ListBox();
            this.RemoveFileBtn = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewPanel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.closeBtn.Location = new System.Drawing.Point(0, 451);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(934, 34);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Back To Main Menu";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AttachMediaBtn
            // 
            this.AttachMediaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachMediaBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.AttachMediaBtn.Location = new System.Drawing.Point(4, 3);
            this.AttachMediaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AttachMediaBtn.Name = "AttachMediaBtn";
            this.AttachMediaBtn.Size = new System.Drawing.Size(219, 36);
            this.AttachMediaBtn.TabIndex = 2;
            this.AttachMediaBtn.Text = "Attach Media";
            this.AttachMediaBtn.UseVisualStyleBackColor = true;
            this.AttachMediaBtn.Click += new System.EventHandler(this.AttachMediaBtn_Click_1);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.SubmitBtn.Location = new System.Drawing.Point(159, 314);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(88, 48);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locationLbl.AutoSize = true;
            this.locationLbl.BackColor = System.Drawing.Color.White;
            this.locationLbl.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(36, 77);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(63, 18);
            this.locationLbl.TabIndex = 4;
            this.locationLbl.Text = "location:";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryLbl.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.CategoryLbl.Location = new System.Drawing.Point(36, 149);
            this.CategoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(69, 18);
            this.CategoryLbl.TabIndex = 5;
            this.CategoryLbl.Text = "Category:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.White;
            this.descriptionLbl.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.descriptionLbl.Location = new System.Drawing.Point(36, 203);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(84, 18);
            this.descriptionLbl.TabIndex = 6;
            this.descriptionLbl.Text = "Description";
            // 
            // locationTxt
            // 
            this.locationTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locationTxt.Location = new System.Drawing.Point(159, 70);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(296, 22);
            this.locationTxt.TabIndex = 7;
            this.locationTxt.Click += new System.EventHandler(this.locationTxt_Click);
            this.locationTxt.TextChanged += new System.EventHandler(this.locationTxt_TextChanged);
            // 
            // DescriptionRTxt
            // 
            this.DescriptionRTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRTxt.Location = new System.Drawing.Point(159, 206);
            this.DescriptionRTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescriptionRTxt.Name = "DescriptionRTxt";
            this.DescriptionRTxt.Size = new System.Drawing.Size(296, 48);
            this.DescriptionRTxt.TabIndex = 8;
            this.DescriptionRTxt.Text = "";
            this.DescriptionRTxt.Click += new System.EventHandler(this.DescriptionRTxt_Click);
            // 
            // CategoryLBox
            // 
            this.CategoryLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLBox.FormattingEnabled = true;
            this.CategoryLBox.ItemHeight = 14;
            this.CategoryLBox.Location = new System.Drawing.Point(159, 152);
            this.CategoryLBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CategoryLBox.Name = "CategoryLBox";
            this.CategoryLBox.Size = new System.Drawing.Size(296, 48);
            this.CategoryLBox.TabIndex = 9;
            this.CategoryLBox.SelectedIndexChanged += new System.EventHandler(this.CategoryLBox_SelectedIndexChanged_1);
            // 
            // backlbl
            // 
            this.backlbl.AutoSize = true;
            this.backlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlbl.Location = new System.Drawing.Point(4, 0);
            this.backlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(18, 19);
            this.backlbl.TabIndex = 10;
            this.backlbl.Text = "<";
            this.backlbl.Click += new System.EventHandler(this.backlbl_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(934, 25);
            this.progressBar.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.858729F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.57742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69324F));
            this.tableLayoutPanel1.Controls.Add(this.backlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.locationLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.locationTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewReportsFormBtn, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionRTxt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLbl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.locationSuggestionsListBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.827637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88177F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 420);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ViewReportsFormBtn
            // 
            this.ViewReportsFormBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ViewReportsFormBtn.Location = new System.Drawing.Point(36, 368);
            this.ViewReportsFormBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewReportsFormBtn.Name = "ViewReportsFormBtn";
            this.ViewReportsFormBtn.Size = new System.Drawing.Size(115, 49);
            this.ViewReportsFormBtn.TabIndex = 11;
            this.ViewReportsFormBtn.Text = "View Reports";
            this.ViewReportsFormBtn.UseVisualStyleBackColor = true;
            this.ViewReportsFormBtn.Click += new System.EventHandler(this.ViewReportsFormBtn_Click);
            // 
            // locationSuggestionsListBox
            // 
            this.locationSuggestionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationSuggestionsListBox.FormattingEnabled = true;
            this.locationSuggestionsListBox.ItemHeight = 14;
            this.locationSuggestionsListBox.Location = new System.Drawing.Point(158, 98);
            this.locationSuggestionsListBox.Name = "locationSuggestionsListBox";
            this.locationSuggestionsListBox.Size = new System.Drawing.Size(298, 48);
            this.locationSuggestionsListBox.TabIndex = 17;
            this.locationSuggestionsListBox.SelectedIndexChanged += new System.EventHandler(this.locationSuggestionsBox_SelectedIndexChanged);
            // 
            // attachedFilesListBox
            // 
            this.attachedFilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachedFilesListBox.FormattingEnabled = true;
            this.attachedFilesListBox.ItemHeight = 14;
            this.attachedFilesListBox.Location = new System.Drawing.Point(4, 229);
            this.attachedFilesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attachedFilesListBox.Name = "attachedFilesListBox";
            this.attachedFilesListBox.Size = new System.Drawing.Size(453, 66);
            this.attachedFilesListBox.TabIndex = 12;
            this.attachedFilesListBox.SelectedIndexChanged += new System.EventHandler(this.attachedFilesListBox_SelectedIndexChanged);
            // 
            // RemoveFileBtn
            // 
            this.RemoveFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveFileBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.RemoveFileBtn.Location = new System.Drawing.Point(231, 3);
            this.RemoveFileBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveFileBtn.Name = "RemoveFileBtn";
            this.RemoveFileBtn.Size = new System.Drawing.Size(220, 36);
            this.RemoveFileBtn.TabIndex = 13;
            this.RemoveFileBtn.Text = "Remove Media";
            this.RemoveFileBtn.UseVisualStyleBackColor = true;
            this.RemoveFileBtn.Click += new System.EventHandler(this.RemoveFileBtn_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(4, 53);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(453, 170);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 14;
            this.previewPictureBox.TabStop = false;
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewPanel.AutoSize = true;
            this.previewPanel.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.previewPanel.Location = new System.Drawing.Point(178, 32);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(104, 18);
            this.previewPanel.TabIndex = 15;
            this.previewPanel.Text = "Preview Panel";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AttachMediaBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveFileBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 42);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 426);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.previewPanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.attachedFilesListBox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.previewPictureBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(470, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.90476F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38095F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(461, 420);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PROG7312ST10202241.Properties.Resources.capetownreportissues;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportIssuesForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button AttachMediaBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.RichTextBox DescriptionRTxt;
        private System.Windows.Forms.ListBox CategoryLBox;
        private System.Windows.Forms.Label backlbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewReportsFormBtn;
        private System.Windows.Forms.ListBox attachedFilesListBox;
        private System.Windows.Forms.Button RemoveFileBtn;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label previewPanel;
        private System.Windows.Forms.ListBox locationSuggestionsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}