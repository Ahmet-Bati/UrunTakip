using System.Drawing;

namespace UrunTakip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.button1 = new RJCodeAdvance.RJControls.RJButton();
            this.button2 = new RJCodeAdvance.RJControls.RJButton();
            this.button3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            this.lblDolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.urunid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisdolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisdolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunstok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alistarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveToCart = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisdolar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisdolar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjDatePicker1.Location = new System.Drawing.Point(137, 6);
            this.rjDatePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(220, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDatePicker1.TabIndex = 2;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            this.rjDatePicker1.Value = new System.DateTime(2023, 9, 12, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(269, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 193);
            this.panel1.TabIndex = 3;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(291, 108);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(189, 49);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "Barkod Ara";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(41, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(41, 108);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(193, 48);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Ürün Ara";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 7;
            this.button1.BorderSize = 1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(269, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ürün Ekle";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button2.BorderRadius = 7;
            this.button2.BorderSize = 1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(560, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ürün Düzelt";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button3.BorderRadius = 7;
            this.button3.BorderSize = 1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(560, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ürün Sil";
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 7;
            this.rjButton5.BorderSize = 1;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(269, 340);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(235, 43);
            this.rjButton5.TabIndex = 5;
            this.rjButton5.Text = "Satılan Ürünler";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDolar.Location = new System.Drawing.Point(528, 14);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(0, 26);
            this.lblDolar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(388, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dolar  Kuru  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(133, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 6;
            // 
            // dgvUrun
            // 
            this.dgvUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunid,
            this.barkod,
            this.urunadi,
            this.alisdolar,
            this.satisdolar,
            this.urunstok,
            this.alistarihi});
            this.dgvUrun.Location = new System.Drawing.Point(12, 428);
            this.dgvUrun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.RowHeadersVisible = false;
            this.dgvUrun.RowHeadersWidth = 51;
            this.dgvUrun.RowTemplate.Height = 24;
            this.dgvUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrun.Size = new System.Drawing.Size(1452, 348);
            this.dgvUrun.TabIndex = 7;
            this.dgvUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrun_CellClick);
            // 
            // urunid
            // 
            this.urunid.DataPropertyName = "urunid";
            this.urunid.HeaderText = "ÜRÜN ID";
            this.urunid.MinimumWidth = 6;
            this.urunid.Name = "urunid";
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "BARKOD";
            this.barkod.MinimumWidth = 6;
            this.barkod.Name = "barkod";
            // 
            // urunadi
            // 
            this.urunadi.DataPropertyName = "urunadi";
            this.urunadi.HeaderText = "ÜRÜN ADI";
            this.urunadi.MinimumWidth = 6;
            this.urunadi.Name = "urunadi";
            // 
            // alisdolar
            // 
            this.alisdolar.DataPropertyName = "alisdolar";
            this.alisdolar.HeaderText = "ALIŞ DOLAR($)";
            this.alisdolar.MinimumWidth = 6;
            this.alisdolar.Name = "alisdolar";
            // 
            // satisdolar
            // 
            this.satisdolar.DataPropertyName = "satisdolar";
            this.satisdolar.HeaderText = "ŞATIŞ DOLAR ($)";
            this.satisdolar.MinimumWidth = 6;
            this.satisdolar.Name = "satisdolar";
            // 
            // urunstok
            // 
            this.urunstok.DataPropertyName = "urunstok";
            this.urunstok.HeaderText = "ÜRÜN STOĞU";
            this.urunstok.MinimumWidth = 6;
            this.urunstok.Name = "urunstok";
            // 
            // alistarihi
            // 
            this.alistarihi.DataPropertyName = "alistarihi";
            this.alistarihi.HeaderText = "ALIŞ TARİHİ";
            this.alistarihi.MinimumWidth = 6;
            this.alistarihi.Name = "alistarihi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnRemoveToCart);
            this.panel2.Controls.Add(this.rjDatePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDolar);
            this.panel2.Controls.Add(this.rjButton6);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(813, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 384);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(245, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Toplam Tutar  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(397, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 13;
            // 
            // btnRemoveToCart
            // 
            this.btnRemoveToCart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemoveToCart.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemoveToCart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveToCart.BorderRadius = 7;
            this.btnRemoveToCart.BorderSize = 1;
            this.btnRemoveToCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveToCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveToCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveToCart.Location = new System.Drawing.Point(365, 277);
            this.btnRemoveToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveToCart.Name = "btnRemoveToCart";
            this.btnRemoveToCart.Size = new System.Drawing.Size(243, 43);
            this.btnRemoveToCart.TabIndex = 11;
            this.btnRemoveToCart.Text = "Sepetten Çıkar";
            this.btnRemoveToCart.TextColor = System.Drawing.Color.White;
            this.btnRemoveToCart.UseVisualStyleBackColor = false;
            this.btnRemoveToCart.Click += new System.EventHandler(this.btnRemoveToCart_Click);
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 7;
            this.rjButton6.BorderSize = 1;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(27, 277);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(243, 43);
            this.rjButton6.TabIndex = 10;
            this.rjButton6.Text = "Ürünü Sat";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunid1,
            this.barkod1,
            this.urunadi1,
            this.alisdolar1,
            this.satisdolar1});
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 210);
            this.dataGridView1.TabIndex = 9;
            // 
            // urunid1
            // 
            this.urunid1.HeaderText = "ID";
            this.urunid1.MinimumWidth = 6;
            this.urunid1.Name = "urunid1";
            // 
            // barkod1
            // 
            this.barkod1.HeaderText = "BARKOD";
            this.barkod1.MinimumWidth = 6;
            this.barkod1.Name = "barkod1";
            // 
            // urunadi1
            // 
            this.urunadi1.HeaderText = "ÜRÜN ADI";
            this.urunadi1.MinimumWidth = 6;
            this.urunadi1.Name = "urunadi1";
            // 
            // alisdolar1
            // 
            this.alisdolar1.HeaderText = "ALIS DOLAR";
            this.alisdolar1.MinimumWidth = 6;
            this.alisdolar1.Name = "alisdolar1";
            // 
            // satisdolar1
            // 
            this.satisdolar1.HeaderText = "SATİS DOLAR";
            this.satisdolar1.MinimumWidth = 6;
            this.satisdolar1.Name = "satisdolar1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sepet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UrunTakip.Properties.Resources.zyro_image;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::UrunTakip.Properties.Resources.codioful_formerly_gradienta_J6LMHbdW1k8_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 801);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jamesa İletişim Ürün Takip Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private RJCodeAdvance.RJControls.RJButton button1;
        private RJCodeAdvance.RJControls.RJButton button2;
        private RJCodeAdvance.RJControls.RJButton button3;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private System.Windows.Forms.TextBox textBox1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunid;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisdolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisdolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunstok;
        private System.Windows.Forms.DataGridViewTextBoxColumn alistarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJButton btnRemoveToCart;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisdolar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisdolar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

