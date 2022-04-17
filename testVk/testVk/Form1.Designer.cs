
namespace testVk
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInfoButton = new System.Windows.Forms.Button();
            this.StartWebBrowser = new System.Windows.Forms.WebBrowser();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.textButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.Location = new System.Drawing.Point(25, 31);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(75, 23);
            this.UserInfoButton.TabIndex = 0;
            this.UserInfoButton.Text = "button1";
            this.UserInfoButton.UseVisualStyleBackColor = true;
            this.UserInfoButton.Click += new System.EventHandler(this.button1_Click);
            this.UserInfoButton.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // StartWebBrowser
            // 
            this.StartWebBrowser.Location = new System.Drawing.Point(468, 31);
            this.StartWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.StartWebBrowser.Name = "StartWebBrowser";
            this.StartWebBrowser.Size = new System.Drawing.Size(345, 294);
            this.StartWebBrowser.TabIndex = 2;
            this.StartWebBrowser.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=8104769&display=page&redirect_uri=https:" +
        "//oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.131&state=123456" +
        "", System.UriKind.Absolute);
            this.StartWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(12, 357);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(788, 20);
            this.AccessTokenTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(22, 70);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "label1";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(247, 12);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(137, 140);
            this.AvatarPictureBox.TabIndex = 5;
            this.AvatarPictureBox.TabStop = false;
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(106, 31);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(117, 23);
            this.textButton.TabIndex = 6;
            this.textButton.Text = "button1";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 392);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.StartWebBrowser);
            this.Controls.Add(this.UserInfoButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserInfoButton;
        private System.Windows.Forms.WebBrowser StartWebBrowser;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Button textButton;
    }
}

