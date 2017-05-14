﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FabianXamarinConnect {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FabianXamarinConnect.AppResources", typeof(AppResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops!
        ///We couldn&apos;t connect to Office 365. Check your debug output for errors..
        /// </summary>
        internal static string AuthenticationErrorMessage {
            get {
                return ResourceManager.GetString("AuthenticationErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tap the &quot;connect&quot; button to connect to your personal or work or school account..
        /// </summary>
        internal static string ConnectPrompt {
            get {
                return ResourceManager.GetString("ConnectPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;&lt;head&gt;
        ///&lt;meta http-equiv=&apos;Content-Type&apos; content=&apos;text/html; charset=us-ascii&apos;&gt;
        ///&lt;title&gt;&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body style=&apos;font-family:calibri&apos;&gt;
        ///&lt;h2&gt;Congratulations!&lt;/h2&gt;
        ///&lt;p&gt;This is a message from the Microsoft Graph Connect Sample. You are well on your way to incorporating Microsoft Graph endpoints in your apps.&lt;/p&gt;&lt;a href=&apos;{0}&apos;&gt;See the photo you just uploaded!&lt;/a&gt;
        ///&lt;h3&gt;What&apos;s next?&lt;/h3&gt;&lt;ul&gt;
        ///&lt;li&gt;Check out &lt;a href=&apos;https://developer.microsoft.com/graph&apos;&gt;developer.microsoft.com/graph&lt;/a&gt; to start buildi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MailContents {
            get {
                return ResourceManager.GetString("MailContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops!
        ///
        ///We couldn&apos;t send an mail. Check your debug output for errors..
        /// </summary>
        internal static string MailErrorMessage {
            get {
                return ResourceManager.GetString("MailErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi from the Microsoft Graph Connect sample..
        /// </summary>
        internal static string MailSubject {
            get {
                return ResourceManager.GetString("MailSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops - It looks like this app is not registered with the v2.0 authentication endpoint, because we don&apos;t see a client id in App.xaml.  To run this sample, register it in the App Registration Portal. See Readme for more info..
        /// </summary>
        internal static string NoClientIdMessage {
            get {
                return ResourceManager.GetString("NoClientIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You&apos;re now connected to Microsoft Graph. Tap &quot;send mail&quot; to send a message from your account using Microsoft Graph..
        /// </summary>
        internal static string SendMailPrompt {
            get {
                return ResourceManager.GetString("SendMailPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We successfully  sent an email to {0} !.
        /// </summary>
        internal static string SendMailSuccess {
            get {
                return ResourceManager.GetString("SendMailSuccess", resourceCulture);
            }
        }
    }
}