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
            this.components = new System.ComponentModel.Container();
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
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtBoxInterval = new System.Windows.Forms.TextBox();
            this.txtBoxScoreFile = new System.Windows.Forms.TextBox();
            this.lblScoreFile = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblAutoRun = new System.Windows.Forms.Label();
            this.txtBoxKeyFile = new System.Windows.Forms.TextBox();
            this.lblKeyFile = new System.Windows.Forms.Label();
            this.btnMDBFile = new System.Windows.Forms.Button();
            this.btnKeyFile = new System.Windows.Forms.Button();
            this.txtBoxHostName = new System.Windows.Forms.TextBox();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lblYouTube = new System.Windows.Forms.Label();
            this.txtBoxYouTube = new System.Windows.Forms.TextBox();
            this.chkBoxInitSend = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMdbFile
            // 
            this.lblMdbFile.AutoSize = true;
            this.lblMdbFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMdbFile.Location = new System.Drawing.Point(126, 126);
            this.lblMdbFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdbFile.Name = "lblMdbFile";
            this.lblMdbFile.Size = new System.Drawing.Size(138, 33);
            this.lblMdbFile.TabIndex = 0;
            this.lblMdbFile.Text = "MDB File";
            // 
            // lblHtmlPath
            // 
            this.lblHtmlPath.AutoSize = true;
            this.lblHtmlPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHtmlPath.Location = new System.Drawing.Point(126, 700);
            this.lblHtmlPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHtmlPath.Name = "lblHtmlPath";
            this.lblHtmlPath.Size = new System.Drawing.Size(196, 33);
            this.lblHtmlPath.TabIndex = 1;
            this.lblHtmlPath.Text = "Html file path";
            // 
            // lblIndexFile
            // 
            this.lblIndexFile.AutoSize = true;
            this.lblIndexFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIndexFile.Location = new System.Drawing.Point(126, 200);
            this.lblIndexFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndexFile.Name = "lblIndexFile";
            this.lblIndexFile.Size = new System.Drawing.Size(216, 33);
            this.lblIndexFile.TabIndex = 2;
            this.lblIndexFile.Text = "index file name";
            // 
            // lblPrgResult
            // 
            this.lblPrgResult.AutoSize = true;
            this.lblPrgResult.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrgResult.Location = new System.Drawing.Point(126, 267);
            this.lblPrgResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrgResult.Name = "lblPrgResult";
            this.lblPrgResult.Size = new System.Drawing.Size(303, 33);
            this.lblPrgResult.TabIndex = 3;
            this.lblPrgResult.Text = "Program形式結果File";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRanking.Location = new System.Drawing.Point(126, 338);
            this.lblRanking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(177, 33);
            this.lblRanking.TabIndex = 4;
            this.lblRanking.Text = "Ranking File";
            // 
            // txtBoxMDBFile
            // 
            this.txtBoxMDBFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxMDBFile.Location = new System.Drawing.Point(453, 126);
            this.txtBoxMDBFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxMDBFile.Name = "txtBoxMDBFile";
            this.txtBoxMDBFile.Size = new System.Drawing.Size(721, 39);
            this.txtBoxMDBFile.TabIndex = 5;
            // 
            // txtBoxHtmlPath
            // 
            this.txtBoxHtmlPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxHtmlPath.Location = new System.Drawing.Point(453, 694);
            this.txtBoxHtmlPath.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxHtmlPath.Name = "txtBoxHtmlPath";
            this.txtBoxHtmlPath.Size = new System.Drawing.Size(726, 39);
            this.txtBoxHtmlPath.TabIndex = 6;
            // 
            // txtBoxIndexFile
            // 
            this.txtBoxIndexFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxIndexFile.Location = new System.Drawing.Point(453, 194);
            this.txtBoxIndexFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxIndexFile.Name = "txtBoxIndexFile";
            this.txtBoxIndexFile.Size = new System.Drawing.Size(303, 39);
            this.txtBoxIndexFile.TabIndex = 7;
            // 
            // txtBoxPrgResult
            // 
            this.txtBoxPrgResult.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxPrgResult.Location = new System.Drawing.Point(453, 263);
            this.txtBoxPrgResult.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxPrgResult.Name = "txtBoxPrgResult";
            this.txtBoxPrgResult.Size = new System.Drawing.Size(303, 39);
            this.txtBoxPrgResult.TabIndex = 8;
            // 
            // txtBoxRanking
            // 
            this.txtBoxRanking.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxRanking.Location = new System.Drawing.Point(453, 332);
            this.txtBoxRanking.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxRanking.Name = "txtBoxRanking";
            this.txtBoxRanking.Size = new System.Drawing.Size(303, 39);
            this.txtBoxRanking.TabIndex = 9;
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnRun.Location = new System.Drawing.Point(351, 1012);
            this.BtnRun.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(162, 68);
            this.BtnRun.TabIndex = 10;
            this.BtnRun.Text = "作成";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRunClick);
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAutoRun.Location = new System.Drawing.Point(823, 1012);
            this.btnAutoRun.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(154, 68);
            this.btnAutoRun.TabIndex = 11;
            this.btnAutoRun.Text = "開始";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            this.btnAutoRun.Click += new System.EventHandler(this.BtnAutoRunClick);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInterval.Location = new System.Drawing.Point(656, 1114);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(259, 33);
            this.lblInterval.TabIndex = 12;
            this.lblInterval.Text = "自動実行間隔(分)";
            // 
            // txtBoxInterval
            // 
            this.txtBoxInterval.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxInterval.Location = new System.Drawing.Point(962, 1110);
            this.txtBoxInterval.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxInterval.Name = "txtBoxInterval";
            this.txtBoxInterval.Size = new System.Drawing.Size(67, 39);
            this.txtBoxInterval.TabIndex = 13;
            this.txtBoxInterval.Text = "5";
            // 
            // txtBoxScoreFile
            // 
            this.txtBoxScoreFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxScoreFile.Location = new System.Drawing.Point(453, 398);
            this.txtBoxScoreFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxScoreFile.Name = "txtBoxScoreFile";
            this.txtBoxScoreFile.Size = new System.Drawing.Size(303, 39);
            this.txtBoxScoreFile.TabIndex = 17;
            // 
            // lblScoreFile
            // 
            this.lblScoreFile.AutoSize = true;
            this.lblScoreFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblScoreFile.Location = new System.Drawing.Point(126, 405);
            this.lblScoreFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreFile.Name = "lblScoreFile";
            this.lblScoreFile.Size = new System.Drawing.Size(151, 33);
            this.lblScoreFile.TabIndex = 16;
            this.lblScoreFile.Text = "Score File";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(299, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(472, 54);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "WEB速報作成ツール";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnQuit.Location = new System.Drawing.Point(999, 8);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(162, 68);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "終了";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblAutoRun
            // 
            this.lblAutoRun.AutoSize = true;
            this.lblAutoRun.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAutoRun.Location = new System.Drawing.Point(832, 962);
            this.lblAutoRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoRun.Name = "lblAutoRun";
            this.lblAutoRun.Size = new System.Drawing.Size(143, 33);
            this.lblAutoRun.TabIndex = 22;
            this.lblAutoRun.Text = "自動実行";
            // 
            // txtBoxKeyFile
            // 
            this.txtBoxKeyFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxKeyFile.Location = new System.Drawing.Point(451, 765);
            this.txtBoxKeyFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxKeyFile.Name = "txtBoxKeyFile";
            this.txtBoxKeyFile.Size = new System.Drawing.Size(726, 39);
            this.txtBoxKeyFile.TabIndex = 24;
            // 
            // lblKeyFile
            // 
            this.lblKeyFile.AutoSize = true;
            this.lblKeyFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKeyFile.Location = new System.Drawing.Point(126, 765);
            this.lblKeyFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeyFile.Name = "lblKeyFile";
            this.lblKeyFile.Size = new System.Drawing.Size(201, 33);
            this.lblKeyFile.TabIndex = 23;
            this.lblKeyFile.Text = "秘密鍵ファイル";
            // 
            // btnMDBFile
            // 
            this.btnMDBFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMDBFile.Location = new System.Drawing.Point(1257, 121);
            this.btnMDBFile.Name = "btnMDBFile";
            this.btnMDBFile.Size = new System.Drawing.Size(109, 52);
            this.btnMDBFile.TabIndex = 25;
            this.btnMDBFile.Text = "選択";
            this.btnMDBFile.UseVisualStyleBackColor = true;
            this.btnMDBFile.Click += new System.EventHandler(this.btnMDBFile_Click);
            // 
            // btnKeyFile
            // 
            this.btnKeyFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKeyFile.Location = new System.Drawing.Point(1258, 765);
            this.btnKeyFile.Name = "btnKeyFile";
            this.btnKeyFile.Size = new System.Drawing.Size(104, 48);
            this.btnKeyFile.TabIndex = 28;
            this.btnKeyFile.Text = "選択";
            this.btnKeyFile.UseVisualStyleBackColor = true;
            this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
            // 
            // txtBoxHostName
            // 
            this.txtBoxHostName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxHostName.Location = new System.Drawing.Point(453, 575);
            this.txtBoxHostName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxHostName.Name = "txtBoxHostName";
            this.txtBoxHostName.Size = new System.Drawing.Size(303, 39);
            this.txtBoxHostName.TabIndex = 30;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHostName.Location = new System.Drawing.Point(126, 579);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(164, 33);
            this.lblHostName.TabIndex = 29;
            this.lblHostName.Text = "Host Name";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNote.Location = new System.Drawing.Point(312, 491);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(894, 33);
            this.lblNote.TabIndex = 31;
            this.lblNote.Text = "-------- Webサーバーにアップロードする場合は以下も設定の事----";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxUserName.Location = new System.Drawing.Point(453, 631);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(303, 39);
            this.txtBoxUserName.TabIndex = 33;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUserName.Location = new System.Drawing.Point(126, 635);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(164, 33);
            this.lblUserName.TabIndex = 32;
            this.lblUserName.Text = "User Name";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxPort.Location = new System.Drawing.Point(953, 573);
            this.txtBoxPort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(76, 39);
            this.txtBoxPort.TabIndex = 35;
            this.txtBoxPort.Text = "22";
            this.toolTip1.SetToolTip(this.txtBoxPort, "sshのポート番号");
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPort.Location = new System.Drawing.Point(845, 579);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(73, 33);
            this.lblPort.TabIndex = 34;
            this.lblPort.Text = "Port";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrowse.Location = new System.Drawing.Point(979, 386);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(142, 50);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "確認";
            this.toolTip1.SetToolTip(this.btnBrowse, "ブラウザーで確認する");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblYouTube
            // 
            this.lblYouTube.AutoSize = true;
            this.lblYouTube.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblYouTube.Location = new System.Drawing.Point(126, 899);
            this.lblYouTube.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYouTube.Name = "lblYouTube";
            this.lblYouTube.Size = new System.Drawing.Size(201, 33);
            this.lblYouTube.TabIndex = 37;
            this.lblYouTube.Text = "YouTube URL";
            // 
            // txtBoxYouTube
            // 
            this.txtBoxYouTube.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxYouTube.Location = new System.Drawing.Point(453, 893);
            this.txtBoxYouTube.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBoxYouTube.Name = "txtBoxYouTube";
            this.txtBoxYouTube.Size = new System.Drawing.Size(726, 39);
            this.txtBoxYouTube.TabIndex = 38;
            // 
            // chkBoxInitSend
            // 
            this.chkBoxInitSend.AutoSize = true;
            this.chkBoxInitSend.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkBoxInitSend.Location = new System.Drawing.Point(132, 827);
            this.chkBoxInitSend.Name = "chkBoxInitSend";
            this.chkBoxInitSend.Size = new System.Drawing.Size(418, 37);
            this.chkBoxInitSend.TabIndex = 40;
            this.chkBoxInitSend.Text = "  CSS, JS ファイルも転送する";
            this.chkBoxInitSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 1282);
            this.Controls.Add(this.chkBoxInitSend);
            this.Controls.Add(this.txtBoxYouTube);
            this.Controls.Add(this.lblYouTube);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtBoxHostName);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.btnKeyFile);
            this.Controls.Add(this.btnMDBFile);
            this.Controls.Add(this.txtBoxKeyFile);
            this.Controls.Add(this.lblKeyFile);
            this.Controls.Add(this.lblAutoRun);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxScoreFile);
            this.Controls.Add(this.lblScoreFile);
            this.Controls.Add(this.txtBoxInterval);
            this.Controls.Add(this.lblInterval);
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
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtBoxInterval;
        private System.Windows.Forms.TextBox txtBoxScoreFile;
        private System.Windows.Forms.Label lblScoreFile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblAutoRun;
        private System.Windows.Forms.TextBox txtBoxKeyFile;
        private System.Windows.Forms.Label lblKeyFile;
        private System.Windows.Forms.Button btnMDBFile;
        private System.Windows.Forms.Button btnKeyFile;
        private System.Windows.Forms.TextBox txtBoxHostName;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblYouTube;
        private System.Windows.Forms.TextBox txtBoxYouTube;
        private System.Windows.Forms.CheckBox chkBoxInitSend;
    }
}

