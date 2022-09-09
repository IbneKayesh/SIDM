namespace SIDM
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlDownloadList = new System.Windows.Forms.Panel();
            this.pnlCurrentItem = new System.Windows.Forms.Panel();
            this.lblFileSizeDownSize = new System.Windows.Forms.Label();
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalBit = new System.Windows.Forms.Label();
            this.lblEndBit = new System.Windows.Forms.Label();
            this.lblStartBit = new System.Windows.Forms.Label();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblChunk = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.lblDiskPath = new System.Windows.Forms.Label();
            this.txtDiskPath = new System.Windows.Forms.TextBox();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.pnlDownloadList.SuspendLayout();
            this.pnlCurrentItem.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.pnlTitleBar.Controls.Add(this.lblPageTitle);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(784, 35);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblPageTitle.Size = new System.Drawing.Size(51, 28);
            this.lblPageTitle.TabIndex = 5;
            this.lblPageTitle.Tag = "Home";
            this.lblPageTitle.Text = "SIDM";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::SIDM.Properties.Resources.minimize_28;
            this.btnMinimize.Location = new System.Drawing.Point(706, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SIDM.Properties.Resources.close_28;
            this.btnClose.Location = new System.Drawing.Point(745, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.pnlDesktop.Controls.Add(this.pnlDownloadList);
            this.pnlDesktop.Controls.Add(this.pnlSettings);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 35);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(784, 247);
            this.pnlDesktop.TabIndex = 1;
            // 
            // pnlDownloadList
            // 
            this.pnlDownloadList.AutoScroll = true;
            this.pnlDownloadList.Controls.Add(this.pnlCurrentItem);
            this.pnlDownloadList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDownloadList.Location = new System.Drawing.Point(0, 58);
            this.pnlDownloadList.Name = "pnlDownloadList";
            this.pnlDownloadList.Size = new System.Drawing.Size(784, 189);
            this.pnlDownloadList.TabIndex = 1;
            // 
            // pnlCurrentItem
            // 
            this.pnlCurrentItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.pnlCurrentItem.Controls.Add(this.lblFileSizeDownSize);
            this.pnlCurrentItem.Controls.Add(this.lblLeftTime);
            this.pnlCurrentItem.Controls.Add(this.label9);
            this.pnlCurrentItem.Controls.Add(this.lblTotalBit);
            this.pnlCurrentItem.Controls.Add(this.lblEndBit);
            this.pnlCurrentItem.Controls.Add(this.lblStartBit);
            this.pnlCurrentItem.Controls.Add(this.progressBar9);
            this.pnlCurrentItem.Controls.Add(this.lblLink);
            this.pnlCurrentItem.Controls.Add(this.lblChunk);
            this.pnlCurrentItem.Location = new System.Drawing.Point(12, 12);
            this.pnlCurrentItem.Name = "pnlCurrentItem";
            this.pnlCurrentItem.Padding = new System.Windows.Forms.Padding(10, 90, 0, 0);
            this.pnlCurrentItem.Size = new System.Drawing.Size(760, 166);
            this.pnlCurrentItem.TabIndex = 0;
            // 
            // lblFileSizeDownSize
            // 
            this.lblFileSizeDownSize.AutoSize = true;
            this.lblFileSizeDownSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileSizeDownSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFileSizeDownSize.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileSizeDownSize.ForeColor = System.Drawing.Color.White;
            this.lblFileSizeDownSize.Location = new System.Drawing.Point(13, 142);
            this.lblFileSizeDownSize.Name = "lblFileSizeDownSize";
            this.lblFileSizeDownSize.Size = new System.Drawing.Size(103, 15);
            this.lblFileSizeDownSize.TabIndex = 26;
            this.lblFileSizeDownSize.Text = "0 MB of 0 MB (Est.)";
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeftTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLeftTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeftTime.ForeColor = System.Drawing.Color.White;
            this.lblLeftTime.Location = new System.Drawing.Point(517, 142);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(129, 15);
            this.lblLeftTime.TabIndex = 25;
            this.lblLeftTime.Text = "0 left. End: 00:00:00 AM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(253, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "0 MB / 0 kbit/s";
            // 
            // lblTotalBit
            // 
            this.lblTotalBit.AutoSize = true;
            this.lblTotalBit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalBit.ForeColor = System.Drawing.Color.White;
            this.lblTotalBit.Location = new System.Drawing.Point(680, 11);
            this.lblTotalBit.Name = "lblTotalBit";
            this.lblTotalBit.Size = new System.Drawing.Size(70, 23);
            this.lblTotalBit.TabIndex = 15;
            this.lblTotalBit.Text = "1000 Bit";
            // 
            // lblEndBit
            // 
            this.lblEndBit.AutoSize = true;
            this.lblEndBit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEndBit.ForeColor = System.Drawing.Color.White;
            this.lblEndBit.Location = new System.Drawing.Point(567, 11);
            this.lblEndBit.Name = "lblEndBit";
            this.lblEndBit.Size = new System.Drawing.Size(61, 23);
            this.lblEndBit.TabIndex = 14;
            this.lblEndBit.Text = "100 Bit";
            // 
            // lblStartBit
            // 
            this.lblStartBit.AutoSize = true;
            this.lblStartBit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStartBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblStartBit.ForeColor = System.Drawing.Color.White;
            this.lblStartBit.Location = new System.Drawing.Point(474, 10);
            this.lblStartBit.Name = "lblStartBit";
            this.lblStartBit.Size = new System.Drawing.Size(43, 23);
            this.lblStartBit.TabIndex = 13;
            this.lblStartBit.Text = "0 Bit";
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(9, 112);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(741, 23);
            this.progressBar9.TabIndex = 12;
            // 
            // lblLink
            // 
            this.lblLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLink.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLink.ForeColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(39, 10);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(400, 25);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "https://example.com/file.bin";
            // 
            // lblChunk
            // 
            this.lblChunk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChunk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblChunk.ForeColor = System.Drawing.Color.White;
            this.lblChunk.Location = new System.Drawing.Point(13, 10);
            this.lblChunk.Name = "lblChunk";
            this.lblChunk.Size = new System.Drawing.Size(20, 25);
            this.lblChunk.TabIndex = 2;
            this.lblChunk.Text = "1";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnDownload);
            this.pnlSettings.Controls.Add(this.btnAddLink);
            this.pnlSettings.Controls.Add(this.lblDiskPath);
            this.pnlSettings.Controls.Add(this.txtDiskPath);
            this.pnlSettings.Location = new System.Drawing.Point(94, 8);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(614, 45);
            this.pnlSettings.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Image = global::SIDM.Properties.Resources.download_28;
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(485, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(120, 35);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Image = global::SIDM.Properties.Resources.plus_28;
            this.btnAddLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLink.Location = new System.Drawing.Point(359, 5);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(120, 35);
            this.btnAddLink.TabIndex = 2;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // lblDiskPath
            // 
            this.lblDiskPath.AutoSize = true;
            this.lblDiskPath.Location = new System.Drawing.Point(7, 12);
            this.lblDiskPath.Name = "lblDiskPath";
            this.lblDiskPath.Size = new System.Drawing.Size(77, 21);
            this.lblDiskPath.TabIndex = 1;
            this.lblDiskPath.Text = "Disk Path:";
            // 
            // txtDiskPath
            // 
            this.txtDiskPath.Location = new System.Drawing.Point(87, 8);
            this.txtDiskPath.Name = "txtDiskPath";
            this.txtDiskPath.PlaceholderText = "Enter Disk Path";
            this.txtDiskPath.Size = new System.Drawing.Size(267, 29);
            this.txtDiskPath.TabIndex = 0;
            this.txtDiskPath.Text = "D:\\";
            this.txtDiskPath.Click += new System.EventHandler(this.txtDiskPath_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 282);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDownloadList.ResumeLayout(false);
            this.pnlCurrentItem.ResumeLayout(false);
            this.pnlCurrentItem.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTitleBar;
        private Panel pnlDesktop;
        private Button btnMinimize;
        private Button btnClose;
        private Label lblPageTitle;
        private Panel pnlSettings;
        private Label lblDiskPath;
        private TextBox txtDiskPath;
        private Button btnAddLink;
        private Button btnDownload;
        private Panel pnlDownloadList;
        private Panel pnlCurrentItem;
        private Label lblChunk;
        private Label lblLink;
        private Label lblTotalBit;
        private Label lblEndBit;
        private Label lblStartBit;
        private Label lblLeftTime;
        private Label label9;
        private Label lblFileSizeDownSize;
        private ProgressBar progressBar9;
    }
}