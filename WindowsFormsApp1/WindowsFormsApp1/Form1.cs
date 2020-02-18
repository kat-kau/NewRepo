using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using REG_MARK_LIB;
using VIN_LIB;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
             Class1 vinLib = new Class1();
             if (vinLib.CheckVIN(textBox1.Text))
             {
                 MessageBox.Show("VIN верный!");
             } else
             {
                 MessageBox.Show("VIN не верный!");
             } 
        } */

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string your_user_name = textLogin.ToString();
            string your_password = textPassword.ToString();
            using (SqlConnection con = new SqlConnection(@"Data Source = 303-17\SQLSERVER; Initial Catalog = GIBDD; Integrated Security = true"))
            {
                con.Open();
                string sqlcommand = "SELECT COUNT(login, password) FROM Users WHERE login=" + your_user_name + " AND password=" + your_password;
                SqlCommand com = new SqlCommand(sqlcommand, con);
                object value = com.ExecuteScalar();
                con.Close();
                if (value.ToString() == "0")
                {
                    MessageBox.Show("Успешная авторизация!");
                }
            }
        }
    }
}
