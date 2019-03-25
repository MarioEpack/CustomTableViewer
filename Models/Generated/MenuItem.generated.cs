//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.MEDIO;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MenuItem.CLASS_NAME, typeof(MenuItem))]

namespace CMS.DocumentEngine.Types.MEDIO
{
	/// <summary>
	/// Represents a content item of type MenuItem.
	/// </summary>
	public partial class MenuItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MEDIO.MenuItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with MenuItem fields.
		/// </summary>
		private readonly MenuItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MenuItemID.
		/// </summary>
		[DatabaseIDField]
		public int MenuItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MenuItemID"), 0);
			}
			set
			{
				SetValue("MenuItemID", value);
			}
		}


		/// <summary>
		/// Menu Text.
		/// </summary>
		[DatabaseField]
		public string MenuItemText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MenuItemText"), @"");
			}
			set
			{
				SetValue("MenuItemText", value);
			}
		}


		/// <summary>
		/// Page.
		/// </summary>
		[DatabaseField]
		public Guid MenuItemPage
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("MenuItemPage"), Guid.Empty);
			}
			set
			{
				SetValue("MenuItemPage", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MenuItem fields.
		/// </summary>
		[RegisterProperty]
		public MenuItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MenuItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MenuItemFields : AbstractHierarchicalObject<MenuItemFields>
		{
			/// <summary>
			/// The content item of type MenuItem that is a target of the extended API.
			/// </summary>
			private readonly MenuItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MenuItemFields" /> class with the specified content item of type MenuItem.
			/// </summary>
			/// <param name="instance">The content item of type MenuItem that is a target of the extended API.</param>
			public MenuItemFields(MenuItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MenuItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MenuItemID;
				}
				set
				{
					mInstance.MenuItemID = value;
				}
			}


			/// <summary>
			/// Menu Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.MenuItemText;
				}
				set
				{
					mInstance.MenuItemText = value;
				}
			}


			/// <summary>
			/// Page.
			/// </summary>
			public Guid Page
			{
				get
				{
					return mInstance.MenuItemPage;
				}
				set
				{
					mInstance.MenuItemPage = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MenuItem" /> class.
		/// </summary>
		public MenuItem() : base(CLASS_NAME)
		{
			mFields = new MenuItemFields(this);
		}

		#endregion
	}
}