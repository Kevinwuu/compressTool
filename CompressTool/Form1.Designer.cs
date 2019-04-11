﻿using System;
using System.ComponentModel;

namespace CompressTool
{
    partial class CompressTool
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.cbData1 = new System.Windows.Forms.ComboBox();
            this.Compress = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.targetAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textFileSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textFile = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.textUnit = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.txtCompressPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(36, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "(只接受64KB~2GB的輸入值)";
            // 
            // cbData1
            // 
            this.cbData1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbData1.FormattingEnabled = true;
            this.cbData1.Items.AddRange(new object[] {
            "KB",
            "MB"});
            this.cbData1.Location = new System.Drawing.Point(133, 177);
            this.cbData1.Name = "cbData1";
            this.cbData1.Size = new System.Drawing.Size(102, 24);
            this.cbData1.TabIndex = 20;
            // 
            // Compress
            // 
            this.Compress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Compress.Location = new System.Drawing.Point(424, 332);
            this.Compress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(82, 29);
            this.Compress.TabIndex = 14;
            this.Compress.Text = "壓縮";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // btnMail
            // 
            this.btnMail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMail.Location = new System.Drawing.Point(197, 378);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(129, 29);
            this.btnMail.TabIndex = 15;
            this.btnMail.Text = "填寫信箱資料";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // cbData
            // 
            this.cbData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "64",
            "100",
            "200",
            "400"});
            this.cbData.Location = new System.Drawing.Point(133, 144);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(103, 25);
            this.cbData.TabIndex = 16;
            // 
            // targetAddr
            // 
            this.targetAddr.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.targetAddr.Location = new System.Drawing.Point(133, 282);
            this.targetAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.targetAddr.Name = "targetAddr";
            this.targetAddr.ReadOnly = true;
            this.targetAddr.Size = new System.Drawing.Size(239, 25);
            this.targetAddr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "存檔至";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "分割檔大小";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectPath.Location = new System.Drawing.Point(381, 282);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(36, 25);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFolder.Location = new System.Drawing.Point(471, 69);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(36, 27);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // textFolder
            // 
            this.textFolder.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFolder.Location = new System.Drawing.Point(134, 69);
            this.textFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFolder.Name = "textFolder";
            this.textFolder.ReadOnly = true;
            this.textFolder.Size = new System.Drawing.Size(321, 25);
            this.textFolder.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(39, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(76, 25);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "資料夾";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textFileSize
            // 
            this.textFileSize.AutoSize = true;
            this.textFileSize.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFileSize.Location = new System.Drawing.Point(406, 112);
            this.textFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textFileSize.Name = "textFileSize";
            this.textFileSize.Size = new System.Drawing.Size(63, 16);
            this.textFileSize.TabIndex = 9;
            this.textFileSize.Text = "           ";
            this.textFileSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(362, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "大小";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFile
            // 
            this.textFile.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFile.Location = new System.Drawing.Point(134, 31);
            this.textFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.ShortcutsEnabled = false;
            this.textFile.Size = new System.Drawing.Size(321, 25);
            this.textFile.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(39, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(76, 25);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "    檔案";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFile.Location = new System.Drawing.Point(471, 32);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(36, 27);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // textUnit
            // 
            this.textUnit.AutoSize = true;
            this.textUnit.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textUnit.Location = new System.Drawing.Point(479, 109);
            this.textUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textUnit.Name = "textUnit";
            this.textUnit.Size = new System.Drawing.Size(27, 19);
            this.textUnit.TabIndex = 9;
            this.textUnit.Text = "KB";
            this.textUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(39, 332);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(378, 29);
            this.progressBar.TabIndex = 24;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(424, 282);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 28);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "開啟";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showPass);
            this.groupBox1.Controls.Add(this.txtCompressPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(282, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(225, 139);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加密";
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showPass.Location = new System.Drawing.Point(26, 94);
            this.showPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(88, 23);
            this.showPass.TabIndex = 2;
            this.showPass.Text = "顯示密碼";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // txtCompressPass
            // 
            this.txtCompressPass.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCompressPass.Location = new System.Drawing.Point(26, 61);
            this.txtCompressPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompressPass.Name = "txtCompressPass";
            this.txtCompressPass.Size = new System.Drawing.Size(181, 25);
            this.txtCompressPass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "輸入密碼";
            // 
            // CompressTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textUnit);
            this.Controls.Add(this.textFileSize);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.targetAddr);
            this.Controls.Add(this.Compress);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.cbData1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnSelectFolder);
            this.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompressTool";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbData1;
        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.TextBox targetAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label textFileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label textUnit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox txtCompressPass;
    }
}

