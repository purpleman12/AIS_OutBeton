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
    public partial class ReportOutBeton : Form
    {
        public ReportOutBeton()
        {
            InitializeComponent();
        }

        private void ReportOutBeton_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetDb_Beton.releasee". При необходимости она может быть перемещена или удалена.
            this.releaseeTableAdapter.Fill(this.DataSetDb_Beton.releasee);

            this.reportViewer.RefreshReport();
        }
    }
}
