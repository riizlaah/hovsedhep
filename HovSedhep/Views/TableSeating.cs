using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HovSedhep.Models;

namespace HovSedhep.Views
{
    public partial class TableSeating : UserControl
    {
        HovSedhepDBC db;
        List<Button> tableButtons = new List<Button>();
        public TableSeating(HovSedhepDBC dbc)
        {
            db = dbc;
            InitializeComponent();
            tableButtons = new List<Button>() { a1, a2, a3, a4, b1, b2, c1, c2};
            RefreshTable();
        }
        private void RefreshTable()
        {
            foreach(var btn in tableButtons)
            {
                //if(db.TableViews.Count == 0)
                if(db.TableViews.Any(t => t.Name == btn.Text))
                {
                    btn.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                }
            }
        }

        private void onRestTableClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var table = db.RestaurantTables.FirstOrDefault(t => t.Name == btn.Text);
            var tableView = db.TableViews.FirstOrDefault(tv => tv.Name == btn.Text);
            var mngTable = new ManageTable(db, table, tableView);
            mngTable.ShowDialog();
            RefreshTable();
        }
    }
}