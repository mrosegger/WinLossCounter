namespace WinLossCounter
{
    partial class FormCounter
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
            this.winCount = new System.Windows.Forms.Label();
            this.lossCount = new System.Windows.Forms.Label();
            this.winBtn = new System.Windows.Forms.Button();
            this.lossBtn = new System.Windows.Forms.Button();
            this.winPercent = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // winCount
            // 
            this.winCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winCount.BackColor = System.Drawing.Color.Transparent;
            this.winCount.Location = new System.Drawing.Point(12, 53);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(46, 17);
            this.winCount.TabIndex = 0;
            this.winCount.Text = "label1";
            this.winCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lossCount
            // 
            this.lossCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lossCount.BackColor = System.Drawing.Color.Transparent;
            this.lossCount.Location = new System.Drawing.Point(399, 53);
            this.lossCount.Name = "lossCount";
            this.lossCount.Size = new System.Drawing.Size(46, 17);
            this.lossCount.TabIndex = 1;
            this.lossCount.Text = "label2";
            this.lossCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winBtn
            // 
            this.winBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winBtn.Location = new System.Drawing.Point(15, 415);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(75, 23);
            this.winBtn.TabIndex = 2;
            this.winBtn.Text = "Add Win";
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.winBtn_Click);
            // 
            // lossBtn
            // 
            this.lossBtn.Location = new System.Drawing.Point(402, 415);
            this.lossBtn.Name = "lossBtn";
            this.lossBtn.Size = new System.Drawing.Size(75, 23);
            this.lossBtn.TabIndex = 3;
            this.lossBtn.Text = "Add Loss";
            this.lossBtn.UseVisualStyleBackColor = true;
            this.lossBtn.Click += new System.EventHandler(this.lossBtn_Click);
            // 
            // winPercent
            // 
            this.winPercent.AutoSize = true;
            this.winPercent.Location = new System.Drawing.Point(742, 421);
            this.winPercent.Name = "winPercent";
            this.winPercent.Size = new System.Drawing.Size(46, 17);
            this.winPercent.TabIndex = 4;
            this.winPercent.Text = "label1";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToCounterToolStripMenuItem,
            this.removeFromCounterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToCounterToolStripMenuItem
            // 
            this.addToCounterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWinToolStripMenuItem,
            this.addLossToolStripMenuItem});
            this.addToCounterToolStripMenuItem.Name = "addToCounterToolStripMenuItem";
            this.addToCounterToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addToCounterToolStripMenuItem.Text = "Add to counter";
            // 
            // addWinToolStripMenuItem
            // 
            this.addWinToolStripMenuItem.Name = "addWinToolStripMenuItem";
            this.addWinToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addWinToolStripMenuItem.Text = "Add win";
            this.addWinToolStripMenuItem.Click += new System.EventHandler(this.addWinToolStripMenuItem_Click);
            // 
            // addLossToolStripMenuItem
            // 
            this.addLossToolStripMenuItem.Name = "addLossToolStripMenuItem";
            this.addLossToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addLossToolStripMenuItem.Text = "Add loss";
            this.addLossToolStripMenuItem.Click += new System.EventHandler(this.addLossToolStripMenuItem_Click);
            // 
            // removeFromCounterToolStripMenuItem
            // 
            this.removeFromCounterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeWinToolStripMenuItem,
            this.removeLossToolStripMenuItem});
            this.removeFromCounterToolStripMenuItem.Name = "removeFromCounterToolStripMenuItem";
            this.removeFromCounterToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.removeFromCounterToolStripMenuItem.Text = "Remove from counter";
            // 
            // removeWinToolStripMenuItem
            // 
            this.removeWinToolStripMenuItem.Name = "removeWinToolStripMenuItem";
            this.removeWinToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.removeWinToolStripMenuItem.Text = "Remove win";
            this.removeWinToolStripMenuItem.Click += new System.EventHandler(this.removeWinToolStripMenuItem_Click);
            // 
            // removeLossToolStripMenuItem
            // 
            this.removeLossToolStripMenuItem.Name = "removeLossToolStripMenuItem";
            this.removeLossToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.removeLossToolStripMenuItem.Text = "Remove loss";
            this.removeLossToolStripMenuItem.Click += new System.EventHandler(this.removeLossToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winPercent);
            this.Controls.Add(this.lossBtn);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.lossCount);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormCounter";
            this.Text = "WinLossCounter";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.Label lossCount;
        private System.Windows.Forms.Button winBtn;
        private System.Windows.Forms.Button lossBtn;
        private System.Windows.Forms.Label winPercent;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

