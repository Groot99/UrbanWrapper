
namespace UrbanWrapper
{
    partial class CustomerFeedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSendLater = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numFeedback = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(366, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "FEEDBACK";
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(550, 360);
            this.tbFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFeedback.Multiline = true;
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(417, 198);
            this.tbFeedback.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(76, 360);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(326, 57);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(36, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(931, 118);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Thank you for shopping with us, we hope you enjoyed your experience! \r\n\r\nPlease p" +
    "rovide us with some feedback. \r\nYou may click \"Send Feedback Later\" if you\'d lik" +
    "e a reminder email in the future.";
            // 
            // btnSendLater
            // 
            this.btnSendLater.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSendLater.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSendLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendLater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendLater.Location = new System.Drawing.Point(641, 243);
            this.btnSendLater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendLater.Name = "btnSendLater";
            this.btnSendLater.Size = new System.Drawing.Size(326, 57);
            this.btnSendLater.TabIndex = 13;
            this.btnSendLater.Text = "Send Feedback Later";
            this.btnSendLater.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(76, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // numFeedback
            // 
            this.numFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numFeedback.Location = new System.Drawing.Point(441, 433);
            this.numFeedback.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFeedback.Name = "numFeedback";
            this.numFeedback.Size = new System.Drawing.Size(62, 53);
            this.numFeedback.TabIndex = 15;
            // 
            // CustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1241, 869);
            this.Controls.Add(this.numFeedback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendLater);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbFeedback);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerFeedback";
            this.Text = "CustomerFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.numFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSendLater;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numFeedback;
    }
}