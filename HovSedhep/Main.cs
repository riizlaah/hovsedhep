using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HovSedhep.Views;

namespace HovSedhep
{
    public partial class Main : Form
    {
        TableSeating tableSeating = new TableSeating();
        public Main()
        {
            InitializeComponent();
            setControl(tableSeating);
        }

        private void setControl(UserControl control)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
        private void onTableSeating(object sender, EventArgs e)
        {
            setControl(tableSeating);
        }

        private void onMenu(object sender, EventArgs e)
        {

        }

        private void onTransaction(object sender, EventArgs e)
        {

        }
    }
}
