using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMaket_project
{
    public partial class FormProducts : Form
    {
        connection con = new connection();
        public FormProducts()
            
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            SqlDataAdapter sda = con.command("Select * from SendProducts ");
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DisplayData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

           
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            con.delete("Delete  From SendProducts where prodName='" + textprodName.Text + "'");
           
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
            

            MessageBox.Show("Recods are deleted successfully");
            DisplayData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
           con.command("Update SendProducts set prodName ='" + textprodName.Text + "' where prodName ='" + textSearch.Text + "'");
           
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;


            MessageBox.Show("Recods are update successfully");
            DisplayData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            ;
            
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;

            DataTable dt = new DataTable();
            SqlDataAdapter sda = con.command("select * from SendProducts where prodName ='" + textSearch.Text + "'");

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
