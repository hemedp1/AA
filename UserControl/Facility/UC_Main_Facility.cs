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
    public partial class UC_Main_Facility : System.Windows.Forms.UserControl, ICrudForm
    {
        public UC_Main_Facility()
        {
            InitializeComponent();
        }
        public void SaveData()
        {
            MessageBox.Show("facilty");
        }
        private void UC_Main_Facility_Load(object sender, EventArgs e)
        {

        }
        public void AddNew() { }
        public void DeleteData() { }
        public void RefreshData() { }
        public void ToggleFilter() { }
        public void Cancel() { }

    }
}
