using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestirovanieNik.Models;

namespace TestirovanieNik
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            Dictionary<int, string> loadComboBox = new Dictionary<int, string>();
            foreach (TypeProduct typeProduct in MainPage.TypeList)
            {
                loadComboBox.Add(typeProduct.IdType, typeProduct.NameType);
            }
            loadComboBox.Add(0, "Все типы");
            comboBoxTypeProduct.DataSource = new BindingSource(loadComboBox, null);
            comboBoxTypeProduct.DisplayMember = "Value";
            comboBoxTypeProduct.ValueMember = "Key";
            comboBoxTypeProduct.SelectedIndex = loadComboBox.Count - 1;

        }
        Product productData = new Product();
        public void LoadData()
        {
            List<Product> products = MainPage.db.Products.ToList();


            foreach (Product product in products)
            {
                if(product.IdProduct == TestJSonContext.idProduct)
                {
                    NameProductTx.Text = product.NameProduct;
                    PriceProductTx.Text =  product.Price;
                    comboBoxTypeProduct.SelectedItem = product.TypeId;//Доделать
                    productData = product;
                }
            }
        }
        
        public void EditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainPage.EditBt.Enabled = true;
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            int idType = ((KeyValuePair<int, string>)comboBoxTypeProduct.SelectedItem).Key; 
            Product updateProduct = MainPage.db.Products.SingleOrDefault(u => u.IdProduct == productData.IdProduct);
            updateProduct.NameProduct = NameProductTx.Text;
            updateProduct.Price = Convert.ToDecimal(PriceProductTx.Text).ToString();
            updateProduct.TypeId = idType;
            MainPage.db.Products.Update(updateProduct);
            MainPage.db.SaveChanges();
            this.Close();
        }
    }
}
