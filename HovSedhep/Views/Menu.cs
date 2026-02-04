using HovSedhep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep.Views
{
    public partial class Menu : UserControl
    {
        HovSedhepDBC DBC;
        public Menu(HovSedhepDBC dbc)
        {
            DBC = dbc;
            InitializeComponent();
            menuTable.AutoGenerateColumns = false;
            var idCol = Main.createColumn("MenuItemID", "Menu ID");
            var categoryCol = Main.createColumn("Category", "Category");
            var nameCol = Main.createColumn("Name", "Name");
            var priceCol = Main.createColumn("Price", "Price");
            var descCol = Main.createColumn("Description", "Description");
            menuTable.Columns.AddRange(new DataGridViewColumn[] {
                idCol, categoryCol, nameCol, priceCol, descCol
            });
            var datas = DBC.Categories.ToList();
            datas = datas.Prepend(new Category() { CategoryID = 0, Name = "All" }).ToList();
            filter.DataSource = datas;
            filter.DisplayMember = "Name";
            filter.ValueMember = "CategoryID";
            Debug.WriteLine(datas);
            //filter.SelectedIndex = 0;
            
            RefreshData();
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            RefreshData(search.Text);
        }

        private void RefreshData(string src = null)
        {
            
            var query = DBC.MenuItems.Include("Category").AsQueryable();
            if(filter.SelectedIndex > 0)
            {
                query = query.Where(m => m.CategoryID == (int)filter.SelectedValue);
            }
            if (src == null || src.Trim() == "")
            {
                menuTable.DataSource = query.ToList();
            }
            else
            {
                menuTable.DataSource = query.Where(m => m.Name.Contains(src) || m.Description.Contains(src)).ToList();
            }
            menuTable.AutoResizeColumns();
            menuTable.Refresh();
        }

        private void filter_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData(search.Text);
        }
    }
}
