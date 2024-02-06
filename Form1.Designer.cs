﻿namespace CreateWebReport
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
            this.lblMdbFile = new System.Windows.Forms.Label();
            this.lblHtmlPath = new System.Windows.Forms.Label();
            this.lblIndexFile = new System.Windows.Forms.Label();
            this.lblPrgResult = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.txtBoxMDBFile = new System.Windows.Forms.TextBox();
            this.txtBoxHtmlPath = new System.Windows.Forms.TextBox();
            this.txtBoxIndexFile = new System.Windows.Forms.TextBox();
            this.txtBoxPrgResult = new System.Windows.Forms.TextBox();
            this.txtBoxRanking = new System.Windows.Forms.TextBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.btnAutoRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInterval = new System.Windows.Forms.TextBox();
            this.txtBoxScoreFile = new System.Windows.Forms.TextBox();
            this.lblScoreFile = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxWorkDir = new System.Windows.Forms.TextBox();
            this.lblWorkDir = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMdbFile
            // 
            this.lblMdbFile.AutoSize = true;
            this.lblMdbFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMdbFile.Location = new System.Drawing.Point(58, 64);
            this.lblMdbFile.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMdbFile.Name = "lblMdbFile";
            this.lblMdbFile.Size = new System.Drawing.Size(67, 16);
            this.lblMdbFile.TabIndex = 0;
            this.lblMdbFile.Text = "MDB File";
            // 
            // lblHtmlPath
            // 
            this.lblHtmlPath.AutoSize = true;
            this.lblHtmlPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHtmlPath.Location = new System.Drawing.Point(58, 140);
            this.lblHtmlPath.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHtmlPath.Name = "lblHtmlPath";
            this.lblHtmlPath.Size = new System.Drawing.Size(97, 16);
            this.lblHtmlPath.TabIndex = 1;
            this.lblHtmlPath.Text = "Html file path";
            // 
            // lblIndexFile
            // 
            this.lblIndexFile.AutoSize = true;
            this.lblIndexFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIndexFile.Location = new System.Drawing.Point(58, 178);
            this.lblIndexFile.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblIndexFile.Name = "lblIndexFile";
            this.lblIndexFile.Size = new System.Drawing.Size(65, 16);
            this.lblIndexFile.TabIndex = 2;
            this.lblIndexFile.Text = "index file";
            // 
            // lblPrgResult
            // 
            this.lblPrgResult.AutoSize = true;
            this.lblPrgResult.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrgResult.Location = new System.Drawing.Point(58, 214);
            this.lblPrgResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrgResult.Name = "lblPrgResult";
            this.lblPrgResult.Size = new System.Drawing.Size(151, 16);
            this.lblPrgResult.TabIndex = 3;
            this.lblPrgResult.Text = "Program形式結果File";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRanking.Location = new System.Drawing.Point(58, 252);
            this.lblRanking.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(86, 16);
            this.lblRanking.TabIndex = 4;
            this.lblRanking.Text = "Ranking File";
            // 
            // txtBoxMDBFile
            // 
            this.txtBoxMDBFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxMDBFile.Location = new System.Drawing.Point(210, 62);
            this.txtBoxMDBFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxMDBFile.Name = "txtBoxMDBFile";
            this.txtBoxMDBFile.Size = new System.Drawing.Size(335, 23);
            this.txtBoxMDBFile.TabIndex = 5;
            // 
            // txtBoxHtmlPath
            // 
            this.txtBoxHtmlPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxHtmlPath.Location = new System.Drawing.Point(209, 137);
            this.txtBoxHtmlPath.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxHtmlPath.Name = "txtBoxHtmlPath";
            this.txtBoxHtmlPath.Size = new System.Drawing.Size(337, 23);
            this.txtBoxHtmlPath.TabIndex = 6;
            // 
            // txtBoxIndexFile
            // 
            this.txtBoxIndexFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxIndexFile.Location = new System.Drawing.Point(209, 176);
            this.txtBoxIndexFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxIndexFile.Name = "txtBoxIndexFile";
            this.txtBoxIndexFile.Size = new System.Drawing.Size(142, 23);
            this.txtBoxIndexFile.TabIndex = 7;
            // 
            // txtBoxPrgResult
            // 
            this.txtBoxPrgResult.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxPrgResult.Location = new System.Drawing.Point(209, 212);
            this.txtBoxPrgResult.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxPrgResult.Name = "txtBoxPrgResult";
            this.txtBoxPrgResult.Size = new System.Drawing.Size(142, 23);
            this.txtBoxPrgResult.TabIndex = 8;
            // 
            // txtBoxRanking
            // 
            this.txtBoxRanking.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxRanking.Location = new System.Drawing.Point(209, 249);
            this.txtBoxRanking.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxRanking.Name = "txtBoxRanking";
            this.txtBoxRanking.Size = new System.Drawing.Size(142, 23);
            this.txtBoxRanking.TabIndex = 9;
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnRun.Location = new System.Drawing.Point(162, 373);
            this.BtnRun.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 34);
            this.BtnRun.TabIndex = 10;
            this.BtnRun.Text = "作成";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRunClick);
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAutoRun.Location = new System.Drawing.Point(380, 373);
            this.btnAutoRun.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(71, 34);
            this.btnAutoRun.TabIndex = 11;
            this.btnAutoRun.Text = "開始";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            this.btnAutoRun.Click += new System.EventHandler(this.BtnAutoRunClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(303, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "自動実行間隔(分)";
            // 
            // txtBoxInterval
            // 
            this.txtBoxInterval.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxInterval.Location = new System.Drawing.Point(444, 422);
            this.txtBoxInterval.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxInterval.Name = "txtBoxInterval";
            this.txtBoxInterval.Size = new System.Drawing.Size(33, 23);
            this.txtBoxInterval.TabIndex = 13;
            this.txtBoxInterval.Text = "5";
            // 
            // txtBoxScoreFile
            // 
            this.txtBoxScoreFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxScoreFile.Location = new System.Drawing.Point(209, 284);
            this.txtBoxScoreFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxScoreFile.Name = "txtBoxScoreFile";
            this.txtBoxScoreFile.Size = new System.Drawing.Size(142, 23);
            this.txtBoxScoreFile.TabIndex = 17;
            // 
            // lblScoreFile
            // 
            this.lblScoreFile.AutoSize = true;
            this.lblScoreFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblScoreFile.Location = new System.Drawing.Point(58, 286);
            this.lblScoreFile.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblScoreFile.Name = "lblScoreFile";
            this.lblScoreFile.Size = new System.Drawing.Size(75, 16);
            this.lblScoreFile.TabIndex = 16;
            this.lblScoreFile.Text = "Score File";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(138, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 27);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "WEB速報作成ツール";
            // 
            // txtBoxWorkDir
            // 
            this.txtBoxWorkDir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxWorkDir.Location = new System.Drawing.Point(210, 98);
            this.txtBoxWorkDir.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBoxWorkDir.Name = "txtBoxWorkDir";
            this.txtBoxWorkDir.Size = new System.Drawing.Size(335, 23);
            this.txtBoxWorkDir.TabIndex = 20;
            // 
            // lblWorkDir
            // 
            this.lblWorkDir.AutoSize = true;
            this.lblWorkDir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWorkDir.Location = new System.Drawing.Point(58, 101);
            this.lblWorkDir.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWorkDir.Name = "lblWorkDir";
            this.lblWorkDir.Size = new System.Drawing.Size(99, 16);
            this.lblWorkDir.TabIndex = 19;
            this.lblWorkDir.Text = "作業フォルダー";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnQuit.Location = new System.Drawing.Point(461, 4);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 34);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "終了";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(384, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "自動実行";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtBoxWorkDir);
            this.Controls.Add(this.lblWorkDir);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxScoreFile);
            this.Controls.Add(this.lblScoreFile);
            this.Controls.Add(this.txtBoxInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutoRun);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.txtBoxRanking);
            this.Controls.Add(this.txtBoxPrgResult);
            this.Controls.Add(this.txtBoxIndexFile);
            this.Controls.Add(this.txtBoxHtmlPath);
            this.Controls.Add(this.txtBoxMDBFile);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblPrgResult);
            this.Controls.Add(this.lblIndexFile);
            this.Controls.Add(this.lblHtmlPath);
            this.Controls.Add(this.lblMdbFile);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "(C)一般社団法人大津市水泳協会";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMdbFile;
        private System.Windows.Forms.Label lblHtmlPath;
        private System.Windows.Forms.Label lblIndexFile;
        private System.Windows.Forms.Label lblPrgResult;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.TextBox txtBoxMDBFile;
        private System.Windows.Forms.TextBox txtBoxHtmlPath;
        private System.Windows.Forms.TextBox txtBoxIndexFile;
        private System.Windows.Forms.TextBox txtBoxPrgResult;
        private System.Windows.Forms.TextBox txtBoxRanking;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button btnAutoRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInterval;
        private System.Windows.Forms.TextBox txtBoxScoreFile;
        private System.Windows.Forms.Label lblScoreFile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxWorkDir;
        private System.Windows.Forms.Label lblWorkDir;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
    }
}
