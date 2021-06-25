namespace Bilgi_Yarışması
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbpara = new System.Windows.Forms.Label();
            this.lbemin = new System.Windows.Forms.Label();
            this.btemin = new System.Windows.Forms.Button();
            this.odul = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.tkalansure = new System.Windows.Forms.Timer(this.components);
            this.lbkalansure = new System.Windows.Forms.Label();
            this.lbdogru = new System.Windows.Forms.Label();
            this.lbsoru = new System.Windows.Forms.Label();
            this.lbsiradaki = new System.Windows.Forms.Label();
            this.tsiradakisure = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(135, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 33);
            this.label5.TabIndex = 20;
            // 
            // lbpara
            // 
            this.lbpara.AutoSize = true;
            this.lbpara.BackColor = System.Drawing.Color.Transparent;
            this.lbpara.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbpara.ForeColor = System.Drawing.SystemColors.Control;
            this.lbpara.Location = new System.Drawing.Point(12, 9);
            this.lbpara.Name = "lbpara";
            this.lbpara.Size = new System.Drawing.Size(153, 33);
            this.lbpara.TabIndex = 19;
            this.lbpara.Text = "Toplam para = 0";
            // 
            // lbemin
            // 
            this.lbemin.AutoSize = true;
            this.lbemin.BackColor = System.Drawing.Color.Transparent;
            this.lbemin.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbemin.ForeColor = System.Drawing.SystemColors.Control;
            this.lbemin.Location = new System.Drawing.Point(456, 237);
            this.lbemin.Name = "lbemin";
            this.lbemin.Size = new System.Drawing.Size(136, 33);
            this.lbemin.TabIndex = 18;
            this.lbemin.Text = "Emin misiniz?";
            this.lbemin.Visible = false;
            // 
            // btemin
            // 
            this.btemin.BackColor = System.Drawing.Color.Black;
            this.btemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btemin.ForeColor = System.Drawing.SystemColors.Control;
            this.btemin.Location = new System.Drawing.Point(598, 237);
            this.btemin.Name = "btemin";
            this.btemin.Size = new System.Drawing.Size(73, 33);
            this.btemin.TabIndex = 17;
            this.btemin.Text = "Eminim";
            this.btemin.UseVisualStyleBackColor = false;
            this.btemin.Visible = false;
            this.btemin.Click += new System.EventHandler(this.btemin_Click);
            // 
            // odul
            // 
            this.odul.AutoSize = true;
            this.odul.BackColor = System.Drawing.Color.Transparent;
            this.odul.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odul.ForeColor = System.Drawing.SystemColors.Control;
            this.odul.Location = new System.Drawing.Point(547, 61);
            this.odul.Name = "odul";
            this.odul.Size = new System.Drawing.Size(72, 33);
            this.odul.TabIndex = 16;
            this.odul.Text = "500 TL";
            this.odul.Visible = false;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.d.ForeColor = System.Drawing.SystemColors.Control;
            this.d.Location = new System.Drawing.Point(452, 378);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(14, 13);
            this.d.TabIndex = 15;
            this.d.UseVisualStyleBackColor = false;
            this.d.Visible = false;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c.ForeColor = System.Drawing.SystemColors.Control;
            this.c.Location = new System.Drawing.Point(182, 378);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(14, 13);
            this.c.TabIndex = 14;
            this.c.UseVisualStyleBackColor = false;
            this.c.Visible = false;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b.ForeColor = System.Drawing.SystemColors.Control;
            this.b.Location = new System.Drawing.Point(452, 341);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(14, 13);
            this.b.TabIndex = 13;
            this.b.UseVisualStyleBackColor = false;
            this.b.Visible = false;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.ForeColor = System.Drawing.SystemColors.Control;
            this.a.Location = new System.Drawing.Point(182, 341);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(14, 13);
            this.a.TabIndex = 11;
            this.a.UseVisualStyleBackColor = false;
            this.a.Visible = false;
            // 
            // tkalansure
            // 
            this.tkalansure.Interval = 1000;
            this.tkalansure.Tick += new System.EventHandler(this.tkalansure_Tick);
            // 
            // lbkalansure
            // 
            this.lbkalansure.AutoSize = true;
            this.lbkalansure.BackColor = System.Drawing.Color.Transparent;
            this.lbkalansure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkalansure.ForeColor = System.Drawing.SystemColors.Control;
            this.lbkalansure.Location = new System.Drawing.Point(15, 52);
            this.lbkalansure.Name = "lbkalansure";
            this.lbkalansure.Size = new System.Drawing.Size(112, 24);
            this.lbkalansure.TabIndex = 21;
            this.lbkalansure.Text = "Kalan Süre: ";
            // 
            // lbdogru
            // 
            this.lbdogru.AutoSize = true;
            this.lbdogru.BackColor = System.Drawing.Color.Transparent;
            this.lbdogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbdogru.ForeColor = System.Drawing.Color.Lime;
            this.lbdogru.Location = new System.Drawing.Point(78, 231);
            this.lbdogru.Name = "lbdogru";
            this.lbdogru.Size = new System.Drawing.Size(169, 25);
            this.lbdogru.TabIndex = 22;
            this.lbdogru.Text = "CEVAP DOĞRU !";
            this.lbdogru.Visible = false;
            // 
            // lbsoru
            // 
            this.lbsoru.AutoSize = true;
            this.lbsoru.BackColor = System.Drawing.Color.Transparent;
            this.lbsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsoru.Location = new System.Drawing.Point(65, 284);
            this.lbsoru.Name = "lbsoru";
            this.lbsoru.Size = new System.Drawing.Size(0, 25);
            this.lbsoru.TabIndex = 23;
            // 
            // lbsiradaki
            // 
            this.lbsiradaki.AutoSize = true;
            this.lbsiradaki.BackColor = System.Drawing.Color.Transparent;
            this.lbsiradaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsiradaki.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsiradaki.Location = new System.Drawing.Point(15, 87);
            this.lbsiradaki.Name = "lbsiradaki";
            this.lbsiradaki.Size = new System.Drawing.Size(145, 24);
            this.lbsiradaki.TabIndex = 24;
            this.lbsiradaki.Text = "Sıradaki Soruya:";
            this.lbsiradaki.Visible = false;
            // 
            // tsiradakisure
            // 
            this.tsiradakisure.Interval = 1000;
            this.tsiradakisure.Tick += new System.EventHandler(this.tsiradakisure_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(18, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 25;
            this.button1.Text = "BAŞLAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbsiradaki);
            this.Controls.Add(this.lbsoru);
            this.Controls.Add(this.lbdogru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbpara);
            this.Controls.Add(this.lbemin);
            this.Controls.Add(this.btemin);
            this.Controls.Add(this.odul);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.lbkalansure);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(811, 492);
            this.MinimumSize = new System.Drawing.Size(811, 492);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbpara;
        private System.Windows.Forms.Label lbemin;
        private System.Windows.Forms.Button btemin;
        private System.Windows.Forms.Label odul;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.Timer tkalansure;
        private System.Windows.Forms.Label lbkalansure;
        private System.Windows.Forms.Label lbdogru;
        private System.Windows.Forms.Label lbsoru;
        private System.Windows.Forms.Label lbsiradaki;
        private System.Windows.Forms.Timer tsiradakisure;
        private System.Windows.Forms.Button button1;
    }
}

