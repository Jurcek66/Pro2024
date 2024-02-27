namespace PrvoOkno
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
            this.mojGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.počisti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radplus = new System.Windows.Forms.RadioButton();
            this.radminus = new System.Windows.Forms.RadioButton();
            this.radkrat = new System.Windows.Forms.RadioButton();
            this.raddeljeno = new System.Windows.Forms.RadioButton();
            this.chkneg = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mojGumb
            // 
            this.mojGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mojGumb.Location = new System.Drawing.Point(54, 195);
            this.mojGumb.Name = "mojGumb";
            this.mojGumb.Size = new System.Drawing.Size(110, 56);
            this.mojGumb.TabIndex = 7;
            this.mojGumb.Text = "izračunaj";
            this.mojGumb.UseVisualStyleBackColor = true;
            this.mojGumb.Click += new System.EventHandler(this.seštej);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. število";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. število";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "rezultat";
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(235, 38);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(100, 22);
            this.txtp.TabIndex = 4;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(235, 88);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(100, 22);
            this.txtd.TabIndex = 5;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(235, 132);
            this.txtr.Name = "txtr";
            this.txtr.ReadOnly = true;
            this.txtr.Size = new System.Drawing.Size(100, 22);
            this.txtr.TabIndex = 6;
            this.txtr.TabStop = false;
            // 
            // počisti
            // 
            this.počisti.Location = new System.Drawing.Point(235, 195);
            this.počisti.Name = "počisti";
            this.počisti.Size = new System.Drawing.Size(100, 56);
            this.počisti.TabIndex = 8;
            this.počisti.Text = "Počisti";
            this.počisti.UseVisualStyleBackColor = true;
            this.počisti.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raddeljeno);
            this.groupBox1.Controls.Add(this.radkrat);
            this.groupBox1.Controls.Add(this.radminus);
            this.groupBox1.Controls.Add(this.radplus);
            this.groupBox1.Location = new System.Drawing.Point(533, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "operacija";
            // 
            // radplus
            // 
            this.radplus.AutoSize = true;
            this.radplus.Checked = true;
            this.radplus.Location = new System.Drawing.Point(17, 31);
            this.radplus.Name = "radplus";
            this.radplus.Size = new System.Drawing.Size(91, 20);
            this.radplus.TabIndex = 0;
            this.radplus.TabStop = true;
            this.radplus.Text = "seštevanje";
            this.radplus.UseVisualStyleBackColor = true;
            // 
            // radminus
            // 
            this.radminus.AutoSize = true;
            this.radminus.Location = new System.Drawing.Point(17, 58);
            this.radminus.Name = "radminus";
            this.radminus.Size = new System.Drawing.Size(92, 20);
            this.radminus.TabIndex = 1;
            this.radminus.Text = "odštevanje";
            this.radminus.UseVisualStyleBackColor = true;
            // 
            // radkrat
            // 
            this.radkrat.AutoSize = true;
            this.radkrat.Location = new System.Drawing.Point(17, 85);
            this.radkrat.Name = "radkrat";
            this.radkrat.Size = new System.Drawing.Size(83, 20);
            this.radkrat.TabIndex = 2;
            this.radkrat.Text = "množenje";
            this.radkrat.UseVisualStyleBackColor = true;
            // 
            // raddeljeno
            // 
            this.raddeljeno.AutoSize = true;
            this.raddeljeno.Location = new System.Drawing.Point(17, 112);
            this.raddeljeno.Name = "raddeljeno";
            this.raddeljeno.Size = new System.Drawing.Size(73, 20);
            this.raddeljeno.TabIndex = 3;
            this.raddeljeno.Text = "deljenje";
            this.raddeljeno.UseVisualStyleBackColor = true;
            // 
            // chkneg
            // 
            this.chkneg.AutoSize = true;
            this.chkneg.Location = new System.Drawing.Point(533, 217);
            this.chkneg.Name = "chkneg";
            this.chkneg.Size = new System.Drawing.Size(229, 20);
            this.chkneg.TabIndex = 10;
            this.chkneg.Text = "pobarvaj če je vrednost negativna";
            this.chkneg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 293);
            this.Controls.Add(this.chkneg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.počisti);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mojGumb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Prvo Okno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mojGumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button počisti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raddeljeno;
        private System.Windows.Forms.RadioButton radkrat;
        private System.Windows.Forms.RadioButton radminus;
        private System.Windows.Forms.RadioButton radplus;
        private System.Windows.Forms.CheckBox chkneg;
    }
}

