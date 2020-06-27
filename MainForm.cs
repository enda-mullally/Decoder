using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Decoder
{
    public partial class MainForm : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection _pfc;
        
        public MainForm()
        {
            InitializeComponent();

            InitCustomFont();

            AssignCustomFont();

            this.Text = string.Format(this.Text, AppUtils.GetAppVersion());
        }

        private void InitCustomFont()
        {
            _pfc = new PrivateFontCollection();
            var fontLength = Properties.Resources.SpaceMono_Regular.Length;
            var fontData = Properties.Resources.SpaceMono_Regular;
            var data = IntPtr.Zero;
            try
            {
                data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, data, fontLength);
                uint cFonts = 0;
                AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);
                _pfc.AddMemoryFont(data, fontLength);
            }
            finally
            {
                if (data != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(data);
                }
            }
        }

        private void AssignCustomFont()
        {
            uxtxtInput.Font = new Font(_pfc.Families[0], uxtxtInput.Font.Size);
            uxtxtOutput.Font = new Font(_pfc.Families[0], uxtxtOutput.Font.Size);
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
                    var data = Convert.ToBase64String(Encoding.UTF8.GetBytes(uxtxtInput.Text));
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

            if (e.KeyChar == (char)24) // clear
            {
                uxtxtInput.Text = string.Empty;
                uxtxtInput.Focus();
                e.Handled = true;
            }
            if (e.KeyChar == (char)19) // switch
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
                // use thr startup string (decoded) and paste it to input for automatic encoding
                uxtxtInput.Text = startup;
            }

            uxtxtInput.SelectionStart = uxtxtInput.Text.Length;
            uxtxtInput.SelectionLength = 0;

            uxtxtOutput.SelectionStart = uxtxtOutput.Text.Length;
            uxtxtOutput.SelectionLength = 0;
        }
    }
}
