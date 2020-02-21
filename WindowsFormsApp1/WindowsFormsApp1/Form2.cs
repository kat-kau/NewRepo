using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string imgPath = "imgs/";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source = 303-17\SQLSERVER; Initial Catalog = GIBDD; Integrated Security = true"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select id, name, surname, middlename, passport_serial, passport_number, postcode, address, address_life, company, jobname, phone, email, photo, description from [Drivers]", con);
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



                    dataGridView1.Rows[i].Cells[13].Value = Image.FromFile(imgPath + dr[13].ToString());
                            i++;
                        
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddDriver();
            ifrm.Show();
            this.Hide();
        }
    }
}
