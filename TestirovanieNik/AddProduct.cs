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
    public partial class AddProduct : Form
    {

        public AddProduct()
        {
            InitializeComponent();
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
        private void AddBt_Click(object sender, EventArgs e)
        {
            try
            {
                int idType = ((KeyValuePair<int, string>)comboBoxTypeProduct.SelectedItem).Key;

                Product product = new Product()
                {
                    NameProduct = NameProductTx.Text,
                    Price = Convert.ToDecimal(PriceProductTx.Text).ToString(),
                    TypeId = idType
                };
                MainPage.db.Products.Add(product);
                MainPage.db.SaveChanges();
                MessageBox.Show("Добавленно");
            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
            
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
           //MainPage.AddBt.Enabled = true;
        }

        private void PriceProductTx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameProductTx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
