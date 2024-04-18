namespace Project_Db_Beton
{
    partial class ReportAutoMilage
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAutoMilage));
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDb_Beton = new Project_Db_Beton.DataSetDb_Beton();
            this.reportViewerAutoMileage = new Microsoft.Reporting.WinForms.ReportViewer();
            this.autosTableAdapter = new Project_Db_Beton.DataSetDb_BetonTableAdapters.autosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDb_Beton)).BeginInit();
            this.SuspendLayout();
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "autos";
            this.autosBindingSource.DataSource = this.DataSetDb_Beton;
            // 
            // DataSetDb_Beton
            // 
            this.DataSetDb_Beton.DataSetName = "DataSetDb_Beton";
            this.DataSetDb_Beton.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerAutoMileage
            // 
            this.reportViewerAutoMileage.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.autosBindingSource;
            this.reportViewerAutoMileage.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAutoMileage.LocalReport.ReportEmbeddedResource = "Project_Db_Beton.ReportAutoMilage.rdlc";
            this.reportViewerAutoMileage.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAutoMileage.Name = "reportViewerAutoMileage";
            this.reportViewerAutoMileage.Size = new System.Drawing.Size(497, 327);
            this.reportViewerAutoMileage.TabIndex = 0;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportAutoMilage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 327);
            this.Controls.Add(this.reportViewerAutoMileage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportAutoMilage";
            this.Text = "Отчет по автохозяйствам";
            this.Load += new System.EventHandler(this.ReportAutoMilage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDb_Beton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAutoMileage;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private DataSetDb_Beton DataSetDb_Beton;
        private DataSetDb_BetonTableAdapters.autosTableAdapter autosTableAdapter;
    }
}