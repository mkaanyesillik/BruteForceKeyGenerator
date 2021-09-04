namespace BruteForceKeyGenerator
{
    partial class BruteForceGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruteForceGenerator));
            this.txtChars = new System.Windows.Forms.TextBox();
            this.lblChars = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblToplamCikti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChars
            // 
            this.txtChars.Location = new System.Drawing.Point(113, 9);
            this.txtChars.Name = "txtChars";
            this.txtChars.Size = new System.Drawing.Size(158, 20);
            this.txtChars.TabIndex = 0;
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(11, 12);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(70, 13);
            this.lblChars.TabIndex = 1;
            this.lblChars.Text = "Harfleri Girin :";
            this.lblChars.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(14, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(258, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(12, 32);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(259, 71);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = resources.GetString("lblAciklama.Text");
            // 
            // lblToplamCikti
            // 
            this.lblToplamCikti.AutoSize = true;
            this.lblToplamCikti.Location = new System.Drawing.Point(12, 103);
            this.lblToplamCikti.Name = "lblToplamCikti";
            this.lblToplamCikti.Size = new System.Drawing.Size(71, 13);
            this.lblToplamCikti.TabIndex = 8;
            this.lblToplamCikti.Text = "Toplam Çıktı :";
            // 
            // BruteForceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.lblToplamCikti);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblChars);
            this.Controls.Add(this.txtChars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BruteForceGenerator";
            this.Text = "BruteForceGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChars;
        private System.Windows.Forms.Label lblChars;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblToplamCikti;
    }
}

