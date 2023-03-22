namespace wfacrud
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSirket = new System.Windows.Forms.TextBox();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.bntEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şirket";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 29);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 0;
            // 
            // txtSirket
            // 
            this.txtSirket.Location = new System.Drawing.Point(124, 58);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Size = new System.Drawing.Size(100, 23);
            this.txtSirket.TabIndex = 1;
            // 
            // dgw1
            // 
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(12, 113);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.RowTemplate.Height = 25;
            this.dgw1.Size = new System.Drawing.Size(750, 236);
            this.dgw1.TabIndex = 2;
            this.dgw1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellEndEdit);
            this.dgw1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellEndEdit);
            // 
            // bntEkle
            // 
            this.bntEkle.Location = new System.Drawing.Point(309, 53);
            this.bntEkle.Name = "bntEkle";
            this.bntEkle.Size = new System.Drawing.Size(75, 23);
            this.bntEkle.TabIndex = 3;
            this.bntEkle.Text = "Ekle";
            this.bntEkle.UseVisualStyleBackColor = true;
            this.bntEkle.Click += new System.EventHandler(this.txtEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(429, 53);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(563, 53);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.bntEkle);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtSirket;
        private DataGridView dgw1;
        private Button bntEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}