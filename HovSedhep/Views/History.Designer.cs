namespace HovSedhep.Views
{
    partial class History
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.transacTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.orderDetailTable = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tableNames = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transacTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableNames);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transacTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(811, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orderTable);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox3.Size = new System.Drawing.Size(811, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.orderDetailTable);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox4.Size = new System.Drawing.Size(811, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // transacTable
            // 
            this.transacTable.AllowUserToAddRows = false;
            this.transacTable.AllowUserToDeleteRows = false;
            this.transacTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transacTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transacTable.Location = new System.Drawing.Point(8, 23);
            this.transacTable.MultiSelect = false;
            this.transacTable.Name = "transacTable";
            this.transacTable.ReadOnly = true;
            this.transacTable.RowHeadersWidth = 51;
            this.transacTable.RowTemplate.Height = 24;
            this.transacTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transacTable.Size = new System.Drawing.Size(795, 119);
            this.transacTable.TabIndex = 0;
            this.transacTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onTransacCellClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table Name";
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTable.Location = new System.Drawing.Point(8, 23);
            this.orderTable.MultiSelect = false;
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersWidth = 51;
            this.orderTable.RowTemplate.Height = 24;
            this.orderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderTable.Size = new System.Drawing.Size(795, 119);
            this.orderTable.TabIndex = 1;
            this.orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onOrderCellClicked);
            // 
            // orderDetailTable
            // 
            this.orderDetailTable.AllowUserToAddRows = false;
            this.orderDetailTable.AllowUserToDeleteRows = false;
            this.orderDetailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailTable.Location = new System.Drawing.Point(8, 23);
            this.orderDetailTable.MultiSelect = false;
            this.orderDetailTable.Name = "orderDetailTable";
            this.orderDetailTable.ReadOnly = true;
            this.orderDetailTable.RowHeadersWidth = 51;
            this.orderDetailTable.RowTemplate.Height = 24;
            this.orderDetailTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailTable.Size = new System.Drawing.Size(795, 119);
            this.orderDetailTable.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(122, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.onDateChanged);
            // 
            // tableNames
            // 
            this.tableNames.DisplayMember = "Name";
            this.tableNames.FormattingEnabled = true;
            this.tableNames.Location = new System.Drawing.Point(122, 73);
            this.tableNames.Name = "tableNames";
            this.tableNames.Size = new System.Drawing.Size(200, 24);
            this.tableNames.TabIndex = 3;
            this.tableNames.ValueMember = "TableID";
            this.tableNames.SelectedValueChanged += new System.EventHandler(this.tableNameChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "History";
            this.Size = new System.Drawing.Size(811, 579);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transacTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView transacTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tableNames;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.DataGridView orderDetailTable;
    }
}
