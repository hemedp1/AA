namespace AA.UserControl
{
    partial class UC_Main_Engineering
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
            this.btn_Engineering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Engineering
            // 
            this.btn_Engineering.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Engineering.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Engineering.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Engineering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Engineering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Engineering.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Engineering.Location = new System.Drawing.Point(0, 0);
            this.btn_Engineering.Name = "btn_Engineering";
            this.btn_Engineering.Size = new System.Drawing.Size(1323, 51);
            this.btn_Engineering.TabIndex = 4;
            this.btn_Engineering.Text = "Engineering";
            this.btn_Engineering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Engineering.UseVisualStyleBackColor = false;
            // 
            // UC_Main_Engineering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btn_Engineering);
            this.Name = "UC_Main_Engineering";
            this.Size = new System.Drawing.Size(1323, 713);
            this.Load += new System.EventHandler(this.UC_Main_Engineering_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Engineering;
    }
}
