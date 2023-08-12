namespace Northwind.WebForms
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityperUnit = new System.Windows.Forms.Label();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.cbxCategory2 = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStok = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnit3 = new System.Windows.Forms.TextBox();
            this.tbxUnitStock3 = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice3 = new System.Windows.Forms.TextBox();
            this.cbxCategory3 = new System.Windows.Forms.ComboBox();
            this.tbxProductName3 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit3 = new System.Windows.Forms.Label();
            this.lblUnitStock3 = new System.Windows.Forms.Label();
            this.lblUnitPrice3 = new System.Windows.Forms.Label();
            this.lblCategory3 = new System.Windows.Forms.Label();
            this.lblProductName3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 225);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(732, 273);
            this.dgwProduct.TabIndex = 1;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(732, 101);
            this.gbxCategory.TabIndex = 2;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(154, 39);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(289, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 48);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxSearch);
            this.gbxProductName.Controls.Add(this.lblSearch);
            this.gbxProductName.Location = new System.Drawing.Point(12, 119);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(732, 100);
            this.gbxProductName.TabIndex = 3;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "İsme Göre Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(154, 43);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(289, 22);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(24, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStok);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxCategory2);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityperUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryName);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(751, 13);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(501, 230);
            this.gbxProductAdd.TabIndex = 4;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 42);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(33, 75);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(62, 16);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(33, 110);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(36, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(33, 142);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 16);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblQuantityperUnit
            // 
            this.lblQuantityperUnit.AutoSize = true;
            this.lblQuantityperUnit.Location = new System.Drawing.Point(33, 183);
            this.lblQuantityperUnit.Name = "lblQuantityperUnit";
            this.lblQuantityperUnit.Size = new System.Drawing.Size(76, 16);
            this.lblQuantityperUnit.TabIndex = 4;
            this.lblQuantityperUnit.Text = "Birim Adedi";
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(169, 35);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(150, 22);
            this.tbxProductName2.TabIndex = 5;
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(169, 66);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(150, 24);
            this.cbxCategory2.TabIndex = 6;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(169, 107);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(150, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxStok
            // 
            this.tbxStok.Location = new System.Drawing.Point(169, 139);
            this.tbxStok.Name = "tbxStok";
            this.tbxStok.Size = new System.Drawing.Size(150, 22);
            this.tbxStok.TabIndex = 8;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(169, 180);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(150, 22);
            this.tbxQuantityPerUnit.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(365, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 81);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnit3);
            this.groupBox1.Controls.Add(this.tbxUnitStock3);
            this.groupBox1.Controls.Add(this.tbxUnitPrice3);
            this.groupBox1.Controls.Add(this.cbxCategory3);
            this.groupBox1.Controls.Add(this.tbxProductName3);
            this.groupBox1.Controls.Add(this.lblQuantityPerUnit3);
            this.groupBox1.Controls.Add(this.lblUnitStock3);
            this.groupBox1.Controls.Add(this.lblUnitPrice3);
            this.groupBox1.Controls.Add(this.lblCategory3);
            this.groupBox1.Controls.Add(this.lblProductName3);
            this.groupBox1.Location = new System.Drawing.Point(751, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(365, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 81);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityPerUnit3
            // 
            this.tbxQuantityPerUnit3.Location = new System.Drawing.Point(169, 180);
            this.tbxQuantityPerUnit3.Name = "tbxQuantityPerUnit3";
            this.tbxQuantityPerUnit3.Size = new System.Drawing.Size(150, 22);
            this.tbxQuantityPerUnit3.TabIndex = 9;
            // 
            // tbxUnitStock3
            // 
            this.tbxUnitStock3.Location = new System.Drawing.Point(169, 139);
            this.tbxUnitStock3.Name = "tbxUnitStock3";
            this.tbxUnitStock3.Size = new System.Drawing.Size(150, 22);
            this.tbxUnitStock3.TabIndex = 8;
            // 
            // tbxUnitPrice3
            // 
            this.tbxUnitPrice3.Location = new System.Drawing.Point(169, 107);
            this.tbxUnitPrice3.Name = "tbxUnitPrice3";
            this.tbxUnitPrice3.Size = new System.Drawing.Size(150, 22);
            this.tbxUnitPrice3.TabIndex = 7;
            // 
            // cbxCategory3
            // 
            this.cbxCategory3.FormattingEnabled = true;
            this.cbxCategory3.Location = new System.Drawing.Point(169, 66);
            this.cbxCategory3.Name = "cbxCategory3";
            this.cbxCategory3.Size = new System.Drawing.Size(150, 24);
            this.cbxCategory3.TabIndex = 6;
            // 
            // tbxProductName3
            // 
            this.tbxProductName3.Location = new System.Drawing.Point(169, 35);
            this.tbxProductName3.Name = "tbxProductName3";
            this.tbxProductName3.Size = new System.Drawing.Size(150, 22);
            this.tbxProductName3.TabIndex = 5;
            // 
            // lblQuantityPerUnit3
            // 
            this.lblQuantityPerUnit3.AutoSize = true;
            this.lblQuantityPerUnit3.Location = new System.Drawing.Point(33, 183);
            this.lblQuantityPerUnit3.Name = "lblQuantityPerUnit3";
            this.lblQuantityPerUnit3.Size = new System.Drawing.Size(76, 16);
            this.lblQuantityPerUnit3.TabIndex = 4;
            this.lblQuantityPerUnit3.Text = "Birim Adedi";
            // 
            // lblUnitStock3
            // 
            this.lblUnitStock3.AutoSize = true;
            this.lblUnitStock3.Location = new System.Drawing.Point(33, 142);
            this.lblUnitStock3.Name = "lblUnitStock3";
            this.lblUnitStock3.Size = new System.Drawing.Size(73, 16);
            this.lblUnitStock3.TabIndex = 3;
            this.lblUnitStock3.Text = "Stok Adedi";
            // 
            // lblUnitPrice3
            // 
            this.lblUnitPrice3.AutoSize = true;
            this.lblUnitPrice3.Location = new System.Drawing.Point(33, 110);
            this.lblUnitPrice3.Name = "lblUnitPrice3";
            this.lblUnitPrice3.Size = new System.Drawing.Size(36, 16);
            this.lblUnitPrice3.TabIndex = 2;
            this.lblUnitPrice3.Text = "Fiyat";
            // 
            // lblCategory3
            // 
            this.lblCategory3.AutoSize = true;
            this.lblCategory3.Location = new System.Drawing.Point(33, 75);
            this.lblCategory3.Name = "lblCategory3";
            this.lblCategory3.Size = new System.Drawing.Size(62, 16);
            this.lblCategory3.TabIndex = 1;
            this.lblCategory3.Text = "Category";
            // 
            // lblProductName3
            // 
            this.lblProductName3.AutoSize = true;
            this.lblProductName3.Location = new System.Drawing.Point(33, 42);
            this.lblProductName3.Name = "lblProductName3";
            this.lblProductName3.Size = new System.Drawing.Size(58, 16);
            this.lblProductName3.TabIndex = 0;
            this.lblProductName3.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblQuantityperUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStok;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategory2;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit3;
        private System.Windows.Forms.TextBox tbxUnitStock3;
        private System.Windows.Forms.TextBox tbxUnitPrice3;
        private System.Windows.Forms.ComboBox cbxCategory3;
        private System.Windows.Forms.TextBox tbxProductName3;
        private System.Windows.Forms.Label lblQuantityPerUnit3;
        private System.Windows.Forms.Label lblUnitStock3;
        private System.Windows.Forms.Label lblUnitPrice3;
        private System.Windows.Forms.Label lblCategory3;
        private System.Windows.Forms.Label lblProductName3;
    }
}

