using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace LogOutClassicWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /* Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                Form desktop = new Form();
                desktop.ShowInTaskbar = false;
                desktop.FormBorderStyle = FormBorderStyle.None;
                desktop.WindowState = FormWindowState.Maximized;
                PictureBox desktopPic = new PictureBox();
                desktopPic.Width = Screen.PrimaryScreen.Bounds.Size.Width;
                desktopPic.Height = Screen.PrimaryScreen.Bounds.Size.Height;
                // desktopPic.Image = g;
                desktop.Controls.Add(desktopPic);
                // desktop.Show();
            } */

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
            
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = this.CreateGraphics();
            g.FillRectangle(aBrush, 1, 1, 5, 5);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "logoff";
            process.StartInfo.RedirectStandardError = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            Application.Exit();
        }
    }
}
