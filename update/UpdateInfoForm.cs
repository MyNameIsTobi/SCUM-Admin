using System;
using System.Windows.Forms;

namespace update
{
    public partial class UpdateInfoForm : Form
    {
        public UpdateInfoForm(Updateable applicationInfo, UpdateXML updateInfo)
        {
            InitializeComponent();

            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;

            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersionOld.Text = "Current Version: " + applicationInfo.ApplicationAssembly.GetName().Version.ToString();
            this.lblVersionNew.Text = "Current Version: " + updateInfo.Version.ToString();
            this.textDescription.Text = updateInfo.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
