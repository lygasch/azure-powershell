﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Profile.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Profile.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Selected profile must not be null..
        /// </summary>
        internal static string AzureProfileMustNotBeNull {
            get {
                return ResourceManager.GetString("AzureProfileMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide either a subscription ID or a subscription name..
        /// </summary>
        internal static string BothSubscriptionIdAndNameProvided {
            get {
                return ResourceManager.GetString("BothSubscriptionIdAndNameProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate your user account {0} with the common tenant. Please login again using Login-AzureRmAccount..
        /// </summary>
        internal static string CommonTenantAuthFailed {
            get {
                return ResourceManager.GetString("CommonTenantAuthFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided subscription ID &quot;{0}&quot; is not a valid Guid..
        /// </summary>
        internal static string InvalidSubscriptionId {
            get {
                return ResourceManager.GetString("InvalidSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (no account provided).
        /// </summary>
        internal static string NoAccountProvided {
            get {
                return ResourceManager.GetString("NoAccountProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide a valid tenant Id on the command line or execute Login-AzureRmAccount..
        /// </summary>
        internal static string NoValidTenant {
            get {
                return ResourceManager.GetString("NoValidTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {0} was not found in tenant {1}. Please verify that the subscription exists in this tenant..
        /// </summary>
        internal static string SubscriptionNotFoundError {
            get {
                return ResourceManager.GetString("SubscriptionNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate with tenant {0}. Please ensure that your account has access to this tenant and log in with Login-AzureRmAccount.
        /// </summary>
        internal static string TenantAuthFailed {
            get {
                return ResourceManager.GetString("TenantAuthFailed", resourceCulture);
            }
        }
    }
}
