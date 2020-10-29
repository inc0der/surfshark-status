using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfSharkStatus
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            onlyDisplayOption.Checked = settings.displayOnDisconnect;
            var newOpacityValue = Convert.ToInt32(settings.transparency) * 255;
            opacityBar.Value = Convert.ToInt32(settings.transparency) * 255 > 0 ? newOpacityValue : 1;
            disconnectNotifyOption.Checked = settings.notifyOnDisconnect;
            connectNotifyOption.Checked = settings.notifyOnConnect;
        }

        private void OnlyDisplayOnDisconnectOption_CheckedChanged(object sender, EventArgs e)
        {
            SurfSharkStatus.Properties.Settings.Default.displayOnDisconnect = onlyDisplayOption.Checked;
        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            var settings = SurfSharkStatus.Properties.Settings.Default;
            double value = opacityBar.Value / (double) 255;
            settings.transparency = Convert.ToDouble(value);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SurfSharkStatus.Properties.Settings.Default.Save();
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DisconnectNotifyOption_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SurfSharkStatus.Properties.Settings.Default;
            settings.notifyOnDisconnect = disconnectNotifyOption.Checked;
        }

        private void ConnectNotifyOption_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SurfSharkStatus.Properties.Settings.Default;
            settings.notifyOnConnect = connectNotifyOption.Checked;
        }
    }
}
