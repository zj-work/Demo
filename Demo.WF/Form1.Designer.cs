namespace Demo.WF
{
    partial class Form1
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.Group_List = new System.Windows.Forms.GroupBox();
            this.pb_upload = new System.Windows.Forms.ProgressBar();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.btn_uploadDir = new System.Windows.Forms.Button();
            this.Group_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(12, 12);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "上传文件";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // Group_List
            // 
            this.Group_List.Controls.Add(this.lb_History);
            this.Group_List.Location = new System.Drawing.Point(12, 50);
            this.Group_List.Name = "Group_List";
            this.Group_List.Size = new System.Drawing.Size(776, 436);
            this.Group_List.TabIndex = 1;
            this.Group_List.TabStop = false;
            this.Group_List.Text = "上传记录";
            // 
            // pb_upload
            // 
            this.pb_upload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_upload.Location = new System.Drawing.Point(0, 525);
            this.pb_upload.Name = "pb_upload";
            this.pb_upload.Size = new System.Drawing.Size(800, 23);
            this.pb_upload.TabIndex = 2;
            // 
            // lb_History
            // 
            this.lb_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_History.FormattingEnabled = true;
            this.lb_History.ItemHeight = 12;
            this.lb_History.Location = new System.Drawing.Point(3, 17);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(770, 416);
            this.lb_History.TabIndex = 0;
            // 
            // btn_uploadDir
            // 
            this.btn_uploadDir.Location = new System.Drawing.Point(114, 12);
            this.btn_uploadDir.Name = "btn_uploadDir";
            this.btn_uploadDir.Size = new System.Drawing.Size(75, 23);
            this.btn_uploadDir.TabIndex = 3;
            this.btn_uploadDir.Text = "上传文件夹";
            this.btn_uploadDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.btn_uploadDir);
            this.Controls.Add(this.pb_upload);
            this.Controls.Add(this.Group_List);
            this.Controls.Add(this.btn_upload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Group_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.GroupBox Group_List;
        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.ProgressBar pb_upload;
        private System.Windows.Forms.Button btn_uploadDir;
    }
}

