namespace Decoder
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
            this.uxpnlTop = new System.Windows.Forms.Panel();
            this.uxrdoEncode = new System.Windows.Forms.RadioButton();
            this.uxlblMode = new System.Windows.Forms.Label();
            this.uxrdoDecode = new System.Windows.Forms.RadioButton();
            this.uxpnlOuter.SuspendLayout();
            this.uxpnlRight.SuspendLayout();
            this.uxpnlLeft.SuspendLayout();
            this.uxpnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxpnlOuter
            // 
            this.uxpnlOuter.Controls.Add(this.uxpnlRight);
            this.uxpnlOuter.Controls.Add(this.uxpnlLeft);
            this.uxpnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxpnlOuter.Location = new System.Drawing.Point(0, 46);
            this.uxpnlOuter.Name = "uxpnlOuter";
            this.uxpnlOuter.Size = new System.Drawing.Size(1105, 504);
            this.uxpnlOuter.TabIndex = 0;
            // 
            // uxpnlRight
            // 
            this.uxpnlRight.Controls.Add(this.uxtxtOutput);
            this.uxpnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxpnlRight.Location = new System.Drawing.Point(387, 0);
            this.uxpnlRight.Name = "uxpnlRight";
            this.uxpnlRight.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.uxpnlRight.Size = new System.Drawing.Size(718, 504);
            this.uxpnlRight.TabIndex = 1;
            // 
            // uxtxtOutput
            // 
            this.uxtxtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uxtxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxtxtOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtxtOutput.ForeColor = System.Drawing.Color.LightGreen;
            this.uxtxtOutput.Location = new System.Drawing.Point(3, 6);
            this.uxtxtOutput.Multiline = true;
            this.uxtxtOutput.Name = "uxtxtOutput";
            this.uxtxtOutput.ReadOnly = true;
            this.uxtxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxtxtOutput.Size = new System.Drawing.Size(709, 492);
            this.uxtxtOutput.TabIndex = 0;
            this.uxtxtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtOutput_KeyPress);
            // 
            // uxpnlLeft
            // 
            this.uxpnlLeft.Controls.Add(this.uxtxtInput);
            this.uxpnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxpnlLeft.Location = new System.Drawing.Point(0, 0);
            this.uxpnlLeft.Name = "uxpnlLeft";
            this.uxpnlLeft.Padding = new System.Windows.Forms.Padding(6, 6, 3, 6);
            this.uxpnlLeft.Size = new System.Drawing.Size(387, 504);
            this.uxpnlLeft.TabIndex = 0;
            // 
            // uxtxtInput
            // 
            this.uxtxtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uxtxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxtxtInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxtxtInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxtxtInput.Location = new System.Drawing.Point(6, 6);
            this.uxtxtInput.Multiline = true;
            this.uxtxtInput.Name = "uxtxtInput";
            this.uxtxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxtxtInput.Size = new System.Drawing.Size(378, 492);
            this.uxtxtInput.TabIndex = 0;
            this.uxtxtInput.TextChanged += new System.EventHandler(this.uxtxtInput_TextChanged);
            this.uxtxtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtInput_KeyPress);
            // 
            // uxpnlTop
            // 
            this.uxpnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uxpnlTop.Controls.Add(this.uxrdoEncode);
            this.uxpnlTop.Controls.Add(this.uxlblMode);
            this.uxpnlTop.Controls.Add(this.uxrdoDecode);
            this.uxpnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxpnlTop.Location = new System.Drawing.Point(0, 0);
            this.uxpnlTop.Name = "uxpnlTop";
            this.uxpnlTop.Size = new System.Drawing.Size(1105, 46);
            this.uxpnlTop.TabIndex = 1;
            // 
            // uxrdoEncode
            // 
            this.uxrdoEncode.AutoSize = true;
            this.uxrdoEncode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxrdoEncode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxrdoEncode.Location = new System.Drawing.Point(162, 16);
            this.uxrdoEncode.Name = "uxrdoEncode";
            this.uxrdoEncode.Size = new System.Drawing.Size(76, 20);
            this.uxrdoEncode.TabIndex = 2;
            this.uxrdoEncode.Text = " &Encode";
            this.uxrdoEncode.UseVisualStyleBackColor = true;
            this.uxrdoEncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtInput_KeyPress);
            // 
            // uxlblMode
            // 
            this.uxlblMode.AutoSize = true;
            this.uxlblMode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlblMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxlblMode.Location = new System.Drawing.Point(7, 18);
            this.uxlblMode.Name = "uxlblMode";
            this.uxlblMode.Size = new System.Drawing.Size(48, 16);
            this.uxlblMode.TabIndex = 0;
            this.uxlblMode.Text = "Mode:";
            // 
            // uxrdoDecode
            // 
            this.uxrdoDecode.AutoSize = true;
            this.uxrdoDecode.Checked = true;
            this.uxrdoDecode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxrdoDecode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxrdoDecode.Location = new System.Drawing.Point(65, 16);
            this.uxrdoDecode.Name = "uxrdoDecode";
            this.uxrdoDecode.Size = new System.Drawing.Size(78, 20);
            this.uxrdoDecode.TabIndex = 1;
            this.uxrdoDecode.TabStop = true;
            this.uxrdoDecode.Text = " &Decode";
            this.uxrdoDecode.UseVisualStyleBackColor = true;
            this.uxrdoDecode.CheckedChanged += new System.EventHandler(this.uxrdoDecode_CheckedChanged);
            this.uxrdoDecode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxtxtInput_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1105, 550);
            this.Controls.Add(this.uxpnlOuter);
            this.Controls.Add(this.uxpnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 De/Encoder  |  Version {0}";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.uxpnlOuter.ResumeLayout(false);
            this.uxpnlRight.ResumeLayout(false);
            this.uxpnlRight.PerformLayout();
            this.uxpnlLeft.ResumeLayout(false);
            this.uxpnlLeft.PerformLayout();
            this.uxpnlTop.ResumeLayout(false);
            this.uxpnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxpnlOuter;
        private System.Windows.Forms.Panel uxpnlRight;
        private System.Windows.Forms.TextBox uxtxtOutput;
        private System.Windows.Forms.Panel uxpnlLeft;
        private System.Windows.Forms.TextBox uxtxtInput;
        private System.Windows.Forms.Panel uxpnlTop;
        private System.Windows.Forms.RadioButton uxrdoEncode;
        private System.Windows.Forms.Label uxlblMode;
        private System.Windows.Forms.RadioButton uxrdoDecode;
    }
}

