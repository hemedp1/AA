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
    public partial class UC_Main_Engineering : System.Windows.Forms.UserControl, ICrudForm
    {
        public UC_Main_Engineering()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("engineering");
        }

        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }
        public void ToggleFilter() { }
        public void Cancel() { }

        private void UC_Main_Engineering_Load(object sender, EventArgs e)
        {

        }
    }
}
