
namespace UrbanWrapper
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendSurveyLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.OrderNumber,
            this.NumberOfProducts,
            this.OrderDate,
            this.OrderAmount,
            this.Status,
            this.Select});
            this.dgOrders.Location = new System.Drawing.Point(18, 131);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowHeadersWidth = 62;
            this.dgOrders.Size = new System.Drawing.Size(1174, 543);
            this.dgOrders.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 8;
            this.Customer.Name = "Customer";
            this.Customer.Width = 200;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.MinimumWidth = 8;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Width = 40;
            // 
            // NumberOfProducts
            // 
            this.NumberOfProducts.DataPropertyName = "NumberOfProducts";
            this.NumberOfProducts.HeaderText = "NumberOfProducts";
            this.NumberOfProducts.MinimumWidth = 8;
            this.NumberOfProducts.Name = "NumberOfProducts";
            this.NumberOfProducts.Width = 40;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 8;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 150;
            // 
            // OrderAmount
            // 
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "Order Amount";
            this.OrderAmount.MinimumWidth = 8;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.Width = 50;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(398, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Orders";
            // 
            // btnSendSurveyLink
            // 
            this.btnSendSurveyLink.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSendSurveyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSurveyLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendSurveyLink.Location = new System.Drawing.Point(873, 684);
            this.btnSendSurveyLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendSurveyLink.Name = "btnSendSurveyLink";
            this.btnSendSurveyLink.Size = new System.Drawing.Size(306, 74);
            this.btnSendSurveyLink.TabIndex = 12;
            this.btnSendSurveyLink.Text = "Send Survey Link";
            this.btnSendSurveyLink.UseVisualStyleBackColor = false;
            this.btnSendSurveyLink.Click += new System.EventHandler(this.btnSendSurveyLink_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 755);
            this.Controls.Add(this.btnSendSurveyLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendSurveyLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}