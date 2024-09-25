using System.Diagnostics;
using System.Management;

namespace PLACT
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// These lists are used to store the Windows version and the corresponding key
        /// </summary>
        private readonly List<string> windowsVersionList = [ "Home", "Home N", "Professional", "Professionnal N", "Education", "Education N", "Enterprise", "Enterprise N" ];
        private readonly List<string> windows10KeyList = [ "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99", "3KHY7-WNT83-DGQKR-F7HPR-844BM", "W269N-WFGWX-YVC9B-4J6C9-T83GX", "MH37W-N47XK-V7XM9-C7227-GCQG9", "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2", "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ", "NPPR9-FWDCX-D2C8J-H872K-2YT43", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4" ];

        public MainForm()
        {
            InitializeComponent();
            string version = GetWindowsVersion();

            if (version is not "Windows 11" or "Windows 10")
            {
                MessageBox.Show("This program only works on Windows 10 and Windows 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (IsWindowsActivated())
            {
                MessageBox.Show("Windows is already activated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            groupBoxWinVersion.Text = "OS Detected : " + version;
            LoadComboBoxItems(version);
        }

        /// <summary>
        /// Get the Windows version
        /// </summary>
        /// <returns></returns>
        private static string GetWindowsVersion()
        {
            Version version = Environment.OSVersion.Version;

            if (version.Major == 10 && version.Build >= 22000)
                return "Windows 11";
            else if (version.Major == 10)
                return "Windows 10";
            else
                return $"Unknown version: {version}";
        }

        /// <summary>
        /// Check if Windows is activated
        /// </summary>
        /// <returns></returns>
        static bool IsWindowsActivated()
        {
            var searcher = new ManagementObjectSearcher("SELECT LicenseStatus FROM SoftwareLicensingProduct WHERE PartialProductKey IS NOT NULL AND LicenseStatus = 1");

            return searcher.Get().Count > 0;
        }

        /// <summary>
        /// Load the items in the ComboBox
        /// </summary>
        /// <param name="version"></param>
        private void LoadComboBoxItems(string version)
        {
            if (version == "Windows 10")
            {
                comboBoxLicence.DataSource = windowsVersionList;
            }
            else if (version == "Windows 11")
            {
                comboBoxLicence.DataSource = windowsVersionList;
            }
            else
            {
                comboBoxLicence.DataSource = null;
                buttonActivate.Enabled = false;
            }
        }

        /// <summary>
        /// Activate the licence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonActivate_Click(object sender, EventArgs e)
        {
            if (comboBoxLicence.SelectedItem == null)
            {
                MessageBox.Show("Please select a licence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (groupBoxWinVersion.Text == "OS Detected : Windows 10")
            {
                RunCommand("slmgr /ipk " + windows10KeyList[comboBoxLicence.SelectedIndex]);
            }
            else if (groupBoxWinVersion.Text == "OS Detected : Windows 11")
            {
                RunCommand("slmgr /ipk " + windows10KeyList[comboBoxLicence.SelectedIndex]);
            }
            RunCommand("slmgr /skms kms8.msguides.com");
            RunCommand("slmgr /ato");
        }

        /// <summary>
        /// Run a command in the command prompt
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        static string RunCommand(string command)
        {
            ProcessStartInfo processInfo = new()
            {
                FileName = "cmd.exe",
                Arguments = $"/c {command}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process? process = Process.Start(processInfo);
            if (process == null)
                return "Error: Process is null";
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
                return $"Error: {error}";

            return output;
        }
    }
}
