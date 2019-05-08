namespace Demo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FileOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.tb_Color = new System.Windows.Forms.TrackBar();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_saturation = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saturation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FileOpen
            // 
            this.btn_FileOpen.Location = new System.Drawing.Point(50, 54);
            this.btn_FileOpen.Name = "btn_FileOpen";
            this.btn_FileOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_FileOpen.TabIndex = 0;
            this.btn_FileOpen.Text = "选择文件";
            this.btn_FileOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_saturation);
            this.groupBox1.Controls.Add(this.lbl_Color);
            this.groupBox1.Controls.Add(this.tb_Color);
            this.groupBox1.Controls.Add(this.btn_FileOpen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 585);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 585);
            this.panel1.TabIndex = 2;
            // 
            // picShow
            // 
            this.picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShow.Location = new System.Drawing.Point(0, 0);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(860, 585);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // tb_Color
            // 
            this.tb_Color.Location = new System.Drawing.Point(0, 154);
            this.tb_Color.Maximum = 255;
            this.tb_Color.Minimum = -255;
            this.tb_Color.Name = "tb_Color";
            this.tb_Color.Size = new System.Drawing.Size(396, 45);
            this.tb_Color.TabIndex = 1;
            this.tb_Color.TickFrequency = 10;
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(9, 132);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(29, 12);
            this.lbl_Color.TabIndex = 2;
            this.lbl_Color.Text = "亮度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "饱和度";
            // 
            // tb_saturation
            // 
            this.tb_saturation.Location = new System.Drawing.Point(0, 220);
            this.tb_saturation.Name = "tb_saturation";
            this.tb_saturation.Size = new System.Drawing.Size(396, 45);
            this.tb_saturation.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "主窗体";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_saturation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FileOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.TrackBar tb_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_saturation;
        private System.Windows.Forms.Label lbl_Color;
    }
}

