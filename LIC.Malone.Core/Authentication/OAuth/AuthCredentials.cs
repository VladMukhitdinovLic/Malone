using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIC.Malone.Core.Authentication.OAuth
{
    public class AuthCredentials
    {
        public OAuthApplication Application { get; set; }
        public Uri Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthorizeResult Authorize()
        {
            return Application.Authorize(Url, Username, Password);
        }
    }
}
