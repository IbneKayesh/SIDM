namespace SIDM
{
    partial class frmAddLink
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
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDownloadLink = new System.Windows.Forms.TextBox();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnAddLink);
            this.pnlSettings.Controls.Add(this.btnClose);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.txtDownloadLink);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(620, 44);
            this.pnlSettings.TabIndex = 1;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddLink.FlatAppearance.BorderSize = 0;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Image = global::SIDM.Properties.Resources.ok_28;
            this.btnAddLink.Location = new System.Drawing.Point(530, 0);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(45, 44);
            this.btnAddLink.TabIndex = 2;
            this.btnAddLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SIDM.Properties.Resources.close_28;
            this.btnClose.Location = new System.Drawing.Point(575, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link:";
            // 
            // txtDownloadLink
            // 
            this.txtDownloadLink.Location = new System.Drawing.Point(55, 8);
            this.txtDownloadLink.Name = "txtDownloadLink";
            this.txtDownloadLink.PlaceholderText = "Enter Download Link";
            this.txtDownloadLink.Size = new System.Drawing.Size(469, 29);
            this.txtDownloadLink.TabIndex = 0;
            // 
            // frmAddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(620, 44);
            this.Controls.Add(this.pnlSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddLink";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Link";
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSettings;
        private Button btnAddLink;
        private Label label1;
        private TextBox txtDownloadLink;
        private Button btnClose;
    }
}