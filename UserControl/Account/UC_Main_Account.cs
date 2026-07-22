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
    public partial class UC_Main_Account : System.Windows.Forms.UserControl, ICrudForm
    {
        public UC_Main_Account()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("acaount");
        }
        private void T1_Load(object sender, EventArgs e)
        {

        }
        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }
    }
}
