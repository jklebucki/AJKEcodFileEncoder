using AJKEcodFileEncoder.Models;
using AJKEcodFileEncoder.Services;
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
        private readonly ConfigService _configService = new ConfigService();
        private readonly Config _config;

        public MainForm()
        {
            InitializeComponent();
            _config = _configService.LoadConfig();
            SetFolders();
            btnStartStop.Click += BtnStartStop_Click!;
            btnRegister.Click += BtnRegister_Click!;
            btnUnregister.Click += BtnUnregister_Click!;

            _statusCheckTimer = new Timer { Interval = 5000 }; // 5 seconds interval
            _statusCheckTimer.Tick += StatusCheckTimer_Tick!;
            _statusCheckTimer.Start();

            UpdateServiceStatus();
        }

        private void SetFolders()
        {
            textBoxSource.Text = _config.Source;
            textBoxDestination.Text = _config.Destination;
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

        private void BtnUnregister_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var serviceController = new ServiceController(ServiceName))
                {
                    if (ServiceExists() && serviceController.Status == ServiceControllerStatus.Stopped)
                    {
                        var process = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "sc.exe",
                                Arguments = $"delete {ServiceName}",
                                Verb = "runas",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                RedirectStandardError = true
                            }
                        };

                        string fullCommand = $"{process.StartInfo.FileName} {process.StartInfo.Arguments}";
                        process.Start();
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            MessageBox.Show("Service unregistered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to unregister the service. Please try again.\n{fullCommand}\n{error}\n{output}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Service is either not registered or not stopped.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    btnRegister.Enabled = !serviceExists;
                    btnUnregister.Enabled = serviceExists && serviceController.Status == ServiceControllerStatus.Stopped;

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
                btnUnregister.Enabled = false;
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

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            _configService.SaveConfig(new Config
            {
                Source = textBoxSource.Text,
                Destination = textBoxDestination.Text
            });
        }

        private void buttonSourceFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxSource.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDestinationFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxDestination.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
