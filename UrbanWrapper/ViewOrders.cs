using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanWrapper.Model;

namespace UrbanWrapper
{
    public partial class ViewOrders : Form
    {
        BindingList<OrdersInfo> Orders = new BindingList<OrdersInfo>();
        public ViewOrders(bool value)
        {
            InitializeComponent();
            this.CenterToScreen();
            if(value == false)
            {
                dgOrders.Columns["Select"].Visible = false;
                dgOrders.Width = dgOrders.Width - 100;
            }
            dgOrders.AutoGenerateColumns = false;
            dgOrders.DataSource = Orders;

            loadData();
        }

        void loadData()
        {
            UrbanWrapperEntities dbContext = new UrbanWrapperEntities();
            var data = dbContext.CustomerOrders.Include(x=>x.Customer).Include(x=>x.Invoices).ToList();

            foreach (var item in data)
            {
                OrdersInfo info = new OrdersInfo();
                info.Customer = item.Customer.FirstName;
                info.NumberOfProducts = item.NumberOfProducts.GetValueOrDefault();
                info.OrderAmount = item.OrderTotal.GetValueOrDefault();
                info.OrderDate = item.OrderDate.GetValueOrDefault();
                info.OrderNumber = item.Id;
               // info.InvoiceNumber = item.Invoices;
                info.Status = item.Invoices.Count > 0 ? "Paid" : "Un-Paid";

                Orders.Add(info);
            }
        }
        public class OrdersInfo
        {
            public string Customer { get; set; }
            public int OrderNumber { get; set; }
            public int NumberOfProducts { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal OrderAmount { get; set; }
            public string Status { get; set; }
        }

        private void btnSendSurveyLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Survey links sent!");
        }
    }
}
