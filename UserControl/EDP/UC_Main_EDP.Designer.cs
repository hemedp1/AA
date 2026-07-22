namespace AA.UserControl
{
    partial class UC_Main_EDP
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_EDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(792, 365);
            this.button1.TabIndex = 0;
            this.button1.Text = "T2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_EDP
            // 
            this.btn_EDP.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EDP.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_EDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_EDP.Location = new System.Drawing.Point(0, 0);
            this.btn_EDP.Name = "btn_EDP";
            this.btn_EDP.Size = new System.Drawing.Size(1359, 51);
            this.btn_EDP.TabIndex = 3;
            this.btn_EDP.Text = "EDP";
            this.btn_EDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EDP.UseVisualStyleBackColor = false;
            // 
            // UC_Main_EDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_EDP);
            this.Controls.Add(this.button1);
            this.Name = "UC_Main_EDP";
            this.Size = new System.Drawing.Size(1359, 797);
            this.Load += new System.EventHandler(this.UC_Main_EDP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_EDP;
    }
}
