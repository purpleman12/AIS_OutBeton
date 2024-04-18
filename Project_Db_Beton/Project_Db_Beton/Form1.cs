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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hide_panels()
        {
            panel_AutoPark.Visible = false;
            panel_Application.Visible = false;
            panel_OutBeton.Visible = false;
            panelCustomers.Visible = false;
            panelMain.Visible = false;
            panelAuthor.Visible = false;
            panelLeftAuthor.Visible = false;
        }

        private void button_Autopark_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            hide_panels();
            panel_AutoPark.Visible = true;
            MySqlCommand command = new MySqlCommand(("SELECT autopark.ID,autopark.Name_Parking,autopark.INN,autopark.KPP,autopark.Bank,autopark.BIK,autopark.KS,autopark.RS,autopark.Supervisor,autopark.ChiefAccountant,autopark.address FROM autopark ORDER BY ID"), DB.GetConnection());
            DataTable Table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
            adapter.Fill(Table);
            dataGridViewPanel_AutoPark.DataSource = Table;
            dataGridViewPanel_AutoPark_Rename();
        }

        private void buttonPanel_AutoPark_Add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            try { 
            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO autopark (ID,Name_Parking,INN,KPP,Bank,BIK,KS,RS,Supervisor,ChiefAccountant,address) VALUES(@ID,@Name_Parking,@INN,@KPP,@Bank,@BIK,@KS,@RS,@Supervisor,@ChiefAccountant,@address)",DB.GetConnection());
            command.Parameters.AddWithValue("ID",Convert.ToInt32(textBoxPanel_AutoParkId.Text));
            command.Parameters.AddWithValue("Name_Parking", textBoxPanel_Autopark_Auto_Company.Text);
            command.Parameters.AddWithValue("INN", textBoxpanel_AutoPark_INN.Text);
            command.Parameters.AddWithValue("KPP",textBoxpanel_AutoPark_KPP.Text );
            command.Parameters.AddWithValue("Bank",textBoxpanel_AutoPark_Bank.Text);
            command.Parameters.AddWithValue("BIK", textBoxpanel_AutoPark_BIK.Text);
            command.Parameters.AddWithValue("KS",textBoxpanel_AutoPark__KS.Text);
            command.Parameters.AddWithValue("RS", textBoxpanel_AutoPark_RS.Text);
            command.Parameters.AddWithValue("Supervisor", textBoxpanel_AutoPark_Supervisor.Text);
            command.Parameters.AddWithValue("ChiefAccountant",textBoxpanel_AutoPark_Cheaf.Text);
            command.Parameters.AddWithValue("address",textBoxpanel_AutoPark_Adress.Text);
            DB.OpenConnection();
            command.ExecuteNonQuery();
            DB.ClosedConnection();
            command.CommandText = "SELECT * FROM autopark ORDER BY ID";
            DataTable Table = new DataTable();
            DataSet DataSet = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText,DB.GetConnection());
            adapter.Fill(Table);
            dataGridViewPanel_AutoPark.DataSource = Table;


                }
            catch
            {
                MessageBox.Show("Проверьте не занят ли номер записи");
            }
            }
        }

        private void buttonPanel_Autopark_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    MySqlCommand command = new MySqlCommand(("DELETE FROM autopark WHERE autopark.ID =" + dataGridViewPanel_AutoPark[0, dataGridViewPanel_AutoPark.CurrentRow.Index].Value), DB.GetConnection());
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT * FROM autopark ORDER BY ID";
                    DataTable Table = new DataTable();
                    DataSet DataSet = new DataSet();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    adapter.Fill(Table);
                    dataGridViewPanel_AutoPark.DataSource = Table;
                }
                catch
                {

                }
                try
                {
                    textBoxPanel_AutoParkId.Text = Convert.ToString(dataGridViewPanel_AutoPark[0, dataGridViewPanel_AutoPark.CurrentRow.Index].Value);
                }
                catch
                {

                }
            }
        }

        private void dataGridViewPanel_AutoPark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxPanel_AutoParkId.Text = Convert.ToString(dataGridViewPanel_AutoPark[0, dataGridViewPanel_AutoPark.CurrentRow.Index].Value);//Возвращает значения id при выделении
            }
            catch
            {

            }
        }

        //Кнопка заявок
        private void button_Panel_Left_Application_Click(object sender, EventArgs e)
        {
            LoadComboBox();
            hide_panels();
            panel_Application.Visible = true;

            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("Select * FROM application ORDER BY Application");
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText,DB.GetConnection());
            DataTable Table = new DataTable();

            adapter.Fill(Table);
            dataGridViewPanel_Application.DataSource = Table;
            dataGridViewPanel_Application_Rename();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
       
        private void dataGridViewPanel_Application_Rename()
        {
            dataGridViewPanel_Application.Columns[0].HeaderText = "Номер Заявки";
            dataGridViewPanel_Application.Columns[1].HeaderText = "Закзчик";
            dataGridViewPanel_Application.Columns[2].HeaderText = "Менеджер";
            dataGridViewPanel_Application.Columns[3].HeaderText = "Подразделение";
            dataGridViewPanel_Application.Columns[4].HeaderText = "Автомобиль";
            dataGridViewPanel_Application.Columns[5].HeaderText = "Дата";
            dataGridViewPanel_Application.Columns[6].HeaderText = "Пункт Отправления";
            dataGridViewPanel_Application.Columns[7].HeaderText = "Пункт назначения";
            dataGridViewPanel_Application.Columns[8].HeaderText = "Расстояние";
        }
        private void dataGridViewOutBeton_Rename()
        {
            dataGridViewOutBeton.Columns[0].HeaderText = "ID";
            dataGridViewOutBeton.Columns[1].HeaderText = "Подразделение";
            dataGridViewOutBeton.Columns[2].HeaderText = "Продукция";
            dataGridViewOutBeton.Columns[3].HeaderText = "Дата выпуска";
            dataGridViewOutBeton.Columns[4].HeaderText = "Количество";


        }
        private void dataGridViewAutos_Rename()
        {
            dataGridViewAutos.Columns[0].HeaderText = "ID";
            dataGridViewAutos.Columns[1].HeaderText = "Наименование";
            dataGridViewAutos.Columns[2].HeaderText = "Автомобиль";
            dataGridViewAutos.Columns[3].HeaderText = "Регистрационный номер";
            dataGridViewAutos.Columns[4].HeaderText = "Ответственное лицо";
            dataGridViewAutos.Columns[5].HeaderText = "Пробег";
            dataGridViewAutos.Columns[6].HeaderText = "Подробнее";

        }
        private void dataGridViewPanel_AutoPark_Rename()
        {
            dataGridViewPanel_AutoPark.Columns[0].HeaderText = "ID";
            dataGridViewPanel_AutoPark.Columns[1].HeaderText = "Наименование";
            dataGridViewPanel_AutoPark.Columns[2].HeaderText = "ИНН";
            dataGridViewPanel_AutoPark.Columns[3].HeaderText = "КПП";
            dataGridViewPanel_AutoPark.Columns[4].HeaderText = "БИК";
            dataGridViewPanel_AutoPark.Columns[5].HeaderText = "КС";
            dataGridViewPanel_AutoPark.Columns[6].HeaderText = "РС";
            dataGridViewPanel_AutoPark.Columns[7].HeaderText = "Заведующий";
            dataGridViewPanel_AutoPark.Columns[8].HeaderText = "Гл Бухгалтер";
            dataGridViewPanel_AutoPark.Columns[9].HeaderText = "Адрес";

        }
        private void dataGridViewCustomers_Rename()
        {
            dataGridViewCustomers.Columns[0].HeaderText = "ID";
            dataGridViewCustomers.Columns[1].HeaderText = "Наименование";
            dataGridViewCustomers.Columns[2].HeaderText = "ИНН";
            dataGridViewCustomers.Columns[3].HeaderText = "КПП";
            dataGridViewCustomers.Columns[4].HeaderText = "БИК";
            dataGridViewCustomers.Columns[5].HeaderText = "КС";
            dataGridViewCustomers.Columns[6].HeaderText = "РС";
            dataGridViewCustomers.Columns[7].HeaderText = "Заведующий";
            dataGridViewCustomers.Columns[8].HeaderText = "Гл Бухгалтер";
            dataGridViewCustomers.Columns[9].HeaderText = "Адрес";

        }

        //Добавялет завпись в заявках
        private void buttonPanel_Application_ADD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase DB = new DataBase();

                MySqlCommand command = new MySqlCommand("INSERT INTO application (Application, Customer, Manager,Subdivision,Auto,DateTime,PointOfDeparture,Destination,Distance) VALUES(@Application, @Customer, @Manager,@Subdivision,@Auto,@DateTime,@PointOfDeparture,@Destination,@Distance)", DB.GetConnection());
                try
                {
                    command.Parameters.AddWithValue("Application", Convert.ToInt32(textBoxPanel_Application_NumberApp.Text));
                    command.Parameters.AddWithValue("Customer", comboBoxPanel_Application_Customers.Text);
                    command.Parameters.AddWithValue("Manager", comboBoxPanel_Application_Manager.Text);
                    command.Parameters.AddWithValue("Subdivision", comboBoxPanel_Application_Subdivision.Text);
                    command.Parameters.AddWithValue("Auto", comboBoxPanel_Application_Auto.Text);
                    command.Parameters.AddWithValue("DateTime", dateTimePickerPanel_Application.Value.ToString());
                    command.Parameters.AddWithValue("PointOfDeparture", comboBoxPanel_Application_PointOfDeapture.Text);
                    command.Parameters.AddWithValue("Destination", textBoxPanel_Application_Destination.Text);
                    command.Parameters.AddWithValue("Distance", textBoxPanel_Application_Distance.Text);
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();


                }

                catch
                {
                    MessageBox.Show("Проверьте выделена ли строки или выбран номер заявки");

                }
                try
                {
                    command.CommandText = "INSERT INTO content (ID,Application,Products,Quantity) VALUES(@ID,@Application,@Products,@Quantity)";
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(textBoxPanel_Application_NumberApp.Text));
                    command.Parameters.AddWithValue("@Application", textBoxPanel_Application_NumberApp.Text);
                    command.Parameters.AddWithValue("@Products", comboBox_Panel_App_Products1.Text);
                    command.Parameters.AddWithValue("@Quantity", textBox_Panel_App_Products1.Text);
                    DB.OpenConnection();
                    command.ExecuteNonQuery();

                    DB.ClosedConnection();
                    command.Parameters.Clear();


                }
                catch
                {
                }
                //тест
                try
                {
                    command.CommandText = "INSERT INTO content (ID,Application,Products,Quantity) VALUES(@ID,@Application,@Products,@Quantity)";
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(textBoxPanel_Application_NumberApp.Text));
                    command.Parameters.AddWithValue("@Application", textBoxPanel_Application_NumberApp.Text);
                    command.Parameters.AddWithValue("@Products", comboBox_Panel_App_Products2.Text);
                    command.Parameters.AddWithValue("@Quantity", textBox_Panel_App_Products2.Text);
                    DB.OpenConnection();
                    command.ExecuteNonQuery();

                    DB.ClosedConnection();
                    command.Parameters.Clear();

                }
                catch
                {

                }
                try
                {
                    command.CommandText = "INSERT INTO content (ID,Application,Products,Quantity) VALUES(@ID,@Application,@Products,@Quantity)";
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(textBoxPanel_Application_NumberApp.Text));
                    command.Parameters.AddWithValue("@Application", textBoxPanel_Application_NumberApp.Text);
                    command.Parameters.AddWithValue("@Products", comboBox_Panel_App_Products3.Text);
                    command.Parameters.AddWithValue("@Quantity", textBox_Panel_App_Products3.Text);
                    DB.OpenConnection();
                    command.ExecuteNonQuery();

                    DB.ClosedConnection();
                    command.Parameters.Clear();
                }
                catch
                {

                }
                command.CommandText = "SELECT * FROM application";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                dataGridViewPanel_Application.DataSource = Table;
                dataGridViewPanel_Application_Rename();
            }
        }

        private void LoadComboBox()
        {
            DataBase DB = new DataBase();
            using (MySqlCommand command = new MySqlCommand("SELECT customers.Name FROM Customers", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxPanel_Application_Customers.DisplayMember = "Name";
                comboBoxPanel_Application_Customers.DataSource = Table;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT Manager.FIOManager FROM Manager", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxPanel_Application_Manager.DisplayMember = "FIOManager";
                comboBoxPanel_Application_Manager.DataSource = Table;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT subdivision.Subdivision FROM subdivision", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxPanel_Application_Subdivision.DisplayMember = "Subdivision";
                comboBoxPanel_Application_Subdivision.DataSource = Table;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT autos.auto FROM autos", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxPanel_Application_Auto.DisplayMember = "auto";
                comboBoxPanel_Application_Auto.DataSource = Table;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT requisites.adress FROM requisites", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxPanel_Application_PointOfDeapture.DisplayMember = "adress";
                comboBoxPanel_Application_PointOfDeapture.DataSource = Table;
            }
            //Комбобоксы Продукции
            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBox_Panel_App_Products1.DisplayMember = "Name";
                comboBox_Panel_App_Products1.DataSource = Table;
            }
            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBox_Panel_App_Products2.DisplayMember = "Name";
                comboBox_Panel_App_Products2.DataSource = Table;
            }
            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBox_Panel_App_Products3.DisplayMember = "Name";
                comboBox_Panel_App_Products3.DataSource = Table;
            }

        }
        private void LoadComboBoxOutBeton()
        {
            DataBase DB = new DataBase();
            using (MySqlCommand command = new MySqlCommand("SELECT subdivision.Subdivision FROM subdivision WHERE subdivision.ID = 1", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton1.DisplayMember = "Subdivision";
                comboBoxOutBeton1.DataSource = Table;
                comboBoxOutBeton1.SelectedIndex = -1;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT subdivision.Subdivision FROM subdivision WHERE subdivision.ID = 2", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton2.DisplayMember = "Subdivision";
                comboBoxOutBeton2.DataSource = Table;
                comboBoxOutBeton2.SelectedIndex = -1;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT subdivision.Subdivision FROM subdivision WHERE subdivision.ID = 3", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton3.DisplayMember = "Subdivision";
                comboBoxOutBeton3.DataSource = Table;
                comboBoxOutBeton3.SelectedIndex = -1;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton_Products1.DisplayMember = "Name";
                comboBoxOutBeton_Products1.DataSource = Table;
                comboBoxOutBeton_Products1.SelectedIndex = -1;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton_Products2.DisplayMember = "Name";
                comboBoxOutBeton_Products2.DataSource = Table;
                comboBoxOutBeton_Products2.SelectedIndex = -1;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT products.Name FROM products", DB.GetConnection()))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                comboBoxOutBeton_Products3.DisplayMember = "Name";
                comboBoxOutBeton_Products3.DataSource = Table;
                comboBoxOutBeton_Products3.SelectedIndex = -1;
            }


        }
        //Вернуться
        private void buttonPanel_ApplicationCHANGE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    MySqlCommand command = new MySqlCommand("UPDATE application SET Customer = @Customer, Manager = @Manager,Subdivision = @Subdivision,Auto = @Auto,DateTime = @DateTime,PointOfDeparture = @PointOfDeparture,Destination = @Destination,Distance=@Distance WHERE application.Application=" + dataGridViewPanel_Application[0, dataGridViewPanel_Application.CurrentRow.Index].Value.ToString(), DB.GetConnection());

                    command.Parameters.AddWithValue("Customer", comboBoxPanel_Application_Customers.Text);
                    command.Parameters.AddWithValue("Manager", comboBoxPanel_Application_Manager.Text);
                    command.Parameters.AddWithValue("Subdivision", comboBoxPanel_Application_Subdivision.Text);
                    command.Parameters.AddWithValue("Auto", comboBoxPanel_Application_Auto.Text);
                    command.Parameters.AddWithValue("DateTime", dateTimePickerPanel_Application.Value.ToString());
                    command.Parameters.AddWithValue("PointOfDeparture", comboBoxPanel_Application_PointOfDeapture.Text);
                    command.Parameters.AddWithValue("Destination", textBoxPanel_Application_Destination.Text);
                    command.Parameters.AddWithValue("Distance", textBoxPanel_Application_Distance.Text);

                    DB.OpenConnection();
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                    command.CommandText = "SELECT * FROM application";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    DataTable Table = new DataTable();
                    adapter.Fill(Table);
                    dataGridViewPanel_Application.DataSource = Table;
                    dataGridViewPanel_Application_Rename();
                }
                catch
                {
                    MessageBox.Show("Проверьте пустая таблица и выделен ли элемент");

                }
            }
        }

        private void dateTimePickerPanel_Application_MouseLeave(object sender, EventArgs e)
        {
            textBoxPanel_Application_DateTime.Text = dateTimePickerPanel_Application.Value.ToString();
        }

        private void buttonPanel_Application_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    MySqlCommand command = new MySqlCommand("DELETE FROM application WHERE application.Application =" + dataGridViewPanel_Application[0, dataGridViewPanel_Application.CurrentRow.Index].Value.ToString(), DB.GetConnection());
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();

                    command.CommandText = "DELETE FROM content WHERE content.Application =" + dataGridViewPanel_Application[0, dataGridViewPanel_Application.CurrentRow.Index].Value.ToString();

                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();

                    command.CommandText = "SELECT * FROM application";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    DataTable Table = new DataTable();
                    adapter.Fill(Table);
                    dataGridViewPanel_Application.DataSource = Table;
                    dataGridViewPanel_Application_Rename();
                }
                catch
                {
                    MessageBox.Show("Таблица Пустая или не выделен нужный элемент");
                }
            }

        }

        private void Button_OutBeton_Click(object sender, EventArgs e)
        {
            LoadComboBoxOutBeton();
            hide_panels();

            panel_OutBeton.Visible = true;
            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM releasee", DB.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            dataGridViewOutBeton.DataSource = Table;
            dataGridViewOutBeton_Rename();



        }

        private void button_Requsites_Click(object sender, EventArgs e)
        {
        }

        private void buttonOutBetonChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    //1
                    MySqlCommand command = new MySqlCommand("UPDATE releasee SET ID = 1,Subdivision = @Subdivision, Products = @Products, DateRelase = @DateRelase,Quantity = @Quantity WHERE releasee.ID = 1", DB.GetConnection());
                    command.Parameters.AddWithValue("Subdivision", comboBoxOutBeton1.Text);
                    command.Parameters.AddWithValue("Products", comboBoxOutBeton_Products1.Text);
                    command.Parameters.AddWithValue("DateRelase", textBoxOutBetonDate1.Text);
                    command.Parameters.AddWithValue("Quantity", textBoxOutBetonQuantity1.Text);

                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();
                    //2
                    command.CommandText = "UPDATE releasee SET ID = 2,Subdivision = @Subdivision, Products = @Products, DateRelase = @DateRelase,Quantity = @Quantity WHERE releasee.ID = 2";
                    command.Parameters.AddWithValue("Subdivision", comboBoxOutBeton2.Text);
                    command.Parameters.AddWithValue("Products", comboBoxOutBeton_Products2.Text);
                    command.Parameters.AddWithValue("DateRelase", textBoxOutBetonDate2.Text);
                    command.Parameters.AddWithValue("Quantity", textBoxOutBetonQuantity2.Text);

                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();
                    //3
                    command.CommandText = "UPDATE releasee SET ID = 3,Subdivision = @Subdivision, Products = @Products, DateRelase = @DateRelase,Quantity = @Quantity WHERE releasee.ID = 3";
                    command.Parameters.AddWithValue("Subdivision", comboBoxOutBeton3.Text);
                    command.Parameters.AddWithValue("Products", comboBoxOutBeton_Products3.Text);
                    command.Parameters.AddWithValue("DateRelase", textBoxOutBetonDate3.Text);
                    command.Parameters.AddWithValue("Quantity", textBoxOutBetonQuantity3.Text);

                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();



                    command.CommandText = "SELECT * FROM releasee";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    DataTable Table = new DataTable();
                    adapter.Fill(Table);
                    dataGridViewOutBeton.DataSource = Table;
                    dataGridViewOutBeton_Rename();

                }
                catch
                {
                    MessageBox.Show("Таблица Пустая или не выделен нужный элемент");
                }
            }

        }

        private void buttonCustomers_LeftPanel_Click(object sender, EventArgs e)
        {
            hide_panels();

            panelCustomers.Visible = true;

            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM customers", DB.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
            DataTable Table = new DataTable();
            adapter.Fill(Table);

            dataGridViewCustomers.DataSource = Table;
            dataGridViewCustomers_Rename();
        }

        private void dataGridViewPanel_AutoPark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBase DB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM autos INNER JOIN autopark ON autopark.Name_Parking = autos.AutoParking", DB.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            dataGridViewAutos.DataSource = Table;
            dataGridViewAutos_Rename();

            
        }

        private void buttonCustomersADD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    MySqlCommand command = new MySqlCommand("INSERT INTO customers (ID,Name,INN,KPP,Bank,BIK,KS,RS,Supervisor,ChiefAccountant,address) VALUES(@ID,@Name,@INN,@KPP,@Bank,@BIK,@KS,@RS,@Supervisor,@ChiefAccountant,@address)", DB.GetConnection());
                    command.Parameters.AddWithValue("ID", Convert.ToInt32(textBoxCustomersNumber.Text));
                    command.Parameters.AddWithValue("Name", textBoxCustomersName.Text);
                    command.Parameters.AddWithValue("INN", textBoxCustomersINN.Text);
                    command.Parameters.AddWithValue("KPP", textBoxCustomersKPP.Text);
                    command.Parameters.AddWithValue("Bank", textBoxCustomersBank.Text);
                    command.Parameters.AddWithValue("BIK", textBoxCustomersBIK.Text);
                    command.Parameters.AddWithValue("KS", textBoxCustomersKS.Text);
                    command.Parameters.AddWithValue("RS", textBoxCustomersRS.Text);
                    command.Parameters.AddWithValue("Supervisor", textBoxCustomersSupervisor.Text);
                    command.Parameters.AddWithValue("ChiefAccountant", textBoxCustomersMainAccountant.Text);
                    command.Parameters.AddWithValue("address", textBoxCustomersAdress.Text);

                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();

                    command.Parameters.Clear();

                    command.CommandText = "Select * FROM customers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    DataTable Table = new DataTable();
                    adapter.Fill(Table);
                    dataGridViewCustomers.DataSource = Table;

                }
                catch
                {
                    MessageBox.Show("Введите или измените номер записи");
                }
            }
        }

        private void buttonCustomersDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataBase DB = new DataBase();
                    MySqlCommand command = new MySqlCommand("DELETE FROM customers WHERE customers.ID =" + dataGridViewCustomers[0, dataGridViewCustomers.CurrentRow.Index].Value.ToString(), DB.GetConnection());
                    DB.OpenConnection();
                    command.ExecuteNonQuery();
                    DB.ClosedConnection();
                    command.Parameters.Clear();

                    command.CommandText = "SELECT * FROM customers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                    DataTable Table = new DataTable();
                    adapter.Fill(Table);
                    dataGridViewCustomers.DataSource = Table;
                }
                catch
                {
                    MessageBox.Show("Таблица Пустая или не выделен нужный элемент");
                }
            }

        }

        private void buttonCustomersChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase DB = new DataBase();
                MySqlCommand command = new MySqlCommand("UPDATE customers SET customers.Name = @Name, INN = @INN,KPP = @KPP,Bank = @Bank,BIK = @BIK,KS = @KS,RS = @RS,Supervisor = @Supervisor, ChiefAccountant = @ChiefAccountant,Address = @Address WHERE customers.ID=" + dataGridViewCustomers[0, dataGridViewCustomers.CurrentRow.Index].Value.ToString(), DB.GetConnection());

                command.Parameters.AddWithValue("Name", textBoxCustomersName.Text);
                command.Parameters.AddWithValue("INN", textBoxCustomersINN.Text);
                command.Parameters.AddWithValue("KPP", textBoxCustomersKPP.Text);
                command.Parameters.AddWithValue("Bank", textBoxCustomersBank.Text);
                command.Parameters.AddWithValue("BIK", textBoxCustomersBIK.Text);
                command.Parameters.AddWithValue("KS", textBoxCustomersKS.Text);
                command.Parameters.AddWithValue("RS", textBoxCustomersRS.Text);
                command.Parameters.AddWithValue("Supervisor", textBoxCustomersSupervisor.Text);
                command.Parameters.AddWithValue("ChiefAccountant", textBoxCustomersMainAccountant.Text);
                command.Parameters.AddWithValue("Address", textBoxCustomersAdress.Text);

                DB.OpenConnection();
                command.ExecuteNonQuery();
                DB.ClosedConnection();

                command.Parameters.Clear();

                command.CommandText = "SELECT * FROM customers";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command.CommandText, DB.GetConnection());
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                dataGridViewCustomers.DataSource = Table;
                dataGridViewCustomers_Rename();
            }
         


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonOutProductsReview_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ReportOutBeton ReportOutBeton = new ReportOutBeton();
                ReportOutBeton.Show();
            }
        }

        private void buttonReviewAutoPark_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ReportAutoMilage ReportAutoMilage = new ReportAutoMilage();
                ReportAutoMilage.Show();
            }
        }

        private void buttonPayReview_Click(object sender, EventArgs e)
        {

        }

        private void buttonReportFAQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClassStatic.Index = dataGridViewPanel_Application[0, dataGridViewPanel_Application.CurrentRow.Index].Value.ToString();
                ReportFAQ ReportFAQ = new ReportFAQ();
                ReportFAQ.Show();
            }
        }

        private void buttonMainPanel_Click(object sender, EventArgs e)
        {
            hide_panels();
            panelMain.Visible = true;

        }

        private void buttonLoging_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase DB = new DataBase();
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                MySqlCommand command = new MySqlCommand("SELECT * FROM manager WHERE manager.Login = @login AND manager.Password = @password", DB.GetConnection());
                command.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("password", MySqlDbType.VarChar).Value = password;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                if (Table.Rows.Count > 0)
                {
                    hide_panels();
                    panelMain.Visible = true;
                    MessageBox.Show("Добро пожаловать" + " " + Table.Rows[0].Field<string>(1).ToString());
                    labelNameUser.Text = Table.Rows[0].Field<string>(1);

                }
                else
                {
                    MessageBox.Show("Попробуйте ввести заново Проверьте Логин или Пароль");
                }
            }


        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это выбрать", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormRegistration FormRegistration = new FormRegistration();
                FormRegistration.Show();
            }
        }

        }

    }

