using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    public static class Config
    {
        public static string USER_REQUEST_FORMAT = "https://www.habbo.com/api/public/users?name={0}";

        public static string PROFILE_REQUEST_FORMAT = "https://www.habbo.com/api/public/users/{0}/profile";
    }
}
