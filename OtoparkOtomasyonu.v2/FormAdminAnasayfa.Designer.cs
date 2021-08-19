
namespace OtoparkOtomasyonu.v2
{
    partial class FormAdminAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAnasayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdminAyarlar = new System.Windows.Forms.Button();
            this.buttonMusteriKayit = new System.Windows.Forms.Button();
            this.buttonParkYeriSorgu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAracKayit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "admin.png");
            this.ımageList1.Images.SetKeyName(1, "operator.png");
            this.ımageList1.Images.SetKeyName(2, "parking.png");
            this.ımageList1.Images.SetKeyName(3, "customer.png");
            this.ımageList1.Images.SetKeyName(4, "racing-car.png");
            // 
            // buttonAdminAyarlar
            // 
            this.buttonAdminAyarlar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdminAyarlar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdminAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminAyarlar.ImageKey = "admin.png";
            this.buttonAdminAyarlar.ImageList = this.ımageList1;
            this.buttonAdminAyarlar.Location = new System.Drawing.Point(1450, 12);
            this.buttonAdminAyarlar.Name = "buttonAdminAyarlar";
            this.buttonAdminAyarlar.Size = new System.Drawing.Size(386, 80);
            this.buttonAdminAyarlar.TabIndex = 7;
            this.buttonAdminAyarlar.Text = "     AYARLAR";
            this.buttonAdminAyarlar.UseVisualStyleBackColor = false;
            // 
            // buttonMusteriKayit
            // 
            this.buttonMusteriKayit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMusteriKayit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteriKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusteriKayit.ImageKey = "customer.png";
            this.buttonMusteriKayit.ImageList = this.ımageList1;
            this.buttonMusteriKayit.Location = new System.Drawing.Point(533, 12);
            this.buttonMusteriKayit.Name = "buttonMusteriKayit";
            this.buttonMusteriKayit.Size = new System.Drawing.Size(416, 80);
            this.buttonMusteriKayit.TabIndex = 7;
            this.buttonMusteriKayit.Text = "MÜŞTERİ KAYIT";
            this.buttonMusteriKayit.UseVisualStyleBackColor = false;
            this.buttonMusteriKayit.Click += new System.EventHandler(this.buttonMusteriKayit_Click);
            // 
            // buttonParkYeriSorgu
            // 
            this.buttonParkYeriSorgu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonParkYeriSorgu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonParkYeriSorgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParkYeriSorgu.ImageKey = "parking.png";
            this.buttonParkYeriSorgu.ImageList = this.ımageList1;
            this.buttonParkYeriSorgu.Location = new System.Drawing.Point(47, 12);
            this.buttonParkYeriSorgu.Name = "buttonParkYeriSorgu";
            this.buttonParkYeriSorgu.Size = new System.Drawing.Size(402, 80);
            this.buttonParkYeriSorgu.TabIndex = 8;
            this.buttonParkYeriSorgu.Text = "PARK YERİ SORGULA";
            this.buttonParkYeriSorgu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.buttonAracKayit);
            this.panel1.Controls.Add(this.buttonParkYeriSorgu);
            this.panel1.Controls.Add(this.buttonAdminAyarlar);
            this.panel1.Controls.Add(this.buttonMusteriKayit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 102);
            this.panel1.TabIndex = 12;
            // 
            // buttonAracKayit
            // 
            this.buttonAracKayit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAracKayit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAracKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAracKayit.ImageKey = "racing-car.png";
            this.buttonAracKayit.ImageList = this.ımageList1;
            this.buttonAracKayit.Location = new System.Drawing.Point(1003, 12);
            this.buttonAracKayit.Name = "buttonAracKayit";
            this.buttonAracKayit.Size = new System.Drawing.Size(377, 80);
            this.buttonAracKayit.TabIndex = 13;
            this.buttonAracKayit.Text = "ARAÇ KAYIT";
            this.buttonAracKayit.UseVisualStyleBackColor = false;
            this.buttonAracKayit.Click += new System.EventHandler(this.buttonAracKayit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Location = new System.Drawing.Point(274, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 634);
            this.panel2.TabIndex = 14;
            // 
            // FormAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormAdminAnasayfa";
            this.Text = "FormAdminAnasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdminAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonAdminAyarlar;
        private System.Windows.Forms.Button buttonMusteriKayit;
        private System.Windows.Forms.Button buttonParkYeriSorgu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAracKayit;
        private System.Windows.Forms.Panel panel2;
    }
}