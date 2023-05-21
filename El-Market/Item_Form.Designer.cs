namespace El_Market
{
    partial class Item_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ItemsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.txtItemQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCategoryDesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageActive = null;
            this.btnLogo.Location = new System.Drawing.Point(12, 15);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(100, 100);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 15;
            this.btnLogo.TabStop = false;
            this.btnLogo.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.cbSearchCategory);
            this.panel1.Controls.Add(this.cbSelectCategory);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.ItemsDGV);
            this.panel1.Controls.Add(this.txtItemQuantity);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Controls.Add(this.txtCategoryDesc);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(137, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 690);
            this.panel1.TabIndex = 8;
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbSearchCategory.Location = new System.Drawing.Point(634, 46);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(210, 30);
            this.cbSearchCategory.TabIndex = 9;
            this.cbSearchCategory.Text = "Select Category";
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            this.cbSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.cbSearchCategory_SelectionChangeCommitted);
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.Black;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbSelectCategory.Location = new System.Drawing.Point(156, 306);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(210, 30);
            this.cbSelectCategory.TabIndex = 9;
            this.cbSelectCategory.Text = "Select Category";
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
            this.txtItemPrice.Location = new System.Drawing.Point(156, 234);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(210, 49);
            this.txtItemPrice.TabIndex = 3;
            this.txtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ItemsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDGV.ColumnHeadersHeight = 30;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDGV.EnableHeadersVisualStyles = false;
            this.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.Location = new System.Drawing.Point(434, 82);
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.RowHeadersVisible = false;
            this.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDGV.Size = new System.Drawing.Size(665, 602);
            this.ItemsDGV.TabIndex = 8;
            this.ItemsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.ItemsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ItemsDGV.ThemeStyle.ReadOnly = false;
            this.ItemsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ItemsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDGV_CellContentClick);
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
            this.txtItemQuantity.Location = new System.Drawing.Point(156, 180);
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
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(156, 234);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(193, 49);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtCategoryDesc.Location = new System.Drawing.Point(156, 180);
            this.txtCategoryDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(193, 49);
            this.txtCategoryDesc.TabIndex = 7;
            this.txtCategoryDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(258, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(133, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Category";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(862, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 36);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(8, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 250);
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
            this.txtItemName.Location = new System.Drawing.Point(156, 123);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(210, 49);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 196);
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
            this.txtCategoryName.Location = new System.Drawing.Point(156, 123);
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
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.ForeColor = System.Drawing.Color.White;
            this.txtItemID.HintForeColor = System.Drawing.Color.White;
            this.txtItemID.HintText = "";
            this.txtItemID.isPassword = false;
            this.txtItemID.LineFocusedColor = System.Drawing.Color.White;
            this.txtItemID.LineIdleColor = System.Drawing.Color.White;
            this.txtItemID.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtItemID.LineThickness = 3;
            this.txtItemID.Location = new System.Drawing.Point(156, 66);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(210, 49);
            this.txtItemID.TabIndex = 0;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Items";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(3, 700);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.Location = new System.Drawing.Point(3, 230);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(119, 36);
            this.btnSelling.TabIndex = 10;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.Location = new System.Drawing.Point(3, 188);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(128, 36);
            this.btnCategories.TabIndex = 11;
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
            this.btnStaff.Location = new System.Drawing.Point(3, 146);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 36);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1249, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(596, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "El-Market";
            // 
            // Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Item_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Form";
            this.Load += new System.EventHandler(this.Item_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnLogo;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView ItemsDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryDesc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnStaff;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemName;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.Button btnRefresh;
    }
}