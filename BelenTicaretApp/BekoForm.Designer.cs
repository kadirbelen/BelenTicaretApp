namespace BelenTicaretApp
{
    partial class BekoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BekoForm));
            this.lblBekoUrun = new System.Windows.Forms.Label();
            this.lblBekoFiyat = new System.Windows.Forms.Label();
            this.lblBekoMiktar = new System.Windows.Forms.Label();
            this.txtBekoUrun = new System.Windows.Forms.TextBox();
            this.txtBekoFiyat = new System.Windows.Forms.TextBox();
            this.txtBekoMiktar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBekoEkleme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBekoUpdate = new System.Windows.Forms.Button();
            this.txtBekoFiyatUpdate = new System.Windows.Forms.TextBox();
            this.txtBekoMiktarUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBekoUrunUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBekoClearUpdate = new System.Windows.Forms.Button();
            this.btnClearBeko = new System.Windows.Forms.Button();
            this.btnGeriBeko = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBekoUrun
            // 
            this.lblBekoUrun.AutoSize = true;
            this.lblBekoUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekoUrun.Location = new System.Drawing.Point(22, 35);
            this.lblBekoUrun.Name = "lblBekoUrun";
            this.lblBekoUrun.Size = new System.Drawing.Size(44, 18);
            this.lblBekoUrun.TabIndex = 0;
            this.lblBekoUrun.Text = "Ürün ";
            // 
            // lblBekoFiyat
            // 
            this.lblBekoFiyat.AutoSize = true;
            this.lblBekoFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekoFiyat.Location = new System.Drawing.Point(22, 76);
            this.lblBekoFiyat.Name = "lblBekoFiyat";
            this.lblBekoFiyat.Size = new System.Drawing.Size(39, 18);
            this.lblBekoFiyat.TabIndex = 1;
            this.lblBekoFiyat.Text = "Fiyat";
            // 
            // lblBekoMiktar
            // 
            this.lblBekoMiktar.AutoSize = true;
            this.lblBekoMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekoMiktar.Location = new System.Drawing.Point(14, 121);
            this.lblBekoMiktar.Name = "lblBekoMiktar";
            this.lblBekoMiktar.Size = new System.Drawing.Size(49, 18);
            this.lblBekoMiktar.TabIndex = 2;
            this.lblBekoMiktar.Text = "Miktar";
            // 
            // txtBekoUrun
            // 
            this.txtBekoUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoUrun.Location = new System.Drawing.Point(154, 32);
            this.txtBekoUrun.Name = "txtBekoUrun";
            this.txtBekoUrun.Size = new System.Drawing.Size(100, 24);
            this.txtBekoUrun.TabIndex = 3;
            // 
            // txtBekoFiyat
            // 
            this.txtBekoFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoFiyat.Location = new System.Drawing.Point(154, 76);
            this.txtBekoFiyat.Name = "txtBekoFiyat";
            this.txtBekoFiyat.Size = new System.Drawing.Size(100, 24);
            this.txtBekoFiyat.TabIndex = 4;
            // 
            // txtBekoMiktar
            // 
            this.txtBekoMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoMiktar.Location = new System.Drawing.Point(154, 118);
            this.txtBekoMiktar.Name = "txtBekoMiktar";
            this.txtBekoMiktar.Size = new System.Drawing.Size(100, 24);
            this.txtBekoMiktar.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearBeko);
            this.groupBox1.Controls.Add(this.btnBekoEkleme);
            this.groupBox1.Controls.Add(this.txtBekoFiyat);
            this.groupBox1.Controls.Add(this.txtBekoMiktar);
            this.groupBox1.Controls.Add(this.lblBekoUrun);
            this.groupBox1.Controls.Add(this.lblBekoFiyat);
            this.groupBox1.Controls.Add(this.txtBekoUrun);
            this.groupBox1.Controls.Add(this.lblBekoMiktar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLEME";
            // 
            // btnBekoEkleme
            // 
            this.btnBekoEkleme.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBekoEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBekoEkleme.ForeColor = System.Drawing.Color.White;
            this.btnBekoEkleme.Location = new System.Drawing.Point(25, 168);
            this.btnBekoEkleme.Name = "btnBekoEkleme";
            this.btnBekoEkleme.Size = new System.Drawing.Size(97, 37);
            this.btnBekoEkleme.TabIndex = 6;
            this.btnBekoEkleme.Text = "EKLE";
            this.btnBekoEkleme.UseVisualStyleBackColor = false;
            this.btnBekoEkleme.Click += new System.EventHandler(this.btnBekoEkleme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 307);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBekoClearUpdate);
            this.groupBox2.Controls.Add(this.btnBekoUpdate);
            this.groupBox2.Controls.Add(this.txtBekoFiyatUpdate);
            this.groupBox2.Controls.Add(this.txtBekoMiktarUpdate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBekoUrunUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(899, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 244);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLEME";
            // 
            // btnBekoUpdate
            // 
            this.btnBekoUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBekoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBekoUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBekoUpdate.Location = new System.Drawing.Point(28, 168);
            this.btnBekoUpdate.Name = "btnBekoUpdate";
            this.btnBekoUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnBekoUpdate.TabIndex = 6;
            this.btnBekoUpdate.Text = "GÜNCELLE";
            this.btnBekoUpdate.UseVisualStyleBackColor = false;
            this.btnBekoUpdate.Click += new System.EventHandler(this.btnBekoUpdate_Click);
            // 
            // txtBekoFiyatUpdate
            // 
            this.txtBekoFiyatUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoFiyatUpdate.Location = new System.Drawing.Point(162, 80);
            this.txtBekoFiyatUpdate.Name = "txtBekoFiyatUpdate";
            this.txtBekoFiyatUpdate.Size = new System.Drawing.Size(114, 24);
            this.txtBekoFiyatUpdate.TabIndex = 4;
            // 
            // txtBekoMiktarUpdate
            // 
            this.txtBekoMiktarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoMiktarUpdate.Location = new System.Drawing.Point(162, 122);
            this.txtBekoMiktarUpdate.Name = "txtBekoMiktarUpdate";
            this.txtBekoMiktarUpdate.Size = new System.Drawing.Size(114, 24);
            this.txtBekoMiktarUpdate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // txtBekoUrunUpdate
            // 
            this.txtBekoUrunUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBekoUrunUpdate.Location = new System.Drawing.Point(162, 35);
            this.txtBekoUrunUpdate.Name = "txtBekoUrunUpdate";
            this.txtBekoUrunUpdate.Size = new System.Drawing.Size(114, 24);
            this.txtBekoUrunUpdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1046, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnBekoClearUpdate
            // 
            this.btnBekoClearUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBekoClearUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBekoClearUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBekoClearUpdate.Location = new System.Drawing.Point(197, 168);
            this.btnBekoClearUpdate.Name = "btnBekoClearUpdate";
            this.btnBekoClearUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnBekoClearUpdate.TabIndex = 10;
            this.btnBekoClearUpdate.Text = "TEMİZLE";
            this.btnBekoClearUpdate.UseVisualStyleBackColor = false;
            this.btnBekoClearUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearBeko
            // 
            this.btnClearBeko.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearBeko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearBeko.ForeColor = System.Drawing.Color.White;
            this.btnClearBeko.Location = new System.Drawing.Point(154, 168);
            this.btnClearBeko.Name = "btnClearBeko";
            this.btnClearBeko.Size = new System.Drawing.Size(130, 35);
            this.btnClearBeko.TabIndex = 11;
            this.btnClearBeko.Text = "TEMİZLE";
            this.btnClearBeko.UseVisualStyleBackColor = false;
            this.btnClearBeko.Click += new System.EventHandler(this.btnClearBeko_Click);
            // 
            // btnGeriBeko
            // 
            this.btnGeriBeko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBeko.Location = new System.Drawing.Point(559, 586);
            this.btnGeriBeko.Name = "btnGeriBeko";
            this.btnGeriBeko.Size = new System.Drawing.Size(121, 45);
            this.btnGeriBeko.TabIndex = 10;
            this.btnGeriBeko.Text = "GERİ ";
            this.btnGeriBeko.UseVisualStyleBackColor = true;
            this.btnGeriBeko.Click += new System.EventHandler(this.btnGeriBeko_Click);
            // 
            // BekoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1304, 684);
            this.Controls.Add(this.btnGeriBeko);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BekoForm";
            this.Text = "BekoForm";
            this.Load += new System.EventHandler(this.BekoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBekoUrun;
        private System.Windows.Forms.Label lblBekoFiyat;
        private System.Windows.Forms.Label lblBekoMiktar;
        private System.Windows.Forms.TextBox txtBekoUrun;
        private System.Windows.Forms.TextBox txtBekoFiyat;
        private System.Windows.Forms.TextBox txtBekoMiktar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBekoEkleme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBekoUpdate;
        private System.Windows.Forms.TextBox txtBekoFiyatUpdate;
        private System.Windows.Forms.TextBox txtBekoMiktarUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBekoUrunUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBekoClearUpdate;
        private System.Windows.Forms.Button btnClearBeko;
        private System.Windows.Forms.Button btnGeriBeko;
    }
}