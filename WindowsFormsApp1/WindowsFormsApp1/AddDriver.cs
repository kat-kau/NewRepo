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
             using (SqlConnection con = new SqlConnection(@"Data Source = 303-17\SQLSERVER; Initial Catalog = GIBDD; Integrated Security = true"))
             {
                 con.Open();
                 SqlCommand com = new SqlCommand("INSERT Drivers(id, name, surname, middlename, passport_serial, passport_number, address, address_life, company, jobname, phone, email, photo, description) VALUES (597, 'NorthWestern1', 'NorthWestern2','NorthWestern3', 6251,444466,'NorthWestern6','NorthWestern7','NorthWestern8','NorthWestern9','NorthWestern10','NorthWestern11','aaa@aaa.dd','001-happy-18.png')", con);
                 com.ExecuteNonQuery();
                 con.Close();
             }
        }
    }
}
