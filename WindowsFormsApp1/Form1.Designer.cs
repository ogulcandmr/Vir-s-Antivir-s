namespace Virüs_Antivirüs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAntivirus = new System.Windows.Forms.Button();
            this.btnVirus = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStego = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAntivirus);
            this.groupBox1.Controls.Add(this.btnVirus);
            this.groupBox1.Controls.Add(this.btnSec);
            this.groupBox1.Controls.Add(this.txtYol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hedef Klasör İşlemleri";
            // 
            // btnAntivirus
            // 
            this.btnAntivirus.BackColor = System.Drawing.Color.Lime;
            this.btnAntivirus.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAntivirus.ForeColor = System.Drawing.Color.White;
            this.btnAntivirus.Location = new System.Drawing.Point(235, 89);
            this.btnAntivirus.Name = "btnAntivirus";
            this.btnAntivirus.Size = new System.Drawing.Size(113, 61);
            this.btnAntivirus.TabIndex = 4;
            this.btnAntivirus.Text = "TARAMA VE KURTARMA";
            this.btnAntivirus.UseVisualStyleBackColor = false;
            this.btnAntivirus.Click += new System.EventHandler(this.btnAntivirus_Click);
            // 
            // btnVirus
            // 
            this.btnVirus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVirus.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVirus.ForeColor = System.Drawing.Color.White;
            this.btnVirus.Location = new System.Drawing.Point(25, 89);
            this.btnVirus.Name = "btnVirus";
            this.btnVirus.Size = new System.Drawing.Size(150, 59);
            this.btnVirus.TabIndex = 3;
            this.btnVirus.Text = "VİRÜS SİMÜLASYONU";
            this.btnVirus.UseVisualStyleBackColor = false;
            this.btnVirus.Click += new System.EventHandler(this.btnVirus_Click);
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(208, 12);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(124, 51);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Klasör Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(75, 28);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(100, 20);
            this.txtYol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasör Yolu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStego);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steganografi (Veri Gizleme)";
            // 
            // btnStego
            // 
            this.btnStego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStego.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStego.Location = new System.Drawing.Point(27, 31);
            this.btnStego.Name = "btnStego";
            this.btnStego.Size = new System.Drawing.Size(134, 63);
            this.btnStego.TabIndex = 6;
            this.btnStego.Text = "EXE\'yi Resme Göm";
            this.btnStego.UseVisualStyleBackColor = false;
            this.btnStego.Click += new System.EventHandler(this.btnStego_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(-1, 213);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(800, 238);
            this.lstLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAntivirus;
        private System.Windows.Forms.Button btnVirus;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStego;
        private System.Windows.Forms.ListBox lstLog;
    }
}

