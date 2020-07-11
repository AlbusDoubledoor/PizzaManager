using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Pizza_Manager
{
    public partial class ManagerForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PizzaManagerConnectionString"].ConnectionString;
        public string officeCodePropagation;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.Text += " " + officeCodePropagation;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT OrderID FROM Orders WHERE " +
                    "CONVERT(date,OrderDatetime) = CONVERT(date,GETDATE()) AND OfficeCode='" + officeCodePropagation + "'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrderListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                command = new SqlCommand("SELECT TicketID FROM LossTickets WHERE " +
                    "CONVERT(date,TicketDatetime) = CONVERT(date,GETDATE()) AND OfficeCode='" + officeCodePropagation + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LossTicketListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                command = new SqlCommand("SELECT EmployeeID FROM Staff WHERE " +
                    "OfficeCode='" + officeCodePropagation + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OfficerListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                command = new SqlCommand("SELECT Name FROM Products WHERE Name IN " +
                    "(SELECT Product FROM ProductStorage WHERE Number > 0 AND OfficeCode ='" + officeCodePropagation + "')", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductListBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command = new SqlCommand("SELECT Name FROM Products", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductBuyListBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM ProductOfficeStorage('" + officeCodePropagation + "')", connection);
                reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ProductOfficeStorage.DataSource = dataTable;
                foreach (DataGridViewColumn column in ProductOfficeStorage.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT Name AS 'Наименование'," +
                    "Price AS 'Цена'," +
                    "Category AS 'Категория'," +
                    "Description AS 'Описание' FROM Products", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                AvailableProducts.DataSource = dataTable;
                foreach (DataGridViewColumn column in AvailableProducts.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void ChooseOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderListBox.SelectedItem == null) return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM OrderFullList(" + OrderListBox.SelectedItem + ")", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                SaleListView.DataSource = dataTable;
                foreach (DataGridViewColumn column in SaleListView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM OrderInfo WHERE [Ид заказа] = " +
                   OrderListBox.SelectedItem, connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                OrderInfo.DataSource = dataTable;
                foreach (DataGridViewColumn column in OrderInfo.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }

        private void RefreshOrderList_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                OrderListBox.Items.Clear();
                SqlCommand command = new SqlCommand("SELECT OrderID FROM Orders WHERE " +
                    "CONVERT(date,OrderDatetime) = CONVERT(date,GETDATE()) AND OfficeCode='" + officeCodePropagation + "'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrderListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
        }

        private void RefreshProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                ProductListBox.Items.Clear();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Name FROM Products WHERE Name IN " +
                        "(SELECT Product FROM ProductStorage WHERE Number > 0 AND OfficeCode ='" + officeCodePropagation + "')", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductListBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                connection.Close();
            }
        }
        private string TransformOrderPlace(string orderplace)
        {
            if (orderplace == "В ресторане")
                return "Office";
            return "Remote";
        }
 
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderPlaceListbox.SelectedItem == null || OfficerListBox.SelectedItem == null) return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddOrder", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@officeCode", officeCodePropagation);
                command.Parameters.AddWithValue("@orderPlace", TransformOrderPlace(OrderPlaceListbox.SelectedItem.ToString()));
                command.Parameters.AddWithValue("@processOfficer", OfficerListBox.SelectedItem);
                command.Parameters.AddWithValue("@onlineClient", onlineClientTextbox.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void AddSaleList_Click(object sender, EventArgs e)
        {
            if (ProductListBox.SelectedItem == null || OrderListBox.SelectedItem == null) return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddSaleToOrder", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@orderId", OrderListBox.SelectedItem);
                command.Parameters.AddWithValue("@product", ProductListBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@action", ActionTextBox.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void UpdateDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderListBox.SelectedItem == null || DiscountTextBox.Text == null) return;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateOrderDiscount", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@orderId", OrderListBox.SelectedItem);
                    command.Parameters.AddWithValue("@discount", Double.Parse(DiscountTextBox.Text));
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            { MessageBox.Show("Неверный формат для поля \"Скидка\"", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void ChooseLossTicket_Click(object sender, EventArgs e)
        {
            if (LossTicketListBox.SelectedItem == null) return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM LossFullList(" + LossTicketListBox.SelectedItem + ")", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                LossListView.DataSource = dataTable;
                foreach (DataGridViewColumn column in LossListView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM LossInfo WHERE [Ид расхода] = " +
                   LossTicketListBox.SelectedItem, connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                LossInfo.DataSource = dataTable;
                foreach (DataGridViewColumn column in LossInfo.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }

        private void AddLossTicket_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddLossTicket", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@officeCode", officeCodePropagation);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void RefreshLossTickets_Click(object sender, EventArgs e)
        {
            LossTicketListBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TicketID FROM LossTickets WHERE " +
                    "CONVERT(date,TicketDatetime) = CONVERT(date,GETDATE()) AND OfficeCode='" + officeCodePropagation + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LossTicketListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                connection.Close();
               }
            }

        private void AddLossToTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LossTicketListBox.SelectedItem == null ||
                  losstypeListBox.SelectedItem == null || 
                  CostTextbox.Text == null || DescriptionTextbox.Text == null) return;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddLossToTicket", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ticketId", LossTicketListBox.SelectedItem);
                    command.Parameters.AddWithValue("@lossType", losstypeListBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@cost", Double.Parse(CostTextbox.Text));
                    command.Parameters.AddWithValue("@description", DescriptionTextbox.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            { MessageBox.Show("Неверный формат для поля \"Стоимость\"", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void RefreshProductsButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM ProductOfficeStorage('" + officeCodePropagation + "')", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ProductOfficeStorage.DataSource = dataTable;
                foreach (DataGridViewColumn column in ProductOfficeStorage.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT Name AS 'Наименование'," +
                    "Price AS 'Цена'," +
                    "Category AS 'Категория'," +
                    "Description AS 'Описание' FROM Products", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                AvailableProducts.DataSource = dataTable;
                foreach (DataGridViewColumn column in AvailableProducts.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                ProductBuyListBox.Items.Clear();
                command = new SqlCommand("SELECT Name FROM Products", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductBuyListBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                connection.Close();
            }
        }

        private void BuyProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductBuyListBox.SelectedItem == null ||
                      NumberProductsTextbox.Text == null) return;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateProductNumber", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", ProductBuyListBox.SelectedItem);
                    command.Parameters.AddWithValue("@number", Int32.Parse(NumberProductsTextbox.Text));
                    command.Parameters.AddWithValue("@officeCode", officeCodePropagation);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            { MessageBox.Show("Неверный формат для поля \"Количество\"", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
