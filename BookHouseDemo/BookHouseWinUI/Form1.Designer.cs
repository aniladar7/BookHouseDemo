
namespace BookHouseWinUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıneviİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabeviİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPaneliToolStripMenuItem,
            this.kitapListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarİşlemleriToolStripMenuItem,
            this.yayıneviİşlemleriToolStripMenuItem,
            this.kitabeviİşlemleriToolStripMenuItem,
            this.categoriİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem});
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.adminPaneliToolStripMenuItem.Text = "Admin Paneli";
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            this.yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            this.yazarİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            this.yazarİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.yazarİşlemleriToolStripMenuItem_Click);
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            this.yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            this.yayıneviİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            // 
            // kitabeviİşlemleriToolStripMenuItem
            // 
            this.kitabeviİşlemleriToolStripMenuItem.Name = "kitabeviİşlemleriToolStripMenuItem";
            this.kitabeviİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitabeviİşlemleriToolStripMenuItem.Text = "Kitabevi İşlemleri";
            // 
            // categoriİşlemleriToolStripMenuItem
            // 
            this.categoriİşlemleriToolStripMenuItem.Name = "categoriİşlemleriToolStripMenuItem";
            this.categoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.kitapListesiToolStripMenuItem.Text = "Kitap listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 583);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem adminPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayıneviİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabeviİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
    }
}

