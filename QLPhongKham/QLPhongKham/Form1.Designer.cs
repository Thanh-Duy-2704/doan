namespace QLPhongKham
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
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bacSiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benhNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bacSiToolStripMenuItem,
            this.benhNhanToolStripMenuItem,
            this.loaiThuocToolStripMenuItem,
            this.thuocToolStripMenuItem,
            this.phieuKhamToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // bacSiToolStripMenuItem
            // 
            this.bacSiToolStripMenuItem.Name = "bacSiToolStripMenuItem";
            this.bacSiToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.bacSiToolStripMenuItem.Text = "Bac Si";
            this.bacSiToolStripMenuItem.Click += new System.EventHandler(this.bacSiToolStripMenuItem_Click);
            // 
            // benhNhanToolStripMenuItem
            // 
            this.benhNhanToolStripMenuItem.Name = "benhNhanToolStripMenuItem";
            this.benhNhanToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.benhNhanToolStripMenuItem.Text = "Benh Nhan";
            this.benhNhanToolStripMenuItem.Click += new System.EventHandler(this.benhNhanToolStripMenuItem_Click);
            // 
            // loaiThuocToolStripMenuItem
            // 
            this.loaiThuocToolStripMenuItem.Name = "loaiThuocToolStripMenuItem";
            this.loaiThuocToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.loaiThuocToolStripMenuItem.Text = "Loai Thuoc";
            this.loaiThuocToolStripMenuItem.Click += new System.EventHandler(this.loaiThuocToolStripMenuItem_Click);
            // 
            // thuocToolStripMenuItem
            // 
            this.thuocToolStripMenuItem.Name = "thuocToolStripMenuItem";
            this.thuocToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.thuocToolStripMenuItem.Text = "Thuoc";
            this.thuocToolStripMenuItem.Click += new System.EventHandler(this.thuocToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Khám";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bacSiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benhNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaiThuocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuocToolStripMenuItem;
    }
}

