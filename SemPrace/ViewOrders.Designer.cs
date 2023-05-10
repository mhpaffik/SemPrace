namespace SemPrace
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            orderListDGV = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cust_id = new DataGridViewTextBoxColumn();
            cust_name = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            printOrders = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)orderListDGV).BeginInit();
            SuspendLayout();
            // 
            // orderListDGV
            // 
            orderListDGV.AllowUserToAddRows = false;
            orderListDGV.AllowUserToDeleteRows = false;
            orderListDGV.AllowUserToResizeColumns = false;
            orderListDGV.AllowUserToResizeRows = false;
            orderListDGV.BackgroundColor = Color.White;
            orderListDGV.BorderStyle = BorderStyle.None;
            orderListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            orderListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            orderListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderListDGV.Columns.AddRange(new DataGridViewColumn[] { id, cust_id, cust_name, date, dataGridViewTextBoxColumn5 });
            orderListDGV.Location = new Point(64, 70);
            orderListDGV.MultiSelect = false;
            orderListDGV.Name = "orderListDGV";
            orderListDGV.ReadOnly = true;
            orderListDGV.RowHeadersVisible = false;
            orderListDGV.RowTemplate.Height = 25;
            orderListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderListDGV.Size = new Size(648, 551);
            orderListDGV.TabIndex = 54;
            orderListDGV.CellContentClick += orderListDGV_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // cust_id
            // 
            cust_id.HeaderText = "Cust Id";
            cust_id.Name = "cust_id";
            cust_id.ReadOnly = true;
            cust_id.Width = 50;
            // 
            // cust_name
            // 
            cust_name.HeaderText = "Cust Name";
            cust_name.Name = "cust_name";
            cust_name.ReadOnly = true;
            cust_name.Width = 170;
            // 
            // date
            // 
            date.HeaderText = "Order Date";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 210;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // printOrders
            // 
            printOrders.DocumentName = "Orders";
            printOrders.PrintPage += printOrders_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Document = printOrders;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 668);
            Controls.Add(orderListDGV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            ((System.ComponentModel.ISupportInitialize)orderListDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderListDGV;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cust_id;
        private DataGridViewTextBoxColumn cust_name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Drawing.Printing.PrintDocument printOrders;
        private PrintPreviewDialog printPreviewDialog;
    }
}