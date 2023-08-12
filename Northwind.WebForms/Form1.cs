using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntitiyFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebForms
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategory2.DataSource = _categoryService.GetAll();
            cbxCategory2.DisplayMember = "CategoryName";
            cbxCategory2.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSearch.Text))
            {
                LoadProducts();
            }
            else
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxSearch.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategory2.SelectedValue),
                ProductName = tbxProductName2.Text,
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxStok.Text)
            });

            MessageBox.Show("Ürün Kaydedildi");

            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategory3.SelectedValue),
                ProductName = tbxProductName3.Text,
                QuantityPerUnit = tbxQuantityPerUnit3.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice3.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitStock3)
            });

            MessageBox.Show("Ürün Güncellendi");

            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
