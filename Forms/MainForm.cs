using AA.UserControl;
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
    public partial class MainForm : Form
    {
        UC_Toolbar bar = new UC_Toolbar();
        Panel menu = new Panel();
        Panel body = new Panel();
        Button btnItem = new Button() 
        { 
            Text = "ITEMMASTER", Width = 150, Top = 20, Left = 10 
        };
        Button btnBom = new Button() 
        { 
            Text = "BOMMASTER", Width = 150, Top = 60, Left = 10 
        };
        public MainForm()
        {
            InitializeComponent();
            // Text = "AA System"; Width = 1000; Height = 600;
            //  Controls.Add(bar);
            // menu.Dock = DockStyle.Left; menu.Width = 180; body.Dock = DockStyle.Fill;
            // Controls.Add(body); Controls.Add(menu);
            //  menu.Controls.Add(btnItem); menu.Controls.Add(btnBom);
            //  btnItem.Click += (s, e) => OpenChild(new FrmItem());
            //  btnBom.Click += (s, e) => OpenChild(new FrmBOM());
        }
        void OpenChild(Form frm) 
        { 
            body.Controls.Clear(); 
            frm.TopLevel = false; 
            frm.FormBorderStyle = FormBorderStyle.None; 
            frm.Dock = DockStyle.Fill; 
            body.Controls.Add(frm); 
            frm.Show(); bar.CurrentForm = (ICrudForm)frm; }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            left_Side_Bar_Panel.Visible = !left_Side_Bar_Panel.Visible;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            left_Side_Bar_Panel.Visible = false;

            //treeView1.Nodes.Clear();

            //TreeNode master = new TreeNode("Master Data"); 
            //master.Nodes.Add("T1"); 
            //master.Nodes.Add("T2");

            //TreeNode booking = new TreeNode("Booking"); 
            //booking.Nodes.Add("Car Booking"); 
            //booking.Nodes.Add("Meeting Room"); 
            //treeView1.Nodes.Add(master); 
            //treeView1.Nodes.Add(booking); 
            //treeView1.ExpandAll();
        }
        /*private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "T1":
                    OpenScreen(new T1());
                    break;

                case "T2":
                    OpenScreen(new T2());
                    break;

            }
        }*/
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                Control activeScreen = panelMain.Controls[0];

                if (activeScreen is ICrudForm saveable)
                {
                    saveable.SaveData();
                }
                else
                {
                    MessageBox.Show("This screen has no save function.");
                }
            }
        }
        private void OpenScreen(System.Windows.Forms.UserControl screen)
        {
            panelMain.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            panelMain.Controls.Add(screen);
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Account());
        }

        private void btn_EDP_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_EDP());
        }

        private void btn_Engineering_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Engineering());
        }

        private void btn_Facility_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Facility());
        }

        private void btn_HRAdmin_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_HR_Admin());
        }

        private void btn_ISO_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_ISO());
        }

        private void btn_ProductionEngineering_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Production_Engineering());
        }

        private void btn_Planning_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Planning());
        }

        private void btn_Production_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Production());
        }

        private void btn_Purchasing_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Purchasing());
        }

        private void btn_QC_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_QC());
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Sales());
        }

        private void btn_Shipping_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Shipping());
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            OpenScreen(new UC_Main_Warehouse());
        }

        private void txt_Main_Search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_Main_Search.Text.ToLower();

            SearchButtons(left_Side_Bar_Panel, search);
        }

        private void SearchButtons(Control parent, string search)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Visible = btn.Text.ToLower().Contains(search);
                }

                if (ctrl.HasChildren)
                {
                    SearchButtons(ctrl, search);
                }
            }
        }

    }
}
