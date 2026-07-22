namespace AA.UserControl
{
    partial class UC_Main_QC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Main_QC));
            this.btn_QC = new System.Windows.Forms.Button();
            this.btn_Summary_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QC
            // 
            this.btn_QC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_QC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QC.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_QC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QC.Location = new System.Drawing.Point(0, 0);
            this.btn_QC.Name = "btn_QC";
            this.btn_QC.Size = new System.Drawing.Size(1323, 51);
            this.btn_QC.TabIndex = 29;
            this.btn_QC.Text = "Quality Control";
            this.btn_QC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QC.UseVisualStyleBackColor = false;
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
            this.btn_Summary_Report.Location = new System.Drawing.Point(3, 56);
            this.btn_Summary_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Summary_Report.Name = "btn_Summary_Report";
            this.btn_Summary_Report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Summary_Report.Size = new System.Drawing.Size(259, 72);
            this.btn_Summary_Report.TabIndex = 30;
            this.btn_Summary_Report.Tag = "Summary Report";
            this.btn_Summary_Report.Text = "PCAR";
            this.btn_Summary_Report.UseVisualStyleBackColor = true;
            // 
            // UC_Main_QC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Summary_Report);
            this.Controls.Add(this.btn_QC);
            this.Name = "UC_Main_QC";
            this.Size = new System.Drawing.Size(1323, 713);
            this.Load += new System.EventHandler(this.UC_Main_QC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QC;
        private System.Windows.Forms.Button btn_Summary_Report;
    }
}
