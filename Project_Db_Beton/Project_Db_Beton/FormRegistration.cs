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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase DB = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO manager (manager.ID,manager.FIOManager,manager.Login,manager.Password) VALUES(@ID,@FIOManager,@Login,@Password)", DB.GetConnection());
                command.Parameters.AddWithValue("ID", textBoxIdManager.Text);
                command.Parameters.AddWithValue("FIOManager", textBoxFManager.Text + " " + textBoxIManager.Text + " " + textBoxOManager.Text);
                command.Parameters.AddWithValue("Login", textBoxLManager.Text);
                command.Parameters.AddWithValue("Password", textBoxPManager.Text);
                DB.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт был успешно создан");
                }
                else
                {
                    MessageBox.Show("Проверьте заполнены ли поля");
                }
                DB.ClosedConnection();
                command.Parameters.Clear();
            }
            catch
            {

            }

        }

        private void buttonRegCancel_Click(object sender, EventArgs e)
        {
            FormRegistration FormRegistration = new FormRegistration();
            textBoxIdManager.Text = "";
            textBoxFManager.Text = "";
            textBoxIManager.Text = "";
            textBoxOManager.Text = "";
            textBoxLManager.Text = "";
            textBoxPManager.Text = "";
            this.Close();
        }
    }
}
