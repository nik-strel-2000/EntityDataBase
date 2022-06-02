using Microsoft.Data.SqlClient;
using System.Data;
using TestirovanieNik.Models;

namespace TestirovanieNik
{
    public partial class MainPage : Form
    {
        SqlConnection connection = new SqlConnection(TestJSonContext.connectionString);
        public MainPage()
        {
            connection.Open();
            InitializeComponent();
            LoadComboBox();
            LoadDataGrid();
        }
        public static TestJSonContext db = new TestJSonContext();
        public List<User> UserList = new List<User>();
        public static List<Product> ProductList = new List<Product>();
        public static List<TypeProduct> TypeList = new List<TypeProduct>();
        public List<ProductFull> ProductFullsList = new List<ProductFull>();
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
        public DataTable dataTableProduct = new DataTable();

        public void LoadDataGrid()
        {
            string sql = "SELECT [IdProduct],[NameProduct],[Price],[NameType] FROM [dbo].[Products] join TypeProduct on IdType = TypeId";
            SqlCommand command = new SqlCommand(sql, connection);
            dataTableProduct.Load(command.ExecuteReader());
            ProductList = db.Products.ToList();
            dataGridViewProduct.DataSource = dataTableProduct;
            ProductFullsList = dataTableProduct.AsEnumerable().Select(n => new ProductFull()
            {
                IdProduct = n.Field<int>("IdProduct"),
                NameProduct = n.Field<string>("NameProduct"),
                Price = n.Field<string>("Price"),
                TypeName = n.Field<string>("NameType")
            }).ToList();


        }
      
        public void LoadComboBox()
        {

            TypeList = db.TypeProducts.ToList();

            Dictionary<int, string> loadComboBox = new Dictionary<int, string>();
            foreach (TypeProduct typeProduct in TypeList)
            {
                loadComboBox.Add(typeProduct.IdType, typeProduct.NameType);
            }
            loadComboBox.Add(0, "Все типы");
            comboBoxType.DataSource = new BindingSource(loadComboBox, null);
            comboBoxType.DisplayMember = "Value";
            comboBoxType.ValueMember = "Key";
            comboBoxType.SelectedIndex = loadComboBox.Count - 1;

        }
        private void SoursTx_TextChanged(object sender, EventArgs e)
        {
            List<ProductFull> newProducts = new List<ProductFull>();
            foreach(ProductFull product in ProductFullsList)
            {
                int item = product.NameProduct.IndexOf(SoursTx.Text);
                if(item > -1)
                {
                    newProducts.Add(product);
                }
            }
            dataGridViewProduct.DataSource = newProducts;
        }

        private void checkBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = null;
            LoadDataGrid();
        }

        private void AddTx_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            addProduct.Owner = this;
          //  AddBt.Enabled = false;
        }
        
        private void EditTx_Click(object sender, EventArgs e)
        {
            try
            {
                TestJSonContext.idProduct = Convert.ToInt32(dataGridViewProduct.CurrentRow.Cells[0].Value);
                EditProduct editProduct = new EditProduct();
                editProduct.Show();
                editProduct.Owner = this;
               // EditBt.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }
           
        }

        private void DeleteTx_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Вы уверенны","dELETE",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectProduct = Convert.ToInt32(dataGridViewProduct.CurrentRow.Cells[0].Value);
                Product deleteProduct = MainPage.db.Products.SingleOrDefault(u => u.IdProduct == selectProduct);
                MainPage.db.Products.Remove(deleteProduct);
                MainPage.db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ну нет так нет");
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxSort.Checked)
            {
                int idType = ((KeyValuePair<int, string>)comboBoxType.SelectedItem).Key;

                DataTable dataTable = new DataTable();
                string sql = "SELECT [IdProduct],[NameProduct],[Price],[NameType] " +
                    "FROM [dbo].[Products] " +
                    $"join TypeProduct on IdType = TypeId where TypeId = {idType}";
                SqlCommand command = new SqlCommand(sql, connection);
                dataTable.Load(command.ExecuteReader());
                dataGridViewProduct.DataSource = dataTable;
            }
        }

        private void dataGridViewProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridViewProduct.RowCount-1; i++)
            {
                string type = dataGridViewProduct.Rows[i].Cells[3].Value.ToString();
                if (type == "Еда")
                {

                    dataGridViewProduct.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }

            }
        }
    }
}