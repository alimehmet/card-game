namespace kart_oyunu
{
    partial class girisEkrani
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
            this.oyunButonu2x5 = new System.Windows.Forms.Button();
            this.oyunButonu3x6 = new System.Windows.Forms.Button();
            this.oyunButonu4x5 = new System.Windows.Forms.Button();
            this.cikisButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oyunButonu2x5
            // 
            this.oyunButonu2x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunButonu2x5.Location = new System.Drawing.Point(128, 152);
            this.oyunButonu2x5.Name = "oyunButonu2x5";
            this.oyunButonu2x5.Size = new System.Drawing.Size(114, 45);
            this.oyunButonu2x5.TabIndex = 0;
            this.oyunButonu2x5.Text = "2x5\'lik Oyuna Başla";
            this.oyunButonu2x5.UseVisualStyleBackColor = true;
            this.oyunButonu2x5.Click += new System.EventHandler(this.oyunButonu2x5_Click);
            // 
            // oyunButonu3x6
            // 
            this.oyunButonu3x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunButonu3x6.Location = new System.Drawing.Point(128, 212);
            this.oyunButonu3x6.Name = "oyunButonu3x6";
            this.oyunButonu3x6.Size = new System.Drawing.Size(114, 45);
            this.oyunButonu3x6.TabIndex = 1;
            this.oyunButonu3x6.Text = "3x4\'lük Oyuna Başla";
            this.oyunButonu3x6.UseVisualStyleBackColor = true;
            this.oyunButonu3x6.Click += new System.EventHandler(this.oyunButonu3x6_Click);
            // 
            // oyunButonu4x5
            // 
            this.oyunButonu4x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunButonu4x5.Location = new System.Drawing.Point(128, 273);
            this.oyunButonu4x5.Name = "oyunButonu4x5";
            this.oyunButonu4x5.Size = new System.Drawing.Size(114, 45);
            this.oyunButonu4x5.TabIndex = 2;
            this.oyunButonu4x5.Text = "4x5\'lik Oyuna Başla";
            this.oyunButonu4x5.UseVisualStyleBackColor = true;
            this.oyunButonu4x5.Click += new System.EventHandler(this.oyunButonu4x5_Click);
            // 
            // cikisButonu
            // 
            this.cikisButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButonu.Location = new System.Drawing.Point(128, 358);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(114, 45);
            this.cikisButonu.TabIndex = 3;
            this.cikisButonu.Text = "Çıkış";
            this.cikisButonu.UseVisualStyleBackColor = true;
            this.cikisButonu.Click += new System.EventHandler(this.cikisButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 47);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kart Oyunu";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.oyunButonu4x5);
            this.Controls.Add(this.oyunButonu3x6);
            this.Controls.Add(this.oyunButonu2x5);
            this.Name = "girisEkrani";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oyunButonu2x5;
        private System.Windows.Forms.Button oyunButonu3x6;
        private System.Windows.Forms.Button oyunButonu4x5;
        private System.Windows.Forms.Button cikisButonu;
        private System.Windows.Forms.Label label1;
    }
}