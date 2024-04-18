using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Db_Beton
{
    public partial class ReportAutoMilage : Form
    {
        public ReportAutoMilage()
        {
            InitializeComponent();
        }

        private void ReportAutoMilage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetDb_Beton.autos". При необходимости она может быть перемещена или удалена.
            this.autosTableAdapter.Fill(this.DataSetDb_Beton.autos);
            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT autos.AutoParking, SUM(autos.Mileage * application.Distance) AS Mileage FROM autos INNER JOIN application ON application.Auto = autos.Auto GROUP BY autos.Auto", DB.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            reportViewerAutoMileage.LocalReport.DataSources.Clear();
            ReportDataSource ReportDataSource = new ReportDataSource("DataSet1", Table);
            reportViewerAutoMileage.LocalReport.ReportPath = @"D:\Project c++\Project_Db_Beton\Project_Db_Beton\ReportAutoMileage.rdlc";
            reportViewerAutoMileage.LocalReport.DataSources.Add(ReportDataSource);
            this.reportViewerAutoMileage.RefreshReport();
        }
    }
}
