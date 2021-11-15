
namespace ClientProxyForm_P5_003
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label labelPenjumlahan;
            System.Windows.Forms.Label labelPengurangan;
            System.Windows.Forms.Label labelPerkalian;
            System.Windows.Forms.Label LabelPembagian;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            labelPenjumlahan = new System.Windows.Forms.Label();
            labelPengurangan = new System.Windows.Forms.Label();
            labelPerkalian = new System.Windows.Forms.Label();
            LabelPembagian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(452, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 17);
            label3.TabIndex = 4;
            label3.Text = "Hasil Penjumlahan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(452, 140);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 17);
            label4.TabIndex = 5;
            label4.Text = "Hasil Pengurangan :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(452, 170);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 17);
            label5.TabIndex = 6;
            label5.Text = "Hasil Perkalian :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(452, 199);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(122, 17);
            label6.TabIndex = 7;
            label6.Text = "Hasil Pembagian :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hasil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPenjumlahan
            // 
            labelPenjumlahan.AutoSize = true;
            labelPenjumlahan.Location = new System.Drawing.Point(608, 116);
            labelPenjumlahan.Name = "labelPenjumlahan";
            labelPenjumlahan.Size = new System.Drawing.Size(0, 17);
            labelPenjumlahan.TabIndex = 9;
            // 
            // labelPengurangan
            // 
            labelPengurangan.AutoSize = true;
            labelPengurangan.Location = new System.Drawing.Point(608, 140);
            labelPengurangan.Name = "labelPengurangan";
            labelPengurangan.Size = new System.Drawing.Size(0, 17);
            labelPengurangan.TabIndex = 10;
            // 
            // labelPerkalian
            // 
            labelPerkalian.AutoSize = true;
            labelPerkalian.Location = new System.Drawing.Point(608, 170);
            labelPerkalian.Name = "labelPerkalian";
            labelPerkalian.Size = new System.Drawing.Size(0, 17);
            labelPerkalian.TabIndex = 11;
            // 
            // LabelPembagian
            // 
            LabelPembagian.AutoSize = true;
            LabelPembagian.Location = new System.Drawing.Point(608, 199);
            LabelPembagian.Name = "LabelPembagian";
            LabelPembagian.Size = new System.Drawing.Size(0, 17);
            LabelPembagian.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(LabelPembagian);
            this.Controls.Add(labelPerkalian);
            this.Controls.Add(labelPengurangan);
            this.Controls.Add(labelPenjumlahan);
            this.Controls.Add(this.button1);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

