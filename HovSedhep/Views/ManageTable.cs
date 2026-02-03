using HovSedhep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep.Views
{
    public partial class ManageTable : Form
    {
        HovSedhepDBC DBC;
        RestaurantTable table;
        TableView tableView;
        public ManageTable(HovSedhepDBC dbc, RestaurantTable table1, TableView tblView = null)
        {
            DBC = dbc;
            table = table1;
            tableView = tblView;
            InitializeComponent();
            waitress.DataSource = DBC.Employees.ToList();
            waitress.DisplayMember = "Name";
            waitress.ValueMember = "EmployeeID";
            if (tableView != null)
            {
                waitress.SelectedValue = tableView.Employee.EmployeeID;
                custName.Text = tableView.CustomerName;
                paxSize.Text = tableView.PaxSize.ToString();
                waitress.Enabled = false;
                custName.Enabled = false;
                paxSize.Enabled = false;
                cancel.Text = "Cancel Table";
                confirm.Text = "Finish Table";
            }
            
        }
        private void onCancel(object sender, EventArgs e)
        {
            if(tableView != null)
            {
                var transac = DBC.Transactions.Find(tableView.TransacId);
                transac.Status = "Cancelled";
                DBC.SaveChanges();
                DBC.TableViews.Remove(tableView);
            }
            Close();
        }

        private void onConfirm(object sender, EventArgs e)
        {
            if(waitress.SelectedItem == null)
            {
                MessageBox.Show("Please select a waitress.");
                return;
            }
            if(custName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }
            if(int.TryParse(paxSize.Text.Trim(), out int pax) == false || pax <= 0)
            {
                MessageBox.Show("Please enter a valid pax size.");
                return;
            }
            if(pax > table.Capacity)
            {
                MessageBox.Show($"Pax Size must be same or less than table capacity! (table capacity = {table.Capacity})");
                return;
            }
            
            if (tableView == null)
            {
                var paxApprox = pax % 2 == 0 ? pax : pax + 1;
                var closestTable = DBC.RestaurantTables.Where(rt => rt.Capacity == paxApprox).FirstOrDefault();
                if (closestTable == null)
                {
                    MessageBox.Show("All table is occupied");
                    return;
                }
                if(closestTable.Capacity != table.Capacity)
                {
                    MessageBox.Show($"There is another table that can fit pax size efficiently (table '{closestTable.Name}')");
                    return;
                }
                var transac = new Transaction
                {
                    CustomerName = custName.Text,
                    TableID = table.TableID,
                };
                DBC.Transactions.Add(transac);
                DBC.SaveChanges();
                tableView = new TableView()
                {
                    Name = table.Name,
                    TransacId = transac.TransactionID,
                    Transac = transac,
                    Employee = waitress.SelectedItem as Employee,
                    CustomerName = custName.Text.Trim(),
                    PaxSize = pax,
                };
                DBC.TableViews.Add(tableView);
            }
            else
            {
                var transac = DBC.Transactions.Find(tableView.TransacId);
                transac.Status = "Completed";
                DBC.SaveChanges();
                DBC.TableViews.Remove(tableView);
            }
            Close();
        }
    }
}
