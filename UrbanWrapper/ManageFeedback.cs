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
    public partial class ManageFeedback : Form
    {
        public ManageFeedback()
        {
            InitializeComponent();
        }

        private void btnSendSurveyLink_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders(true);
            viewOrders.ShowDialog();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ViewFeedback feedback = new ViewFeedback();
            feedback.ShowDialog();
        }
    }
}
