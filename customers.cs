using SuperMaket_project.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMaket_project
{
    public partial class customers : Form
    {
        FCustomer Customer = new FCustomer();
        public customers()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            SqlDataAdapter sda = Customer.getAll();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGVcustomer.DataSource = dt;
        }
        private void textCustomer_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCustName.Focus();
            }
        }

        private void textCustomer_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCustBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCustIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCustEmail.Focus();
            }
        }

        private void textCustEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCustPhone.Focus();
            }
        }

        private void textCustPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comTypeCust.Focus();
            }
        }

        private void comTypeCust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCustBalance.Focus();
            }
        }

        private void textCustBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comGender.Focus();
            }
        }

        private void comGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCustIdentity.Focus();
            }
        }

        private void textCustIdentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textCity.Focus();
            }
        }

        private void textStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textStreet.Focus();
            }
        }

        private void textCustBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //decimal phone = Convert.ToDecimal(textCustPhone.Text);
            //decimal snn = Convert.ToDecimal(textCustIdentity.Text);
            //decimal balance = Convert.ToDecimal(textCustBalance.Text);
            ////DateTime dateTimeEnter = Convert.ToDateTime(dateTimePicker1.Value);
            //Customer.Add(textCustName.Text, textStreet.Text, textCity.Text, phone, comGender.Text, textCustEmail.Text, snn, comTypeCust.Text, dateTimePicker1.Value, balance);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(textCustomer_id.Text);
            //decimal phone = Convert.ToDecimal(textCustPhone.Text);
            //decimal snn = Convert.ToDecimal(textCustIdentity.Text);
            //decimal balance = Convert.ToDecimal(textCustBalance.Text);
            //Customer.updata(id, textCustName.Text, textStreet.Text, textCity.Text, phone, comGender.Text, textCustEmail.Text, snn, comTypeCust.Text, dateTimePicker1.Value, balance);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(textCustomer_id.Text);
            //Customer.delete(id);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Customer.delete(Convert.ToInt32(dataGVcustomer.CurrentRow.Cells[0].Value.ToString()));
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }
    }
}