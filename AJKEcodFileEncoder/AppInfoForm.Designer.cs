namespace AJKEcodFileEncoder
{
    partial class AppInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxAppInfo = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxAppInfo
            // 
            richTextBoxAppInfo.Dock = DockStyle.Fill;
            richTextBoxAppInfo.Location = new Point(0, 0);
            richTextBoxAppInfo.MaximumSize = new Size(801, 223);
            richTextBoxAppInfo.MinimumSize = new Size(801, 223);
            richTextBoxAppInfo.Name = "richTextBoxAppInfo";
            richTextBoxAppInfo.ReadOnly = true;
            richTextBoxAppInfo.Size = new Size(801, 223);
            richTextBoxAppInfo.TabIndex = 0;
            richTextBoxAppInfo.Text = "";
            // 
            // AppInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 223);
            Controls.Add(richTextBoxAppInfo);
            Name = "AppInfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Application informations";
            Load += AppInfoForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxAppInfo;
    }
}