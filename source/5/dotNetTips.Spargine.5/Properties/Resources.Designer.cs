﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-12-2021
// ***********************************************************************
// <copyright file="Resources.Designer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Spargine.Properties
{


	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated by the StronglyTypedResourceBuilder
	// class via a tool like ResGen or Visual Studio.
	// To add or remove a member, edit your .ResX file then rerun ResGen
	// with the /str option, or rebuild your VS project.
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {

		/// <summary>
		/// The resource man
		/// </summary>
		private static global::System.Resources.ResourceManager resourceMan;

		/// <summary>
		/// The resource culture
		/// </summary>
		private static global::System.Globalization.CultureInfo resourceCulture;

		/// <summary>
		/// Initializes a new instance of the <see cref="Resources"/> class.
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		/// <value>The resource manager.</value>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dotNetTips.Spargine.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

		/// <summary>
		/// Overrides the current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class.
		/// </summary>
		/// <value>The culture.</value>
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
		/// Looks up a localized string similar to File not found..
		/// </summary>
		/// <value>The file not found.</value>
		internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }

		/// <summary>
		/// Looks up a localized string similar to Folder not found..
		/// </summary>
		/// <value>The folder not found.</value>
		internal static string FolderNotFound {
            get {
                return ResourceManager.GetString("FolderNotFound", resourceCulture);
            }
        }

		/// <summary>
		/// Looks up a localized string similar to Service not found..
		/// </summary>
		/// <value>The service not found.</value>
		internal static string ServiceNotFound {
            get {
                return ResourceManager.GetString("ServiceNotFound", resourceCulture);
            }
        }

		/// <summary>
		/// Looks up a localized string similar to Zip file not found..
		/// </summary>
		/// <value>The zip file not found.</value>
		internal static string ZipFileNotFound {
            get {
                return ResourceManager.GetString("ZipFileNotFound", resourceCulture);
            }
        }
    }
}
