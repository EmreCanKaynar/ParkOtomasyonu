
namespace OtoparkOtomasyonu.v2
{
    partial class FormKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKaydol));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelbaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxsifretekrar = new System.Windows.Forms.TextBox();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.comboBoxyetki = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labeltckontrol = new System.Windows.Forms.Label();
            this.labeladkontrol = new System.Windows.Forms.Label();
            this.labelsoyadkontrol = new System.Windows.Forms.Label();
            this.labeltelnokontrol = new System.Windows.Forms.Label();
            this.labelemailkontrol = new System.Windows.Forms.Label();
            this.labelsifrekontrol = new System.Windows.Forms.Label();
            this.labelsifretekrarkontrol = new System.Windows.Forms.Label();
            this.labelyetkikontrol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.textBoxtelno = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "admin.png");
            this.ımageList1.Images.SetKeyName(1, "operator.png");
            this.ımageList1.Images.SetKeyName(2, "previous.png");
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelbaslik.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslik.Location = new System.Drawing.Point(438, 18);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(176, 44);
            this.labelbaslik.TabIndex = 8;
            this.labelbaslik.Text = "KAYIT OL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC NO";
            // 
            // textBoxad
            // 
            this.textBoxad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxad.Location = new System.Drawing.Point(430, 137);
            this.textBoxad.MaxLength = 30;
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(217, 24);
            this.textBoxad.TabIndex = 16;
            this.textBoxad.TextChanged += new System.EventHandler(this.textBoxad_TextChanged);
            this.textBoxad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxad_KeyPress);
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsoyad.Location = new System.Drawing.Point(429, 181);
            this.textBoxsoyad.MaxLength = 30;
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(218, 24);
            this.textBoxsoyad.TabIndex = 17;
            this.textBoxsoyad.TextChanged += new System.EventHandler(this.textBoxsoyad_TextChanged);
            this.textBoxsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsoyad_KeyPress);
            // 
            // textBoxemail
            // 
            this.textBoxemail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxemail.Location = new System.Drawing.Point(429, 273);
            this.textBoxemail.MaxLength = 30;
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(91, 24);
            this.textBoxemail.TabIndex = 19;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsifre.Location = new System.Drawing.Point(430, 322);
            this.textBoxsifre.MaxLength = 15;
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.PasswordChar = '*';
            this.textBoxsifre.Size = new System.Drawing.Size(217, 24);
            this.textBoxsifre.TabIndex = 20;
            this.textBoxsifre.TextChanged += new System.EventHandler(this.textBoxsifre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyadınız";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TEL NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "E-mail adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Şifreniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Şifre Tekrar";
            // 
            // textBoxsifretekrar
            // 
            this.textBoxsifretekrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsifretekrar.Location = new System.Drawing.Point(433, 372);
            this.textBoxsifretekrar.MaxLength = 15;
            this.textBoxsifretekrar.Name = "textBoxsifretekrar";
            this.textBoxsifretekrar.PasswordChar = '*';
            this.textBoxsifretekrar.Size = new System.Drawing.Size(214, 24);
            this.textBoxsifretekrar.TabIndex = 22;
            this.textBoxsifretekrar.TextChanged += new System.EventHandler(this.textBoxsifretekrar_TextChanged);
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKayıtOl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayıtOl.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKayıtOl.Location = new System.Drawing.Point(429, 465);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(201, 47);
            this.buttonKayıtOl.TabIndex = 24;
            this.buttonKayıtOl.Text = "KAYDOL";
            this.buttonKayıtOl.UseVisualStyleBackColor = false;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // comboBoxyetki
            // 
            this.comboBoxyetki.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxyetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxyetki.FormattingEnabled = true;
            this.comboBoxyetki.Items.AddRange(new object[] {
            "Operator",
            "Admin"});
            this.comboBoxyetki.Location = new System.Drawing.Point(430, 415);
            this.comboBoxyetki.Name = "comboBoxyetki";
            this.comboBoxyetki.Size = new System.Drawing.Size(217, 26);
            this.comboBoxyetki.TabIndex = 25;
            this.comboBoxyetki.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Yetki";
            // 
            // labeltckontrol
            // 
            this.labeltckontrol.AutoSize = true;
            this.labeltckontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltckontrol.Location = new System.Drawing.Point(3, 2);
            this.labeltckontrol.Name = "labeltckontrol";
            this.labeltckontrol.Size = new System.Drawing.Size(0, 18);
            this.labeltckontrol.TabIndex = 27;
            this.labeltckontrol.Click += new System.EventHandler(this.labeltckontrol_Click);
            // 
            // labeladkontrol
            // 
            this.labeladkontrol.AutoSize = true;
            this.labeladkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladkontrol.Location = new System.Drawing.Point(3, 44);
            this.labeladkontrol.Name = "labeladkontrol";
            this.labeladkontrol.Size = new System.Drawing.Size(0, 18);
            this.labeladkontrol.TabIndex = 28;
            // 
            // labelsoyadkontrol
            // 
            this.labelsoyadkontrol.AutoSize = true;
            this.labelsoyadkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyadkontrol.Location = new System.Drawing.Point(3, 92);
            this.labelsoyadkontrol.Name = "labelsoyadkontrol";
            this.labelsoyadkontrol.Size = new System.Drawing.Size(0, 18);
            this.labelsoyadkontrol.TabIndex = 29;
            // 
            // labeltelnokontrol
            // 
            this.labeltelnokontrol.AutoSize = true;
            this.labeltelnokontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltelnokontrol.Location = new System.Drawing.Point(3, 140);
            this.labeltelnokontrol.Name = "labeltelnokontrol";
            this.labeltelnokontrol.Size = new System.Drawing.Size(0, 18);
            this.labeltelnokontrol.TabIndex = 30;
            // 
            // labelemailkontrol
            // 
            this.labelemailkontrol.AutoSize = true;
            this.labelemailkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelemailkontrol.Location = new System.Drawing.Point(3, 183);
            this.labelemailkontrol.Name = "labelemailkontrol";
            this.labelemailkontrol.Size = new System.Drawing.Size(0, 18);
            this.labelemailkontrol.TabIndex = 31;
            // 
            // labelsifrekontrol
            // 
            this.labelsifrekontrol.AutoSize = true;
            this.labelsifrekontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsifrekontrol.Location = new System.Drawing.Point(3, 231);
            this.labelsifrekontrol.Name = "labelsifrekontrol";
            this.labelsifrekontrol.Size = new System.Drawing.Size(0, 18);
            this.labelsifrekontrol.TabIndex = 32;
            // 
            // labelsifretekrarkontrol
            // 
            this.labelsifretekrarkontrol.AutoSize = true;
            this.labelsifretekrarkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsifretekrarkontrol.Location = new System.Drawing.Point(3, 278);
            this.labelsifretekrarkontrol.Name = "labelsifretekrarkontrol";
            this.labelsifretekrarkontrol.Size = new System.Drawing.Size(0, 18);
            this.labelsifretekrarkontrol.TabIndex = 33;
            // 
            // labelyetkikontrol
            // 
            this.labelyetkikontrol.AutoSize = true;
            this.labelyetkikontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyetkikontrol.ForeColor = System.Drawing.Color.Red;
            this.labelyetkikontrol.Location = new System.Drawing.Point(3, 321);
            this.labelyetkikontrol.Name = "labelyetkikontrol";
            this.labelyetkikontrol.Size = new System.Drawing.Size(192, 18);
            this.labelyetkikontrol.TabIndex = 34;
            this.labelyetkikontrol.Text = "Bu alan boş bırakılamaz!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelsifretekrarkontrol);
            this.panel1.Controls.Add(this.labelyetkikontrol);
            this.panel1.Controls.Add(this.labeltckontrol);
            this.panel1.Controls.Add(this.labeladkontrol);
            this.panel1.Controls.Add(this.labelsifrekontrol);
            this.panel1.Controls.Add(this.labelsoyadkontrol);
            this.panel1.Controls.Add(this.labelemailkontrol);
            this.panel1.Controls.Add(this.labeltelnokontrol);
            this.panel1.Location = new System.Drawing.Point(668, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 346);
            this.panel1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageKey = "previous.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 79);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxtc
            // 
            this.textBoxtc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtc.Location = new System.Drawing.Point(430, 95);
            this.textBoxtc.MaxLength = 11;
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(217, 24);
            this.textBoxtc.TabIndex = 15;
            this.textBoxtc.TextChanged += new System.EventHandler(this.textBoxtc_TextChanged);
            this.textBoxtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtc_KeyPress);
            // 
            // textBoxtelno
            // 
            this.textBoxtelno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtelno.Location = new System.Drawing.Point(430, 228);
            this.textBoxtelno.Mask = "(###) ###-####";
            this.textBoxtelno.Name = "textBoxtelno";
            this.textBoxtelno.Size = new System.Drawing.Size(217, 24);
            this.textBoxtelno.TabIndex = 55;
            this.textBoxtelno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxtelno_MaskInputRejected);
            this.textBoxtelno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtelno_KeyPress_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "@hotmail.com",
            "@gmail.com",
            "@yahoo.com",
            "@outlive.com",
            "@outlook.com"});
            this.comboBox1.Location = new System.Drawing.Point(526, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 56;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 536);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxtelno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxyetki);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxsifretekrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.textBoxtc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelbaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormKaydol";
            this.Text = "FormKaydol";
            this.Load += new System.EventHandler(this.FormKaydol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxsifretekrar;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.ComboBox comboBoxyetki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeltckontrol;
        private System.Windows.Forms.Label labeladkontrol;
        private System.Windows.Forms.Label labelsoyadkontrol;
        private System.Windows.Forms.Label labeltelnokontrol;
        private System.Windows.Forms.Label labelemailkontrol;
        private System.Windows.Forms.Label labelsifrekontrol;
        private System.Windows.Forms.Label labelsifretekrarkontrol;
        private System.Windows.Forms.Label labelyetkikontrol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxtc;
        private System.Windows.Forms.MaskedTextBox textBoxtelno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}