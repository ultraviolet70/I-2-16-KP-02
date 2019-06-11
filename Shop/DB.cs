using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class DB
    {
        public event Action<DataTable> dtServers;
        public static SqlConnection connection;

        public static string ID_Client;

        public void getServers()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            dtServers(instance.GetDataSources());
        }

        public static void startConnection(String connectionString)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Client_Insert(string Surname_client, string Name_client, string Patronymic_client,
        string Number_client, string Email_client)
        {
            string spConfiguration = "Client_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Surname_client", Surname_client);
            cmd.Parameters.AddWithValue("@Name_client", Name_client);
            cmd.Parameters.AddWithValue("@Patronymic_client", Patronymic_client);
            cmd.Parameters.AddWithValue("@Number_client", Number_client);
            cmd.Parameters.AddWithValue("@Email_client", Email_client);
            cmd.Parameters.Clear();
        }

        public void Client_Update(Int32 ID_Client, string Surname_client, string Name_client, string Patronymic_client,
        string Number_client, string Email_client)
        {
            string spConfiguration = "Client_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
            cmd.Parameters.AddWithValue("@Surname_client", Surname_client);
            cmd.Parameters.AddWithValue("@Name_client", Name_client);
            cmd.Parameters.AddWithValue("@Patronymic_client", Patronymic_client);
            cmd.Parameters.AddWithValue("@Number_client", Number_client);
            cmd.Parameters.AddWithValue("@Email_client", Email_client);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Client_Delete(Int32 ID_Client)
        {
            string spConfiguration = "Client_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Client_Logical_Delete(Int32 ID_Client)
        {
            string spConfiguration = "Client_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Type_Product_Insert(string Name_product)
        {
            string spConfiguration = "Type_Product_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Name_product", Name_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Type_Product_Update(Int32 ID_Type_Product, string Name_product)
        {
            string spConfiguration = "Type_Product_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Type_Product", ID_Type_Product);
            cmd.Parameters.AddWithValue("@Name_product", Name_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Type_Product_Delete(Int32 ID_Type_Product)
        {
            string spConfiguration = "Type_Product_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Type_Product", ID_Type_Product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Type_Product_Logical_Delete(Int32 ID_Type_Product)
        {
            string spConfiguration = "Type_Product_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Type_Product", ID_Type_Product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Position_Insert(string Position_product)
        {
            string spConfiguration = "Position_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Position_product", Position_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Position_Update(Int32 ID_Position, string Position_product)
        {
            string spConfiguration = "Position_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Position", ID_Position);
            cmd.Parameters.AddWithValue("@Position_product", Position_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Position_Delete(Int32 ID_Position)
        {
            string spConfiguration = "Position_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Position", ID_Position);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Position_Logical_Delete(Int32 ID_Position)
        {
            string spConfiguration = "Position_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Position", ID_Position);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Supplier_Insert(string Name_supplier, string Contact_number, string Email_supplier)
        {
            string spConfiguration = "Supplier_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Name_supplier", Name_supplier);
            cmd.Parameters.AddWithValue("@Contact_number", Contact_number);
            cmd.Parameters.AddWithValue("@Email_supplier", Email_supplier);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Supplier_Update(Int32 ID_Supplier, string Name_supplier, string Contact_number, string Email_supplier)
        {
            string spConfiguration = "Supplier_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Supplier", ID_Supplier);
            cmd.Parameters.AddWithValue("@Name_supplier", Name_supplier);
            cmd.Parameters.AddWithValue("@Contact_number", Contact_number);
            cmd.Parameters.AddWithValue("@Email_supplier", Email_supplier);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Supplier_Delete(Int32 ID_Supplier)
        {
            string spConfiguration = "Supplier_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Supplier", ID_Supplier);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Supplier_Logical_Delete(Int32 ID_Supplier)
        {
            string spConfiguration = "Supplier_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Supplier", ID_Supplier);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Product_Insert(string Name_product, decimal Const_product, Int32 Type_product_ID)
        {
            string spConfiguration = "Product_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Name_product", Name_product);
            cmd.Parameters.AddWithValue("@Const_product", Const_product);
            cmd.Parameters.AddWithValue("@Type_product_ID", Type_product_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Product_Update(Int32 ID_Product, Int32 Type_product_ID, string Name_product, decimal Const_product)
        {
            string spConfiguration = "Product_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Product", ID_Product);
            cmd.Parameters.AddWithValue("@Type_product_ID", Type_product_ID);
            cmd.Parameters.AddWithValue("@Name_product", Name_product);
            cmd.Parameters.AddWithValue("@Const_product", Const_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Product_Delete(Int32 ID_Product)
        {
            string spConfiguration = "Product_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Product", ID_Product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Product_Logical_Delete(Int32 ID_Product)
        {
            string spConfiguration = "Product_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Product", ID_Product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Order_Insert(int Order_number, string Order_date, decimal Order_price, Int32 Client_ID, string Login_employee_order)
        {
            string spConfiguration = "Order_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Order_number", Order_number);
            cmd.Parameters.AddWithValue("@Order_date", Order_date);
            cmd.Parameters.AddWithValue("@Order_price", Order_price);
            cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
            cmd.Parameters.AddWithValue("@Login_employee_order", Login_employee_order);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Order_Update(Int32 ID_Order, int Order_number, string Order_date, decimal Order_price, Int32 Client_ID, string Login_employee_order)
        {
            string spConfiguration = "Order_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Order", ID_Order);
            cmd.Parameters.AddWithValue("@Order_number", Order_number);
            cmd.Parameters.AddWithValue("@Order_date", Order_date);
            cmd.Parameters.AddWithValue("@Order_price", Order_price);
            cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
            cmd.Parameters.AddWithValue("@Login_employee_order", Login_employee_order);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Order_Delete(Int32 ID_Order)
        {
            string spConfiguration = "Order_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Order", ID_Order);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Order_Logical_Delete(Int32 ID_Order)
        {
            string spConfiguration = "Order_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Order", ID_Order);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Ordered_product_Insert(Int32 Order_ID, Int32 Product_ID, int Count_product)
        {
            string spConfiguration = "Ordered_product_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Order_ID", Order_ID);
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
            cmd.Parameters.AddWithValue("@Count_product", Count_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Ordered_product_Update(Int32 ID_Ordered_product, Int32 Order_ID, Int32 Product_ID, int Count_product)
        {
            string spConfiguration = "Ordered_product_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Ordered_product", ID_Ordered_product);
            cmd.Parameters.AddWithValue("@Order_ID", Order_ID);
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
            cmd.Parameters.AddWithValue("@Count_product", Count_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Ordered_product_Delete(Int32 ID_Ordered_product)
        {
            string spConfiguration = "Ordered_product_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Ordered_product", ID_Ordered_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Ordered_product_Logical_Delete(Int32 ID_Ordered_product)
        {
            string  spConfiguration = "Ordered_product_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Ordered_product", ID_Ordered_product);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_Insert(string Delivery_date, Int32 Supplier_ID, string Login_employee_delivery)
        {
            string spConfiguration = "Delivery_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Delivery_date", Delivery_date);
            cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
            cmd.Parameters.AddWithValue("@Login_employee_delivery", Login_employee_delivery);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_Update(Int32 ID_Delivery, string Delivery_date, Int32 Supplier_ID, string Login_employee_delivery)
        {
            string spConfiguration = "Delivery_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery", ID_Delivery);
            cmd.Parameters.AddWithValue("@Delivery_date", Delivery_date);
            cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
            cmd.Parameters.AddWithValue("@Login_employee_delivery", Login_employee_delivery);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_Delete(Int32 ID_Delivery)
        {
            string spConfiguration = "Delivery_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery", ID_Delivery);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_Logical_Delete(Int32 ID_Delivery)
        {
            string spConfiguration = "Delivery_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery", ID_Delivery);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_info_Insert(Int32 Product_ID, Int32 Delivery_ID)
        {
            string spConfiguration = "Delivery_info_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
            cmd.Parameters.AddWithValue("@Delivery_ID", Delivery_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_info_Update(Int32 ID_Delivery_info, Int32 Product_ID, Int32 Delivery_ID)
        {
            string spConfiguration = "Delivery_info_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery_info", ID_Delivery_info);
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
            cmd.Parameters.AddWithValue("@Delivery_ID", Delivery_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_info_Delete(Int32 ID_Delivery_info)
        {
            string spConfiguration = "Delivery_info_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery_info", ID_Delivery_info);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Delivery_info_Logical_Delete(Int32 ID_Delivery_info)
        {
            string spConfiguration = "Delivery_info_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Delivery_info", ID_Delivery_info);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Report_Insert(string Report_date, Int32 Delivery_info_ID, Int32 Ordered_product_ID, string Login_employee_report)
        {
            string spConfiguration = "Report_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Report_date", Report_date);
            cmd.Parameters.AddWithValue("@Delivery_info_ID", Delivery_info_ID);
            cmd.Parameters.AddWithValue("@Ordered_product_ID", Ordered_product_ID);
            cmd.Parameters.AddWithValue("@Login_employee_report", Login_employee_report);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Report_Update(Int32 ID_Report, string Report_date, Int32 Delivery_info_ID, Int32 Ordered_product_ID, string Login_employee_report)
        {
            string spConfiguration = "Report_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Report", ID_Report);
            cmd.Parameters.AddWithValue("@Report_date", Report_date);
            cmd.Parameters.AddWithValue("@Delivery_info_ID", Delivery_info_ID);
            cmd.Parameters.AddWithValue("@Ordered_product_ID", Ordered_product_ID);
            cmd.Parameters.AddWithValue("@Login_employee_report", Login_employee_report);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Report_Delete(Int32 ID_Report)
        {
            string spConfiguration = "Report_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Report", ID_Report);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void Report_Logical_Delete(Int32 ID_Report)
        {
            string spConfiguration = "Report_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Report", ID_Report);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Employee_Insert(string Login_employee, string Surname_employee, string Name_employee,
        string Patronymic_employee, Int32 Position_ID)
        {
            string spConfiguration = "Employee_Insert";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@Surname_employee", Surname_employee);
            cmd.Parameters.AddWithValue("@Name_employee", Name_employee);
            cmd.Parameters.AddWithValue("@Patronymic_employee", Patronymic_employee);
            cmd.Parameters.AddWithValue("@Position_ID", Position_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Employee_Update(Int32 ID_Employee, string Login_employee, string Surname_employee, string Name_employee,
        string Patronymic_employee, Int32 Position_ID)
        {
            string spConfiguration = "Employee_Update";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
            cmd.Parameters.AddWithValue("@Surname_employee", Surname_employee);
            cmd.Parameters.AddWithValue("@Name_employee", Name_employee);
            cmd.Parameters.AddWithValue("@Patronymic_employee", Patronymic_employee);
            cmd.Parameters.AddWithValue("@Position_ID", Position_ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Employee_Delete(Int32 ID_Employee)
        {
            string spConfiguration = "Employee_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Employee_Logical_Delete(Int32 ID_Employee)
        {
            string spConfiguration= "Client_Logical_Delete";
            var cmd = new SqlCommand(spConfiguration, connection);
            cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
