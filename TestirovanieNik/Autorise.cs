using Microsoft.Data.SqlClient;
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
    public partial class Autorise : Form
    {

        SqlConnection connection = new SqlConnection(TestJSonContext.connectionString);
        public Autorise()
        {
            InitializeComponent();
            connection.Open();
        }

        private void SingInBt_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string sqlCommand = $"SELECT NameRole FROM [dbo].[Users] " +
                $"join Roles on IdRole = RoleId " +
                $"where Login = '{LoginTx.Text}' and Password = '{PasswordTx.Text}'"; 
            SqlCommand command = new SqlCommand(sqlCommand,connection);
            
            dataTable.Load(command.ExecuteReader());
            string value = dataTable.Rows[0].ItemArray[0].ToString();
            if (dataTable.Rows.Count > 0)
            {
                if (value == "Admin")
                {

                }
                if (value == "User")
                {
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    mainPage.Owner = this;
                    this.Visible = false;
                }
                if (value == "SisAdmin")
                {

                }
            }
        }
    }
}
