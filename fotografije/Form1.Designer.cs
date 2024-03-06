namespace fotografije
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odpriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za270wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navpičnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodoravnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posvetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potemniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dlgOdpri = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(783, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 426);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 433);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(783, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.vrtenjeToolStripMenuItem,
            this.zrcaljenjeToolStripMenuItem,
            this.filtriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odpriToolStripMenuItem,
            this.shraniToolStripMenuItem,
            this.toolStripSeparator1,
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // odpriToolStripMenuItem
            // 
            this.odpriToolStripMenuItem.Name = "odpriToolStripMenuItem";
            this.odpriToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.odpriToolStripMenuItem.Text = "odpri";
            this.odpriToolStripMenuItem.Click += new System.EventHandler(this.odpriToolStripMenuItem_Click);
            // 
            // shraniToolStripMenuItem
            // 
            this.shraniToolStripMenuItem.Name = "shraniToolStripMenuItem";
            this.shraniToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.shraniToolStripMenuItem.Text = "shrani";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(103, 6);
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.izhodToolStripMenuItem.Text = "izhod";
            // 
            // vrtenjeToolStripMenuItem
            // 
            this.vrtenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.za90ToolStripMenuItem,
            this.za180ToolStripMenuItem,
            this.za270wToolStripMenuItem});
            this.vrtenjeToolStripMenuItem.Name = "vrtenjeToolStripMenuItem";
            this.vrtenjeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vrtenjeToolStripMenuItem.Text = "Vrtenje";
            // 
            // za90ToolStripMenuItem
            // 
            this.za90ToolStripMenuItem.Name = "za90ToolStripMenuItem";
            this.za90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za90ToolStripMenuItem.Text = "za 90°";
            this.za90ToolStripMenuItem.Click += new System.EventHandler(this.za90ToolStripMenuItem_Click);
            // 
            // za180ToolStripMenuItem
            // 
            this.za180ToolStripMenuItem.Name = "za180ToolStripMenuItem";
            this.za180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za180ToolStripMenuItem.Text = "za 180°";
            this.za180ToolStripMenuItem.Click += new System.EventHandler(this.za180ToolStripMenuItem_Click);
            // 
            // za270wToolStripMenuItem
            // 
            this.za270wToolStripMenuItem.Name = "za270wToolStripMenuItem";
            this.za270wToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za270wToolStripMenuItem.Text = "za 270°";
            this.za270wToolStripMenuItem.Click += new System.EventHandler(this.za270wToolStripMenuItem_Click);
            // 
            // zrcaljenjeToolStripMenuItem
            // 
            this.zrcaljenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navpičnoToolStripMenuItem,
            this.vodoravnoToolStripMenuItem});
            this.zrcaljenjeToolStripMenuItem.Name = "zrcaljenjeToolStripMenuItem";
            this.zrcaljenjeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zrcaljenjeToolStripMenuItem.Text = "Zrcaljenje";
            // 
            // navpičnoToolStripMenuItem
            // 
            this.navpičnoToolStripMenuItem.Name = "navpičnoToolStripMenuItem";
            this.navpičnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navpičnoToolStripMenuItem.Text = "navpično";
            this.navpičnoToolStripMenuItem.Click += new System.EventHandler(this.navpičnoToolStripMenuItem_Click);
            // 
            // vodoravnoToolStripMenuItem
            // 
            this.vodoravnoToolStripMenuItem.Name = "vodoravnoToolStripMenuItem";
            this.vodoravnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vodoravnoToolStripMenuItem.Text = "vodoravno";
            this.vodoravnoToolStripMenuItem.Click += new System.EventHandler(this.vodoravnoToolStripMenuItem_Click);
            // 
            // filtriToolStripMenuItem
            // 
            this.filtriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posvetiToolStripMenuItem,
            this.potemniToolStripMenuItem,
            this.negativToolStripMenuItem});
            this.filtriToolStripMenuItem.Name = "filtriToolStripMenuItem";
            this.filtriToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filtriToolStripMenuItem.Text = "Filtri";
            // 
            // posvetiToolStripMenuItem
            // 
            this.posvetiToolStripMenuItem.Name = "posvetiToolStripMenuItem";
            this.posvetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.posvetiToolStripMenuItem.Text = "posveti";
            this.posvetiToolStripMenuItem.Click += new System.EventHandler(this.posvetiToolStripMenuItem_Click);
            // 
            // potemniToolStripMenuItem
            // 
            this.potemniToolStripMenuItem.Name = "potemniToolStripMenuItem";
            this.potemniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.potemniToolStripMenuItem.Text = "potemni";
            this.potemniToolStripMenuItem.Click += new System.EventHandler(this.potemniToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativToolStripMenuItem.Text = "negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dlgOdpri
            // 
            this.dlgOdpri.FileName = "dlgodpri";
            this.dlgOdpri.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odpriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za270wToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navpičnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodoravnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posvetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potemniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog dlgOdpri;
    }
}

