﻿namespace Decoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxpnlOuter = new System.Windows.Forms.Panel();
            this.uxpnlRight = new System.Windows.Forms.Panel();
            this.uxtxtOutput = new System.Windows.Forms.TextBox();
            this.uxpnlLeft = new System.Windows.Forms.Panel();
            this.uxtxtInput = new System.Windows.Forms.TextBox();
            this.uxpnlOuter.SuspendLayout();
            this.uxpnlRight.SuspendLayout();
            this.uxpnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxpnlOuter
            // 
            this.uxpnlOuter.Controls.Add(this.uxpnlRight);
            this.uxpnlOuter.Controls.Add(this.uxpnlLeft);
            this.uxpnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxpnlOuter.Location = new System.Drawing.Point(0, 0);
            this.uxpnlOuter.Name = "uxpnlOuter";
            this.uxpnlOuter.Size = new System.Drawing.Size(1105, 550);
            this.uxpnlOuter.TabIndex = 0;
            // 
            // uxpnlRight
            // 
            this.uxpnlRight.Controls.Add(this.uxtxtOutput);
            this.uxpnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxpnlRight.Location = new System.Drawing.Point(387, 0);
            this.uxpnlRight.Name = "uxpnlRight";
            this.uxpnlRight.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.uxpnlRight.Size = new System.Drawing.Size(718, 550);
            this.uxpnlRight.TabIndex = 1;
            // 
            // uxtxtOutput
            // 
            this.uxtxtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uxtxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxtxtOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtxtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.uxtxtOutput.Location = new System.Drawing.Point(3, 6);
            this.uxtxtOutput.Multiline = true;
            this.uxtxtOutput.Name = "uxtxtOutput";
            this.uxtxtOutput.ReadOnly = true;
            this.uxtxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxtxtOutput.Size = new System.Drawing.Size(709, 538);
            this.uxtxtOutput.TabIndex = 1;
            this.uxtxtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtOutput_KeyPress);
            // 
            // uxpnlLeft
            // 
            this.uxpnlLeft.Controls.Add(this.uxtxtInput);
            this.uxpnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxpnlLeft.Location = new System.Drawing.Point(0, 0);
            this.uxpnlLeft.Name = "uxpnlLeft";
            this.uxpnlLeft.Padding = new System.Windows.Forms.Padding(6, 6, 3, 6);
            this.uxpnlLeft.Size = new System.Drawing.Size(387, 550);
            this.uxpnlLeft.TabIndex = 0;
            // 
            // uxtxtInput
            // 
            this.uxtxtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uxtxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxtxtInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtxtInput.ForeColor = System.Drawing.Color.White;
            this.uxtxtInput.Location = new System.Drawing.Point(6, 6);
            this.uxtxtInput.Multiline = true;
            this.uxtxtInput.Name = "uxtxtInput";
            this.uxtxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxtxtInput.Size = new System.Drawing.Size(378, 538);
            this.uxtxtInput.TabIndex = 0;
            this.uxtxtInput.TextChanged += new System.EventHandler(this.uxtxtInput_TextChanged);
            this.uxtxtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtInput_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1105, 550);
            this.Controls.Add(this.uxpnlOuter);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Decoder  |  Version 1.0.1  |  5research.xyz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.uxpnlOuter.ResumeLayout(false);
            this.uxpnlRight.ResumeLayout(false);
            this.uxpnlRight.PerformLayout();
            this.uxpnlLeft.ResumeLayout(false);
            this.uxpnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxpnlOuter;
        private System.Windows.Forms.Panel uxpnlRight;
        private System.Windows.Forms.TextBox uxtxtOutput;
        private System.Windows.Forms.Panel uxpnlLeft;
        private System.Windows.Forms.TextBox uxtxtInput;
    }
}

