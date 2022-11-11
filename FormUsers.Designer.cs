
namespace SuperMaket_project
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddUSR = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.isLogin = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBSelery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBSSN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBGander = new System.Windows.Forms.ComboBox();
            this.textBStreet = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1778, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUser.Location = new System.Drawing.Point(783, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(175, 45);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "المستخدمين";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-30, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 611);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAddUSR
            // 
            this.btnAddUSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUSR.BackColor = System.Drawing.Color.Green;
            this.btnAddUSR.FlatAppearance.BorderSize = 0;
            this.btnAddUSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUSR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUSR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUSR.Location = new System.Drawing.Point(244, 5);
            this.btnAddUSR.Name = "btnAddUSR";
            this.btnAddUSR.Size = new System.Drawing.Size(196, 46);
            this.btnAddUSR.TabIndex = 1;
            this.btnAddUSR.Text = "إظافة مستخدم";
            this.btnAddUSR.UseVisualStyleBackColor = false;
            this.btnAddUSR.Click += new System.EventHandler(this.btnAddUSR_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.isLogin);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.textBEmail);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBSelery);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBSSN);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.comboBGander);
            this.panel4.Controls.Add(this.textBStreet);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.textPass);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBCity);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtFullName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtUserName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(920, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 614);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // isLogin
            // 
            this.isLogin.AutoSize = true;
            this.isLogin.Location = new System.Drawing.Point(315, 472);
            this.isLogin.Name = "isLogin";
            this.isLogin.Size = new System.Drawing.Size(22, 21);
            this.isLogin.TabIndex = 55;
            this.isLogin.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(371, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 36);
            this.label11.TabIndex = 54;
            this.label11.Text = ":الدخول";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 424);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 27);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(30, 101);
            this.textBEmail.Multiline = true;
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(307, 40);
            this.textBEmail.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(371, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 36);
            this.label10.TabIndex = 40;
            this.label10.Text = ":الايميل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(371, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 36);
            this.label9.TabIndex = 52;
            this.label9.Text = ":تاريخ الاتحاق";
            // 
            // textBSelery
            // 
            this.textBSelery.Location = new System.Drawing.Point(30, 377);
            this.textBSelery.Multiline = true;
            this.textBSelery.Name = "textBSelery";
            this.textBSelery.Size = new System.Drawing.Size(307, 40);
            this.textBSelery.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(371, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 36);
            this.label8.TabIndex = 50;
            this.label8.Text = ":الراتب";
            // 
            // textBSSN
            // 
            this.textBSSN.Location = new System.Drawing.Point(30, 331);
            this.textBSSN.Multiline = true;
            this.textBSSN.Name = "textBSSN";
            this.textBSSN.Size = new System.Drawing.Size(307, 40);
            this.textBSSN.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(371, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 36);
            this.label7.TabIndex = 48;
            this.label7.Text = ":رقم البطاقة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(371, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 36);
            this.label5.TabIndex = 47;
            this.label5.Text = ":النوع";
            // 
            // comboBGander
            // 
            this.comboBGander.FormattingEnabled = true;
            this.comboBGander.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comboBGander.Location = new System.Drawing.Point(30, 249);
            this.comboBGander.Name = "comboBGander";
            this.comboBGander.Size = new System.Drawing.Size(307, 27);
            this.comboBGander.TabIndex = 46;
            // 
            // textBStreet
            // 
            this.textBStreet.Location = new System.Drawing.Point(189, 147);
            this.textBStreet.Multiline = true;
            this.textBStreet.Name = "textBStreet";
            this.textBStreet.Size = new System.Drawing.Size(148, 45);
            this.textBStreet.TabIndex = 45;
            this.textBStreet.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddUSR);
            this.panel2.Controls.Add(this.btnDelet);
            this.panel2.Location = new System.Drawing.Point(13, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 108);
            this.panel2.TabIndex = 44;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(15, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 46);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Red;
            this.btnDelet.FlatAppearance.BorderSize = 0;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(15, 55);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(425, 43);
            this.btnDelet.TabIndex = 39;
            this.btnDelet.Text = "حذف";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(30, 282);
            this.textPass.Multiline = true;
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(307, 43);
            this.textPass.TabIndex = 43;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(30, 198);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(307, 45);
            this.txtPhone.TabIndex = 42;
            this.txtPhone.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(371, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 36);
            this.label6.TabIndex = 41;
            this.label6.Text = ":كلمة السر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(371, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = ":التلفون";
            // 
            // textBCity
            // 
            this.textBCity.Location = new System.Drawing.Point(30, 147);
            this.textBCity.Multiline = true;
            this.textBCity.Name = "textBCity";
            this.textBCity.Size = new System.Drawing.Size(153, 45);
            this.textBCity.TabIndex = 34;
            this.textBCity.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(371, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 36);
            this.label4.TabIndex = 33;
            this.label4.Text = ":العنون (الشارع,المدينة)";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(30, 55);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(307, 40);
            this.txtFullName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(371, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = ":الاسم الكامل";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(30, 3);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(307, 46);
            this.txtUserName.TabIndex = 30;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(371, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = ":اسم المستخدم";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 674);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button btnAddUSR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox textPass;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDelet;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox textBCity;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox textBEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBSelery;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBSSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBGander;
        public System.Windows.Forms.TextBox textBStreet;
        private System.Windows.Forms.CheckBox isLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}