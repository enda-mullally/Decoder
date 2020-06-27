using System;
using System.Windows.Forms;
using Decoder.External;
using Decoder.Utils;

namespace Decoder
{
    partial class MainForm
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;

        private int SYSMENU_ABOUT_ID = 0x1;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            var hSysMenu = Win32.GetSystemMenu(this.Handle, false);
            Win32.AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);
            Win32.AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About…");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                var appVersion = AppUtils.GetAppVersion();

                var aboutText = $"Base64 De/Encoder" + 
                                Environment.NewLine +
                                Environment.NewLine +
                                $"Version: {appVersion}" +
                                Environment.NewLine +
                                Environment.NewLine +
                                "Copyright © 2020 Enda Mullally";

                MessageBox.Show(aboutText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
