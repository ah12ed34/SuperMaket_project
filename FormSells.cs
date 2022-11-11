using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using SuperMaket_project.Facade;
namespace SuperMaket_project
{
    public partial class FormSells : Form
    {
        FSalesBill salesBill = new FSalesBill();
        
        public FormSells()
        {
            InitializeComponent();
        }
       

        public void DisplayData()
        {
            SqlDataAdapter sda = salesBill.getAll();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

          //textBoxAllQty.Text= (SqlDataAdapter sda2 = new SqlDataAdapter("Select ProdPrice * ProdQoulty from  ProductSells  " , con));

        }
        private void FormSells_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersHeight =100;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
            //DisplayData();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
           
           

            textSearch.Text = "";

            DataTable dt = new DataTable();
            SqlDataAdapter sda = salesBill.Search(Convert.ToInt32(textSearch.Text));

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 45;
         
            Font f = new Font("Arial", 18, FontStyle.Bold);
            string strnameSuper = "سوبر ماركت";
            string stName = "تقرير مبيعات";
            SizeF fontsizeNameSuper = e.Graphics.MeasureString(strnameSuper, f);
            SizeF fontsizeName = e.Graphics.MeasureString(stName, f);

            e.Graphics.DrawString(strnameSuper, f, Brushes.Blue, (e.PageBounds.Width - fontsizeNameSuper.Width) - margin, margin );
            e.Graphics.DrawString(stName, f, Brushes.Navy, e.PageBounds.Width - fontsizeName.Width - margin, margin+ fontsizeNameSuper.Height);
            float preHights = margin +  fontsizeNameSuper.Height + 50;
            e.Graphics.DrawRectangle(Pens.Black, margin, preHights, e.PageBounds.Width - margin * 2, e.PageBounds.Height * 2 - preHights * 2);

            float colHight = 50;
            float col1width = 50;
            float col2width = 120 + col1width;
            float col3width = 100 + col2width;
            float col4width = 100 + col3width;
            float col5width = 120 + col4width;
            float col6width = 100 + col5width;
            float colsptotal = 160 + col6width;
            SolidBrush sb = new SolidBrush(Color.Blue);

            e.Graphics.DrawLine(Pens.Black, margin, preHights + colHight, e.PageBounds.Width - margin, preHights + colHight);
            e.Graphics.DrawString("الرقم", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHights);
           

            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHights, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHights, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الوحدة", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHights, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4width, preHights, e.PageBounds.Width - margin * 2 - col4width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الباركود", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col5width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col5width, preHights, e.PageBounds.Width - margin * 2 - col5width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col6width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col6width, preHights, e.PageBounds.Width - margin * 2 - col6width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الاجمالي", f, Brushes.Black, e.PageBounds.Width - margin / 2 - 1 - colsptotal, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colsptotal, preHights, e.PageBounds.Width - margin * 2 - colsptotal, e.PageBounds.Height - margin);



            float rowsHeight = 60;
            for (int x = 0; x < dataGridView1.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 +4 - col1width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2  - col2width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[4].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2  - col5width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[5].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 +4 - col6width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[6].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);

               
                e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);


                rowsHeight += 60;
            }
            //e.Graphics.DrawString("الاجمالي", f, Brushes.Blue, e.PageBounds.Width - margin * 2 + 1 - col5width, preHights + rowsHeight);
            //e.Graphics.DrawString(textBoxAllQty.Text, f, Brushes.Green, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);
            //e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
