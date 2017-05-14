//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Resources;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using FabianXamarinConnect;
using Xamarin.Forms;

namespace FabianXamarinConnect
{
    public partial class MainPage : ContentPage
    {
        public IPlatformParameters platformParameters { get; set; }
        private static GraphServiceClient graphClient = null;
        private MailHelper _mailHelper = new MailHelper();

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            App.IdentityClientApp.PlatformParameters = platformParameters;
            SignInSignOutBtn.Text = "connect";

            // Developer code - if you haven't registered the app yet, we warn you. 
            if (App.ClientID == "")
            {
                InfoText.Text = AppResources_Fabian.NoClientIdMessage;
                SignInSignOutBtn.IsEnabled = false;
            }
            else
            {
                InfoText.Text = AppResources_Fabian.ConnectPrompt;
                SignInSignOutBtn.IsEnabled = true;
            }

        }
        async void OnSignInSignOut(object sender, EventArgs e)
        {

            if (SignInSignOutBtn.Text == "connect")
            {

                graphClient = AuthenticationHelper.GetAuthenticatedClient();
                var currentUserObject = await graphClient.Me.Request().GetAsync();
                App.Username = currentUserObject.DisplayName;
                App.UserEmail = currentUserObject.UserPrincipalName;

                InfoText.Text = "Hello, " + App.Username + ". " + AppResources_Fabian.SendMailPrompt;
                MailButton.IsVisible = true;
                EmailAddressBox.IsVisible = true;
                EmailAddressBox.Text = App.UserEmail;
                SignInSignOutBtn.Text = "disconnect";
            }
            else
            {
                AuthenticationHelper.SignOut();
                InfoText.Text = AppResources_Fabian.ConnectPrompt;
                SignInSignOutBtn.Text = "connect";
                MailButton.IsVisible = false;
                EmailAddressBox.Text = "";
                EmailAddressBox.IsVisible = false;
            }
        }

        private async void MailButton_Click(object sender, EventArgs e)
        {
            var mailAddress = EmailAddressBox.Text;
            try
            {

                await _mailHelper.ComposeAndSendMailAsync(AppResources_Fabian.MailSubject, AppResources_Fabian.MailContents, mailAddress);
                InfoText.Text = string.Format(AppResources_Fabian.SendMailSuccess, mailAddress);

            }
            catch (ServiceException exception)
            {
                InfoText.Text = AppResources_Fabian.MailErrorMessage;
                throw new Exception("We could not send the message: " + exception.Error == null ? "No error message returned." : exception.Error.Message);
                
            }


        }

    }
}
