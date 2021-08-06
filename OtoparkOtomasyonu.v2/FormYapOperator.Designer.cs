
namespace OtoparkOtomasyonu.v2
{
    partial class FormYapOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYapOperator));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelbaslik = new System.Windows.Forms.Label();
            this.buttonGirisYAP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageKey = "previous.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 79);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.labelbaslik.Location = new System.Drawing.Point(261, 19);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(385, 44);
            this.labelbaslik.TabIndex = 59;
            this.labelbaslik.Text = "OPERATOR GİRİŞ YAP";
            this.labelbaslik.Click += new System.EventHandler(this.labelbaslik_Click);
            // 
            // buttonGirisYAP
            // 
            this.buttonGirisYAP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGirisYAP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGirisYAP.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGirisYAP.Location = new System.Drawing.Point(377, 248);
            this.buttonGirisYAP.Name = "buttonGirisYAP";
            this.buttonGirisYAP.Size = new System.Drawing.Size(201, 47);
            this.buttonGirisYAP.TabIndex = 58;
            this.buttonGirisYAP.Text = "GİRİŞ YAP";
            this.buttonGirisYAP.UseVisualStyleBackColor = false;
            this.buttonGirisYAP.Click += new System.EventHandler(this.buttonGirisYAP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Şifreniz";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsifre.Location = new System.Drawing.Point(378, 199);
            this.textBoxsifre.MaxLength = 15;
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.PasswordChar = '*';
            this.textBoxsifre.Size = new System.Drawing.Size(200, 22);
            this.textBoxsifre.TabIndex = 56;
            this.textBoxsifre.TextChanged += new System.EventHandler(this.textBoxsifre_TextChanged);
            // 
            // textBoxtc
            // 
            this.textBoxtc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtc.Location = new System.Drawing.Point(378, 159);
            this.textBoxtc.MaxLength = 11;
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(200, 22);
            this.textBoxtc.TabIndex = 55;
            this.textBoxtc.TextChanged += new System.EventHandler(this.textBoxtc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "TC NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormYapOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelbaslik);
            this.Controls.Add(this.buttonGirisYAP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxtc);
            this.Controls.Add(this.label1);
            this.Name = "FormYapOperator";
            this.Text = "FormYapOperator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.Button buttonGirisYAP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.TextBox textBoxtc;
        private System.Windows.Forms.Label label1;
    }
}