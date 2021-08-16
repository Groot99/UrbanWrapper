
namespace UrbanWrapper
{
    partial class ManageFeedback
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
            this.btnViewFeedback = new System.Windows.Forms.Button();
            this.btnSendSurveyLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnViewFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewFeedback.Location = new System.Drawing.Point(240, 283);
            this.btnViewFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(306, 98);
            this.btnViewFeedback.TabIndex = 12;
            this.btnViewFeedback.Text = "View Feedback";
            this.btnViewFeedback.UseVisualStyleBackColor = false;
            this.btnViewFeedback.Click += new System.EventHandler(this.btnViewFeedback_Click);
            // 
            // btnSendSurveyLink
            // 
            this.btnSendSurveyLink.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSendSurveyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSurveyLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendSurveyLink.Location = new System.Drawing.Point(240, 132);
            this.btnSendSurveyLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendSurveyLink.Name = "btnSendSurveyLink";
            this.btnSendSurveyLink.Size = new System.Drawing.Size(306, 98);
            this.btnSendSurveyLink.TabIndex = 11;
            this.btnSendSurveyLink.Text = "Send Survey Link";
            this.btnSendSurveyLink.UseVisualStyleBackColor = false;
            this.btnSendSurveyLink.Click += new System.EventHandler(this.btnSendSurveyLink_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(123, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(539, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Collect Customer Feedback";
            // 
            // ManageFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(792, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewFeedback);
            this.Controls.Add(this.btnSendSurveyLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ManageFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collect Customer Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewFeedback;
        private System.Windows.Forms.Button btnSendSurveyLink;
        private System.Windows.Forms.Label label6;
    }
}