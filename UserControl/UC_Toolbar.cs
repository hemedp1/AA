using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AA
{
    public partial class UC_Toolbar : System.Windows.Forms.UserControl
    {
        public ICrudForm CurrentForm;
        Button btnAdd = new Button() 
        { 
            Text = "Add", Left = 10, Top = 10, Width = 80 
        };
        Button btnSave = new Button() 
        { 
            Text = "Save", Left = 100, Top = 10, Width = 80 
        };
        Button btnDelete = new Button() 
        { 
            Text = "Delete", Left = 190, Top = 10, Width = 80 
        };
        Button btnRefresh = new Button() 
        { 
            Text = "Refresh", Left = 280, Top = 10, Width = 80 
        };
        public UC_Toolbar()
        {
            Height = 50; Dock = DockStyle.Top; Controls.AddRange(new Control[] 
            { 
                btnAdd, btnSave, btnDelete, btnRefresh 
            });
            btnAdd.Click += (s, e) => CurrentForm?.AddNew();
            btnSave.Click += (s, e) => CurrentForm?.SaveData();
            btnDelete.Click += (s, e) => CurrentForm?.DeleteData();
            btnRefresh.Click += (s, e) => CurrentForm?.RefreshData();
        }
    }
}