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
    public partial class History : UserControl
    {
        HovSedhepDBC DBC;
        public History(HovSedhepDBC dbc)
        {
            DBC = dbc;
            InitializeComponent();
            transacTable.AutoGenerateColumns = false;
            orderTable.AutoGenerateColumns = false;
            orderDetailTable.AutoGenerateColumns = false;
            // transac
            transacTable.Columns.Add(Main.createColumn("TransactionID", "Transaction ID"));
            transacTable.Columns.Add(Main.createColumn("RestaurantTable", "Table Name"));
            transacTable.Columns.Add(Main.createColumn("CustomerName", "Customer Name"));
            transacTable.Columns.Add(Main.createColumn("TransactionDateString", "Date"));
            transacTable.Columns.Add(Main.createColumn("TotalPriceString", "Total Price"));
            // order
            orderTable.Columns.Add(Main.createColumn("TransactionID", "Transaction ID"));
            orderTable.Columns.Add(Main.createColumn("OrderID", "Order ID"));
            orderTable.Columns.Add(Main.createColumn("OrderTimeString", "Order Time"));
            orderTable.Columns.Add(Main.createColumn("EmployeeName", "Input by Waitress"));
            orderTable.Columns.Add(Main.createColumn("TotalItems", "Number of Items Ordered"));
            // order details
            orderDetailTable.Columns.Add(Main.createColumn("OrderID", "Order ID"));
            orderDetailTable.Columns.Add(Main.createColumn("OrderDetailID", "Order Detail ID"));
            orderDetailTable.Columns.Add(Main.createColumn("MenuITemName", "Menu Name"));
            orderDetailTable.Columns.Add(Main.createColumn("Quantity", "Quantity"));
            orderDetailTable.Columns.Add(Main.createColumn("PriceString", "Price"));
            tableNames.ValueMember = "TableID";
            tableNames.DisplayMember = "Name";
            tableNames.Items.AddRange(
                DBC.RestaurantTables
                .ToArray().Prepend(new RestaurantTable { TableID = 0, Name = "All Tables" }).ToArray()
            );
            datePicker.Value = new DateTime(2025, 4, 20);
            tableNames.SelectedIndex = 0;

        }

        private void RefreshTransacs()
        {
            var query = DBC.Transactions.Include("Orders.OrderDetails").Include("RestaurantTable").AsQueryable();
            if (tableNames.SelectedItem != null && tableNames.SelectedIndex > 0)
            {
                var tableId = (tableNames.SelectedItem as RestaurantTable).TableID;
                query = query.Where(t => t.TableID == tableId);
            }
            var dateOnly = datePicker.Value.Date;
            var endDay = dateOnly.AddDays(1);
            query = query.Where(t => t.TransactionDate >= dateOnly && t.TransactionDate < endDay);
            transacTable.DataSource = query.ToList();
            transacTable[0, 0].Selected = true;
            onTransacCellClicked(this, new DataGridViewCellEventArgs(0, 0));
        }

        private void RefreshOrders(Transaction transac)
        {
            orderTable.DataSource = transac.Orders.ToList();
            if (orderTable.Rows.Count == 0)
            {
                orderDetailTable.DataSource = null;
                return;
            }
            orderTable[0, 0].Selected = true;
            onOrderCellClicked(this, new DataGridViewCellEventArgs(0, 0));
        }

        private void RefreshOrderDetails(Order order)
        {
            orderDetailTable.DataSource = order.OrderDetails.ToList();
        }

        private void onDateChanged(object sender, EventArgs e)
        {
            RefreshTransacs();
        }

        private void tableNameChanged(object sender, EventArgs e)
        {
            RefreshTransacs();
        }

        private void onOrderCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (orderTable.SelectedRows.Count == 0 || orderTable.SelectedRows[0] == null) return;
            var order = orderTable.SelectedRows[0].DataBoundItem as Order;
            RefreshOrderDetails(order);
        }

        private void onTransacCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (transacTable.SelectedRows.Count == 0 || transacTable.SelectedRows[0] == null) return;
            var transac = transacTable.SelectedRows[0].DataBoundItem as Transaction;
            RefreshOrders(transac);
        }
    }
}
