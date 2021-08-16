using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanWrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            ManageSales sales = new ManageSales();
            sales.ShowDialog();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmManageProduct manageProduct = new frmManageProduct();
            manageProduct.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageFeedback feedback = new ManageFeedback();
            feedback.ShowDialog();
        }
    }
}
