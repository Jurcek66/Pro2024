namespace GDI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barva = new System.Windows.Forms.TextBox();
            this.nstozd = new System.Windows.Forms.Button();
            this.alfa = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.TextBox();
            this.nstospr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nstozd);
            this.groupBox1.Controls.Add(this.barva);
            this.groupBox1.Location = new System.Drawing.Point(43, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nstospr);
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.green);
            this.groupBox2.Controls.Add(this.red);
            this.groupBox2.Controls.Add(this.alfa);
            this.groupBox2.Location = new System.Drawing.Point(43, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // barva
            // 
            this.barva.Location = new System.Drawing.Point(34, 35);
            this.barva.Name = "barva";
            this.barva.Size = new System.Drawing.Size(278, 20);
            this.barva.TabIndex = 0;
            // 
            // nstozd
            // 
            this.nstozd.Location = new System.Drawing.Point(347, 35);
            this.nstozd.Name = "nstozd";
            this.nstozd.Size = new System.Drawing.Size(75, 23);
            this.nstozd.TabIndex = 1;
            this.nstozd.Text = "Zadaj";
            this.nstozd.UseVisualStyleBackColor = true;
            this.nstozd.Click += new System.EventHandler(this.nstozd_Click);
            // 
            // alfa
            // 
            this.alfa.Location = new System.Drawing.Point(34, 46);
            this.alfa.Name = "alfa";
            this.alfa.Size = new System.Drawing.Size(58, 20);
            this.alfa.TabIndex = 0;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(113, 46);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(58, 20);
            this.red.TabIndex = 1;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(190, 46);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(58, 20);
            this.green.TabIndex = 2;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(278, 46);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(58, 20);
            this.blue.TabIndex = 3;
            this.blue.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // nstospr
            // 
            this.nstospr.Location = new System.Drawing.Point(347, 46);
            this.nstospr.Name = "nstospr";
            this.nstospr.Size = new System.Drawing.Size(75, 23);
            this.nstospr.TabIndex = 4;
            this.nstospr.Text = "Spredaj";
            this.nstospr.UseVisualStyleBackColor = true;
            this.nstospr.Click += new System.EventHandler(this.nstospr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nstozd;
        private System.Windows.Forms.TextBox barva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox alfa;
        private System.Windows.Forms.Button nstospr;
    }
}

