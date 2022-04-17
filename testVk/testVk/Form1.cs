using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace testVk
{
    public partial class MainForm : Form
    {
        string access_token;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string answer = Encoding.UTF8.GetString(client.DownloadData(
                "https://api.vk.com/method/account.getProfileInfo?"
                +access_token
                +"&v=5.131"
                ));

            getProfileInfo userInfo = 
                JsonConvert.DeserializeObject<getProfileInfo>(answer);

            
            answer = Encoding.UTF8.GetString(client.DownloadData(
               "https://api.vk.com/method/users.get?user_ids=" 
               +userInfo.response.id  
               +"&fields=photo_50&"
               +access_token
               +"&v=5.131"
               ));

            getAvatar avatar = JsonConvert.DeserializeObject<getAvatar>(answer);

            LastNameLabel.Text = userInfo.response.last_name;
            AvatarPictureBox.Load(avatar.response[0].photo_50);
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string str;
            str = StartWebBrowser.Url.ToString();
            if (str.Contains("access_token"))
            {
                //удаление всего после &
                int AmpersandPos = str.IndexOf("&");

                access_token = str.Remove(AmpersandPos);
                //удаление всего перед #
                int SharpPos = access_token.IndexOf("#");

                access_token = access_token.Remove(0, SharpPos + 1);

                AccessTokenTextBox.Text = access_token;
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = UserInfoButton.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -1);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            UserInfoButton.Region = new System.Drawing.Region(buttonPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textButton_Click(object sender, EventArgs e)
        {
            textButton.Text = "купите платную версию";
        }
    }
}
