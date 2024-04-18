namespace Project_Db_Beton
{
    partial class ReportFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFAQ));
            this.reportViewerReportFAQ = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerReportFAQ
            // 
            this.reportViewerReportFAQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerReportFAQ.LocalReport.ReportEmbeddedResource = "Project_Db_Beton.ReportFaq2.rdlc";
            this.reportViewerReportFAQ.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReportFAQ.Name = "reportViewerReportFAQ";
            this.reportViewerReportFAQ.Size = new System.Drawing.Size(710, 647);
            this.reportViewerReportFAQ.TabIndex = 0;
            // 
            // ReportFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 647);
            this.Controls.Add(this.reportViewerReportFAQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportFAQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счет Фактура";
            this.Load += new System.EventHandler(this.ReportFAQ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReportFAQ;
    }
}