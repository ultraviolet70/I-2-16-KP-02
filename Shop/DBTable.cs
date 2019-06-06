using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class DBTable
    {
        private SqlCommand command = new SqlCommand();
        public DataTable dtClient = new DataTable("Client");
        public DataTable dtPosition = new DataTable("Position");
        public DataTable dtEmployee = new DataTable("Employee");
        public DataTable dtType_Product = new DataTable("Type_Produc");
        public DataTable dtSupplier = new DataTable("Supplier");
        public DataTable dtProduct = new DataTable("Product");
        public DataTable dtOrder = new DataTable("Order");
        public DataTable dtOrdered_product = new DataTable("Ordered_product");
        public DataTable dtDelivery = new DataTable("Delivery ");
        public DataTable dtDelivery_info = new DataTable("Delivery_info");
        public DataTable dtReport = new DataTable("Report");
        public SqlDependency dependency = new SqlDependency();
        public string qrClient = "select [ID_Client],[Surname_client],[Name_client],[Patronymic_client], [Number_client], [Email_client] from[dbo].[Client] where[Client_Logical_Delete] = 0";

        private void dtFill(DataTable table, string query)
        {

            {
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                table.Load(command.ExecuteReader());
            }
        }

        public void dtClientFill()
        {

        }

        public void dtPositionFill()
        {

        }

        public void dtEmployeeFill()
        {

        }

        public void dtType_ProductFill()
        {

        }

        public void dtSupplierFill()
        {

        }

        public void dtProductFill()
        {

        }

        public void dtOrderFill()
        {

        }

        public void dtOrdered_productFill()
        {

        }

        public void dtDeliveryFill()
        {

        }

        public void dtDelivery_infoFill()
        {

        }

        public void dtReportFill()
        {

        }
    }
}
