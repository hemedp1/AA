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
        public MainForm()
        {
            InitializeComponent();
        }




        #region Screen Loader & Toolbar Sync
        /// <summary>
        /// Gets the active User Control loaded inside the currently selected TabPage.
        /// </summary>
        private Control GetActiveScreen()
        {
            if (tabControlMain.SelectedTab != null && tabControlMain.SelectedTab.Controls.Count > 0)
            {
                return tabControlMain.SelectedTab.Controls[0];
            }
            return null;
        }


        /// <summary>
        /// Opens a User Control inside a tab.
        /// If already open, focuses the existing tab instead of opening a duplicate.
        /// </summary>
        private void OpenScreen(System.Windows.Forms.UserControl screen)
        {

            // Check if tab is already open    
            foreach (TabPage tab in tabControlMain.TabPages)
            {
                if (tab.Text == title)
                {
                    tabControlMain.SelectedTab = tab; // Switch to existing tab
                    return;
                }
            }

            // Create new tab page if not open yet
            TabPage newTab = new TabPage(title);
            screen.Dock = DockStyle.Fill;
            newTab.Controls.Add(screen);

            tabControlMain.TabPages.Add(newTab);
            tabControlMain.SelectedTab = newTab;

            UpdateToolbarState();
        }


        private void UpdateToolbarState()
        {
            if (panelMain.Controls.Count == 0)
            {
                DisableAllToolbarButtons();
                return;
            }
            if (panelMain.Controls.Count == 0) return;

            Control activeScreen = panelMain.Controls[0];

            // Check if current screen supports CRUD
            bool isCrud = activeScreen is ICrudForm;
            if (btn_Create != null) btn_Create.Enabled = isCrud;
            if (btn_Save != null) btn_Save.Enabled = isCrud;
            if (btn_Delete != null) btn_Delete.Enabled = isCrud;
            if (btn_Refresh != null) btn_Refresh.Enabled = isCrud;
            if (btn_Cancel != null) btn_Cancel.Enabled = isCrud;

            // Check if current screen supports Filtering
            bool isFilterable = activeScreen is IFilterableForm;
            if (btn_Filter != null) btn_Filter.Enabled = isFilterable;

        }
        private void DisableAllToolbarButtons()
        {
            if (btn_Create != null) btn_Create.Enabled = false;
            if (btn_Save != null) btn_Save.Enabled = false;
            if (btn_Delete != null) btn_Delete.Enabled = false;
            if (btn_Refresh != null) btn_Refresh.Enabled = false;
            if (btn_Cancel != null) btn_Cancel.Enabled = false;
            if (btn_Filter != null) btn_Filter.Enabled = false;
        }


        #endregion

        #region Global Toolbar Action Handlers
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0 && panelMain.Controls[0] is ICrudForm crud)
            {
                crud.AddNew();
            }
        }
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
                    MessageBox.Show("This screen does not support saving.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0 && panelMain.Controls[0] is ICrudForm crud)
            {
                crud.DeleteData();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0 && panelMain.Controls[0] is ICrudForm crud)
            {
                crud.RefreshData();
            }
        }
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            // Check if there is an active User Control loaded in panelMain
            if (panelMain.Controls.Count > 0)
            {
                Control activeScreen = panelMain.Controls[0];

                // Check if the current screen supports IFilterableForm
                if (activeScreen is IFilterableForm filterable)
                {
                    filterable.ToggleFilter(); // Calls the filter method on the User Control
                }
                else
                {
                    MessageBox.Show("This screen does not support search or filtering.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0 && panelMain.Controls[0] is ICrudForm crud)
            {
                crud.Cancel();
            }
        }
        #endregion


        #region Form Events & Navigation Controls
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            left_Side_Bar_Panel.Visible = !left_Side_Bar_Panel.Visible;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            left_Side_Bar_Panel.Visible = false;
            DisableAllToolbarButtons();
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
        #endregion
    }
}
