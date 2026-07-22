namespace AA.UserControl
{
    partial class UC_Main_Purchasing
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
            this.btn_Purchasing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Purchasing
            // 
            this.btn_Purchasing.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Purchasing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Purchasing.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Purchasing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Purchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchasing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Purchasing.Location = new System.Drawing.Point(0, 0);
            this.btn_Purchasing.Name = "btn_Purchasing";
            this.btn_Purchasing.Size = new System.Drawing.Size(1323, 51);
            this.btn_Purchasing.TabIndex = 28;
            this.btn_Purchasing.Text = "Purchasing";
            this.btn_Purchasing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Purchasing.UseVisualStyleBackColor = false;
            // 
            // UC_Main_Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btn_Purchasing);
            this.Name = "UC_Main_Purchasing";
            this.Size = new System.Drawing.Size(1323, 713);
            this.Load += new System.EventHandler(this.UC_Main_Purchasing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Purchasing;
    }
}
