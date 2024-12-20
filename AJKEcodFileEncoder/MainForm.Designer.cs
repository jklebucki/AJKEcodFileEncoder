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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 131);
            Controls.Add(tableLayoutMain);
            Name = "MainForm";
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
    }
}
