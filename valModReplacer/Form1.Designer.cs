namespace valModReplacer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoText = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.subInfo = new System.Windows.Forms.Label();
            this.backupLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.infoText.Location = new System.Drawing.Point(12, 9);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(419, 30);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "This replaces your BepInEx folder from a zip";
            // 
            // installButton
            // 
            this.installButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.installButton.BackColor = System.Drawing.Color.SeaShell;
            this.installButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.installButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.installButton.Location = new System.Drawing.Point(12, 144);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(136, 37);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "Install / Update";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 74);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 3;
            // 
            // urlBox
            // 
            this.urlBox.BackColor = System.Drawing.Color.White;
            this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.urlBox.Location = new System.Drawing.Point(41, 102);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(406, 16);
            this.urlBox.TabIndex = 0;
            this.urlBox.TabStop = false;
            this.urlBox.Text = "https://codeload.github.com/GREEB/gvModPack/zip/refs/heads/main";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(10, 103);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(25, 15);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "Url:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // subInfo
            // 
            this.subInfo.AutoSize = true;
            this.subInfo.ForeColor = System.Drawing.Color.Black;
            this.subInfo.Location = new System.Drawing.Point(12, 54);
            this.subInfo.Name = "subInfo";
            this.subInfo.Size = new System.Drawing.Size(168, 15);
            this.subInfo.TabIndex = 10;
            this.subInfo.Text = "Run this in you valheim folder!";
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.BackColor = System.Drawing.Color.LightGreen;
            this.backupLabel.Location = new System.Drawing.Point(12, 74);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(389, 15);
            this.backupLabel.TabIndex = 13;
            this.backupLabel.Text = "backup created in BepInEx.old if anything goes wrong restore from there";
            this.backupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backupLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(549, 216);
            this.Controls.Add(this.backupLabel);
            this.Controls.Add(this.subInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.infoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "valModReplacer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label infoText;
        private Button installButton;
        private LinkLabel linkLabel1;
        private TextBox urlBox;
        private Label urlLabel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label subInfo;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label backupLabel;
    }
}