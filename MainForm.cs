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
                var data = Convert.FromBase64String(uxtxtInput.Text);
                var decodedString = Encoding.UTF8.GetString(data);
                uxtxtOutput.Text = decodedString;
            }
            catch (Exception)
            {
                uxtxtOutput.Text = @":-(";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);

            var startup = @"Base64 Decoder, Version: {0} by 5research.xyz" +
                          Environment.NewLine +
                          Environment.NewLine +
                          "Ctrl+X = Clear";

            uxtxtInput.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(startup));

            uxtxtInput.SelectionStart = uxtxtInput.Text.Length;
            uxtxtInput.SelectionLength = 0;

            uxtxtOutput.SelectionStart = uxtxtOutput.Text.Length;
            uxtxtOutput.SelectionLength = 0;
        }

        private void uxtxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)24)
            {
                uxtxtInput.Text = string.Empty;
                uxtxtInput.Focus();
                e.Handled = true;
            }
        }

        private void uxtxtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)24)
            {
                uxtxtInput.Text = string.Empty;
                uxtxtInput.Focus();
                e.Handled = true;
            }
        }
    }
}
