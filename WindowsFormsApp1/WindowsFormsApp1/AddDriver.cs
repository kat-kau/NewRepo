using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }

        //INSERT Drivers(id, name, surname, middlename, passport_serial, passport_number, address, address_life, company, jobname, phone, email, photo, description) VALUES (5958, 'NorthWestern1', 'NorthWestern2','NorthWestern3', 6251,444466,'NorthWestern6','NorthWestern7','NorthWestern8','NorthWestern9','NorthWestern10','NorthWestern11','aaa@aaa.dd','dgfdgf.jpeg')
        private void button4_Click(object sender, EventArgs e)
        {
           /* using (SqlConnection con = new SqlConnection(@"Data Source = 303-17\SQLSERVER; Initial Catalog = GIBDD; Integrated Security = true"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT Region (id, name, surname, middlename, passport_serial, passport_number, address, address_life, company, jobname, phone, email, photo, description) VALUES (5, 'NorthWestern')", con);
                SqlDataReader dr = com.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dr[0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dr[1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dr[2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dr[3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dr[4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dr[5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dr[6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dr[7].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = dr[8].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = dr[9].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = dr[10].ToString();
                    dataGridView1.Rows[i].Cells[11].Value = dr[11].ToString();
                    dataGridView1.Rows[i].Cells[12].Value = dr[12].ToString();
                    dataGridView1.Rows[i].Cells[13].Value = Image.FromFile(@"C:\Users\1\Desktop\Задание\Ресурсы\Сессия 2\drivers 2\photo\" + dr[13].ToString());
                    dataGridView1.Rows[i].Cells[14].Value = dr[14].ToString();
                    i++;

                }

            }*/
        }
    }
}
