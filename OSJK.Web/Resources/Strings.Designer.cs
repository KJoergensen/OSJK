﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSJK.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OSJK.Web.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Der skal vælges en modtager.
        /// </summary>
        internal static string ERROR_CHOOSE_A_RECIPIENT {
            get {
                return ResourceManager.GetString("ERROR_CHOOSE_A_RECIPIENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email-adressen er ugyldig.
        /// </summary>
        internal static string ERROR_EMAIL_ADDRESS_INVALID {
            get {
                return ResourceManager.GetString("ERROR_EMAIL_ADDRESS_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email skal udfyldes.
        /// </summary>
        internal static string ERROR_EMAIL_MUST_BE_FILLED_OUT {
            get {
                return ResourceManager.GetString("ERROR_EMAIL_MUST_BE_FILLED_OUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Besked skal udfyldes.
        /// </summary>
        internal static string ERROR_MESSAGE_MUST_BE_FILLED_OUT {
            get {
                return ResourceManager.GetString("ERROR_MESSAGE_MUST_BE_FILLED_OUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navn skal udfyldes.
        /// </summary>
        internal static string ERROR_NAME_MUST_BE_FILLED_OUT {
            get {
                return ResourceManager.GetString("ERROR_NAME_MUST_BE_FILLED_OUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vi havde problemer med at sende din besked. Prøv venligst igen, eller send til en anden modtager..
        /// </summary>
        internal static string ERROR_PROBLEM_SENDING_EMAIL {
            get {
                return ResourceManager.GetString("ERROR_PROBLEM_SENDING_EMAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Besked.
        /// </summary>
        internal static string SYS_MESSAGE {
            get {
                return ResourceManager.GetString("SYS_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Til.
        /// </summary>
        internal static string SYS_TO {
            get {
                return ResourceManager.GetString("SYS_TO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Din email.
        /// </summary>
        internal static string SYS_YOUR_EMAIL {
            get {
                return ResourceManager.GetString("SYS_YOUR_EMAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dit navn.
        /// </summary>
        internal static string SYS_YOUR_NAME {
            get {
                return ResourceManager.GetString("SYS_YOUR_NAME", resourceCulture);
            }
        }
    }
}