using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace update
{
    public class Updater
    {
        private Updateable applicationInfo;
        private BackgroundWorker bgWorger;

        public Updater(Updateable applicationInfo)
        {
            this.applicationInfo = applicationInfo;
            this.bgWorger = new BackgroundWorker();
            this.bgWorger.DoWork += new DoWorkEventHandler(BgWorger_DoWork);
            this.bgWorger.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgWorger_RunWorkerCompleted);
        }

        public void DoUpdate()
        {
            if (!this.bgWorger.IsBusy)
                this.bgWorger.RunWorkerAsync(this.applicationInfo);
        }

        private void BgWorger_DoWork(object sender, DoWorkEventArgs e)
        {
            Updateable application = (Updateable)e.Argument;

            if (!UpdateXML.ExsistsOnServer(application.UpdateXmlLocation))
                e.Cancel = true;
            else
                e.Result = UpdateXML.Parse(application.UpdateXmlLocation, application.ApplicationID);
        }

        private void BgWorger_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                UpdateXML update = (UpdateXML)e.Result;

                if (update != null && update.IsNewerThan(this.applicationInfo.ApplicationAssembly.GetName().Version))
                {
                    if (new UpdateAcceptForm(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes)
                        this.DownloadUpdate(update);
                }
            }
        }

        private void DownloadUpdate(UpdateXML update)
        {
            UpdateDownloadForm form = new UpdateDownloadForm(update.Uri, update.Md5, this.applicationInfo.ApplicationIcon);
            DialogResult result = form.ShowDialog(this.applicationInfo.Context);

            if (result == DialogResult.OK)
            {
                string currentPath = this.applicationInfo.ApplicationAssembly.Location;
                string newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

                UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

                Application.Exit();
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("The update download was cancelled.\nThis Programm has not been modified.", "Update Download Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was a problem downloading the update.\nPlease try again later.", "Update Download Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateApplication(string tempFilePath, string currentPath, string newPath, string launchArgs)
        {
            string argument = "/C Choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & Choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(argument, currentPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
        }
    }
}

