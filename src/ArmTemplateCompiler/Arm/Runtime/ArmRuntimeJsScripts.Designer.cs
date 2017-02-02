﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmEngine.Arm.Runtime {
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
    internal class ArmRuntimeJsScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ArmRuntimeJsScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ArmEngine.Arm.Runtime.ArmRuntimeJsScripts", typeof(ArmRuntimeJsScripts).Assembly);
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
        ///   Looks up a localized string similar to &quot;use strict&quot;;
        ///
        ///var subscriptionId = &quot;0000-123213213-asd123-123136&quot;;
        ///var resourceGroupName = &quot;aurg&quot;;
        ///
        ///var base64 = arm.base64;
        ///
        ///function reference() {
        ///    throw new &quot;The arm template compiler does not support these functions, reference(),resourceGroup(),listKeys()&quot;;
        ///}
        ///
        ///function resourceGroup() {
        ///    throw new &quot;The arm template compiler does not support these functions, reference(),resourceGroup(),listKeys()&quot;;
        ///}
        ///
        ///function listKeys() {
        ///    throw new &quot;The arm template compiler does not support t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string armFunctions {
            get {
                return ResourceManager.GetString("armFunctions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    json2.js
        ///    2015-02-25
        ///
        ///    Public Domain.
        ///
        ///    NO WARRANTY EXPRESSED OR IMPLIED. USE AT YOUR OWN RISK.
        ///
        ///    See http://www.JSON.org/js.html
        ///
        ///
        ///    This code should be minified before deployment.
        ///    See http://javascript.crockford.com/jsmin.html
        ///
        ///    USE YOUR OWN COPY. IT IS EXTREMELY UNWISE TO LOAD CODE FROM SERVERS YOU DO
        ///    NOT CONTROL.
        ///
        ///
        ///    This file creates a global JSON object containing two methods: stringify
        ///    and parse.
        ///
        ///        JSON.stringify(value, replacer, space [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JSON2 {
            get {
                return ResourceManager.GetString("JSON2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string unimplementedArmFunctions {
            get {
                return ResourceManager.GetString("unimplementedArmFunctions", resourceCulture);
            }
        }
    }
}
