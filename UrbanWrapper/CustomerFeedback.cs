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
    public partial class CustomerFeedback : Form
    {
        int CustomerId,invoiceID;
        string name;
        UrbanWrapperEntities dbContext = new UrbanWrapperEntities();
        public CustomerFeedback(int _CustomerId, string _name,int _invoiceID)
        {
            InitializeComponent();
            this.CenterToScreen();
            CustomerId = _CustomerId;
            name = _name;
            invoiceID = _invoiceID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (numFeedback.Value != 0)
            {
                Model.CustomerFeedback feedback = new Model.CustomerFeedback();
                feedback.CustomerId = CustomerId;
                feedback.CustomerName = name;
                feedback.Feedback = tbFeedback.Text;
                feedback.FDate = DateTime.Now;
                feedback.InvoiceId = invoiceID;
                feedback.Rating = (int?)numFeedback.Value;

                dbContext.CustomerFeedbacks.Add(feedback);
                dbContext.SaveChanges();
                MessageBox.Show("Thank you for your feedback!");
                this.Close();
            }
            else MessageBox.Show("Please provide a rating other than 0.");
        }
    }
}
