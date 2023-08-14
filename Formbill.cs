using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;
using SuperMaket_project.Facade;
namespace SuperMaket_project
{

    public partial class Formbill : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\bin\Debug\LODB.mdf;Integrated Security=True;Connect Timeout=30");

        FSalesBill SalesBill = new FSalesBill();
        public Formbill()
        {
            InitializeComponent();
        }


        connection con = new connection();

        public void DisplayData()
        {
            
            SqlDataAdapter sda = SalesBill.getAll();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
         


            if (textBoxname.Text == "")
            {
                MessageBox.Show("Please Enter Data:");

            }
            //else if (textBoxUnit.Text == "")
            //{
            //    MessageBox.Show("Please Enter unit :");

            //}
            else if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Please Enter unit :");
                ;
            }
            else if (textBoxBCode.Text == "")
            {

                MessageBox.Show("Please Enter  barcode:");
            }
            else if (numbericdoQlty.Value == 0)
            {

                MessageBox.Show("Please Enter Qluaty:");
            }
            else
            {

              
                int qty = Convert.ToInt32(numbericdoQlty.Value);
                int price = Convert.ToInt32(textBoxPrice.Text);
                int barecode = Convert.ToInt32(textBoxBCode.Text);
                int totalqlty = qty * price;
                textBoxAllQty.Text = (Convert.ToInt32(textBoxAllQty.Text) + totalqlty + "");
                //string query = "insert into ProductSells (ProdName,comBoProds,ProdPrice,ProdBareCod,ProdQoulty,ProdTotalQlty)  values( ' " + textBoxname.Text + "' ,'" + comboBox1.SelectedItem + "' , '" + price + "' , '" + barecode + "' , '" + qty + "','" + totalqlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.CommandText = "insert into ProductSells (ProdName,comBoProds,ProdPrice,ProdBareCod,ProdQoulty,ProdTotalQlty)  values( ' " + textBoxname.Text + "' ,'" + comboBox1.Text + "' , '" + price + "' , '" + barecode + "' , '" + qty + "','" + totalqlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ";
                
               

             

                switch (comboBox2.SelectedItem)
                {
                    case "single":
                        //dataGridView2.Rows.Add(textBoxname.Text, comboBox1.Text, textBoxPrice.Text, textBoxBCode.Text, numbericdoQlty.Text, totalqlty);
                        con.command( "insert into ProductSells (ProdName,comBoProds,ProdBareCod,ProdPrice,ProdQoulty,ProdTotalQlty)  values( N' " + textBoxname.Text + "' , N'" + comboBox2.Text + "' , '" + barecode + "' , '" + price  + "' , '" + qty + "','" + totalqlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ");

                        //cmd.ExecuteNonQuery();
                        textBoxname.Text = "";
                        comboBox1.Text = "single";
                        price = 0;
                        barecode = 0;
                        qty = 0;
                        totalqlty = 0;
                        break;

                    case "package":
                        //dataGridView2.Rows.Add(textBoxname.Text, comboBox1.Text, textBoxPrice.Text, textBoxBCode.Text, numbericdoQlty.Text, totalqlty);
                        con.command("insert into ProductSells (ProdName,comBoProds,ProdBareCod,ProdPrice,ProdQoulty,ProdTotalQlty)  values( ' " + textBoxname.Text + "' ,'" + comboBox2.Text + "' , '" + barecode + "' , '" + price + "' , '" + qty + "','" + totalqlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ");
                        textBoxname.Text = "";
                        comboBox2.Text = "package";
                        price = 0;
                        barecode = 0;
                        qty = 0;
                        totalqlty = 0;
                        break;

                        //        //    case "شريط":
                        //        //        dataGridView2.Rows.Add(textBoxname.Text, comboBox1.Text, textBoxPrice.Text, textBoxBCode.Text, numbericdoQlty.Text, totalqlty);

                        //        //        cmd.CommandText = "insert into ProductSells (ProdName,comBoProds,ProdPrice,ProdBareCod,ProdQoulty,ProdTotalQlty)  values( ' " + textBoxname.Text + "' ,'" + comboBox1.Text  + "' , '" + price + "' , '" + barecode + "' , '" + qty + "','" + totalqlty + /*"','" + dTimeStart + "','" + dTimeEnd + */"') ";
                        //        //        cmd.ExecuteNonQuery();
                        //        //        textBoxname.Text = "";
                        //        //        comboBox1.Text = "";
                        //        //        //item = "";
                        //        //        price = 0;
                        //        //        barecode = 0;
                        //        //        qty = 0;
                        //        //        totalqlty = 0;


                        //        //        break;
                     
                } 
                MessageBox.Show("Recods are entered successfully");
                DisplayData();



            }
        }

        private void textBoxCustomer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxname.Focus();
                textBoxname.Select();
                textBoxname.SelectAll();
            }
        }

        private void textBoxname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBox2.Focus();
                comboBox2.Select();
                comboBox2.SelectAll();
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxPrice.Focus();
                textBoxPrice.Select();
                textBoxPrice.SelectAll();
            }
        }

        private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxBCode.Focus();
                textBoxBCode.Select();
                textBoxBCode.SelectAll();
                
                
            }
        }

        private void textBoxBCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                numbericdoQlty.Focus();
                numbericdoQlty.Select();
            }
        }

        private void numbericdoQlty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonAdd.Focus();
                buttonAdd.Select();
            }
        }

        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void Formbill_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            textBoxCustomer.Focus();
            textBoxCustomer.Select();
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;Connect Timeout=30");

           
            
            int qty = Convert.ToInt32(numbericdoQlty.Value);
            int price = Convert.ToInt32(textBoxPrice.Text);
            int barecode = Convert.ToInt32(textBoxBCode.Text);
            int totalqlty = qty * price;
            textBoxAllQty.Text = (Convert.ToInt32(textBoxAllQty.Text) + totalqlty + "");
            con.delete( "Delete  From ProductSells where prodName='" + textBoxname.Text + "'");
           
            textBoxname.Text = "";
            comboBox2.Text = "";
            price = 0;
            barecode = 0;
            qty = 0;
            totalqlty = 0;

            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
            

            MessageBox.Show("Recods are deleted successfully");
            DisplayData();
            //    if (dataGridView1.Rows.Count == 0)
            //    {
            //        MessageBox.Show("The rows are empty");
            //    }
            //    else if (dataGridView1.SelectedRows.Count == 0)
            //    {
            //        MessageBox.Show("You have to select Row");
            //    }
            //    else if (dataGridView1.SelectedRows.Count > 1)
            //    {
            //        MessageBox.Show("Are you sure to Remove the rows that You select.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            //        //for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //        while (dataGridView1.SelectedRows.Count > 0)
            //        {
            //            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //        }

            //    }
            //    else
            //    {
            //        while (dataGridView1.SelectedRows.Count > 0)
            //        {
            //            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //        }
            //    }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            string StrNo = "BILLNO" + textNumbill.Text;
            string stDate = "التاريخ:" + textBoxDate.Text;
            string strnameSuper = "سوبر ماركت";
            string stName = "الاسم:" + textBoxCustomer.Text;
            SizeF fontsizeNO = e.Graphics.MeasureString(StrNo, f);
            SizeF fontsizeDate = e.Graphics.MeasureString(stDate, f);
            SizeF fontsizeNameSuper = e.Graphics.MeasureString(strnameSuper, f);
            SizeF fontsizeName = e.Graphics.MeasureString(stName, f);
            e.Graphics.DrawString(StrNo, f, Brushes.Red, (e.PageBounds.Width - fontsizeNO.Width) / 2, margin);
            e.Graphics.DrawString(stDate, f, Brushes.Black, e.PageBounds.Width - fontsizeDate.Width - margin, margin + fontsizeNO.Height);
            e.Graphics.DrawString(strnameSuper, f, Brushes.Blue, (e.PageBounds.Width - fontsizeNameSuper.Width) - margin, margin + fontsizeNO.Height + fontsizeDate.Height);
            e.Graphics.DrawString(stName, f, Brushes.Navy, e.PageBounds.Width - fontsizeName.Width - margin, margin + fontsizeNO.Height + fontsizeDate.Height + fontsizeNameSuper.Height);

            float preHights = margin + fontsizeNO.Height + fontsizeDate.Height + fontsizeNameSuper.Height + 50;
            e.Graphics.DrawRectangle(Pens.Black, margin, preHights, e.PageBounds.Width - margin * 2, e.PageBounds.Height * 2 - preHights * 2);

            float colHight = 50;
            float col1width = 100;
            float col2width = 120 + col1width;
            float col3width = 100 + col2width;
            float col4width = 150 + col3width;
            float col5width = 100 + col4width;
            float colsptotal = 180 + col5width;


            e.Graphics.DrawLine(Pens.Black, margin, preHights + colHight, e.PageBounds.Width - margin, preHights + colHight);
            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHights, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الوحدة", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHights, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHights, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الباركود", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4width, preHights, e.PageBounds.Width - margin * 2 - col4width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col5width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col5width, preHights, e.PageBounds.Width - margin * 2 - col5width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الاجمالي", f, Brushes.Black, e.PageBounds.Width - margin / 2 - 1 - colsptotal, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colsptotal, preHights, e.PageBounds.Width - margin * 2 - colsptotal, e.PageBounds.Height - margin);



            float rowsHeight = 60;
            for (int x = 0; x < dataGridView1.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 + 1 - col1width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 + 1 - col2width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Red, e.PageBounds.Width - margin * 2 + 1 - col3width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 + 1 - col4width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[4].Value.ToString(), f, Brushes.Red, e.PageBounds.Width - margin * 2 + 1 - col5width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[5].Value.ToString(), f, Brushes.Red, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);

                e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);


                rowsHeight += 60;
            }
            e.Graphics.DrawString("الاجمالي", f, Brushes.Blue, e.PageBounds.Width - margin * 2 + 1 - col5width, preHights + rowsHeight);
            e.Graphics.DrawString(textBoxAllQty.Text, f, Brushes.Green, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);
            e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            con.command("Update ProductSells set prodName ='" + textBoxname.Text + "' where prodName ='" + textSearch.Text + "'");
            //int qty = Convert.ToInt32(numbericdoQlty.Value);
            //int price = Convert.ToInt32(textBoxPrice.Text);
            //int barecode = Convert.ToInt32(textBoxBCode.Text);
            //int totalqlty = qty * price;
            //textBoxAllQty.Text = (Convert.ToInt32(textBoxAllQty.Text) + totalqlty + "");
           
            textBoxname.Text = "";
            textSearch.Text = "";
            //comboBox2.Text = "";
            //price = 0;
            //barecode = 0;
            //qty = 0;
            //totalqlty = 0;

            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
           

            MessageBox.Show("Recods are update successfully");
            DisplayData();
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;Connect Timeout=30");

            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            ////int price = Convert.ToInt32(textPrice.Text);
            ////int bareCode = Convert.ToInt32(textBarCO.Text);
            ////int qoulty = Convert.ToInt32(textQoulty.Text);
            //cmd.CommandText = "select * from ProductSells where prodName ='" + textSearch.Text + "'";
            //cmd.ExecuteNonQuery();
            //conn.Close();
            textBoxname.Text = "";
            comboBox2.Text = "";
            textBoxPrice.Text = "";
            textBoxBCode.Text = "";
            numbericdoQlty.Value = 0;
            textSearch.Text = "";

            DataTable dt = new DataTable();
            SqlDataAdapter sda = SalesBill.getAllProdectNRQ(); ;

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBoxAllQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string comb1 = "من قاعدة البيانات";
            //switch (comboBox1.SelectedItem)
            //{
            //    case " الفاتورة":
            //        dataGridView2.Visible = true;
            //        dataGridView1.Visible = false;
           
            //        dataGridView2.Enabled = true;
            //        dataGridView2.Show();
            //        break;
            //    case "من قاعدة البيانات":
            //        dataGridView1.Visible = true;
            //        dataGridView2.Visible = false ;
            //        DisplayData();

            //        break;
                


            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
        

            //cmd.CommandText = "insert into ProductSells where comBoProds = '" + comboBox1.SelectedItem + "'";
            //cmd.ExecuteNonQuery();
            
            ////item = "";
            //comboBox1.Text = "";

           
            //con.Close();

            //MessageBox.Show("Recods are entered successfully");
        }
    }
}

