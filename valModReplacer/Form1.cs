using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace valModReplacer
{
    public partial class Form1 : Form
    {
        static class Iou
        {
            public static string type;
        }
        public Form1()
        {
            InitializeComponent();
            folderChecks();
            urlChecks();

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.ForeColor = Color.Black;

            WebClient client = new WebClient();
            string fileName = "mods.zip";
            string zipFilePath = @".\mods.zip";
            string finalPath = @".\BepInEx";
            string tempPath = @".\up_temp";
            string buPath = @".\BepInEx.old";

            //string curFile = @".\valModReplacer.exe";
            if (Directory.Exists(finalPath))
            {
                if (Directory.Exists(buPath))
                {
                    Directory.Delete(buPath, true);

                }
                toolStripStatusLabel2.Text = "Creating Backup of BepInEx";
                CopyDirectory(@".\BepInEx", @".\BepInEx.old", true);
                backupLabel.Visible = true;
            }
            toolStripStatusLabel2.Text = "Deleting old BepInEx folder";
            try
            {
                Directory.Delete(finalPath, true);

            }
            catch (Exception exc)
            {
                toolStripStatusLabel2.Text = exc.Message;
                Debug.WriteLine(exc.Message);
            }
            // Download file
            toolStripStatusLabel2.Text = "Downloading ...";
            Directory.CreateDirectory(tempPath);
         
            try
            {
                client.DownloadFile(new Uri(urlBox.Text), fileName);

            }
            catch (Exception exc)
            {
                // we dont retry if fail to download we just quit app, lol, if using simplewall this will happen
                toolStripStatusLabel2.Text = "error.. restart and retry, could not download";
                toolStripStatusLabel2.ForeColor = Color.Red;
                installButton.Enabled = false;
            }
            finally
            {
                toolStripStatusLabel2.Text = "Download Successful";

            }

            toolStripStatusLabel2.Text = "Extracting Zip";
            ZipFile.ExtractToDirectory(zipFilePath, tempPath);
            var directories = Directory.GetDirectories(tempPath);
            toolStripStatusLabel2.Text = "Moving extracted folder";
            Debug.WriteLine(directories[0] + @"\BepInEx");
            Directory.Move(directories[0] + @"\BepInEx", finalPath);

            toolStripStatusLabel2.Text = "Deleting temp zip";
            File.Delete(fileName);
            try
            {
                toolStripStatusLabel2.Text = "Deleting temp directory";
                Directory.Delete(tempPath, true);

            }
            catch (Exception exc)
            {
                toolStripStatusLabel2.Text = exc.Message;
                Console.WriteLine(exc.Message);
            }
            installButton.Enabled = false;
            toolStripStatusLabel2.Text = "Done, close me";

        }
        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(destinationDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        private void urlChecks()
        {
            var savedUrl = Properties.Settings.Default.Url;
            if (Uri.IsWellFormedUriString(Properties.Settings.Default.Url, UriKind.Absolute))
            {
                //good url
            }
            else
            {
                installButton.Enabled = false;
                installButton.Text = "URL invalid";
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = "URL invalid";

            }

            if (savedUrl != "")
            {
                urlBox.Text = Properties.Settings.Default.Url;
            }
        }
        private void folderChecks()
        {
            string root = @".\BepInEx";
            if (Directory.Exists(root))
            {
                Iou.type = "Update";
                installButton.Text = "Update";
            }
            else
            {
                Iou.type = "Install";
                installButton.Text = "Install";
            }


            string curFile = @".\valheim.exe";
            //string curFile = @".\valModReplacer.exe";
            if (File.Exists(curFile))
            {
                toolStripStatusLabel2.Text = "Ready";
                toolStripStatusLabel2.ForeColor = Color.Green;
            }
            else
            {
                installButton.Enabled = false;
                installButton.Text = "wrong folder";
                toolStripStatusLabel2.Text = "wrong folder, wont run, put this into your game folder";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }
        }
        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(urlBox.Text, UriKind.Absolute))
            {
                installButton.Enabled = true;
                toolStripStatusLabel2.ForeColor = Color.Green;
                toolStripStatusLabel2.Text = "URL valid";
                installButton.Text = Iou.type;

            }
            else
            {
                installButton.Enabled = false;
                installButton.Text = "URL invalid";
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = "URL invalid";


            }

            Properties.Settings.Default.Url = urlBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}