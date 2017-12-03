﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(TreinaWeb.ClinicaVeterinaria.Web.App_Start.StartupOwin))]

namespace TreinaWeb.ClinicaVeterinaria.Web.App_Start
{
    public class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/login")
                
            });
        }
    }
}
//AuthenticationMode = AuthenticationMode.Active