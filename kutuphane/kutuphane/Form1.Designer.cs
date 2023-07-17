
namespace kutuphane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.romanYazarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hikayeYazarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şiirYazarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeAraştırmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.yazarlarToolStripMenuItem1,
            this.üyelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarlarToolStripMenuItem,
            this.silToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.yazarlarToolStripMenuItem.Text = "Ekle";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // yazarlarToolStripMenuItem1
            // 
            this.yazarlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanYazarlarıToolStripMenuItem,
            this.hikayeYazarlarıToolStripMenuItem,
            this.şiirYazarlarıToolStripMenuItem});
            this.yazarlarToolStripMenuItem1.Name = "yazarlarToolStripMenuItem1";
            this.yazarlarToolStripMenuItem1.Size = new System.Drawing.Size(87, 29);
            this.yazarlarToolStripMenuItem1.Text = "Yazarlar";
            // 
            // romanYazarlarıToolStripMenuItem
            // 
            this.romanYazarlarıToolStripMenuItem.Name = "romanYazarlarıToolStripMenuItem";
            this.romanYazarlarıToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.romanYazarlarıToolStripMenuItem.Text = "Roman Yazarları";
            // 
            // hikayeYazarlarıToolStripMenuItem
            // 
            this.hikayeYazarlarıToolStripMenuItem.Name = "hikayeYazarlarıToolStripMenuItem";
            this.hikayeYazarlarıToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.hikayeYazarlarıToolStripMenuItem.Text = "Hikaye Yazarları";
            // 
            // şiirYazarlarıToolStripMenuItem
            // 
            this.şiirYazarlarıToolStripMenuItem.Name = "şiirYazarlarıToolStripMenuItem";
            this.şiirYazarlarıToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.şiirYazarlarıToolStripMenuItem.Text = "Şiir Yazarları";
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜyeEkleToolStripMenuItem,
            this.üyeSilToolStripMenuItem,
            this.üyeAraştırmasıToolStripMenuItem});
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // yeniÜyeEkleToolStripMenuItem
            // 
            this.yeniÜyeEkleToolStripMenuItem.Name = "yeniÜyeEkleToolStripMenuItem";
            this.yeniÜyeEkleToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.yeniÜyeEkleToolStripMenuItem.Text = "Yeni Üye Ekle";
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.üyeSilToolStripMenuItem.Text = "Üye Sil";
            // 
            // üyeAraştırmasıToolStripMenuItem
            // 
            this.üyeAraştırmasıToolStripMenuItem.Name = "üyeAraştırmasıToolStripMenuItem";
            this.üyeAraştırmasıToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.üyeAraştırmasıToolStripMenuItem.Text = "Üye Araştırması";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(35, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 254);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem romanYazarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hikayeYazarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şiirYazarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeAraştırmasıToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox1;
    }
}

