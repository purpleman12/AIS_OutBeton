namespace Project_Db_Beton
{
    partial class ReportOutBeton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOutBeton));
            this.releaseeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDb_Beton = new Project_Db_Beton.DataSetDb_Beton();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.releaseeTableAdapter = new Project_Db_Beton.DataSetDb_BetonTableAdapters.releaseeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.releaseeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDb_Beton)).BeginInit();
            this.SuspendLayout();
            // 
            // releaseeBindingSource
            // 
            this.releaseeBindingSource.DataMember = "releasee";
            this.releaseeBindingSource.DataSource = this.DataSetDb_Beton;
            // 
            // DataSetDb_Beton
            // 
            this.DataSetDb_Beton.DataSetName = "DataSetDb_Beton";
            this.DataSetDb_Beton.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.releaseeBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Project_Db_Beton.ReportOutBeton.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(633, 323);
            this.reportViewer.TabIndex = 0;
            // 
            // releaseeTableAdapter
            // 
            this.releaseeTableAdapter.ClearBeforeFill = true;
            // 
            // ReportOutBeton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 323);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportOutBeton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет Выпуск по подразделениям помесячно";
            this.Load += new System.EventHandler(this.ReportOutBeton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.releaseeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDb_Beton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource releaseeBindingSource;
        private DataSetDb_Beton DataSetDb_Beton;
        private DataSetDb_BetonTableAdapters.releaseeTableAdapter releaseeTableAdapter;
    }
}