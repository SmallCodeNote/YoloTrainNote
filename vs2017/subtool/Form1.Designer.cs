﻿namespace subtool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Frame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_ImageCount = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CreateDirPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateDataSet = new System.Windows.Forms.Button();
            this.panel_Frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Frame
            // 
            this.panel_Frame.AutoScroll = true;
            this.panel_Frame.Controls.Add(this.pictureBox1);
            this.panel_Frame.Controls.Add(this.button_CreateDataSet);
            this.panel_Frame.Controls.Add(this.textBox_ImageCount);
            this.panel_Frame.Controls.Add(this.textBox_Height);
            this.panel_Frame.Controls.Add(this.label4);
            this.panel_Frame.Controls.Add(this.textBox_Width);
            this.panel_Frame.Controls.Add(this.label3);
            this.panel_Frame.Controls.Add(this.textBox_CreateDirPath);
            this.panel_Frame.Controls.Add(this.label2);
            this.panel_Frame.Controls.Add(this.label1);
            this.panel_Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Frame.Location = new System.Drawing.Point(0, 0);
            this.panel_Frame.Name = "panel_Frame";
            this.panel_Frame.Size = new System.Drawing.Size(691, 794);
            this.panel_Frame.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_ImageCount
            // 
            this.textBox_ImageCount.Location = new System.Drawing.Point(187, 68);
            this.textBox_ImageCount.Name = "textBox_ImageCount";
            this.textBox_ImageCount.Size = new System.Drawing.Size(76, 19);
            this.textBox_ImageCount.TabIndex = 2;
            this.textBox_ImageCount.Text = "100";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(85, 68);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(76, 19);
            this.textBox_Height.TabIndex = 2;
            this.textBox_Height.Text = "640";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "ImageCount";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(3, 68);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(76, 19);
            this.textBox_Width.TabIndex = 2;
            this.textBox_Width.Text = "640";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // textBox_CreateDirPath
            // 
            this.textBox_CreateDirPath.Location = new System.Drawing.Point(3, 25);
            this.textBox_CreateDirPath.Name = "textBox_CreateDirPath";
            this.textBox_CreateDirPath.Size = new System.Drawing.Size(576, 19);
            this.textBox_CreateDirPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "CreateDirPath";
            // 
            // button_CreateDataSet
            // 
            this.button_CreateDataSet.Location = new System.Drawing.Point(5, 93);
            this.button_CreateDataSet.Name = "button_CreateDataSet";
            this.button_CreateDataSet.Size = new System.Drawing.Size(168, 23);
            this.button_CreateDataSet.TabIndex = 0;
            this.button_CreateDataSet.Text = "CreateDataSet";
            this.button_CreateDataSet.UseVisualStyleBackColor = true;
            this.button_CreateDataSet.Click += new System.EventHandler(this.button_CreateDataSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 794);
            this.Controls.Add(this.panel_Frame);
            this.Name = "Form1";
            this.Text = "subTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Frame.ResumeLayout(false);
            this.panel_Frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Frame;
        private System.Windows.Forms.TextBox textBox_CreateDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_ImageCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CreateDataSet;
    }
}

