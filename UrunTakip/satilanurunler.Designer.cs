namespace UrunTakip
{
    partial class satilanurunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satilanurunler));
            this.DgvSatilan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisdolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisdolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satistl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satistarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjDatePicker2 = new RJCodeAdvance.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSatilan)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSatilan
            // 
            this.DgvSatilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSatilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSatilan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barkod,
            this.urunadi,
            this.alisdolar,
            this.satisdolar,
            this.satistl,
            this.satistarihi});
            this.DgvSatilan.Location = new System.Drawing.Point(9, 111);
            this.DgvSatilan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvSatilan.Name = "DgvSatilan";
            this.DgvSatilan.RowHeadersVisible = false;
            this.DgvSatilan.RowHeadersWidth = 51;
            this.DgvSatilan.RowTemplate.Height = 24;
            this.DgvSatilan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSatilan.Size = new System.Drawing.Size(976, 410);
            this.DgvSatilan.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
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
            this.alisdolar.HeaderText = "DOLAR ALIŞ($)";
            this.alisdolar.MinimumWidth = 6;
            this.alisdolar.Name = "alisdolar";
            // 
            // satisdolar
            // 
            this.satisdolar.DataPropertyName = "satisdolar";
            this.satisdolar.HeaderText = "DOLAR SATIŞ($)";
            this.satisdolar.MinimumWidth = 6;
            this.satisdolar.Name = "satisdolar";
            // 
            // satistl
            // 
            this.satistl.DataPropertyName = "satistl";
            this.satistl.HeaderText = "TL SATIŞ(₺)";
            this.satistl.MinimumWidth = 6;
            this.satistl.Name = "satistl";
            // 
            // satistarihi
            // 
            this.satistarihi.DataPropertyName = "satistarihi";
            this.satistarihi.HeaderText = "SATIŞ TARİHİ";
            this.satistarihi.MinimumWidth = 6;
            this.satistarihi.Name = "satistarihi";
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(113, 15);
            this.rjDatePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(137, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDatePicker1.TabIndex = 1;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
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
            this.rjButton6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(481, 58);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(133, 35);
            this.rjButton6.TabIndex = 6;
            this.rjButton6.Text = "Kaydı Sil";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 7;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(313, 9);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(133, 35);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "Seçilen Gün Raporu";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(481, 9);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(133, 35);
            this.rjButton2.TabIndex = 9;
            this.rjButton2.Text = "Tüm Kayıtları Göster";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(712, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kazanç ($) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(803, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(803, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(712, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kazanç (₺) :";
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 7;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(313, 58);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(133, 35);
            this.rjButton3.TabIndex = 14;
            this.rjButton3.Text = "Aylık Rapor";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker2.Location = new System.Drawing.Point(113, 58);
            this.rjDatePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(137, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDatePicker2.TabIndex = 15;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            // 
            // satilanurunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UrunTakip.Properties.Resources.codioful_formerly_gradienta_J6LMHbdW1k8_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 535);
            this.Controls.Add(this.rjDatePicker2);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton6);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.DgvSatilan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "satilanurunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satılan Ürünler";
            this.Load += new System.EventHandler(this.satilanurunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSatilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSatilan;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisdolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisdolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn satistl;
        private System.Windows.Forms.DataGridViewTextBoxColumn satistarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker2;
    }
}