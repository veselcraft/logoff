using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace LogOutClassicWindow
{
    public partial class LogoffForm : Form
    {

        public LogoffForm()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Andruschencia No Cocksex prosím...\nMade by Veselcraft specially for winclassic.boards.net\nCurrent language is: {Thread.CurrentThread.CurrentCulture}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            NativeMethods.ExitWindowsEx(NativeMethods.ExitWindows.LogOff, NativeMethods.ShutdownReason.MinorOther);
            Close();
        }
    }
}
