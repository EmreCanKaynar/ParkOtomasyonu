
namespace OtoparkOtomasyonu.v2
{
    partial class FormAracKayit
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRenkler = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.comboBoxYakit = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 317);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(717, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Yakit";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(288, 169);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(156, 44);
            this.buttonGuncelle.TabIndex = 27;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(509, 169);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(156, 44);
            this.buttonSil.TabIndex = 26;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(68, 169);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(156, 44);
            this.buttonEkle.TabIndex = 25;
            this.buttonEkle.Text = "Kaydet";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(386, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Renk";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 36);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 27);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(717, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tip";
            // 
            // comboBoxRenkler
            // 
            this.comboBoxRenkler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRenkler.FormattingEnabled = true;
            this.comboBoxRenkler.Location = new System.Drawing.Point(204, 96);
            this.comboBoxRenkler.Name = "comboBoxRenkler";
            this.comboBoxRenkler.Size = new System.Drawing.Size(149, 27);
            this.comboBoxRenkler.TabIndex = 37;
            this.comboBoxRenkler.SelectedIndexChanged += new System.EventHandler(this.comboBoxRenkler_SelectedIndexChanged);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(497, 31);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(149, 27);
            this.comboBoxMarka.TabIndex = 38;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(825, 94);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(149, 27);
            this.comboBoxTip.TabIndex = 39;
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_SelectedIndexChanged);
            // 
            // comboBoxYakit
            // 
            this.comboBoxYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYakit.FormattingEnabled = true;
            this.comboBoxYakit.Location = new System.Drawing.Point(825, 33);
            this.comboBoxYakit.Name = "comboBoxYakit";
            this.comboBoxYakit.Size = new System.Drawing.Size(149, 27);
            this.comboBoxYakit.TabIndex = 40;
            this.comboBoxYakit.SelectedIndexChanged += new System.EventHandler(this.comboBoxYakit_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(498, 94);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(149, 27);
            this.comboBoxModel.TabIndex = 41;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonYenile);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxTip);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxYakit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMarka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxRenkler);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1143, 227);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(963, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 44);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(733, 169);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(156, 44);
            this.buttonYenile.TabIndex = 31;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // FormAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1143, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAracKayit";
            this.Text = "FormAracKayit";
            this.Load += new System.EventHandler(this.FormAracKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRenkler;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.ComboBox comboBoxYakit;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.TextBox textBox1;
    }
}