using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanWrapper.Model;

namespace UrbanWrapper
{
    public partial class ManageSales : Form
    {
        UrbanWrapperEntities dbContext = new UrbanWrapperEntities();
        BindingList<Product> Products = new BindingList<Product>();
        public ManageSales()
        {
            InitializeComponent();
            this.CenterToScreen();

            dgProducts.AutoGenerateColumns = false;
            dgProducts.DataSource = dbContext.Products.ToList();
            CartlistBox.DataSource = Products;
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var Product = (Product)dgProducts.CurrentRow.DataBoundItem;
                Products.Add(Product);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (CartlistBox.SelectedIndex != -1)
            {
                Products.RemoveAt(CartlistBox.SelectedIndex);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Products.Count < 1)
            {
                MessageBox.Show("ERROR: Please add at least one product in cart.", "Error!");
                return;
            }
            {
                if (!string.IsNullOrEmpty(tbfName.Text) && !string.IsNullOrEmpty(tbLName.Text) &&
                    !string.IsNullOrEmpty(tbPhone.Text))
                {
                    try
                    {
                        Customer customer = new Customer();
                        customer.FirstName = tbfName.Text;
                        customer.LastName = tbLName.Text;
                        customer.Phone = tbPhone.Text;
                        customer.Address = tbAddress.Text;
                        customer.Email = tbEmail.Text;

                        dbContext.Customers.Add(customer);
                        dbContext.SaveChanges();

                        CustomerOrder order = new CustomerOrder();
                        order.CustomerId = customer.Id;
                        order.NumberOfProducts = Products.Count;
                        order.OrderDate = DateTime.Now;
                        order.OrderTotal = Products.Sum(x => x.Price);

                        dbContext.CustomerOrders.Add(order);
                        dbContext.SaveChanges();

                        MessageBox.Show("Order ID #" + order.Id + " successfully.", "Success!");
                        tbfName.Text = string.Empty;
                        tbLName.Text = string.Empty;
                        tbPhone.Text = string.Empty;
                        tbAddress.Text = string.Empty;
                        tbEmail.Text = string.Empty;
                        MakePayment makePayment = new MakePayment();
                        makePayment.label6.Text = "Order #" + order.Id;

                        if (makePayment.ShowDialog() == DialogResult.OK)
                        {
                            Invoice invoice = new Invoice();
                            invoice.InvoiceAmount = order.OrderTotal;
                            invoice.InvoiceDate = DateTime.Now;
                            invoice.OrderId = order.Id;
                            for(int index = 0; index < Products.Count; ++index)
                            {
                                Product product = Products[index];
                                product.StockQuantity -= 1;
                            }
                            dbContext.Invoices.Add(invoice);
                            dbContext.SaveChanges();
                            MessageBox.Show("Invoice #" + invoice.Id + " generated.");
                            CustomerFeedback customerFeedback = new CustomerFeedback(customer.Id, customer.FirstName, invoice.Id);
                            customerFeedback.ShowDialog();
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while placing the order.");
                    }

                }
                else
                {
                    MessageBox.Show("ERROR: Please enter customer details.", "Error!");
                }
            }
        }
    }
}
