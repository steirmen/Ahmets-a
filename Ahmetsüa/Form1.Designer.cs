namespace Ahmetsüa
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kyt = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_scsil = new System.Windows.Forms.Button();
            this.btn_hsil = new System.Windows.Forms.Button();
            this.btn_dosyakaydet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sayac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_duzelt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // btn_kyt
            // 
            this.btn_kyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kyt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kyt.ImageKey = "artı işareti.png";
            this.btn_kyt.ImageList = this.ımageList1;
            this.btn_kyt.Location = new System.Drawing.Point(63, 165);
            this.btn_kyt.Name = "btn_kyt";
            this.btn_kyt.Size = new System.Drawing.Size(86, 31);
            this.btn_kyt.TabIndex = 2;
            this.btn_kyt.Text = "Yeni Kayıt";
            this.btn_kyt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kyt.UseVisualStyleBackColor = true;
            this.btn_kyt.Click += new System.EventHandler(this.btn_kyt_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "artı işareti.png");
            this.ımageList1.Images.SetKeyName(1, "çarpı işareti.png");
            this.ımageList1.Images.SetKeyName(2, "çöp kutusu.png");
            this.ımageList1.Images.SetKeyName(3, "dosyaya kaydet.png");
            this.ımageList1.Images.SetKeyName(4, "kaydet işareti.png");
            this.ımageList1.Images.SetKeyName(5, "çöp.png");
            this.ımageList1.Images.SetKeyName(6, "kalemmm.png");
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageKey = "kaydet işareti.png";
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(183, 165);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(76, 31);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_scsil
            // 
            this.btn_scsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_scsil.ImageKey = "çarpı işareti.png";
            this.btn_scsil.ImageList = this.ımageList1;
            this.btn_scsil.Location = new System.Drawing.Point(44, 558);
            this.btn_scsil.Name = "btn_scsil";
            this.btn_scsil.Size = new System.Drawing.Size(105, 38);
            this.btn_scsil.TabIndex = 5;
            this.btn_scsil.Text = "Seçilenleri Sil";
            this.btn_scsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_scsil.UseVisualStyleBackColor = true;
            this.btn_scsil.Click += new System.EventHandler(this.btn_scsil_Click);
            // 
            // btn_hsil
            // 
            this.btn_hsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hsil.ImageKey = "çöp.png";
            this.btn_hsil.ImageList = this.ımageList1;
            this.btn_hsil.Location = new System.Drawing.Point(183, 558);
            this.btn_hsil.Name = "btn_hsil";
            this.btn_hsil.Size = new System.Drawing.Size(104, 38);
            this.btn_hsil.TabIndex = 6;
            this.btn_hsil.Text = "Hepsini Sil";
            this.btn_hsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hsil.UseVisualStyleBackColor = true;
            this.btn_hsil.Click += new System.EventHandler(this.btn_hsil_Click);
            // 
            // btn_dosyakaydet
            // 
            this.btn_dosyakaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dosyakaydet.ImageKey = "dosyaya kaydet.png";
            this.btn_dosyakaydet.ImageList = this.ımageList1;
            this.btn_dosyakaydet.Location = new System.Drawing.Point(316, 558);
            this.btn_dosyakaydet.Name = "btn_dosyakaydet";
            this.btn_dosyakaydet.Size = new System.Drawing.Size(125, 38);
            this.btn_dosyakaydet.TabIndex = 7;
            this.btn_dosyakaydet.Text = "Dosyaya kaydet";
            this.btn_dosyakaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dosyakaydet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.textBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseMove);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Hatırlatma";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sayac
            // 
            this.sayac.AutoSize = true;
            this.sayac.Location = new System.Drawing.Point(168, 238);
            this.sayac.Name = "sayac";
            this.sayac.Size = new System.Drawing.Size(35, 13);
            this.sayac.TabIndex = 12;
            this.sayac.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kayıt Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-3, 290);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(511, 238);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ahmetsüa.Properties.Resources.saat_deneme;
            this.pictureBox1.Location = new System.Drawing.Point(76, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_duzelt.ImageKey = "kalemmm.png";
            this.btn_duzelt.ImageList = this.ımageList1;
            this.btn_duzelt.Location = new System.Drawing.Point(292, 165);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(72, 31);
            this.btn_duzelt.TabIndex = 4;
            this.btn_duzelt.Text = "Düzelt";
            this.btn_duzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_duzelt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 613);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sayac);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_dosyakaydet);
            this.Controls.Add(this.btn_hsil);
            this.Controls.Add(this.btn_scsil);
            this.Controls.Add(this.btn_duzelt);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_kyt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Takibi 1.0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kyt;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Button btn_scsil;
        private System.Windows.Forms.Button btn_hsil;
        private System.Windows.Forms.Button btn_dosyakaydet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label sayac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

