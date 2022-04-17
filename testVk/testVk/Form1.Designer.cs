﻿
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
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.Location = new System.Drawing.Point(33, 38);
            this.UserInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(100, 28);
            this.UserInfoButton.TabIndex = 0;
            this.UserInfoButton.Text = "button1";
            this.UserInfoButton.UseVisualStyleBackColor = true;
            this.UserInfoButton.Click += new System.EventHandler(this.button1_Click);
            this.UserInfoButton.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // StartWebBrowser
            // 
            this.StartWebBrowser.Location = new System.Drawing.Point(624, 38);
            this.StartWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.StartWebBrowser.Name = "StartWebBrowser";
            this.StartWebBrowser.Size = new System.Drawing.Size(460, 362);
            this.StartWebBrowser.TabIndex = 2;
            this.StartWebBrowser.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=8104769&display=page&redirect_uri=https:" +
        "//oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.131&state=123456" +
        "", System.UriKind.Absolute);
            this.StartWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(16, 439);
            this.AccessTokenTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(1049, 22);
            this.AccessTokenTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(29, 86);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(46, 17);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "label1";
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(329, 15);
            this.AvatarPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(183, 172);
            this.AvatarPictureBox.TabIndex = 5;
            this.AvatarPictureBox.TabStop = false;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(380, 266);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "button1";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 482);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.StartWebBrowser);
            this.Controls.Add(this.UserInfoButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button testButton;
    }
}

