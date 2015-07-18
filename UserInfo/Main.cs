using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserInfo
{
    public partial class Main : Form
    {
        private HttpClient _client;

        private HttpClientHandler _handler;

        private static string PROFILE_REQUEST_FORMAT = "https://www.habbo.com/api/public/users?name={0}";

        private PictureBox[] _badgeImgs;

        public Main()
        {
            InitializeComponent();
            _handler = new HttpClientHandler() { UseProxy = false };
            _client = new HttpClient(_handler, true);
            _badgeImgs = new PictureBox[]{
                BadgeOne,
                BadgeTwo,
                BadgeThree,
                BadgeFour,
                BadgeFive
            };
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string username = SearchTxt.Text;

            if(validate(username))
                GetUserInfo(SearchTxt.Text);
            else
                MessageBox.Show("Please check your input", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async Task<Image> getAvatarAsync(string username)
        {
            try
            {
                var request = WebRequest.Create(
                    string.Format("http://www.habbo.com/habbo-imaging/avatarimage?user={0}", username));
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); return null; }
        }

        public Image getAvatar(string username)
        {
            try
            {
                var request = WebRequest.Create(
                    string.Format("http://www.habbo.com/habbo-imaging/avatarimage?user={0}", username));
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); return null; }
        }

        public async void GetUserInfo(string Username)
        {
            try
            {
                string response = await _client.GetStringAsync(string.Format(PROFILE_REQUEST_FORMAT, Username));
                User user = User.fromJSON(response);
                UpdateInfo(user); 
            }
            catch (Exception) { MessageBox.Show("Error connecting to the habbo API, this is most likely because the username you specified does not exist",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}       
        }

        public async void UpdateInfo(User user)
        {
            try
            {
                UserInfoData.Rows.Clear();
                Image img = await getAvatarAsync(user.Name);
                if (img != null)
                    AvatarImg.Image = img;

                PropertyInfo[] props = typeof(User).GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    UserInfoData.Rows.Add(prop.Name, prop.GetValue(user));
                }
                if(user.SelectedBadges.Count > 0)
                {
                    int i = 0;
                    while(i < user.SelectedBadges.Count)
                    {
                        setImage(user.SelectedBadges[i].getBadgeImage(), i);
                        i++;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString());}
            
            
        }

        public void setImage (Image img, int count)
        {
            try
            {
            _badgeImgs[count].Image = img;             
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void UpdateImg_Click(object sender, EventArgs e)
        {
            AvatarImg.Image = getAvatar(SearchTxt.Text);
        }

        public bool validate(string input)
        {
            if(!string.IsNullOrWhiteSpace(input))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private void githubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.github.com/justdevinc/UserInfo");
        }
    }
}
