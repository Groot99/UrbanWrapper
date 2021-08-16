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
    public partial class frmManageProduct : Form
    {
        UrbanWrapperEntities dbContext = new UrbanWrapperEntities();
        public frmManageProduct()
        {
            InitializeComponent();
            this.CenterToScreen();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            try
            {
                dgProducts.AutoGenerateColumns = false;
                dgProducts.DataSource = dbContext.Products.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching the products.");
            }

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbPrice.Text)
                && !string.IsNullOrEmpty(tbQuantity.Text))
            {
                Product product = new Product();
                product.ProductName = tbName.Text;
                product.Description = tbDSCR.Text;
                product.Price = Convert.ToDecimal(tbPrice.Text);
                product.StockQuantity = Convert.ToInt32(tbQuantity.Text);

                try
                {
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                    MessageBox.Show("Product added.");
                    UpdateGrid();
                    tbDSCR.Text = string.Empty;
                    tbName.Text = string.Empty;
                    tbPrice.Text = string.Empty;
                    tbQuantity.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while adding new product");
                }
            }
            else
                MessageBox.Show("ERROR: Please enter all product information.");
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        var Product = (Product)dgProducts.CurrentRow.DataBoundItem;
                        var prod = dbContext.Products.Find(Product.Id);
                        dbContext.Products.Remove(prod);
                        dbContext.SaveChanges();
                        MessageBox.Show("Product deleted!", "Info");
                        UpdateGrid();

                    }
                }
                else
                {
                    var Product = (Product)dgProducts.CurrentRow.DataBoundItem;
                    var obj = dbContext.Products?.Where(x => x.Id == Product.Id)?.FirstOrDefault();
                    obj.ProductName = Product.ProductName;
                    obj.Price = Product.Price;
                    dbContext.SaveChanges();

                    MessageBox.Show("Product updated!", "Info");
                    UpdateGrid();
                }
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
