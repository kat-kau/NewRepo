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
using System.Configuration;

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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //SELECT COUNT(*) FROM Users WHERE login LIKE 'inspector' AND password LIKE 'inspector'
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.attempts.ToString());
            string userName = textLogin.Text;
            string password = textPassword.Text;
            using (SqlConnection con = new SqlConnection(@"Data Source = 303-17\SQLSERVER; Initial Catalog = GIBDD; Integrated Security = true"))
            {
                con.Open();
                string sqlcommand = "SELECT COUNT(*) FROM Users WHERE login='" + userName + "' AND password='" + password + "'";
                SqlCommand com = new SqlCommand(sqlcommand, con);
                object value = com.ExecuteScalar();

                if (value.ToString() != "0")
                {
                    MessageBox.Show("Авторизация успешна!");
                }
                else
                {
                    if (Properties.Settings.Default.time <= DateTime.UtcNow)
                    {
                        Properties.Settings.Default.attempts++;
                        if (Properties.Settings.Default.attempts == 3)
                        {
                            Properties.Settings.Default.time = DateTime.UtcNow.AddMinutes(1);
                            buttonLogin.Enabled = false;
                            label5.Visible = true;
                        }

                    }
                    MessageBox.Show("Ошибка логина или пароля! Введите данные заново");
                }
                Properties.Settings.Default.Save();
                con.Close();
            }
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {

            MessageBox.Show(Properties.Settings.Default.attempts.ToString());
            if (Properties.Settings.Default.attempts == 3)
            {
                buttonLogin.Enabled = false;
                label5.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.time <= DateTime.UtcNow)
            {
                Properties.Settings.Default.attempts = 0;
                buttonLogin.Enabled = true;
                label5.Visible = false;
            }
        }
    }
}