﻿
namespace OtoparkOtomasyonu.v2
{
    partial class FormGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisYap));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonGirisYAP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelbaslik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // buttonGirisYAP
            // 
            this.buttonGirisYAP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGirisYAP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGirisYAP.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGirisYAP.Location = new System.Drawing.Point(330, 261);
            this.buttonGirisYAP.Name = "buttonGirisYAP";
            this.buttonGirisYAP.Size = new System.Drawing.Size(201, 47);
            this.buttonGirisYAP.TabIndex = 51;
            this.buttonGirisYAP.Text = "GİRİŞ YAP";
            this.buttonGirisYAP.UseVisualStyleBackColor = false;
            this.buttonGirisYAP.Click += new System.EventHandler(this.buttonGirisYAP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Şifreniz";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxsifre.Location = new System.Drawing.Point(331, 214);
            this.textBoxsifre.MaxLength = 15;
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.PasswordChar = '*';
            this.textBoxsifre.Size = new System.Drawing.Size(200, 22);
            this.textBoxsifre.TabIndex = 47;
            this.textBoxsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxsifre_KeyDown);
            // 
            // textBoxtc
            // 
            this.textBoxtc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtc.Location = new System.Drawing.Point(331, 174);
            this.textBoxtc.MaxLength = 11;
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(200, 22);
            this.textBoxtc.TabIndex = 42;
            this.textBoxtc.TextChanged += new System.EventHandler(this.textBoxtc_TextChanged);
            this.textBoxtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "TC NO";
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelbaslik.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslik.Location = new System.Drawing.Point(261, 26);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(322, 44);
            this.labelbaslik.TabIndex = 52;
            this.labelbaslik.Text = "ADMİN GİRİŞ YAP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageKey = "previous.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 79);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelbaslik);
            this.Controls.Add(this.buttonGirisYAP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxtc);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "FormGirisYap";
            this.Text = "FormGirisYap";
            this.Load += new System.EventHandler(this.FormGirisYap_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGirisYap_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonGirisYAP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.TextBox textBoxtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.Button button1;
    }
}