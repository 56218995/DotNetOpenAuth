﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.Web.Resources {
    using System;
    
    
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
    internal class WebResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WebResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.Web.Resources.WebResources", typeof(WebResources).Assembly);
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
        ///   Looks up a localized string similar to {0} cannot be null or an empty string..
        /// </summary>
        internal static string Argument_Cannot_Be_Null_Or_Empty {
            get {
                return ResourceManager.GetString("Argument_Cannot_Be_Null_Or_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A setting in web.config requires a secure connection for this request but the current connection is not secured..
        /// </summary>
        internal static string ConnectionNotSecure {
            get {
                return ResourceManager.GetString("ConnectionNotSecure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to encrypt the authentication ticket..
        /// </summary>
        internal static string FailedToEncryptTicket {
            get {
                return ResourceManager.GetString("FailedToEncryptTicket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpContext is not available in the current thread..
        /// </summary>
        internal static string HttpContextNotAvailable {
            get {
                return ResourceManager.GetString("HttpContextNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid provider name..
        /// </summary>
        internal static string InvalidServiceProviderName {
            get {
                return ResourceManager.GetString("InvalidServiceProviderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An OAuth data provider has not been registered for this application..
        /// </summary>
        internal static string OAuthDataProviderNotRegistered {
            get {
                return ResourceManager.GetString("OAuthDataProviderNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An OAuth data provider has already been registered for this application..
        /// </summary>
        internal static string OAuthDataProviderRegistered {
            get {
                return ResourceManager.GetString("OAuthDataProviderRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain the authentication response from service provider..
        /// </summary>
        internal static string OpenIDFailedToGetResponse {
            get {
                return ResourceManager.GetString("OpenIDFailedToGetResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid identifier.
        /// </summary>
        internal static string OpenIDInvalidIdentifier {
            get {
                return ResourceManager.GetString("OpenIDInvalidIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another service provider with the same name has already been registered..
        /// </summary>
        internal static string ServiceProviderNameExists {
            get {
                return ResourceManager.GetString("ServiceProviderNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A service provider could not be found by the specified name..
        /// </summary>
        internal static string ServiceProviderNotFound {
            get {
                return ResourceManager.GetString("ServiceProviderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t find a username with the provided credentials..
        /// </summary>
        internal static string UsernameNotFoundFromId {
            get {
                return ResourceManager.GetString("UsernameNotFoundFromId", resourceCulture);
            }
        }
    }
}
