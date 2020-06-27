using System;
using System.Text;
using System.Windows.Forms;
using Decoder.Utils;

namespace Decoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitCustomFont();

            AssignCustomFont();

            Text = string.Format(this.Text, AppUtils.GetAppVersion());
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            uxpnlLeft.Width = uxpnlOuter.Width / 2;
        }

        private void uxtxtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (uxrdoDecode.Checked)
                {
                    var data = Convert.FromBase64String(uxtxtInput.Text);
                    var decodedString = Encoding.UTF8.GetString(data);
                    uxtxtOutput.Text = decodedString;
                }
                else
                {
                    var data = Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(uxtxtInput.Text));

                    var encodedString = data;
                    uxtxtOutput.Text = encodedString;
                }
            }
            catch (Exception)
            {
                uxtxtOutput.Text = @":-(";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);
            uxrdoDecode_CheckedChanged(sender, EventArgs.Empty);
        }

        private void uxtxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) 24 && e.KeyChar != (char) 19)
            {
                return;
            }

            switch (e.KeyChar)
            {
                // clear
                case (char)24:
                    uxtxtInput.Text = string.Empty;
                    uxtxtInput.Focus();
                    e.Handled = true;
                    break;

                // switch mode
                case (char)19:
                {
                    if (uxrdoEncode.Checked)
                    {
                        uxrdoDecode.Checked = true;
                    }
                    else
                    {
                        uxrdoEncode.Checked = true;
                    }

                    e.Handled = true;
                    break;
                }
            }
        }

        private void uxtxtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            uxtxtInput_KeyPress(sender, e);
        }

        private void uxrdoDecode_CheckedChanged(object sender, EventArgs e)
        {
            var appVersion = AppUtils.GetAppVersion();
            
            var startup = $"Base64 De/Encoder, Version: {appVersion}" +
                              Environment.NewLine +
                              Environment.NewLine +
                              "Ctrl+X = Clear" +
                              Environment.NewLine +
                              "Ctrl+S = Switch Mode";

            if (uxrdoDecode.Checked)
            {
                // encode the startup string and paste it to input for automatic decoding
                uxtxtInput.Text = Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(startup));
            }
            else
            {
                // use the startup string (decoded) and paste it to input for automatic encoding
                uxtxtInput.Text = startup;
            }

            uxtxtInput.SelectionStart = uxtxtInput.Text.Length;
            uxtxtInput.SelectionLength = 0;

            uxtxtOutput.SelectionStart = uxtxtOutput.Text.Length;
            uxtxtOutput.SelectionLength = 0;
        }
    }
}
