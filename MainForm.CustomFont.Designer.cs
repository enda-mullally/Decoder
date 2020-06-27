using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Decoder.External;

namespace Decoder
{
    partial class MainForm
    {
        private readonly PrivateFontCollection _pfc = new PrivateFontCollection();

        private void InitCustomFont()
        {
            var fontLength = Properties.Resources.SpaceMono_Regular.Length;
            var fontData = Properties.Resources.SpaceMono_Regular;
            var data = IntPtr.Zero;

            try
            {
                data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, data, fontLength);
                uint cFonts = 0;

                Win32.AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

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
    }
}
