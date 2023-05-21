namespace El_Market
{
    partial class Selling_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtItemQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdersDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.BillsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.txtCategoryDesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageActive = null;
            this.btnLogo.Location = new System.Drawing.Point(12, 14);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(100, 100);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 23;
            this.btnLogo.TabStop = false;
            this.btnLogo.Zoom = 10;
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.Black;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbSelectCategory.Location = new System.Drawing.Point(8, 337);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(210, 30);
            this.cbSelectCategory.TabIndex = 9;
            this.cbSelectCategory.Text = "Select Category";
            this.cbSelectCategory.SelectionChangeCommitted += new System.EventHandler(this.cbSelectCategory_SelectionChangeCommitted);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrice.ForeColor = System.Drawing.Color.White;
            this.txtItemPrice.HintForeColor = System.Drawing.Color.White;
            this.txtItemPrice.HintText = "";
            this.txtItemPrice.isPassword = false;
            this.txtItemPrice.LineFocusedColor = System.Drawing.Color.White;
            this.txtItemPrice.LineIdleColor = System.Drawing.Color.White;
            this.txtItemPrice.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtItemPrice.LineThickness = 3;
            this.txtItemPrice.Location = new System.Drawing.Point(156, 236);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(210, 49);
            this.txtItemPrice.TabIndex = 3;
            this.txtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQuantity.ForeColor = System.Drawing.Color.White;
            this.txtItemQuantity.HintForeColor = System.Drawing.Color.White;
            this.txtItemQuantity.HintText = "";
            this.txtItemQuantity.isPassword = false;
            this.txtItemQuantity.LineFocusedColor = System.Drawing.Color.White;
            this.txtItemQuantity.LineIdleColor = System.Drawing.Color.White;
            this.txtItemQuantity.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtItemQuantity.LineThickness = 3;
            this.txtItemQuantity.Location = new System.Drawing.Point(156, 182);
            this.txtItemQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(210, 49);
            this.txtItemQuantity.TabIndex = 2;
            this.txtItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(156, 236);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(193, 49);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // txtItemName
            // 
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.White;
            this.txtItemName.HintForeColor = System.Drawing.Color.White;
            this.txtItemName.HintText = "";
            this.txtItemName.isPassword = false;
            this.txtItemName.LineFocusedColor = System.Drawing.Color.White;
            this.txtItemName.LineIdleColor = System.Drawing.Color.White;
            this.txtItemName.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtItemName.LineThickness = 3;
            this.txtItemName.Location = new System.Drawing.Point(156, 125);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(210, 49);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selling";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.cbSelectCategory);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.OrdersDGV);
            this.panel1.Controls.Add(this.ItemDGV);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.txtItemQuantity);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Controls.Add(this.txtCategoryDesc);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(137, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 690);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OrdersDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersDGV.ColumnHeadersHeight = 30;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrdersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersDGV.EnableHeadersVisualStyles = false;
            this.OrdersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersDGV.Location = new System.Drawing.Point(404, 99);
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.RowHeadersVisible = false;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(698, 223);
            this.OrdersDGV.TabIndex = 8;
            this.OrdersDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.OrdersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrdersDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.OrdersDGV.ThemeStyle.ReadOnly = false;
            this.OrdersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrdersDGV.ThemeStyle.RowsStyle.Height = 22;
            this.OrdersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ItemID";
            this.ID.Name = "ID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // ItemDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ItemDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemDGV.ColumnHeadersHeight = 30;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemDGV.EnableHeadersVisualStyles = false;
            this.ItemDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemDGV.Location = new System.Drawing.Point(8, 387);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowHeadersVisible = false;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(358, 274);
            this.ItemDGV.TabIndex = 8;
            this.ItemDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ItemDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.ItemDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ItemDGV.ThemeStyle.ReadOnly = false;
            this.ItemDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ItemDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellContentClick);
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillsDGV.ColumnHeadersHeight = 30;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillsDGV.EnableHeadersVisualStyles = false;
            this.BillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.Location = new System.Drawing.Point(404, 415);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(695, 223);
            this.BillsDGV.TabIndex = 8;
            this.BillsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.BillsDGV.ThemeStyle.ReadOnly = false;
            this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDesc.ForeColor = System.Drawing.Color.White;
            this.txtCategoryDesc.HintForeColor = System.Drawing.Color.White;
            this.txtCategoryDesc.HintText = "";
            this.txtCategoryDesc.isPassword = false;
            this.txtCategoryDesc.LineFocusedColor = System.Drawing.Color.White;
            this.txtCategoryDesc.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryDesc.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCategoryDesc.LineThickness = 3;
            this.txtCategoryDesc.Location = new System.Drawing.Point(156, 182);
            this.txtCategoryDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(193, 49);
            this.txtCategoryDesc.TabIndex = 7;
            this.txtCategoryDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.Location = new System.Drawing.Point(791, 644);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 36);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(247, 335);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProduct.Location = new System.Drawing.Point(99, 295);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(201, 36);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Item";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(557, 644);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.White;
            this.txtCategoryName.HintForeColor = System.Drawing.Color.White;
            this.txtCategoryName.HintText = "";
            this.txtCategoryName.isPassword = false;
            this.txtCategoryName.LineFocusedColor = System.Drawing.Color.White;
            this.txtCategoryName.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryName.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCategoryName.LineThickness = 3;
            this.txtCategoryName.Location = new System.Drawing.Point(156, 125);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(193, 49);
            this.txtCategoryName.TabIndex = 7;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtBillID
            // 
            this.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.ForeColor = System.Drawing.Color.White;
            this.txtBillID.HintForeColor = System.Drawing.Color.White;
            this.txtBillID.HintText = "";
            this.txtBillID.isPassword = false;
            this.txtBillID.LineFocusedColor = System.Drawing.Color.White;
            this.txtBillID.LineIdleColor = System.Drawing.Color.White;
            this.txtBillID.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtBillID.LineThickness = 3;
            this.txtBillID.Location = new System.Drawing.Point(156, 68);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(210, 49);
            this.txtBillID.TabIndex = 0;
            this.txtBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bill ID";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.DarkOrange;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(798, 327);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(24, 25);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkOrange;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(749, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "List";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.DarkOrange;
            this.lblStaffName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(7, 7);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(124, 25);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(982, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(662, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount";
            // 
            // btnItems
            // 
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnItems.Location = new System.Drawing.Point(3, 229);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(119, 36);
            this.btnItems.TabIndex = 18;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.Location = new System.Drawing.Point(3, 187);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(128, 36);
            this.btnCategories.TabIndex = 19;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStaff.Location = new System.Drawing.Point(3, 145);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 36);
            this.btnStaff.TabIndex = 20;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1249, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(596, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "El-Market";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(3, 699);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 36);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // Selling_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Selling_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling_Form";
            this.Load += new System.EventHandler(this.Selling_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnLogo;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView BillsDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryDesc;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnStaff;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private Guna.UI.WinForms.GunaDataGridView OrdersDGV;
        private Guna.UI.WinForms.GunaDataGridView ItemDGV;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
    }
}