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
    public partial class UC_Main_Warehouse : System.Windows.Forms.UserControl, ICrudForm
    {
        public UC_Main_Warehouse()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("WAREHOUSE");
        }
        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }
        public void ToggleFilter() { }
        public void Cancel() { }
        private void UC_Main_Warehouse_Load(object sender, EventArgs e)
        {

        }
    }
}
