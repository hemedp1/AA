using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AA.UserControl
{
    public partial class UC_Main_Purchasing : System.Windows.Forms.UserControl, ICrudForm
    {
        public UC_Main_Purchasing()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("purchasing");
        }
     
        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }

        private void UC_Main_Purchasing_Load(object sender, EventArgs e)
        {

        }
    }
}
