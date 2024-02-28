namespace liki
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
            this.izrKvadrat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stranica = new System.Windows.Forms.TextBox();
            this.obseg = new System.Windows.Forms.TextBox();
            this.ploščina = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izrKrog = new System.Windows.Forms.Button();
            this.ploščinakrog = new System.Windows.Forms.TextBox();
            this.obsegkrog = new System.Windows.Forms.TextBox();
            this.polmer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ploščina);
            this.groupBox1.Controls.Add(this.obseg);
            this.groupBox1.Controls.Add(this.stranica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.izrKvadrat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(37, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kvadrat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // izrKvadrat
            // 
            this.izrKvadrat.Location = new System.Drawing.Point(99, 134);
            this.izrKvadrat.Name = "izrKvadrat";
            this.izrKvadrat.Size = new System.Drawing.Size(93, 42);
            this.izrKvadrat.TabIndex = 0;
            this.izrKvadrat.Text = "izračun";
            this.izrKvadrat.UseVisualStyleBackColor = true;
            this.izrKvadrat.Click += new System.EventHandler(this.izrKvadrat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // stranica
            // 
            this.stranica.Location = new System.Drawing.Point(92, 32);
            this.stranica.Name = "stranica";
            this.stranica.Size = new System.Drawing.Size(100, 31);
            this.stranica.TabIndex = 4;
            // 
            // obseg
            // 
            this.obseg.Location = new System.Drawing.Point(92, 66);
            this.obseg.Name = "obseg";
            this.obseg.Size = new System.Drawing.Size(100, 31);
            this.obseg.TabIndex = 5;
            // 
            // ploščina
            // 
            this.ploščina.Location = new System.Drawing.Point(92, 97);
            this.ploščina.Name = "ploščina";
            this.ploščina.Size = new System.Drawing.Size(100, 31);
            this.ploščina.TabIndex = 6;
            this.ploščina.TextChanged += new System.EventHandler(this.ploščina_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ploščinakrog);
            this.groupBox2.Controls.Add(this.obsegkrog);
            this.groupBox2.Controls.Add(this.polmer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.izrKrog);
            this.groupBox2.Location = new System.Drawing.Point(469, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // izrKrog
            // 
            this.izrKrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izrKrog.Location = new System.Drawing.Point(132, 121);
            this.izrKrog.Name = "izrKrog";
            this.izrKrog.Size = new System.Drawing.Size(93, 42);
            this.izrKrog.TabIndex = 1;
            this.izrKrog.Text = "izračun";
            this.izrKrog.UseVisualStyleBackColor = true;
            this.izrKrog.Click += new System.EventHandler(this.izrKrog_Click);
            // 
            // ploščinakrog
            // 
            this.ploščinakrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ploščinakrog.Location = new System.Drawing.Point(94, 84);
            this.ploščinakrog.Name = "ploščinakrog";
            this.ploščinakrog.Size = new System.Drawing.Size(100, 31);
            this.ploščinakrog.TabIndex = 12;
            // 
            // obsegkrog
            // 
            this.obsegkrog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obsegkrog.Location = new System.Drawing.Point(94, 53);
            this.obsegkrog.Name = "obsegkrog";
            this.obsegkrog.Size = new System.Drawing.Size(100, 31);
            this.obsegkrog.TabIndex = 11;
            // 
            // polmer
            // 
            this.polmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polmer.Location = new System.Drawing.Point(94, 19);
            this.polmer.Name = "polmer";
            this.polmer.Size = new System.Drawing.Size(100, 31);
            this.polmer.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(18, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izrKvadrat;
        private System.Windows.Forms.TextBox stranica;
        private System.Windows.Forms.TextBox ploščina;
        private System.Windows.Forms.TextBox obseg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button izrKrog;
        private System.Windows.Forms.TextBox ploščinakrog;
        private System.Windows.Forms.TextBox obsegkrog;
        private System.Windows.Forms.TextBox polmer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

