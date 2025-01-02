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
            richTextBoxAppInfo.Margin = new Padding(3, 2, 3, 2);
            richTextBoxAppInfo.MaximumSize = new Size(701, 168);
            richTextBoxAppInfo.MinimumSize = new Size(701, 168);
            richTextBoxAppInfo.Name = "richTextBoxAppInfo";
            richTextBoxAppInfo.ReadOnly = true;
            richTextBoxAppInfo.Size = new Size(701, 168);
            richTextBoxAppInfo.TabIndex = 0;
            richTextBoxAppInfo.Text = "";
            // 
            // AppInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 167);
            Controls.Add(richTextBoxAppInfo);
            Margin = new Padding(3, 2, 3, 2);
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