namespace BooksAndAuthor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbAuthorBookAd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.btnYAzsil = new System.Windows.Forms.Button();
            this.btnyzGunc = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cbAutorAdd = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAutorSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Açıklama";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(28, 58);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 15);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Yazar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(68, 84);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(322, 23);
            this.txtDesc.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 23);
            this.txtAd.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(315, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 35);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(212, 35);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(51, 29);
            this.btnYazarEkle.TabIndex = 6;
            this.btnYazarEkle.Text = "Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(215, 22);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 36);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbAuthorBookAd
            // 
            this.cbAuthorBookAd.FormattingEnabled = true;
            this.cbAuthorBookAd.Location = new System.Drawing.Point(70, 52);
            this.cbAuthorBookAd.Name = "cbAuthorBookAd";
            this.cbAuthorBookAd.Size = new System.Drawing.Size(121, 23);
            this.cbAuthorBookAd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ad";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(67, 41);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(121, 23);
            this.txtYazarAd.TabIndex = 17;
            // 
            // btnYAzsil
            // 
            this.btnYAzsil.Location = new System.Drawing.Point(348, 34);
            this.btnYAzsil.Name = "btnYAzsil";
            this.btnYAzsil.Size = new System.Drawing.Size(49, 29);
            this.btnYAzsil.TabIndex = 15;
            this.btnYAzsil.Text = "Sil";
            this.btnYAzsil.UseVisualStyleBackColor = true;
            this.btnYAzsil.Click += new System.EventHandler(this.btnYAzsil_Click);
            // 
            // btnyzGunc
            // 
            this.btnyzGunc.Location = new System.Drawing.Point(273, 34);
            this.btnyzGunc.Name = "btnyzGunc";
            this.btnyzGunc.Size = new System.Drawing.Size(65, 29);
            this.btnyzGunc.TabIndex = 16;
            this.btnyzGunc.Text = "Güncelle";
            this.btnyzGunc.UseVisualStyleBackColor = true;
            this.btnyzGunc.Click += new System.EventHandler(this.btnyzGunc_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(67, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 23);
            this.txtSoyad.TabIndex = 17;
            // 
            // cbAutorAdd
            // 
            this.cbAutorAdd.FormattingEnabled = true;
            this.cbAutorAdd.Location = new System.Drawing.Point(212, 72);
            this.cbAutorAdd.Name = "cbAutorAdd";
            this.cbAutorAdd.Size = new System.Drawing.Size(186, 23);
            this.cbAutorAdd.TabIndex = 14;
            this.cbAutorAdd.SelectedIndexChanged += new System.EventHandler(this.cbAutorAdd_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(304, 113);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 29);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(370, 6);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 59);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "Listele";
            this.toolTip1.SetToolTip(this.btnListele, "Listelemek istediğiniz yazarı seçin \\n Tüm kitapları görmek için yazar seçimi yap" +
        "mayın");
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yazar Seç";
            // 
            // cbAutorSearch
            // 
            this.cbAutorSearch.FormattingEnabled = true;
            this.cbAutorSearch.Location = new System.Drawing.Point(81, 6);
            this.cbAutorSearch.Name = "cbAutorSearch";
            this.cbAutorSearch.Size = new System.Drawing.Size(196, 23);
            this.cbAutorSearch.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAuthorBookAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 161);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYAzsil);
            this.groupBox2.Controls.Add(this.btnYazarEkle);
            this.groupBox2.Controls.Add(this.cbAutorAdd);
            this.groupBox2.Controls.Add(this.btnyzGunc);
            this.groupBox2.Controls.Add(this.txtYazarAd);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(-2, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 123);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazar Ekle";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Listelemek istediğiniz yazarı seçin,Tüm kitapları görmek için yazar seçimi yapmay" +
    "ın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbAutorSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private Label lbl2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtAd;
        private Button btnSil;
        private Button btnYazarEkle;
        private Button btnGuncelle;
        private ComboBox cbAuthorBookAd;
        private Label label2;
        private Label label4;
        private TextBox txtYazarAd;
        private Button btnYAzsil;
        private Button btnyzGunc;
        private TextBox txtSoyad;
        private ComboBox cbAutorAdd;
        private Button btnEkle;
        private Button btnListele;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ComboBox cbAutorSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolTip toolTip1;
    }
}