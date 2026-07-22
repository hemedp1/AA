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
    public partial class FrmBOM : Form, ICrudForm
    {
        string cs = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        TextBox txtType = new TextBox() 
        { 
            Left = 140, Top = 20, Width = 220 
        };
        TextBox txtID = new TextBox() 
        {
            Left = 140, Top = 50, Width = 220
        };
        TextBox txtDesc1 = new TextBox() 
        { 
            Left = 140, Top = 80, Width = 220 
        };
        TextBox txtComp = new TextBox() 
        { 
            Left = 140, Top = 110, Width = 220
        };
        TextBox txtDesc2 = new TextBox() 
        { 
            Left = 140, Top = 140, Width = 220 
        };
        TextBox txtStdpk = new TextBox() 
        { 
            Left = 140, Top = 170, Width = 220 
        };
        DataGridView dgv = new DataGridView() 
        {
            Left = 20, Top = 220, Width = 900, Height = 250 
        };
        public FrmBOM() 
        { 
            Controls.Add(new Label() 
            { 
                Text = "Product Type", Left = 20, Top = 20 
            }); 

            Controls.Add(txtType);
            
            Controls.Add(new Label() 
            { 
                Text = "Product ID", Left = 20, Top = 50 
            }); 

            Controls.Add(txtID); 

            Controls.Add(new Label() 
            { 
                Text = "Desc1", Left = 20, Top = 80 
            }); 
            Controls.Add(txtDesc1); 

            Controls.Add(new Label() 
            { 
                Text = "Component", Left = 20, Top = 110 
            }); 
            Controls.Add(txtComp); 

            Controls.Add(new Label() 
            { 
                Text = "Desc2", Left = 20, Top = 140 
            }); 
            Controls.Add(txtDesc2); 

            Controls.Add(new Label() 
            { 
                Text = "Stdpk", Left = 20, Top = 170 
            }); 
            Controls.Add(txtStdpk); 

            Controls.Add(dgv); LoadGrid(); 
        }
        public void AddNew() 
        {
            txtType.Clear(); 
            txtID.Clear(); 
            txtDesc1.Clear(); 
            txtComp.Clear(); 
            txtDesc2.Clear();
            txtStdpk.Clear(); }
        public void SaveData() 
        {
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
                con.Open(); 
                SqlCommand cmd = new SqlCommand("INSERT INTO BOMMASTER(Product_Type,Product_ID,Desc1,Component,Desc2,Stdpk) VALUES(@a,@b,@c,@d,@e,@f)", con); 
                cmd.Parameters.AddWithValue("@a", txtType.Text); 
                cmd.Parameters.AddWithValue("@b", txtID.Text); 
                cmd.Parameters.AddWithValue("@c", txtDesc1.Text); 
                cmd.Parameters.AddWithValue("@d", txtComp.Text);
                cmd.Parameters.AddWithValue("@e", txtDesc2.Text);
                cmd.Parameters.AddWithValue("@f", txtStdpk.Text);
                cmd.ExecuteNonQuery(); 
            } 
            LoadGrid(); 
        }
        public void DeleteData() 
        { 
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
                con.Open(); SqlCommand cmd = new SqlCommand("DELETE FROM BOMMASTER WHERE Product_ID=@a AND Component=@b", con); 
                cmd.Parameters.AddWithValue("@a", txtID.Text); 
                cmd.Parameters.AddWithValue("@b", txtComp.Text); 
                cmd.ExecuteNonQuery(); 
            } 
            LoadGrid(); 
        }
        public void RefreshData() 
        { 
            LoadGrid(); 
        }
        void LoadGrid() { using (SqlConnection con = new SqlConnection(cs)) { SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOMMASTER", con); DataTable dt = new DataTable(); da.Fill(dt); dgv.DataSource = dt; } }
    }
}
