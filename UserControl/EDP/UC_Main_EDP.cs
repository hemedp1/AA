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
    public partial class UC_Main_EDP : System.Windows.Forms.UserControl, ICrudForm, IFilterableForm
    {
        public UC_Main_EDP()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("edp");
        }
        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }
        public void ToggleFilter() { }
        public void Cancel() { }

        private void btn_email_Click(object sender, EventArgs e)
        {

        }
    }
}
