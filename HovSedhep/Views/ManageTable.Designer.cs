namespace HovSedhep.Views
{
    partial class ManageTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.custName = new System.Windows.Forms.TextBox();
            this.paxSize = new System.Windows.Forms.TextBox();
            this.waitress = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waitress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pax Size";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(30, 221);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 32);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.onCancel);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(216, 221);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(121, 32);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "OK";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.onConfirm);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(156, 78);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(181, 22);
            this.custName.TabIndex = 6;
            // 
            // paxSize
            // 
            this.paxSize.Location = new System.Drawing.Point(156, 131);
            this.paxSize.Name = "paxSize";
            this.paxSize.Size = new System.Drawing.Size(181, 22);
            this.paxSize.TabIndex = 7;
            // 
            // waitress
            // 
            this.waitress.FormattingEnabled = true;
            this.waitress.Location = new System.Drawing.Point(156, 35);
            this.waitress.Name = "waitress";
            this.waitress.Size = new System.Drawing.Size(181, 24);
            this.waitress.TabIndex = 8;
            // 
            // ManageTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 280);
            this.Controls.Add(this.waitress);
            this.Controls.Add(this.paxSize);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageTable";
            this.Text = "ManageTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox paxSize;
        private System.Windows.Forms.ComboBox waitress;
    }
}