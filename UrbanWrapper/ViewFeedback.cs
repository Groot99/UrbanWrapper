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
    public partial class ViewFeedback : Form
    {
        UrbanWrapperEntities dbContext = new UrbanWrapperEntities();
        public ViewFeedback()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgFeedback.AutoGenerateColumns = false;
            dgFeedback.DataSource = dbContext.CustomerFeedbacks.ToList();
        }
    }
}
