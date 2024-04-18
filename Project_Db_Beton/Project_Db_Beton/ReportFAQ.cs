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
    public partial class ReportFAQ : Form
    {
        public ReportFAQ()
        {
            InitializeComponent();
        }

        private void ReportFAQ_Load(object sender, EventArgs e)
        {
            List<string> SQL = new List<string>();
            DataBase DB = new DataBase();
            string index = ClassStatic.Index;
            MySqlCommand command = new MySqlCommand("SELECT requisites.`Name`, requisites.INN, requisites.KPP, requisites.Adress, customers.Address, customers.`Name`, customers.INN, customers.KPP, requisites.Supervisor FROM requisites INNER JOIN application ON requisites.Adress = application.PointOfDeparture INNER JOIN customers ON application.Customer = customers.`Name` WHERE application.Application =" + index, DB.GetConnection());


            //Можно использовать using
            DB.OpenConnection();
            MySqlDataReader Reader = command.ExecuteReader();
            try
            {
                while (Reader.Read())
                {
                    SQL.Add(Reader["Name"].ToString());

                    SQL.Add(Reader["INN"].ToString());

                    SQL.Add(Reader["KPP"].ToString());
 
                    SQL.Add(Reader["Adress"].ToString());

                    SQL.Add(Reader["Supervisor"].ToString());

                }
                DB.ClosedConnection();

            }
            catch
            {
            }

            command.CommandText = "SELECT customers.Address, customers.`Name`, customers.INN, customers.KPP FROM requisites INNER JOIN application ON requisites.Adress = application.PointOfDeparture INNER JOIN customers ON application.Customer = customers.`Name` WHERE application.Application =" + index;
            DB.OpenConnection();

            MySqlDataReader Reader1 = command.ExecuteReader();
            try
            {
                while (Reader1.Read())
                {
                    SQL.Add(Reader1["Address"].ToString());
 
                    SQL.Add(Reader1["Name"].ToString());
 
                    SQL.Add(Reader1["INN"].ToString());
  
                    SQL.Add(Reader1["KPP"].ToString());

                }
                DB.ClosedConnection();

            }
            catch
            {

            }
            command.CommandText = "SELECT CONCAT(SUM(content.Quantity*products.Pay) * 1,' ','Р')  AS AllPayng, CONCAT(SUM(content.Quantity*products.Pay) * 0.18,' ','Р')  AS AllPayngNds  FROM products INNER JOIN content ON products.`Name` = content.Products INNER JOIN application ON application.Application = content.Application WHERE application.Application =" + index;
            DB.OpenConnection();
            MySqlDataReader Reader2 = command.ExecuteReader();
            try
            {
                while (Reader2.Read())
                {
                    SQL.Add(Reader2["AllPayng"].ToString());

                    SQL.Add(Reader2["AllPayngNds"].ToString());


                }
                DB.ClosedConnection();

            }
            catch
            {

            }

            command.CommandText = "SELECT content.Application,content.Products,content.Quantity FROM content INNER JOIN application ON application.Application = content.Application WHERE application.Application =" + index;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            reportViewerReportFAQ.LocalReport.DataSources.Clear();
            ReportDataSource ReportDataSource = new ReportDataSource("DataSet1", Table);
            reportViewerReportFAQ.LocalReport.ReportPath = @"D:\Project c++\Project_Db_Beton\Project_Db_Beton\ReportFaq2.rdlc";
            reportViewerReportFAQ.LocalReport.DataSources.Add(ReportDataSource);
            command.CommandText = "SELECT CONCAT(products.Pay,' ','Руб') AS Pay, CONCAT(content.Quantity*products.Pay,' ','Руб') AS NoteInfo,products.EdVal FROM products INNER JOIN content ON products.`Name` = content.Products INNER JOIN application ON application.Application = content.Application WHERE application.Application ="+index;
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command);
            DataTable Table1 = new DataTable();
            adapter1.Fill(Table1);
            ReportDataSource ReportDataSource1 = new ReportDataSource("DataSet2", Table1);
            reportViewerReportFAQ.LocalReport.DataSources.Add(ReportDataSource1);


            ReportParameterCollection ReportParameterCollection = new ReportParameterCollection();

            ReportParameterCollection.Add(new ReportParameter("ReportParameterMainName",SQL[0]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterMainINN", SQL[1]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterMainKPP",SQL[2]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterMainAdress", SQL[3]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterSupervisor", SQL[4]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterBuyerAdress", SQL[5]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterBuyer", SQL[6]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterBuyerINN", SQL[7]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterBuyerKPP", SQL[8]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterALLPayng", SQL[9]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterAllPayngNDS", SQL[10]));
            ReportParameterCollection.Add(new ReportParameter("ReportParameterAllPayngLast", SQL[9]));

            reportViewerReportFAQ.LocalReport.SetParameters(ReportParameterCollection);

            this.reportViewerReportFAQ.RefreshReport();
            SQL.Clear();
            ReportParameterCollection.Clear();
        }
    }
}
