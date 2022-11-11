using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SuperMaket_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictIconi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;



            pictIconi.Visible = false;
            picturMaxi.Visible = true;
        }

        private void picturMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            picturMaxi.Visible = false;
            pictIconi.Visible = true;
        }

        private void buttonMInI_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

   

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if( this.panelMenuLe.Width==200)
            //{
              
            //   this.panelMenuLe.Width = 55;
            //}
            //else
            //{
            //    buttonMe.Visible = true;
            //   this.panelMenuLe.Width = 200;
            //}
        }

        private void PanelMenuLeft_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelMenuLe_Paint(object sender, PaintEventArgs e)
        {
           this.panelMenuLe.Width = 200;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(fh);
            this.panelContent.Tag = fh;
            fh.Show();
        }


        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formbill());
        }
        //private void AbrirFormEnPanel2(object Formhijo)
        //{
        //    if (this.panelContent.Controls.Count > 0 || this.panelMenuLe.Controls.Count>0 || this.panel5.Controls.Count>0 || this.paneltitle.Controls.Count>0 || this.menuStrip1.Controls.Count>0)
        //        this.panelContent.Controls.RemoveAt(0);
        //    this.panelMenuLe.Controls.RemoveAt(0);
        //    this.paneltitle.Controls.RemoveAt(0);
        //    this.panel5.Controls.RemoveAt(0);
        //    this.menuStrip1.Controls.RemoveAt(0);




        //    Form fh = Formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelContent.Controls.Add(fh);
        //    this.panel5.Controls.Add(fh);
        //    this.panelMenuLe.Controls.Add(fh);
        //    this.paneltitle.Controls.Add(fh);
        //    this.menuStrip1.Controls.Add(fh);
        //    this.panelContent.Tag = fh;
        //    this.paneltitle.Tag = fh;
        //    this.panelMenuLe.Tag = fh;
        //    this.panel5.Tag = fh;
        //    this.menuStrip1.Tag = fh;
        //    fh.Show();
        //}
       
        private void الرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void AbrirFormEnPanel2(object Formhijo)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(fh);
            this.panelContent.Tag = fh;
            fh.Show();
        }

        private void توريدمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new FormSendProdu());
        }

        private void btnManag_Click(object sender, EventArgs e)
        {
            btnManag.Width = 200;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnProduct.Width = 200;
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            btnSells.Width = 200;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            btnAccounts.Width = 200;
        }

        private void btnEmpl_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void buttonMe_Click(object sender, EventArgs e)
        {
            if (this.panelMenuLe.Width == 200)
            {
                this.panelMenuLe.Width = 55;


                buttonMe.Text = "";
                btnManag.Text = "";
                btnUsers.Text = "";
                btnProduct.Text = "";
                btnSells.Text = "";
                btnAccounts.Text = "";
                btnExit.Text = "";

            
            }
            else
            {
            

                buttonMe.Text = "القائمة";
                btnManag.Text = "الإدارة";
                btnUsers.Text = "المستخدمين";
                btnProduct.Text = "المنتجات";
                btnSells.Text = "المبيعات";
                btnAccounts.Text = "الحسابات";
                btnExit.Text = "خروج";
              
                buttonMe.Visible = true;
                this.panelMenuLe.Width = 200;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelMenuLe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new FormProducts());
        }

        private void btnSells_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new FormSells());

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new FormUsers());

        }
    }
}
