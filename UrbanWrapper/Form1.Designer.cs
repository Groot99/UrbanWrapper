
namespace UrbanWrapper
{
    partial class Form1
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
            this.btnManageSales = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSales
            // 
            this.btnManageSales.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManageSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageSales.Location = new System.Drawing.Point(69, 65);
            this.btnManageSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(306, 98);
            this.btnManageSales.TabIndex = 9;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.UseVisualStyleBackColor = false;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageProduct.Location = new System.Drawing.Point(69, 233);
            this.btnManageProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(306, 98);
            this.btnManageProduct.TabIndex = 10;
            this.btnManageProduct.Text = "Manage Products";
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(69, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 98);
            this.button1.TabIndex = 11;
            this.button1.Text = "Collect Customer Feedback";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(436, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManageProduct);
            this.Controls.Add(this.btnManageSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UW Prototype";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button button1;
    }
}

