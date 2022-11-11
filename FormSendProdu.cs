using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using SuperMaket_project.Facade;

namespace SuperMaket_project
{
    public partial class FormSendProdu : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\bin\Debug\LODB.mdf;Integrated Security=True;Connect Timeout=30");
        Fbuying buy = new Fbuying();
        DataTable ProdectTable = new DataTable();
        List<Products> listProducts = new List<Products>();
        public FormSendProdu()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {

            SqlDataAdapter sda = buy.getAll();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {

            if (textprodName.Text == "" /*&& textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == ""  && textBox4.Text/* *//*|| textBox5.Text || textBox2.Text || textBox3.Text || textBox4.Text*/ /*== ""*/)
            {
                MessageBox.Show("Please Enter Data:");

            }
            else if (textPriceBuy.Text == "")
            {
                MessageBox.Show("Please Enter price:");

            }
            else if (textBareCO.Text == "")
            {
                MessageBox.Show("Please Enter barcode:");
                ;
            }
            else if (numbericdoQlty.Value == 0)
            {

                MessageBox.Show("Please Enter amount reminder:");
            }
            else if (comboBox2.Text == "")
            {

                MessageBox.Show("Please Enter unit:");
            }
            else
            {


                decimal qnantity = Convert.ToDecimal(numbericdoQlty.Value);
                decimal priceSell = Convert.ToDecimal(texpriceSell.Text);
                decimal bareCode = Convert.ToDecimal(textBareCO.Text);
                decimal pricebuy = Convert.ToDecimal(textPriceBuy.Text);
                //int priceBuyQlty = qnantity * pricebuy;
                //int priceSellQlty = qnantity * priceSell;
                string unit = comboBox2.Text;

                DateTime dTimeEnter = dateTimeStart.Value;
                DateTime dTimeEnd = dateTimeEnd.Value;
               
                ProdectTable.Rows.Add(textprodName.Text ,bareCode,unit,pricebuy,qnantity,priceSell,dTimeEnter,dTimeEnd);
                //string dTimeEnter = Convert.ToString(dateTimeStart.Text);
                //string dTimeEnd = Convert.ToString(dateTimeEnd.Text);

                


                //switch (comboBox2.SelectedItem)
                //{

                //    case "single":
                //        con.command("insert into SendProducts (ProdName,comBoProds,ProdBareCod,ProdPriceBuy,ProdPriceSell,ProdQoulty,ProdPriceByQty,ProdPriceSeQty,EnterDate,EndDate)  values( ' " + textprodName.Text + "' ,'" + comboBox2.Text + "' , '" + bareCode + "','"+ pricebuy + "' , '" + priceSell + "' , '" + qoulty + "' , '" + priceBuyQlty + "' , '" + priceSellQlty + "','" + dTimeEnter + "','" + dTimeEnd + "') ");

                //        textprodName.Text = "";
                //        comboBox2.Text = "single";
                //        pricebuy = 0;
                //        priceSell = 0;
                //        textBareCO.Text = "";

                //        bareCode = 0;
                //        qoulty = 0;
                //        priceBuyQlty = 0;
                //        priceSellQlty = 0;



                //        break;
                //    case "package":
                //        con.command( "insert into SendProducts (ProdName,comBoProds,ProdBareCod,ProdPriceBuy,ProdPriceSell,ProdQoulty,ProdPriceByQty,ProdPriceSeQty/*,EnterDate,EndDate*/)  values( ' " + textprodName.Text + "' ,'" + comboBox2.Text + "' , '" + bareCode + "','" + pricebuy + "' , '" + priceSell + "' , '" + qoulty + "' , '" + priceBuyQlty + "' , '" + priceSellQlty + /*"','" + dTimeEnter + "','" + dTimeEnd + */ "') ");

                //        textprodName.Text = "";
                //        comboBox2.Text = "package";
                //        pricebuy = 0;
                //        priceSell = 0;
                //        textBareCO.Text = "";
                //        bareCode = 0;
                //        qoulty = 0;
                //        priceBuyQlty = 0;
                //        priceSellQlty = 0;

                //        break;
                //case "c":
                //    cmd.CommandText = "insert into SendProducts (ProdName,comBoProds,ProdBareCod,ProdPriceBuy,ProdPriceSell,ProdQoulty,ProdPriceByQty,ProdPriceSeQty/*,EnterDate,EndDate*/)  values( ' " + textprodName.Text + "' ,'" + comboBox2.Text + "' , '" + bareCode + "','" + pricebuy + "' , '" + priceSell + "' , '" + qoulty + "' , '" + priceBuyQlty + "' , '" + priceSellQlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ";
                //    cmd.ExecuteNonQuery();
                //    textprodName.Text = "";
                //    comboBox2.Text = "كرتون";
                //    pricebuy = 0;
                //    priceSell = 0;
                //    bareCode = 0;
                //    qoulty = 0;
                //    //dataGridView1.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);
                //    //dataGridView2.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);
                //    //dataGridView3.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);
                //    break;
                textprodName.Text = "";
                comboBox2.SelectedIndex = 0;
                pricebuy = 0;
                priceSell = 0;
                textBareCO.Text = "";
                bareCode = 0;
                qnantity = 0;
                //priceBuyQlty = 0;
                //priceSellQlty = 0;

                //}


                //MessageBox.Show("Recods are entered successfully");
                //DisplayData();

                //switch (comboxParts.SelectedItem)
                //{
                //    case "الماء":
                //        switch (comboBox2.SelectedItem)
                //        {
                //            case "قارورة":
                //                dataGridView1.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "كرتون":
                //                dataGridView1.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "شريط":
                //                dataGridView1.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //        }
                //        dataGridView1.Enabled = true;
                //        dataGridView2.Enabled = false;
                //        dataGridView3.Enabled = true;
                //        dataGridView1.Visible = true;
                //        dataGridView2.Visible = false;
                //        dataGridView3.Visible = false;
                //        break;
                //    case "البسكويتات":
                //        switch (comboBox2.SelectedItem)
                //        {
                //            case "قارورة":
                //                dataGridView2.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "كرتون":
                //                dataGridView2.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "شريط":
                //                dataGridView2.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //        }
                //        dataGridView1.Enabled = false;
                //        dataGridView2.Enabled = true;
                //        dataGridView3.Enabled = false;
                //        dataGridView1.Visible = false;
                //        dataGridView2.Visible = true;
                //        dataGridView3.Visible = false;
                //        break;
                //    case "المشروبات":
                //        switch (comboBox2.SelectedItem)
                //        {
                //            case "قارورة":
                //                dataGridView3.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "كرتون":
                //                dataGridView3.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //            case "شريط":
                //                dataGridView3.Rows.Add(textprodName.Text, comboBox2.Text, price, textBareCO.Text, qty);

                //                break;
                //        }
                //        dataGridView1.Enabled = false;
                //        dataGridView2.Enabled = false;
                //        dataGridView3.Enabled = true;
                //        dataGridView1.Visible = false;
                //        dataGridView2.Visible = false;
                //        dataGridView3.Visible = true;
                //        break;
                // }
                dataGridView1.DataSource = ProdectTable;
            }
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //while (dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //}

           
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            /*con.delete( "Delete  From SendProducts where prodName='" + textprodName.Text + "'")*/;
            buy.delete(0);
            textprodName.Text = "";
            comboBox2.Text = "";
            textPriceBuy.Text = "";
            texpriceSell.Text = "";
            textBareCO.Text = "";
            numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
            
            MessageBox.Show("Recods are deleted successfully");
            DisplayData();
        }

        private void textprodName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox2.Focus();
               

            }
        }

        private void textprodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char)Keys.Enter) == e.KeyChar)
            {comboBox2.Focus();
                e.Handled = true;
            }else if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBareCO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char)Keys.Enter) == e.KeyChar)
            {
                comboBox2.Focus();
                e.Handled = true;
            }
            else
            if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBareCO.Focus();
                
            }
        }

        private void textPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                texpriceSell.Focus();
               
            }
        }

        private void textBareCO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textPriceBuy.Focus();
               
            }
        }

        private void numbericdoQlty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonADD.Focus();
               
            }
         
        }

        private void FormSendProdu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lODBDataSet.SendProducts' table. You can move, or remove it, as needed.
            //this.sendProductsTableAdapter.Fill(this.lODBDataSet.SendProducts);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ProdectTable = new DataTable();
            
            ProdectTable.Columns.Add("product_name");
            ProdectTable.Columns.Add("Barcode");
            ProdectTable.Columns.Add("unit");
            ProdectTable.Columns.Add("price Buy");
            ProdectTable.Columns.Add("Quantity");
            ProdectTable.Columns.Add("price sell");
            ProdectTable.Columns.Add("Start Date");
            ProdectTable.Columns.Add("Expiry Date");
            DisplayData();
           
        }

        private void comboxParts_KeyDown(object sender, KeyEventArgs e)
        {
            //textprodName.Focus();
            //textprodName.Select();
            //textprodName.SelectAll();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            //con.command( "Update SendProducts set prodName ='" + textprodName.Text + "' where prodName ='" + textSearch.Text + "'");
            
            textprodName.Text = "";
            comboBox2.Text = "";
            textPriceBuy.Text = "";
            texpriceSell.Text = "";
            textBareCO.Text = "";
            numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
            //decimal pr = 0;
            //for (int i = 0; i < ProdectTable.Rows.Count; i++)
            //{
            //    pr += Convert.ToDecimal(ProdectTable.Rows[i]["price Buy"]) * Convert.ToDecimal(ProdectTable.Rows[i]["Quantity"]);
            //    listProducts.Add(new Products(ProdectTable.Rows[i]["product_name"].ToString(), ProdectTable.Rows[i]["unit"].ToString(), Convert.ToDecimal(ProdectTable.Rows[i]["price Buy"])
            //        , Convert.ToDecimal(ProdectTable.Rows[i]["price sell"]), Convert.ToDecimal(ProdectTable.Rows[i]["Barcode"]), Convert.ToDecimal(ProdectTable.Rows[i]["Quantity"]), 0, 0, 0, Convert.ToDateTime(ProdectTable.Rows[i]["Start Date"]), Convert.ToDateTime(ProdectTable.Rows[i]["Expiry Date"])));
            //}
            //buy.update(0, 0, pr, DateTime.Now, listProducts);

            MessageBox.Show("Recods are update successfully");
            DisplayData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            
           
            textprodName.Text = "";
            comboBox2.Text = "";
            textPriceBuy.Text = "";
            texpriceSell.Text = "";
            textBareCO.Text = "";
            numbericdoQlty.Value = 0;

            DataTable dt = new DataTable();
            //SqlDataAdapter sda = con.command("select * from SendProducts where prodName ='" + textSearch.Text + "'");
            SqlDataAdapter sda;
            try
            {  sda = buy.Search(int.Parse(textSearch.Text));

            }catch (Exception ex) {  sda = buy.Search(0); }
           

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void texpriceSell_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData ==Keys.Enter)
            {
                numbericdoQlty.Focus();
                numbericdoQlty.Select();
               
            }
        }

        private void texpriceSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex <= dataGridView1.RowCount&e.ColumnIndex>=0&e.ColumnIndex<=dataGridView1.ColumnCount)
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textprodName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBareCO.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textPriceBuy.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                texpriceSell.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string numberiQlty = Convert.ToString(numbericdoQlty.Value);
                numberiQlty = dataGridView1.Rows[e.RowIndex].Cells[6].ValueType.ToString();
                
            }
        }

        private void textprodName_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    comboBox2.Focus();


            //}
            if (e.KeyCode == Keys.Enter)comboBox2.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //ProdectTable.Columns[0].ColumnName = "product_name";
            //ProdectTable.Columns[1].ColumnName = "Barcode";
            //ProdectTable.Columns[2].ColumnName = "unit";
            //ProdectTable.Columns[3].ColumnName = "price Buy";
            //ProdectTable.Columns[4].ColumnName = "Quantity";
            //ProdectTable.Columns[5].ColumnName = "price sell";
            //ProdectTable.Columns[6].ColumnName = "Start Date";
            //ProdectTable.Columns[7].ColumnName = "Expiry Date";
            decimal pr = 0;
            for (int i = 0; i < ProdectTable.Rows.Count; i++)
            {
                pr += Convert.ToDecimal(ProdectTable.Rows[i]["price Buy"])*Convert.ToDecimal(ProdectTable.Rows[i]["Quantity"]);
                listProducts.Add(new Products(ProdectTable.Rows[i]["product_name"].ToString(), ProdectTable.Rows[i]["unit"].ToString(),Convert.ToDecimal(ProdectTable.Rows[i]["price Buy"])
                    ,Convert.ToDecimal(ProdectTable.Rows[i]["price sell"]),Convert.ToDecimal(ProdectTable.Rows[i]["Barcode"]),Convert.ToDecimal(ProdectTable.Rows[i]["Quantity"]),0,0,0,Convert.ToDateTime(ProdectTable.Rows[i]["Start Date"]),Convert.ToDateTime(ProdectTable.Rows[i]["Expiry Date"])));
            }
            buy.add(0, 0, pr, DateTime.Now, listProducts);
        }
    }
}
