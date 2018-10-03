using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace update
{
    internal partial class UpdateAcceptForm : Form
    {
        private Updateable applicationInfo;
        private UpdateXML updateInfo;
        private UpdateInfoForm updateInfoForm;

        internal UpdateAcceptForm(Updateable applicationInfo, UpdateXML updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName + " - Update available";

            if (this.applicationInfo.ApplicationIcon != null)
            {
                this.Icon = this.applicationInfo.ApplicationIcon;
            }

            this.lblNewVersion.Text = string.Format("New Version: {0}", this.updateInfo.Version.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null)
            {
                this.updateInfoForm = new UpdateInfoForm(this.applicationInfo, this.updateInfo);
            }

            this.updateInfoForm.Show(this);
        }
    }
}
