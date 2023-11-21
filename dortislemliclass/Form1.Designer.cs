namespace dortislemliclass
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplama = new System.Windows.Forms.Label();
            this.lblCarpma = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblBolme = new System.Windows.Forms.Label();
            this.lblCikarma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(152, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2";
            // 
            // lblToplama
            // 
            this.lblToplama.AutoSize = true;
            this.lblToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplama.Location = new System.Drawing.Point(45, 253);
            this.lblToplama.Name = "lblToplama";
            this.lblToplama.Size = new System.Drawing.Size(103, 24);
            this.lblToplama.TabIndex = 3;
            this.lblToplama.Text = "Toplama: ";
            // 
            // lblCarpma
            // 
            this.lblCarpma.AutoSize = true;
            this.lblCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarpma.Location = new System.Drawing.Point(208, 253);
            this.lblCarpma.Name = "lblCarpma";
            this.lblCarpma.Size = new System.Drawing.Size(94, 24);
            this.lblCarpma.TabIndex = 4;
            this.lblCarpma.Text = "Çarpma: ";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(152, 57);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(122, 29);
            this.txtSayi1.TabIndex = 5;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(152, 106);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(122, 29);
            this.txtSayi2.TabIndex = 6;
            // 
            // lblBolme
            // 
            this.lblBolme.AutoSize = true;
            this.lblBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolme.Location = new System.Drawing.Point(221, 302);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(81, 24);
            this.lblBolme.TabIndex = 7;
            this.lblBolme.Text = "Bölme: ";
            // 
            // lblCikarma
            // 
            this.lblCikarma.AutoSize = true;
            this.lblCikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikarma.Location = new System.Drawing.Point(49, 302);
            this.lblCikarma.Name = "lblCikarma";
            this.lblCikarma.Size = new System.Drawing.Size(97, 24);
            this.lblCikarma.TabIndex = 8;
            this.lblCikarma.Text = "Çıkarma: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCikarma);
            this.Controls.Add(this.lblBolme);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblCarpma);
            this.Controls.Add(this.lblToplama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplama;
        private System.Windows.Forms.Label lblCarpma;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.Label lblCikarma;
    }
}

