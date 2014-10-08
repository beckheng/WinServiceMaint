namespace WinServiceMaint
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_viewStatus = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.comboBox_services = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "状态:";
            // 
            // button_viewStatus
            // 
            this.button_viewStatus.Location = new System.Drawing.Point(108, 73);
            this.button_viewStatus.Name = "button_viewStatus";
            this.button_viewStatus.Size = new System.Drawing.Size(75, 23);
            this.button_viewStatus.TabIndex = 3;
            this.button_viewStatus.Text = "查看状态";
            this.button_viewStatus.UseVisualStyleBackColor = true;
            this.button_viewStatus.Click += new System.EventHandler(this.button_viewStatus_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(189, 73);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "启动";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // comboBox_services
            // 
            this.comboBox_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_services.FormattingEnabled = true;
            this.comboBox_services.Location = new System.Drawing.Point(108, 47);
            this.comboBox_services.Name = "comboBox_services";
            this.comboBox_services.Size = new System.Drawing.Size(398, 20);
            this.comboBox_services.TabIndex = 6;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(106, 137);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(89, 12);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "请点击查看状态";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.comboBox_services);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_viewStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server服务修复工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_viewStatus;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_services;
        private System.Windows.Forms.Label label_status;
    }
}

