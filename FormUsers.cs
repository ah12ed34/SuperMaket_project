using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SuperMaket_project.Facade;
using System.Globalization;

namespace SuperMaket_project
{
    public partial class FormUsers : Form
    {
        FEmployee fEmp = new FEmployee();
        security security = new security();
        Filtel filtel = new Filtel();
        public FormUsers()
        {
            InitializeComponent();
           
        }
        DataTable dt = new DataTable();
        public void DisplayData()
        {
            SqlDataAdapter sda = fEmp.getAll();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {  
<<<<<<< HEAD
            comboBGander.SelectedIndex = 0;
=======
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
            dataGridView1.MultiSelect = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
          
            
            DisplayData();
           
        }

        private void buttonUPdate_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clear()
        {
            txtUserName.Text = "";
            txtFullName.Text = "";
            textBCity.Text = "";
            txtPhone.Text = "";
            textPass.Text = "";
        }
        private void btnAddUSR_Click(object sender, EventArgs e)
        {

            if (filtel.isEmail(textBEmail.Text))
            {
<<<<<<< HEAD
                decimal phone = Convert.ToDecimal(txtPhone.Text);
=======
                int phone = Convert.ToInt32(txtPhone.Text);
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
                decimal snn = Convert.ToDecimal(textBSSN.Text);
                float salary = float.Parse(textBSelery.Text, CultureInfo.InvariantCulture.NumberFormat);
                //int emial = Convert.ToInt32(txtEmail.Text);
                if (fEmp.Add(txtFullName.Text, txtUserName.Text, textPass.Text, textBStreet.Text, textBCity.Text, phone, comboBGander.Text, textBEmail.Text, snn, salary, dateTimePicker1.Value, isLogin.Checked))
                {
                    
                    clear();

                    MessageBox.Show("Recods are entered successfully");
                    DisplayData();

                }
            }
            else
            {
                MessageBox.Show("Not Email");
            }
           
            
               
    }

<<<<<<< HEAD
=======
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            if (dataGridView1.SelectedRows[0].Index >= 0)
            {
                //int phone = Convert.ToInt32(txtPhone.Text);
                //con.command("Update LoginUsers set UserName ='" + txtUserName.Text + "',FullName = N'" + txtFullName.Text + "',Address = N'" + textBCity.Text + "',Phone = '" + phone + "',Password = '" + security.Encrypt(textPass.Text) + "' where id ='" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value + "'"); ;
                int phone = Convert.ToInt32(txtPhone.Text);
                decimal snn = Convert.ToDecimal(textBSSN.Text);
                float salary = float.Parse(textBSelery.Text, CultureInfo.InvariantCulture.NumberFormat);
                //int emial = Convert.ToInt32(txtEmail.Text);
                if (fEmp.updata(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value),txtFullName.Text, txtUserName.Text, textPass.Text, textBStreet.Text, textBCity.Text, phone, comboBGander.Text, textBEmail.Text, snn, salary, dateTimePicker1.Value, isLogin.Checked))
                { clear();
                //price = 0;
                //bareCode = 0;
                //qoulty = 0;


                MessageBox.Show("Recods are update successfully");

                }
                   
            DisplayData();

            }
            else
            {
                MessageBox.Show("Selected frsitly");
            }
            
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {

            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            if (dataGridView1.SelectedRows[0].Index >= 0)
            {
                if(fEmp.delete(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value)))
                { clear();


                //price = 0;
                //bareCode = 0;
                //qoulty = 0;


                MessageBox.Show("Recods are Delete successfully");

                }
               
                DisplayData();

            }
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            try
            {
                if(e.RowIndex>=0&e.RowIndex<=dataGridView1.RowCount)
                if (dataGridView1.Rows[e.RowIndex] != null)
            {
              
                dataGridView1.CurrentRow.Selected = true;
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells["user"].Value.ToString();
<<<<<<< HEAD
                txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                textBCity.Text = dataGridView1.Rows[e.RowIndex].Cells["city"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                textPass.Text = security.Decrypt( dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                textBStreet.Text = dataGridView1.Rows[e.RowIndex].Cells["street"].Value.ToString();
                textBEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["start_date"].Value);
                isLogin.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["login"].Value);

                    }
=======
                txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textPass.Text = security.Decrypt( dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
              

            }
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+e.RowIndex);
            }
            
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
<<<<<<< HEAD
            //filtel.whriteNumber(e); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmp.delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            DisplayData();
        }

        private void textBSelery_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtel.whriteNumber(e);
=======
            filtel.whriteNumber(e); 
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
        }
    }
}
