namespace El_Market
{
    partial class Category_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoriesDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.txtCategoryDesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.CategoriesDGV);
            this.panel1.Controls.Add(this.txtCategoryDesc);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCategoryID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(137, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 690);
            this.panel1.TabIndex = 0;
            // 
            // CategoriesDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CategoriesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoriesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesDGV.BackgroundColor = System.Drawing.Color.White;
            this.CategoriesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoriesDGV.ColumnHeadersHeight = 30;
            this.CategoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoriesDGV.EnableHeadersVisualStyles = false;
            this.CategoriesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesDGV.Location = new System.Drawing.Point(434, 85);
            this.CategoriesDGV.Name = "CategoriesDGV";
            this.CategoriesDGV.RowHeadersVisible = false;
            this.CategoriesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesDGV.Size = new System.Drawing.Size(665, 602);
            this.CategoriesDGV.TabIndex = 8;
            this.CategoriesDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CategoriesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoriesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoriesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoriesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoriesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.CategoriesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoriesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoriesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CategoriesDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CategoriesDGV.ThemeStyle.ReadOnly = false;
            this.CategoriesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CategoriesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick);
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
            this.txtCategoryDesc.Location = new System.Drawing.Point(156, 183);
            this.txtCategoryDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(221, 49);
            this.txtCategoryDesc.TabIndex = 2;
            this.txtCategoryDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(258, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(133, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(8, 273);
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
            this.label5.Location = new System.Drawing.Point(3, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
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
            this.txtCategoryName.Location = new System.Drawing.Point(156, 126);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(221, 49);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.White;
            this.txtCategoryID.HintForeColor = System.Drawing.Color.White;
            this.txtCategoryID.HintText = "";
            this.txtCategoryID.isPassword = false;
            this.txtCategoryID.LineFocusedColor = System.Drawing.Color.White;
            this.txtCategoryID.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryID.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCategoryID.LineThickness = 3;
            this.txtCategoryID.Location = new System.Drawing.Point(156, 69);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(221, 49);
            this.txtCategoryID.TabIndex = 0;
            this.txtCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 85);
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
            this.label2.Location = new System.Drawing.Point(398, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(595, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "El-Market";
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
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStaff.Location = new System.Drawing.Point(3, 143);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(119, 36);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnProducts.Location = new System.Drawing.Point(3, 185);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(119, 36);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Items";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.Location = new System.Drawing.Point(3, 227);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(119, 36);
            this.btnSelling.TabIndex = 5;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(3, 697);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 36);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageActive = null;
            this.btnLogo.Location = new System.Drawing.Point(12, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(100, 100);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 7;
            this.btnLogo.TabStop = false;
            this.btnLogo.Zoom = 10;
            // 
            // Category_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Category_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Category_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnLogout;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryDesc;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryName;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView CategoriesDGV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuImageButton btnLogo;
    }
}