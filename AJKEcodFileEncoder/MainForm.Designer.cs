namespace AJKEcodFileEncoder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartStop = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            btnRegister = new Button();
            tableLayoutMain = new TableLayoutPanel();
            btnUnregister = new Button();
            labelSource = new Label();
            labelDestination = new Label();
            textBoxSource = new TextBox();
            textBoxDestination = new TextBox();
            buttonSaveConfig = new Button();
            buttonSourceFolder = new Button();
            buttonDestinationFolder = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartStop
            // 
            btnStartStop.Dock = DockStyle.Fill;
            btnStartStop.Location = new Point(343, 99);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(164, 29);
            btnStartStop.TabIndex = 0;
            btnStartStop.Text = "Start / Stop";
            btnStartStop.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(513, 99);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(164, 29);
            progressBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(686, 102);
            lblStatus.Margin = new Padding(6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(162, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.Location = new Point(3, 99);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(164, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register service";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 5;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutMain.Controls.Add(btnRegister, 0, 3);
            tableLayoutMain.Controls.Add(btnStartStop, 2, 3);
            tableLayoutMain.Controls.Add(progressBar, 3, 3);
            tableLayoutMain.Controls.Add(lblStatus, 4, 3);
            tableLayoutMain.Controls.Add(btnUnregister, 1, 3);
            tableLayoutMain.Controls.Add(labelSource, 0, 0);
            tableLayoutMain.Controls.Add(labelDestination, 0, 1);
            tableLayoutMain.Controls.Add(textBoxSource, 1, 0);
            tableLayoutMain.Controls.Add(textBoxDestination, 1, 1);
            tableLayoutMain.Controls.Add(buttonSaveConfig, 4, 0);
            tableLayoutMain.Controls.Add(buttonSourceFolder, 3, 0);
            tableLayoutMain.Controls.Add(buttonDestinationFolder, 3, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutMain.Size = new Size(854, 131);
            tableLayoutMain.TabIndex = 4;
            // 
            // btnUnregister
            // 
            btnUnregister.Dock = DockStyle.Fill;
            btnUnregister.Location = new Point(173, 99);
            btnUnregister.Name = "btnUnregister";
            btnUnregister.Size = new Size(164, 29);
            btnUnregister.TabIndex = 4;
            btnUnregister.Text = "Unregister service";
            btnUnregister.UseVisualStyleBackColor = true;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Dock = DockStyle.Fill;
            labelSource.Location = new Point(8, 8);
            labelSource.Margin = new Padding(8);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(154, 16);
            labelSource.TabIndex = 5;
            labelSource.Text = "Source directory";
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Dock = DockStyle.Fill;
            labelDestination.Location = new Point(8, 40);
            labelDestination.Margin = new Padding(8);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(154, 16);
            labelDestination.TabIndex = 6;
            labelDestination.Text = "Destination directory";
            // 
            // textBoxSource
            // 
            tableLayoutMain.SetColumnSpan(textBoxSource, 2);
            textBoxSource.Dock = DockStyle.Fill;
            textBoxSource.Location = new Point(173, 3);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(334, 23);
            textBoxSource.TabIndex = 7;
            // 
            // textBoxDestination
            // 
            tableLayoutMain.SetColumnSpan(textBoxDestination, 2);
            textBoxDestination.Dock = DockStyle.Fill;
            textBoxDestination.Location = new Point(173, 35);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(334, 23);
            textBoxDestination.TabIndex = 8;
            // 
            // buttonSaveConfig
            // 
            buttonSaveConfig.Dock = DockStyle.Fill;
            buttonSaveConfig.Location = new Point(683, 3);
            buttonSaveConfig.Name = "buttonSaveConfig";
            buttonSaveConfig.Size = new Size(168, 26);
            buttonSaveConfig.TabIndex = 9;
            buttonSaveConfig.Text = "Save config";
            buttonSaveConfig.UseVisualStyleBackColor = true;
            buttonSaveConfig.Click += buttonSaveConfig_Click;
            // 
            // buttonSourceFolder
            // 
            buttonSourceFolder.Dock = DockStyle.Fill;
            buttonSourceFolder.Location = new Point(513, 3);
            buttonSourceFolder.Name = "buttonSourceFolder";
            buttonSourceFolder.Size = new Size(164, 26);
            buttonSourceFolder.TabIndex = 10;
            buttonSourceFolder.Text = "Select source";
            buttonSourceFolder.UseVisualStyleBackColor = true;
            buttonSourceFolder.Click += buttonSourceFolder_Click;
            // 
            // buttonDestinationFolder
            // 
            buttonDestinationFolder.Dock = DockStyle.Fill;
            buttonDestinationFolder.Location = new Point(513, 35);
            buttonDestinationFolder.Name = "buttonDestinationFolder";
            buttonDestinationFolder.Size = new Size(164, 26);
            buttonDestinationFolder.TabIndex = 11;
            buttonDestinationFolder.Text = "Select destination";
            buttonDestinationFolder.UseVisualStyleBackColor = true;
            buttonDestinationFolder.Click += buttonDestinationFolder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 131);
            Controls.Add(tableLayoutMain);
            MaximumSize = new Size(870, 170);
            MinimumSize = new Size(870, 170);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AJK Ecod - file transfer";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartStop;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Button btnRegister;
        private TableLayoutPanel tableLayoutMain;
        private Button btnUnregister;
        private Label labelSource;
        private Label labelDestination;
        private TextBox textBoxSource;
        private TextBox textBoxDestination;
        private Button buttonSaveConfig;
        private FolderBrowserDialog folderBrowserDialog;
        private Button buttonSourceFolder;
        private Button buttonDestinationFolder;
    }
}
