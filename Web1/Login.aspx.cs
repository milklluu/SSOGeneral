﻿using SSO.Helper;
using System;

namespace Web1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SSOCrossDomain cross = new SSOCrossDomain(this);
                cross.ValidationLogIn("CookieWeb1", new TimeSpan(0, 2, 0));
            }
        }
    }
}