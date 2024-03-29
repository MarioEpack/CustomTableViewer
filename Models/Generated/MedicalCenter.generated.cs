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

[assembly: RegisterDocumentType(MedicalCenter.CLASS_NAME, typeof(MedicalCenter))]

namespace CMS.DocumentEngine.Types.MEDIO
{
	/// <summary>
	/// Represents a content item of type MedicalCenter.
	/// </summary>
	public partial class MedicalCenter : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MEDIO.MedicalCenter";


		/// <summary>
		/// The instance of the class that provides extended API for working with MedicalCenter fields.
		/// </summary>
		private readonly MedicalCenterFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MedicalCenterID.
		/// </summary>
		[DatabaseIDField]
		public int MedicalCenterID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MedicalCenterID"), 0);
			}
			set
			{
				SetValue("MedicalCenterID", value);
			}
		}


		/// <summary>
		/// Header.
		/// </summary>
		[DatabaseField]
		public string MedicalCenterHeader
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MedicalCenterHeader"), @"");
			}
			set
			{
				SetValue("MedicalCenterHeader", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string MedicalCenterText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MedicalCenterText"), @"");
			}
			set
			{
				SetValue("MedicalCenterText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MedicalCenter fields.
		/// </summary>
		[RegisterProperty]
		public MedicalCenterFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MedicalCenter fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MedicalCenterFields : AbstractHierarchicalObject<MedicalCenterFields>
		{
			/// <summary>
			/// The content item of type MedicalCenter that is a target of the extended API.
			/// </summary>
			private readonly MedicalCenter mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MedicalCenterFields" /> class with the specified content item of type MedicalCenter.
			/// </summary>
			/// <param name="instance">The content item of type MedicalCenter that is a target of the extended API.</param>
			public MedicalCenterFields(MedicalCenter instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MedicalCenterID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MedicalCenterID;
				}
				set
				{
					mInstance.MedicalCenterID = value;
				}
			}


			/// <summary>
			/// Header.
			/// </summary>
			public string Header
			{
				get
				{
					return mInstance.MedicalCenterHeader;
				}
				set
				{
					mInstance.MedicalCenterHeader = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.MedicalCenterText;
				}
				set
				{
					mInstance.MedicalCenterText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MedicalCenter" /> class.
		/// </summary>
		public MedicalCenter() : base(CLASS_NAME)
		{
			mFields = new MedicalCenterFields(this);
		}

		#endregion
	}
}