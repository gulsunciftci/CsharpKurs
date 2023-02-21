using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();


        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList(); //collectiondan alınıyor
                                                                                                              //C# küçük büyük harf duyarlıdır
            var result = _productDal.GetByName(key); //veri tabanından veriler alınıyor(linq ile)
            dgwProducts.DataSource = result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {

                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)

            });
            LoadProducts();
            MessageBox.Show("Added");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

            });
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id= Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
