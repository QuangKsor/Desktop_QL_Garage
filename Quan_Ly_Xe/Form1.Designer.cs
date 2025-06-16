namespace Quan_Ly_Xe
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
            this.menuThongtin_0993 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinXe_0993 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinBD_0993 = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongtin_0993,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuThongtin_0993
            // 
            this.menuThongtin_0993.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinXe_0993,
            this.thongTinBD_0993});
            this.menuThongtin_0993.Name = "menuThongtin_0993";
            this.menuThongtin_0993.Size = new System.Drawing.Size(71, 20);
            this.menuThongtin_0993.Text = "Thông tin";
            // 
            // thongTinXe_0993
            // 
            this.thongTinXe_0993.Image = global::Quan_Ly_Xe.Properties.Resources.ooto;
            this.thongTinXe_0993.Name = "thongTinXe_0993";
            this.thongTinXe_0993.Size = new System.Drawing.Size(187, 22);
            this.thongTinXe_0993.Text = "Thông tin xe";
            this.thongTinXe_0993.Click += new System.EventHandler(this.thongTinXe_0993_Click);
            // 
            // thongTinBD_0993
            // 
            this.thongTinBD_0993.Image = global::Quan_Ly_Xe.Properties.Resources.baoduong;
            this.thongTinBD_0993.Name = "thongTinBD_0993";
            this.thongTinBD_0993.Size = new System.Drawing.Size(187, 22);
            this.thongTinBD_0993.Text = "Thông tin bảo dưỡng";
            this.thongTinBD_0993.Click += new System.EventHandler(this.thongTinBD_0993_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.soDTToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = global::Quan_Ly_Xe.Properties.Resources.email1;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // soDTToolStripMenuItem
            // 
            this.soDTToolStripMenuItem.Image = global::Quan_Ly_Xe.Properties.Resources.dt1;
            this.soDTToolStripMenuItem.Name = "soDTToolStripMenuItem";
            this.soDTToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.soDTToolStripMenuItem.Text = "Số điện thoại";
            this.soDTToolStripMenuItem.Click += new System.EventHandler(this.sốĐiệnThoạiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(170, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN GARAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(359, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Quan_Ly_Xe.Properties.Resources.ga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Text = "QUẢN LÝ THÔNG TIN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuThongtin_0993;
        private System.Windows.Forms.ToolStripMenuItem thongTinXe_0993;
        private System.Windows.Forms.ToolStripMenuItem thongTinBD_0993;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soDTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

