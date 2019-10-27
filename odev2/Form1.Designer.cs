namespace odev2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRastgeleSayi = new System.Windows.Forms.Label();
            this.txtMetinGirisAlani = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKalanHakkimiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen aşağıda görmüş karakterleri ilgili yazı alanına geçiriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRastgeleSayi
            // 
            this.lblRastgeleSayi.AutoSize = true;
            this.lblRastgeleSayi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRastgeleSayi.Location = new System.Drawing.Point(12, 47);
            this.lblRastgeleSayi.Name = "lblRastgeleSayi";
            this.lblRastgeleSayi.Size = new System.Drawing.Size(36, 19);
            this.lblRastgeleSayi.TabIndex = 1;
            this.lblRastgeleSayi.Text = "...";
            this.lblRastgeleSayi.Click += new System.EventHandler(this.lblRastgeleSayi_Click);
            // 
            // txtMetinGirisAlani
            // 
            this.txtMetinGirisAlani.Location = new System.Drawing.Point(15, 79);
            this.txtMetinGirisAlani.Name = "txtMetinGirisAlani";
            this.txtMetinGirisAlani.Size = new System.Drawing.Size(183, 20);
            this.txtMetinGirisAlani.TabIndex = 2;
            this.txtMetinGirisAlani.TextChanged += new System.EventHandler(this.txtMetinGirisAlani_TextChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(204, 79);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(98, 23);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Hatalı Giriş Hakkınız:";
            // 
            // lblKalanHakkimiz
            // 
            this.lblKalanHakkimiz.AutoSize = true;
            this.lblKalanHakkimiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHakkimiz.ForeColor = System.Drawing.Color.Maroon;
            this.lblKalanHakkimiz.Location = new System.Drawing.Point(236, 122);
            this.lblKalanHakkimiz.Name = "lblKalanHakkimiz";
            this.lblKalanHakkimiz.Size = new System.Drawing.Size(19, 18);
            this.lblKalanHakkimiz.TabIndex = 5;
            this.lblKalanHakkimiz.Text = "5";
            this.lblKalanHakkimiz.Click += new System.EventHandler(this.lblKalanHakkimiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 163);
            this.Controls.Add(this.lblKalanHakkimiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtMetinGirisAlani);
            this.Controls.Add(this.lblRastgeleSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRastgeleSayi;
        private System.Windows.Forms.TextBox txtMetinGirisAlani;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKalanHakkimiz;
    }
}

