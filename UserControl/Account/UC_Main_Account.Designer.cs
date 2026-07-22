namespace AA.UserControl
{
    partial class UC_Main_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Main_Account));
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Summary_Report = new System.Windows.Forms.Button();
            this.btn_Miscellaneous_Claim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Account.Location = new System.Drawing.Point(0, 0);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(1323, 51);
            this.btn_Account.TabIndex = 1;
            this.btn_Account.Text = "Account";
            this.btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.UseVisualStyleBackColor = false;
            // 
            // btn_Summary_Report
            // 
            this.btn_Summary_Report.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Summary_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_Summary_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Summary_Report.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btn_Summary_Report.ForeColor = System.Drawing.Color.Black;
            this.btn_Summary_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Summary_Report.Image")));
            this.btn_Summary_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Summary_Report.Location = new System.Drawing.Point(265, 56);
            this.btn_Summary_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Summary_Report.Name = "btn_Summary_Report";
            this.btn_Summary_Report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Summary_Report.Size = new System.Drawing.Size(259, 72);
            this.btn_Summary_Report.TabIndex = 13;
            this.btn_Summary_Report.Tag = "Summary Report";
            this.btn_Summary_Report.Text = "Summary Report";
            this.btn_Summary_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Miscellaneous_Claim
            // 
            this.btn_Miscellaneous_Claim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Miscellaneous_Claim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_Miscellaneous_Claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Miscellaneous_Claim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btn_Miscellaneous_Claim.ForeColor = System.Drawing.Color.Black;
            this.btn_Miscellaneous_Claim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Miscellaneous_Claim.Image")));
            this.btn_Miscellaneous_Claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Miscellaneous_Claim.Location = new System.Drawing.Point(0, 56);
            this.btn_Miscellaneous_Claim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Miscellaneous_Claim.Name = "btn_Miscellaneous_Claim";
            this.btn_Miscellaneous_Claim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Miscellaneous_Claim.Size = new System.Drawing.Size(259, 72);
            this.btn_Miscellaneous_Claim.TabIndex = 12;
            this.btn_Miscellaneous_Claim.Tag = "Miscellaneous Claim";
            this.btn_Miscellaneous_Claim.Text = "            Miscellaneous Claim";
            this.btn_Miscellaneous_Claim.UseVisualStyleBackColor = true;
            // 
            // UC_Main_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Summary_Report);
            this.Controls.Add(this.btn_Miscellaneous_Claim);
            this.Controls.Add(this.btn_Account);
            this.Name = "UC_Main_Account";
            this.Size = new System.Drawing.Size(1323, 713);
            this.Load += new System.EventHandler(this.T1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Summary_Report;
        private System.Windows.Forms.Button btn_Miscellaneous_Claim;
    }
}
