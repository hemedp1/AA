using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace AA
{
    public partial class FrmItem : Form, ICrudForm
    {
        string cs = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        TextBox txtProductID = new TextBox() { Left = 140, Top = 20, Width = 220 };
        TextBox txtProductType = new TextBox() { Left = 140, Top = 50, Width = 220 };
        TextBox txtDesc = new TextBox() { Left = 140, Top = 80, Width = 220 };
        TextBox txtCode = new TextBox() { Left = 140, Top = 110, Width = 220 };
        TextBox txtStdpk = new TextBox() { Left = 140, Top = 140, Width = 220 };
        DataGridView dgv = new DataGridView() { Left = 20, Top = 190, Width = 900, Height = 280 };
        public FrmItem() 
        { 
            Controls.Add(new Label() { Text = "Product ID", Left = 20, Top = 20 }); 
            Controls.Add(txtProductID); Controls.Add(new Label() { Text = "Product Type", Left = 20, Top = 50 }); 
            Controls.Add(txtProductType); Controls.Add(new Label() { Text = "Desc", Left = 20, Top = 80 }); 
            Controls.Add(txtDesc); Controls.Add(new Label() { Text = "Product Code", Left = 20, Top = 110 }); 
            Controls.Add(txtCode); Controls.Add(new Label() { Text = "Stdpk", Left = 20, Top = 140 }); 
            Controls.Add(txtStdpk); Controls.Add(dgv); LoadGrid(); }
        public void AddNew() 
        { 
            txtProductID.Clear(); 
            txtProductType.Clear(); 
            txtDesc.Clear(); 
            txtCode.Clear(); 
            txtStdpk.Clear(); 
            txtProductID.Focus(); }
        public void SaveData() 
        { 
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
                con.Open(); 
                SqlCommand cmd = new SqlCommand("INSERT INTO ITEMMASTER(Product_ID,Product_Type,[Desc],Product_code,Stdpk) VALUES(@a,@b,@c,@d,@e)", con); 
                cmd.Parameters.AddWithValue("@a", txtProductID.Text); 
                cmd.Parameters.AddWithValue("@b", txtProductType.Text); 
                cmd.Parameters.AddWithValue("@c", txtDesc.Text); 
                cmd.Parameters.AddWithValue("@d", txtCode.Text); 
                cmd.Parameters.AddWithValue("@e", txtStdpk.Text); 
                cmd.ExecuteNonQuery(); } LoadGrid(); }
        public void DeleteData() 
        { 
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
                con.Open(); 
                SqlCommand cmd = new SqlCommand("DELETE FROM ITEMMASTER WHERE Product_ID=@a", con); 
                cmd.Parameters.AddWithValue("@a", txtProductID.Text); 
                cmd.ExecuteNonQuery(); } LoadGrid(); }
        public void RefreshData() 
        { 
            LoadGrid(); 
        }
        void LoadGrid() 
        {
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ITEMMASTER", con); 
                DataTable dt = new DataTable(); da.Fill(dt); dgv.DataSource = dt; 
            } 
        }
    }
}