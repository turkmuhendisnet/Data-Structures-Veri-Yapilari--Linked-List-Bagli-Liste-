namespace LinkedList
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
            this.lstElemanlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTersCevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.ItemHeight = 20;
            this.lstElemanlar.Location = new System.Drawing.Point(105, 12);
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(129, 244);
            this.lstElemanlar.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(12, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 49);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Eleman Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTersCevir
            // 
            this.btnTersCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTersCevir.Location = new System.Drawing.Point(12, 86);
            this.btnTersCevir.Name = "btnTersCevir";
            this.btnTersCevir.Size = new System.Drawing.Size(87, 49);
            this.btnTersCevir.TabIndex = 2;
            this.btnTersCevir.Text = "Elemanları Ters Çevir";
            this.btnTersCevir.UseVisualStyleBackColor = true;
            this.btnTersCevir.Click += new System.EventHandler(this.btnTersCevir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 270);
            this.Controls.Add(this.btnTersCevir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstElemanlar);
            this.Name = "Form1";
            this.Text = "Linked List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstElemanlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTersCevir;
    }
}

