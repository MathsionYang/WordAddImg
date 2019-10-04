namespace WordAddImg
{
    partial class WordAddImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordAddImg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_FileEx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_Satrt = new System.Windows.Forms.Button();
            this.cb_FileEx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_browser = new System.Windows.Forms.Button();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_FileEx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.bt_Satrt);
            this.groupBox1.Controls.Add(this.cb_FileEx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_browser);
            this.groupBox1.Controls.Add(this.tb_FilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "]";
            // 
            // label_FileEx
            // 
            this.label_FileEx.AutoSize = true;
            this.label_FileEx.Location = new System.Drawing.Point(262, 56);
            this.label_FileEx.Name = "label_FileEx";
            this.label_FileEx.Size = new System.Drawing.Size(0, 12);
            this.label_FileEx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "[";
            // 
            // bt_close
            // 
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(470, 68);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(37, 26);
            this.bt_close.TabIndex = 6;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_Satrt
            // 
            this.bt_Satrt.Image = ((System.Drawing.Image)(resources.GetObject("bt_Satrt.Image")));
            this.bt_Satrt.Location = new System.Drawing.Point(419, 68);
            this.bt_Satrt.Name = "bt_Satrt";
            this.bt_Satrt.Size = new System.Drawing.Size(34, 26);
            this.bt_Satrt.TabIndex = 5;
            this.bt_Satrt.UseVisualStyleBackColor = true;
            this.bt_Satrt.Click += new System.EventHandler(this.bt_Satrt_Click);
            // 
            // cb_FileEx
            // 
            this.cb_FileEx.FormattingEnabled = true;
            this.cb_FileEx.Items.AddRange(new object[] {
            "*.JPG",
            "*.PNG",
            "*.TIF"});
            this.cb_FileEx.Location = new System.Drawing.Point(90, 53);
            this.cb_FileEx.Name = "cb_FileEx";
            this.cb_FileEx.Size = new System.Drawing.Size(121, 20);
            this.cb_FileEx.TabIndex = 4;
            this.cb_FileEx.SelectedIndexChanged += new System.EventHandler(this.cb_FileEx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片类型：";
            // 
            // bt_browser
            // 
            this.bt_browser.Image = ((System.Drawing.Image)(resources.GetObject("bt_browser.Image")));
            this.bt_browser.Location = new System.Drawing.Point(483, 12);
            this.bt_browser.Name = "bt_browser";
            this.bt_browser.Size = new System.Drawing.Size(38, 31);
            this.bt_browser.TabIndex = 2;
            this.bt_browser.UseVisualStyleBackColor = true;
            this.bt_browser.Click += new System.EventHandler(this.bt_browser_Click);
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(90, 18);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(387, 21);
            this.tb_FilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹路径：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_FileName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_FileName.Location = new System.Drawing.Point(3, 17);
            this.tb_FileName.Multiline = true;
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(294, 249);
            this.tb_FileName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Location = new System.Drawing.Point(312, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 266);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "   ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 32);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(137, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "湖北大学资源环境学院地图学与地理信息系统--杨洋";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WordAddImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 486);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordAddImg";
            this.Text = "Word图片添加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_browser;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FileEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Satrt;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_FileEx;
        private System.Windows.Forms.Label label4;
    }
}

