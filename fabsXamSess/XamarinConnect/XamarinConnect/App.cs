//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FabianXamarinConnect
{
    public class App : Application
    {
        public static PublicClientApplication IdentityClientApp = null;
        public static string ClientID = "REDACTED FOR NOW!";
        public static string[] Scopes = { "User.Read", "Mail.Send", "Files.ReadWrite" };
        public static string Username = string.Empty;
        public static string UserEmail = string.Empty;
        public App()
        {
            IdentityClientApp = new PublicClientApplication(ClientID);
            MainPage = new NavigationPage(new FabianXamarinConnect.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
