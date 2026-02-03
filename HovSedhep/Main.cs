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
using HovSedhep.Views;

namespace HovSedhep
{
    public partial class Main : Form
    {
        HovSedhepDBC DBC;
        TableSeating tableSeating;
        Views.Menu menu;
        public Main()
        {
            DBC = new HovSedhepDBC();
            menu = new Views.Menu(DBC);
            tableSeating = new TableSeating(DBC);
            InitializeComponent();
            setControl(tableSeating);

        }

        public static DataGridViewTextBoxColumn createColumn(string binding, string header)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = binding;
            col.HeaderText = header;
            col.Name = header;
            return col;
        }

        private void setControl(UserControl control)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        private void onTableSeating(object sender, EventArgs e)
        {
            setControl(tableSeating);
        }

        private void onMenu(object sender, EventArgs e)
        {
            setControl(menu);
        }

        private void onTransaction(object sender, EventArgs e)
        {

        }
    }
}
