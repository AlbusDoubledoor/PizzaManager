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
using System.Text.RegularExpressions;

namespace Pizza_Manager
{
    public partial class HeadmanagerForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PizzaManagerConnectionString"].ConnectionString;
        public HeadmanagerForm()
        {
            InitializeComponent();
        }

        private void HeadmanagerForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Name,LegalEntity,Code FROM Office", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OfficeListBox.Items.Add(reader.GetString(0) + " (" + reader.GetString(1)+") [" + reader.GetString(2) +"]");
                }
                reader.Close();               
            //
            // Выгружаем базу онлайн-клиентов
            // 
                command = new SqlCommand("SELECT * FROM OnlineClientsView", connection);
                reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                OnlineClientsView.DataSource = dataTable;
                foreach (DataGridViewColumn column in OnlineClientsView.Columns)
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

        private void ChooseOfficeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Берём код предприятия
                if (OfficeListBox.SelectedItem == null)
                    return;
                string officecode = OfficeListBox.SelectedItem.ToString();
                Regex codeparse = new Regex(@"(\[\w*\])");
                officecode = codeparse.Match(officecode).Groups[1].Value.Replace("[","").Replace("]","");
                //
                // Выгружаем информацию о предприятии
                //
                OfficeInformationView.DataSource = null;
                SqlCommand command = new SqlCommand("SELECT * FROM OfficeInformation WHERE [Код предприятия] = '"+
                    officecode+"'", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                OfficeInformationView.DataSource = dataTable;
                foreach (DataGridViewColumn column in OfficeInformationView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                //
                // Выгружаем информацию по продуктам
                // 
                ProductsOfficeView.DataSource = null;
                command = new SqlCommand("SELECT * FROM dbo.ProductOfficeStorage('"+officecode+"')", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                ProductsOfficeView.DataSource = dataTable;
                foreach (DataGridViewColumn column in ProductsOfficeView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                //
                // Выгружаем список сотрудников
                //
                StaffOfficeView.DataSource = null;
                command = new SqlCommand("SELECT [ИД Сотрудника],[Имя]," +
                    "[Дата рождения],[Принят на работу]," +
                    "[Должность],[Страховка],[Уволен] FROM StaffOfficeView WHERE [Код предприятия] = '" +
                    officecode + "'", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                StaffOfficeView.DataSource = dataTable;
                foreach (DataGridViewColumn column in StaffOfficeView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                //
                // Выгружаем заказы
                //
                OrdersListBox.Items.Clear();
                OrderInfoView.DataSource = null;
                OrderFullListView.DataSource = null;
                command = new SqlCommand("SELECT OrderID FROM Orders WHERE OfficeCode = '"+
                    officecode+"'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrdersListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                //
                // Выгружаем расходы
                //
                LossTicketsListBox.Items.Clear();
                LossTicketInfoView.DataSource = null;
                LossFullListView.DataSource = null;
                command = new SqlCommand("SELECT TicketID FROM LossTickets WHERE OfficeCode = '" +
                    officecode + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LossTicketsListBox.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                //
                // Чистим Summary за день и месяц
                //
                SummaryDayView.DataSource = null;
                SummaryMonthView.DataSource = null;
                DamageStatDayView.DataSource = null;
                DamageStatMonthView.DataSource = null;
                ProductSoldDayView.DataSource = null;
                ProductsSoldMonthView.DataSource = null;
                ActionsView.DataSource = null;
                MonthListBox.SelectedItem = TranslateMonth(DateTime.Now.Month.ToString());
                YearListBox.SelectedItem = DateTime.Now.Year.ToString();
                //
                connection.Close();
               
            }
        }

        private void ChooseOrderButton_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.Items.Count == 0 || OrdersListBox.SelectedItem == null)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM OrderInfo WHERE [Ид заказа] = " +
                    OrdersListBox.SelectedItem, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                OrderInfoView.DataSource = dataTable;
                foreach (DataGridViewColumn column in OrderInfoView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.OrderFullList(" + OrdersListBox.SelectedItem + ")", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                OrderFullListView.DataSource = dataTable;
                foreach (DataGridViewColumn column in OrderFullListView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                connection.Close();
            }
        }

        private void ChooseLossTicketButton_Click(object sender, EventArgs e)
        {
                if (LossTicketsListBox.Items.Count == 0 || LossTicketsListBox.SelectedItem == null)
                    return;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM LossInfo WHERE [Ид расхода] = " +
                        LossTicketsListBox.SelectedItem, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    LossTicketInfoView.DataSource = dataTable;
                    foreach (DataGridViewColumn column in LossTicketInfoView.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    reader.Close();
                    command = new SqlCommand("SELECT * FROM dbo.LossFullList(" + LossTicketsListBox.SelectedItem + ")", connection);
                    reader = command.ExecuteReader();
                    dataTable = new DataTable();
                    dataTable.Load(reader);
                    LossFullListView.DataSource = dataTable;
                    foreach (DataGridViewColumn column in LossFullListView.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    connection.Close();
                }
        }

        private void ChooseDayButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Берём код предприятия
                if (OfficeListBox.SelectedItem == null)
                    return;
                string officecode = OfficeListBox.SelectedItem.ToString();
                Regex codeparse = new Regex(@"(\[\w*\])");
                officecode = codeparse.Match(officecode).Groups[1].Value.Replace("[", "").Replace("]", "");
                //
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.SummaryViewDay('" +
                        officecode+"','"+ DayCalendar.SelectionRange.Start.ToShortDateString()+"')", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                SummaryDayView.DataSource = dataTable;
                foreach (DataGridViewColumn column in SummaryDayView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.DamageStatDay('" +
                        officecode + "','" + DayCalendar.SelectionRange.Start.ToShortDateString() + "')", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                DamageStatDayView.DataSource = dataTable;
                foreach (DataGridViewColumn column in DamageStatDayView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.ProductSoldCategoryDay('" +
                       officecode + "','" + DayCalendar.SelectionRange.Start.ToShortDateString() + "')", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                ProductSoldDayView.DataSource = dataTable;
                foreach (DataGridViewColumn column in ProductSoldDayView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }

        private int TransformMonth(string month)
        {
            if (month == "Январь") return 1;
            if (month == "Февраль") return 2;
            if (month == "Март") return 3;
            if (month == "Апрель") return 4;
            if (month == "Май") return 5;
            if (month == "Июнь") return 6;
            if (month == "Июль") return 7;
            if (month == "Август") return 8;
            if (month == "Сентябрь") return 9;
            if (month == "Октябрь") return 10;
            if (month == "Ноябрь") return 11;
            return 12;
        }

        private string TranslateMonth(string month)
        {
            if (month == "January") return "Январь";
            if (month == "February") return "Февраль";
            if (month == "March") return "Март";
            if (month == "April") return "Апрель";
            if (month == "May") return "Май";
            if (month == "June") return "Июнь";
            if (month == "July") return "Июль";
            if (month == "August") return "Август";
            if (month == "Semptember") return "Сентябрь";
            if (month == "October") return "Октябрь";
            if (month == "November") return "Ноябрь";
            return "Декабрь";
        }

        private void ChooseMonthButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Берём код предприятия
                if (OfficeListBox.SelectedItem == null)
                    return;
                string officecode = OfficeListBox.SelectedItem.ToString();
                Regex codeparse = new Regex(@"(\[\w*\])");
                officecode = codeparse.Match(officecode).Groups[1].Value.Replace("[", "").Replace("]", "");
                //
                connection.Open();
                if (MonthListBox.SelectedItem == null) return;
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.SummaryViewMonth('" +
                        officecode + "'," + TransformMonth(MonthListBox.SelectedItem.ToString()) + ","+YearListBox.SelectedItem+")", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                SummaryMonthView.DataSource = dataTable;
                foreach (DataGridViewColumn column in SummaryMonthView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.DamageStatMonth('" +
                        officecode + "'," + TransformMonth(MonthListBox.SelectedItem.ToString()) + ","+YearListBox.SelectedItem+")", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                DamageStatMonthView.DataSource = dataTable;
                foreach (DataGridViewColumn column in DamageStatMonthView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.ProductSoldCategoryMonth('" +
                       officecode + "'," + TransformMonth(MonthListBox.SelectedItem.ToString()) + ","+ YearListBox.SelectedItem + ")", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                ProductsSoldMonthView.DataSource = dataTable;
                foreach (DataGridViewColumn column in ProductsSoldMonthView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                command = new SqlCommand("SELECT * FROM dbo.ActionNumberMonth('" +
                       officecode + "'," + TransformMonth(MonthListBox.SelectedItem.ToString()) + "," + YearListBox.SelectedItem + ")", connection);
                reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                ActionsView.DataSource = dataTable;
                foreach (DataGridViewColumn column in ActionsView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //
            // Выгружаем базу онлайн-клиентов
            // 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM OnlineClientsView",connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                OnlineClientsView.DataSource = dataTable;
                foreach (DataGridViewColumn column in OnlineClientsView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                reader.Close();
                connection.Close();
            }
        }
                    
    }
}
