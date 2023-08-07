namespace Hareketler
{
    partial class MusteriEkleme
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtmusteriara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnmusterisil = new System.Windows.Forms.Button();
            this.btnmusterikle = new System.Windows.Forms.Button();
            this.txtmusterikle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmusteriguncelle = new System.Windows.Forms.Button();
            this.txtyenimusteriad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtmusteriara
            // 
            this.txtmusteriara.Location = new System.Drawing.Point(133, 207);
            this.txtmusteriara.Name = "txtmusteriara";
            this.txtmusteriara.Size = new System.Drawing.Size(146, 27);
            this.txtmusteriara.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btnmusterisil);
            this.groupBox2.Controls.Add(this.btnmusterikle);
            this.groupBox2.Controls.Add(this.txtmusterikle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(413, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 217);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Ekleme Silme";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 27);
            this.comboBox2.TabIndex = 14;
            // 
            // btnmusterisil
            // 
            this.btnmusterisil.Location = new System.Drawing.Point(173, 159);
            this.btnmusterisil.Name = "btnmusterisil";
            this.btnmusterisil.Size = new System.Drawing.Size(146, 35);
            this.btnmusterisil.TabIndex = 15;
            this.btnmusterisil.Text = "Müşteri Sil";
            this.btnmusterisil.UseVisualStyleBackColor = true;
            this.btnmusterisil.Click += new System.EventHandler(this.btnmusterisil_Click);
            // 
            // btnmusterikle
            // 
            this.btnmusterikle.Location = new System.Drawing.Point(173, 56);
            this.btnmusterikle.Name = "btnmusterikle";
            this.btnmusterikle.Size = new System.Drawing.Size(146, 35);
            this.btnmusterikle.TabIndex = 14;
            this.btnmusterikle.Text = "Müşteri Ekle";
            this.btnmusterikle.UseVisualStyleBackColor = true;
            this.btnmusterikle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // txtmusterikle
            // 
            this.txtmusterikle.Location = new System.Drawing.Point(173, 23);
            this.txtmusterikle.Name = "txtmusterikle";
            this.txtmusterikle.Size = new System.Drawing.Size(146, 27);
            this.txtmusterikle.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri Ekleme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri Silme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Müşteri Arama:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmusteriguncelle);
            this.groupBox1.Controls.Add(this.txtyenimusteriad);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 153);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Güncelleme Kısmı";
            // 
            // btnmusteriguncelle
            // 
            this.btnmusteriguncelle.Location = new System.Drawing.Point(183, 104);
            this.btnmusteriguncelle.Name = "btnmusteriguncelle";
            this.btnmusteriguncelle.Size = new System.Drawing.Size(146, 35);
            this.btnmusteriguncelle.TabIndex = 13;
            this.btnmusteriguncelle.Text = "Müşteri Güncelle";
            this.btnmusteriguncelle.UseVisualStyleBackColor = true;
            this.btnmusteriguncelle.Click += new System.EventHandler(this.btnmusteriguncelle_Click);
            // 
            // txtyenimusteriad
            // 
            this.txtyenimusteriad.Location = new System.Drawing.Point(183, 71);
            this.txtyenimusteriad.Name = "txtyenimusteriad";
            this.txtyenimusteriad.Size = new System.Drawing.Size(146, 27);
            this.txtyenimusteriad.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 27);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri Seç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yeni Müşteri Adı:";
            // 
            // MusteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtmusteriara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriEkleme";
            this.Text = "MusteriEkleme";
            this.Load += new System.EventHandler(this.MusteriEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmusteriara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnmusterisil;
        private System.Windows.Forms.Button btnmusterikle;
        private System.Windows.Forms.TextBox txtmusterikle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmusteriguncelle;
        private System.Windows.Forms.TextBox txtyenimusteriad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}