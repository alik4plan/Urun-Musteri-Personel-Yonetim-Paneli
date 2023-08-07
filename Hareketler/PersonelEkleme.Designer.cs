namespace Hareketler
{
    partial class PersonelEkleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyenipersonelad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpersonekle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpersonguncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnpersonsil = new System.Windows.Forms.Button();
            this.btnpersonekle = new System.Windows.Forms.Button();
            this.txtpersonelara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personel Ekleme:";
            // 
            // txtyenipersonelad
            // 
            this.txtyenipersonelad.Location = new System.Drawing.Point(183, 71);
            this.txtyenipersonelad.Name = "txtyenipersonelad";
            this.txtyenipersonelad.Size = new System.Drawing.Size(146, 27);
            this.txtyenipersonelad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yeni Personel Adı:";
            // 
            // txtpersonekle
            // 
            this.txtpersonekle.Location = new System.Drawing.Point(173, 23);
            this.txtpersonekle.Name = "txtpersonekle";
            this.txtpersonekle.Size = new System.Drawing.Size(146, 27);
            this.txtpersonekle.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Personel Silme:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 27);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpersonguncelle);
            this.groupBox1.Controls.Add(this.txtyenipersonelad);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(44, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Güncelleme Kısmı";
            // 
            // btnpersonguncelle
            // 
            this.btnpersonguncelle.Location = new System.Drawing.Point(183, 104);
            this.btnpersonguncelle.Name = "btnpersonguncelle";
            this.btnpersonguncelle.Size = new System.Drawing.Size(146, 35);
            this.btnpersonguncelle.TabIndex = 13;
            this.btnpersonguncelle.Text = "Personel Güncelle";
            this.btnpersonguncelle.UseVisualStyleBackColor = true;
            this.btnpersonguncelle.Click += new System.EventHandler(this.btnpersonguncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btnpersonsil);
            this.groupBox2.Controls.Add(this.btnpersonekle);
            this.groupBox2.Controls.Add(this.txtpersonekle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(436, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 217);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Ekleme Silme";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 27);
            this.comboBox2.TabIndex = 14;
            // 
            // btnpersonsil
            // 
            this.btnpersonsil.Location = new System.Drawing.Point(173, 159);
            this.btnpersonsil.Name = "btnpersonsil";
            this.btnpersonsil.Size = new System.Drawing.Size(146, 35);
            this.btnpersonsil.TabIndex = 15;
            this.btnpersonsil.Text = "Personel Sil";
            this.btnpersonsil.UseVisualStyleBackColor = true;
            this.btnpersonsil.Click += new System.EventHandler(this.btnpersonsil_Click);
            // 
            // btnpersonekle
            // 
            this.btnpersonekle.Location = new System.Drawing.Point(173, 56);
            this.btnpersonekle.Name = "btnpersonekle";
            this.btnpersonekle.Size = new System.Drawing.Size(146, 35);
            this.btnpersonekle.TabIndex = 14;
            this.btnpersonekle.Text = "Personel Ekle";
            this.btnpersonekle.UseVisualStyleBackColor = true;
            this.btnpersonekle.Click += new System.EventHandler(this.btnpersonekle_Click);
            // 
            // txtpersonelara
            // 
            this.txtpersonelara.Location = new System.Drawing.Point(156, 219);
            this.txtpersonelara.Name = "txtpersonelara";
            this.txtpersonelara.Size = new System.Drawing.Size(146, 27);
            this.txtpersonelara.TabIndex = 17;
            this.txtpersonelara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Personel Arama:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtpersonelara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelEkleme";
            this.Text = "PersonelEkleme";
            this.Load += new System.EventHandler(this.PersonelEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyenipersonelad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpersonekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpersonguncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnpersonsil;
        private System.Windows.Forms.Button btnpersonekle;
        private System.Windows.Forms.TextBox txtpersonelara;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}