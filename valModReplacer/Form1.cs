using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace valModReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string root = @".\BepInEx";
            if (Directory.Exists(root))
            {
                installButton.Text = "Update";
            }
            else
            {
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
                installButton.Text = "can't";
                toolStripStatusLabel2.Text = "wrong folder, wont run, put this into your game folder";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.ForeColor = Color.Black;

            WebClient client = new WebClient();
            string fileName = "mods.zip";
            string zipFilePath = @".\mods.zip";
            string finalPath = @".\BepInEx";
            string tempPath = @".\up_temp";

            //string curFile = @".\valModReplacer.exe";
            if (Directory.Exists(finalPath))
            {
                Directory.Delete(@".\BepInEx.old", true);
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
                toolStripStatusLabel2.Text = "error.. restart and retry";
                toolStripStatusLabel2.ForeColor = Color.Red;
                Thread.Sleep(2000);
                System.Windows.Forms.Application.Exit();
                return;
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
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

    }
}