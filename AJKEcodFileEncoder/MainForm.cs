using System.Diagnostics;
using System.ServiceProcess;
using Timer = System.Windows.Forms.Timer;

namespace AJKEcodFileEncoder
{
    public partial class MainForm : Form
    {
        private const string ServiceName = "AJKFileTransferService";
        private string ServicePath = Path.Combine(Directory.GetCurrentDirectory(), "FileTransferService.exe");
        //private string ServicePath = "FileTransferService.exe";
        private readonly Timer _statusCheckTimer;

        public MainForm()
        {
            InitializeComponent();

            btnStartStop.Click += BtnStartStop_Click!;
            btnRegister.Click += BtnRegister_Click!;

            _statusCheckTimer = new Timer { Interval = 5000 }; // 5 seconds interval
            _statusCheckTimer.Tick += StatusCheckTimer_Tick!;
            _statusCheckTimer.Start();

            UpdateServiceStatus();
        }

        private void BtnStartStop_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var serviceController = new ServiceController(ServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running)
                    {
                        serviceController.Stop();
                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                        MessageBox.Show("Service stopped successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serviceController.Start();
                        serviceController.WaitForStatus(ServiceControllerStatus.Running);
                        MessageBox.Show("Service started successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateServiceStatus();
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            try
            {
                var createProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "sc.exe",
                        Arguments = $"create {ServiceName} binPath= \"{ServicePath}\" start= auto obj= LocalSystem DisplayName= \"AJK File Transfer Service\"",
                        Verb = "runas",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                string createCommand = $"{createProcess.StartInfo.FileName} {createProcess.StartInfo.Arguments}";
                createProcess.Start();
                string createOutput = createProcess.StandardOutput.ReadToEnd();
                string createError = createProcess.StandardError.ReadToEnd();
                createProcess.WaitForExit();

                if (createProcess.ExitCode != 0)
                {
                    MessageBox.Show($"Failed to create the service. Please check the service path and try again.\n{createCommand}\n{createError}\n{createOutput}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var descriptionProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "sc.exe",
                        Arguments = $"description {ServiceName} \"File transfer service by AJK Software\"",
                        Verb = "runas",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                string descriptionCommand = $"{descriptionProcess.StartInfo.FileName} {descriptionProcess.StartInfo.Arguments}";
                descriptionProcess.Start();
                string descriptionOutput = descriptionProcess.StandardOutput.ReadToEnd();
                string descriptionError = descriptionProcess.StandardError.ReadToEnd();
                descriptionProcess.WaitForExit();

                if (descriptionProcess.ExitCode == 0)
                {
                    MessageBox.Show("Service registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to set the service description. Please check the service path and try again.\n{descriptionCommand}\n{descriptionError}\n{descriptionOutput}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateServiceStatus();
        }

        private void StatusCheckTimer_Tick(object? sender, EventArgs e)
        {
            UpdateServiceStatus();
        }

        private void UpdateServiceStatus()
        {
            try
            {
                using (var serviceController = new ServiceController(ServiceName))
                {
                    bool serviceExists = ServiceExists();
                    btnStartStop.Enabled = serviceExists;

                    progressBar.Style = serviceExists && serviceController.Status == ServiceControllerStatus.Running
                        ? ProgressBarStyle.Marquee
                        : ProgressBarStyle.Blocks;

                    lblStatus.Text = serviceExists
                        ? $"Service is {serviceController.Status}"
                        : "Service is not registered.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                progressBar.Style = ProgressBarStyle.Blocks;
                btnStartStop.Enabled = false;
            }
        }

        private bool ServiceExists()
        {
            try
            {
                using (var serviceController = new ServiceController(ServiceName))
                {
                    ServiceControllerStatus status = serviceController.Status;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
