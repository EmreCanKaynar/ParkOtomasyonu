
namespace OtoparkOtomasyonu.v2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonOperator = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.labelbaslik = new System.Windows.Forms.Label();
            this.linkKaydol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "admin.png");
            this.ımageList1.Images.SetKeyName(1, "operator.png");
            // 
            // buttonOperator
            // 
            this.buttonOperator.BackColor = System.Drawing.Color.Thistle;
            this.buttonOperator.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOperator.ImageIndex = 1;
            this.buttonOperator.ImageList = this.ımageList1;
            this.buttonOperator.Location = new System.Drawing.Point(281, 209);
            this.buttonOperator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOperator.Name = "buttonOperator";
            this.buttonOperator.Size = new System.Drawing.Size(218, 65);
            this.buttonOperator.TabIndex = 2;
            this.buttonOperator.Text = "      OPERATOR";
            this.buttonOperator.UseVisualStyleBackColor = false;
            this.buttonOperator.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.ImageKey = "admin.png";
            this.buttonAdmin.ImageList = this.ımageList1;
            this.buttonAdmin.Location = new System.Drawing.Point(281, 115);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(218, 65);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "ADMIN";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelbaslik.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslik.Location = new System.Drawing.Point(224, 19);
            this.labelbaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(369, 36);
            this.labelbaslik.TabIndex = 4;
            this.labelbaslik.Text = "OTOPARK OTOMASYONU";
            // 
            // linkKaydol
            // 
            this.linkKaydol.AutoSize = true;
            this.linkKaydol.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKaydol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkKaydol.LinkColor = System.Drawing.Color.Black;
            this.linkKaydol.Location = new System.Drawing.Point(329, 306);
            this.linkKaydol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkKaydol.Name = "linkKaydol";
            this.linkKaydol.Size = new System.Drawing.Size(144, 19);
            this.linkKaydol.TabIndex = 5;
            this.linkKaydol.TabStop = true;
            this.linkKaydol.Text = "Hesabınız yok mu ?";
            this.linkKaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKaydol_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 459);
            this.Controls.Add(this.linkKaydol);
            this.Controls.Add(this.labelbaslik);
            this.Controls.Add(this.buttonOperator);
            this.Controls.Add(this.buttonAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonOperator;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label labelbaslik;
        private System.Windows.Forms.LinkLabel linkKaydol;
    }
}

