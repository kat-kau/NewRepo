using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            /* Class1 vinLib = new Class1();
             if (vinLib.CheckVIN(textBox1.Text))
             {
                 MessageBox.Show("VIN верный!");
             } else
             {
                 MessageBox.Show("VIN не верный!");
             } */

            if (CheckVIN(textBox1.Text))
            {
                MessageBox.Show("VIN верный!");
            }
            else
            {
                MessageBox.Show("VIN не верный!");
            }
        }
    }
}
