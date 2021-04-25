
namespace HastaneOtomasyonu
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hayat Hastanesi";
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreter.BackgroundImage")));
            this.BtnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSekreter.Location = new System.Drawing.Point(76, 133);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(228, 168);
            this.BtnSekreter.TabIndex = 1;
            this.BtnSekreter.UseVisualStyleBackColor = true;
            this.BtnSekreter.Click += new System.EventHandler(this.BtnSekreter_Click);
            // 
            // BtnHasta
            // 
            this.BtnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHasta.BackgroundImage")));
            this.BtnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHasta.Location = new System.Drawing.Point(359, 133);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(228, 168);
            this.BtnHasta.TabIndex = 2;
            this.BtnHasta.UseVisualStyleBackColor = true;
            this.BtnHasta.Click += new System.EventHandler(this.BtnHasta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sekreter Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(348, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta Girişi";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(634, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnHasta);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGiris";
            this.Text = "GİRİŞ EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSekreter;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

