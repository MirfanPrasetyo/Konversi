namespace Konversi
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
            this.label2 = new System.Windows.Forms.Label();
            this.HasilKonversi = new System.Windows.Forms.ListBox();
            this.InputNominal = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // HasilKonversi
            // 
            this.HasilKonversi.FormattingEnabled = true;
            this.HasilKonversi.Location = new System.Drawing.Point(58, 60);
            this.HasilKonversi.Name = "HasilKonversi";
            this.HasilKonversi.Size = new System.Drawing.Size(229, 56);
            this.HasilKonversi.TabIndex = 2;
            // 
            // InputNominal
            // 
            this.InputNominal.Location = new System.Drawing.Point(58, 26);
            this.InputNominal.Name = "InputNominal";
            this.InputNominal.Size = new System.Drawing.Size(161, 20);
            this.InputNominal.TabIndex = 3;
            this.InputNominal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(225, 24);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(116, 23);
            this.btn_konversi.TabIndex = 4;
            this.btn_konversi.Text = "Cek Terbilang";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 128);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.InputNominal);
            this.Controls.Add(this.HasilKonversi);
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
        private System.Windows.Forms.ListBox HasilKonversi;
        private System.Windows.Forms.TextBox InputNominal;
        private System.Windows.Forms.Button btn_konversi;
    }
}

