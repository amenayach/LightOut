﻿namespace LightOut
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.trBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblShortcut = new System.Windows.Forms.Label();
            this.lblShortcutKey = new System.Windows.Forms.Label();
            this.chRunWithWindows = new System.Windows.Forms.CheckBox();
            this.ntfLightOut = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trBrightness)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trBrightness
            // 
            this.trBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trBrightness.Location = new System.Drawing.Point(12, 34);
            this.trBrightness.Maximum = 100;
            this.trBrightness.Name = "trBrightness";
            this.trBrightness.Size = new System.Drawing.Size(394, 45);
            this.trBrightness.TabIndex = 0;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(12, 13);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(56, 13);
            this.lblBrightness.TabIndex = 1;
            this.lblBrightness.Text = "Brightness";
            // 
            // lblShortcut
            // 
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(12, 96);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(47, 13);
            this.lblShortcut.TabIndex = 2;
            this.lblShortcut.Text = "Shortcut";
            // 
            // lblShortcutKey
            // 
            this.lblShortcutKey.BackColor = System.Drawing.Color.White;
            this.lblShortcutKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShortcutKey.Location = new System.Drawing.Point(65, 88);
            this.lblShortcutKey.Name = "lblShortcutKey";
            this.lblShortcutKey.Size = new System.Drawing.Size(115, 28);
            this.lblShortcutKey.TabIndex = 3;
            this.lblShortcutKey.Text = "Ctrl + Alt + < + | - >";
            this.lblShortcutKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chRunWithWindows
            // 
            this.chRunWithWindows.AutoSize = true;
            this.chRunWithWindows.Location = new System.Drawing.Point(186, 95);
            this.chRunWithWindows.Name = "chRunWithWindows";
            this.chRunWithWindows.Size = new System.Drawing.Size(118, 17);
            this.chRunWithWindows.TabIndex = 4;
            this.chRunWithWindows.Text = "&Run With Windows";
            this.chRunWithWindows.UseVisualStyleBackColor = true;
            this.chRunWithWindows.CheckedChanged += new System.EventHandler(this.chRunWithWindows_CheckedChanged);
            // 
            // ntfLightOut
            // 
            this.ntfLightOut.ContextMenuStrip = this.contextMenuStrip1;
            this.ntfLightOut.Icon = global::LightOut.Properties.Resources.brightness;
            this.ntfLightOut.Text = "LightOut";
            this.ntfLightOut.Visible = true;
            this.ntfLightOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfLightOut_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(332, 91);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(65, 23);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 133);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.chRunWithWindows);
            this.Controls.Add(this.lblShortcutKey);
            this.Controls.Add(this.lblShortcut);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.trBrightness);
            this.Icon = global::LightOut.Properties.Resources.brightness;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lighout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trBrightness)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.Label lblShortcutKey;
        private System.Windows.Forms.CheckBox chRunWithWindows;
        private System.Windows.Forms.NotifyIcon ntfLightOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnHide;
    }
}

