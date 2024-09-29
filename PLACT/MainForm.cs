using Microsoft.Win32;
using System.Diagnostics;
using System.Management;

namespace PLACT
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// These variables are used to store the Windows version, edition and activation status
        /// </summary>
        private readonly string version = GetWindowsVersion();
        private readonly string edition = GetWindowsEdition();
        private readonly string activationStatus = IsWindowsActivated();
        private readonly string OEMKey = GetOEMKey();
        private readonly string UserKey = GetUserKey();

        /// <summary>
        /// These lists are used to store the Windows edition and the corresponding key
        /// </summary>
        private readonly List<string> windowsVersionList = ["Home", "Home N", "Professional", "Professional N", "Education", "Education N", "Enterprise", "Enterprise N"];
        private readonly List<string> windows10KeyList = ["TX9XD-98N7V-6WMQ6-BX7FG-H8Q99", "3KHY7-WNT83-DGQKR-F7HPR-844BM", "W269N-WFGWX-YVC9B-4J6C9-T83GX", "MH37W-N47XK-V7XM9-C7227-GCQG9", "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2", "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ", "NPPR9-FWDCX-D2C8J-H872K-2YT43", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"];

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            if (version != "10" && version != "11")
            {
                MessageBox.Show("This program only works on Windows 10 and Windows 11", "Incompatibility", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                if (activationStatus == "Licensed")
                {
                    if (MessageBox.Show("Windows is already Licensed.\n\nWould you like to continue?", "Activation Status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

            labelWindowsVersion.Text = "Windows " + version;
            labelEdition.Text = edition;
            labelActivationStatus.Text = activationStatus;
            labelOEMLicence.Text = OEMKey;
            labelUserLicence.Text = UserKey;

            LoadComboBoxItems();
        }

        /// <summary>
        /// Get the Windows version
        /// </summary>
        /// <returns></returns>
        static string GetWindowsVersion()
        {
            Version version = Environment.OSVersion.Version;

            if (version.Major == 10 && version.Build >= 22000)
                return "11";
            else if (version.Major == 10)
                return "10";
            else
                return $"Unknown: {version}";
        }

        /// <summary>
        /// This method is used to get the Windows edition
        /// </summary>
        /// <returns></returns>
        static string GetWindowsEdition()
        {
            string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string keyName = "EditionID";

            using (RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(keyPath, false))
            {
                if (registryKey != null)
                {
                    string EditionID = (string)registryKey.GetValue(keyName);
                    if (EditionID != null)
                    {
                        return EditionID;
                    }
                }
            }

            return "Edition ID not found!";
        }

        /// <summary>
        /// Check if Windows is activated
        /// </summary>
        /// <returns></returns>
        static string IsWindowsActivated()
        {
            var searcher = new ManagementObjectSearcher("SELECT LicenseStatus FROM SoftwareLicensingProduct WHERE PartialProductKey IS NOT NULL");
            foreach (ManagementObject obj in searcher.Get())
            {
                uint licenseStatus = (uint)obj["LicenseStatus"];
                switch (licenseStatus)
                {
                    case 0:
                        return "Not licensed";
                    case 1:
                        return "Licensed";
                    default:
                        return "Unknown status";
                }
            }

            return "Status not found";
        }

        /// <summary>
        /// Get the OEM key
        /// </summary>
        /// <returns></returns>
        static string GetOEMKey()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT OA3xOriginalProductKey FROM SoftwareLicensingService");
                foreach (ManagementObject obj in searcher.Get())
                {
                    string? oemKey = obj["OA3xOriginalProductKey"]?.ToString();
                    if (!string.IsNullOrEmpty(oemKey))
                    {
                        return oemKey;
                    }
                }
            }
            catch (ManagementException ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
            }

            return "-";
        }

        /// <summary>
        /// Get the user key
        /// </summary>
        /// <returns></returns>
        static string GetUserKey()
        {
            string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform";
            string keyName = "BackupProductKeyDefault";

            using (RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(keyPath, false))
            {
                if (registryKey != null)
                {
                    string UserKey = (string)registryKey.GetValue(keyName);
                    if (UserKey != null)
                    {
                        return UserKey;
                    }
                }
            }

            return "-";
        }

        /// <summary>
        /// Load the items in the ComboBox
        /// </summary>
        private void LoadComboBoxItems()
        {
            if (version == "10" || version == "11")
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
            if (version == "10" || version == "11")
            {
                RunCommand("slmgr /ipk " + windows10KeyList[comboBoxLicence.SelectedIndex]);
                RunCommand("slmgr /skms kms8.msguides.com");
                RunCommand("slmgr /ato");
            }
            else
            {
                MessageBox.Show("Unsupported Windows version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method is used to run a command in the command prompt
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
                return "Error: Process could not be started";

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Error: {error}", "Command Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return $"Error: {error}";
            }

            return output;
        }
    }
}
