
using System;
using System.Configuration;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SurfSharkStatus
{
    public partial class StatusOverlay : Form
    {
        private OptionsForm options;
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeChangeColorDelegate(Color color);
        private delegate void SafeChangeVisibility(Boolean visibility);
        private static Array networks;
        public StatusOverlay()
        {
            SetTransparency();
            InitializeComponent();
            options = new OptionsForm();
            options.VisibleChanged += new EventHandler(OptionsForm_VisibleChanged);
        }

        protected void SetTransparency()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
            var settings = SurfSharkStatus.Properties.Settings.Default;
            var opacity = settings.transparency;
            this.Opacity = opacity;
        }
        protected override void OnLoad(EventArgs e)
        {
            this.Top = 10;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
            base.OnLoad(e);
        }

        private void StatusOverlay_Load(object sender, EventArgs e)
        {
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(UpdateStatus);
            if (CheckSurfsharkStatus() == true)
            {
                if (Properties.Settings.Default.displayOnDisconnect)
                {
                    Hide();
                }
                WriteStatus("Connected");
                ChangeLabelColor(Color.Green);
                return;
            }
            WriteStatus("Disconnected");
            ChangeLabelColor(Color.Red);
        }

        private bool CheckSurfsharkStatus()
        {
            bool result = false;
            networks = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in networks)
            {
                if ((adapter.Name.Contains("Surfshark") || adapter.Description.Contains("Surfshark")) || adapter.Name.Contains("wintunshark"))
                {
                    if (adapter.OperationalStatus.ToString() == "Up")
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;
                        continue;
                    }
                }
            }
            return result;
        }

        private void WriteStatus(string text)
        {
            if (statusLabel.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteStatus);
                statusLabel.Invoke(d, new object[] { text });
            }
            else
            {
                statusLabel.Text = text;
            }
        }

        private void ChangeLabelColor(Color color)
        {
            if (statusLabel.InvokeRequired)
            {
                var d = new SafeChangeColorDelegate(ChangeLabelColor);
                statusLabel.Invoke(d, new object[] { color });
            }
            else
            {
                statusLabel.ForeColor = color;
            }
        }

        private void ChangeVisibility(Boolean visible)
        {
            if (InvokeRequired)
            {
                var d = new SafeChangeVisibility(ChangeVisibility);
                Invoke(d, new object[] { visible });
            }
            else
            {
                if (visible)
                {
                    Show();
                }
                else
                {
                    Hide();
                }
            }
        }
        private void UpdateStatus(object sender, EventArgs e)
        {
            if (CheckSurfsharkStatus() == true)
            {
                if (Properties.Settings.Default.displayOnDisconnect)
                {
                    ChangeVisibility(false);
                }
                if (Properties.Settings.Default.notifyOnConnect)
                {
                    notifyIcon1.ShowBalloonTip(5, "Surfshark Status", "You're connected to your VPN", ToolTipIcon.Info);
                }
                WriteStatus("Connected");
                ChangeLabelColor(Color.Green);
                return;
            }
            if (!Visible && Properties.Settings.Default.displayOnDisconnect == true)
            {
                ChangeVisibility(true);
            }
            if (Properties.Settings.Default.notifyOnDisconnect)
            {
                notifyIcon1.ShowBalloonTip(5, "Surfshark Status", "You've been diconnected from your VPN connection", ToolTipIcon.Warning);
            }
            WriteStatus("Disconnected");
            ChangeLabelColor(Color.Red);
        }

        private void OpenSurfsharkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Surfshark\\surfshark.exe");
        }

        private void OpenExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logo_OnMouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        rightContextMenu.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            options.Show();
        }

        private void OptionsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.options.Visible == false)
            {
                var settings = SurfSharkStatus.Properties.Settings.Default;
                this.Opacity = settings.transparency;
                if (settings.displayOnDisconnect && CheckSurfsharkStatus())
                {
                    Hide();
                }
                else if (!settings.displayOnDisconnect && CheckSurfsharkStatus())
                {
                    Show();
                }
            }
        }
    }
}
