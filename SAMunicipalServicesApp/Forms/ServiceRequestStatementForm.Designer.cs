namespace PROG7312ST10202241.Forms
{
    partial class ServiceRequestStatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatementForm));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblSearchByID = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewRequests, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.closeBtn, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.4507F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.44131F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.107982F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 485);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRequests.Location = new System.Drawing.Point(190, 102);
            this.dataGridViewRequests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(552, 335);
            this.dataGridViewRequests.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSearchByID, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(189, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 93);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(372, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearchId.Location = new System.Drawing.Point(188, 68);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(176, 22);
            this.txtSearchId.TabIndex = 5;
            // 
            // lblSearchByID
            // 
            this.lblSearchByID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchByID.AutoSize = true;
            this.lblSearchByID.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchByID.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblSearchByID.Location = new System.Drawing.Point(91, 76);
            this.lblSearchByID.Name = "lblSearchByID";
            this.lblSearchByID.Size = new System.Drawing.Size(90, 17);
            this.lblSearchByID.TabIndex = 8;
            this.lblSearchByID.Text = "Search By ID";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.closeBtn.Location = new System.Drawing.Point(190, 443);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(552, 39);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Back To Main Menu";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ServiceRequestStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312ST10202241.Properties.Resources.servicerequestimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceRequestStatementForm";
            this.Text = "Service Request Statement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestStatementForm_FormClosed);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchByID;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button closeBtn;
    }
}