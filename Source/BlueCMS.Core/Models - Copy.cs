





#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;



namespace BlueCMS.Core.Models
{

	public partial interface IGlassBase{
		
		[SitecoreId]
		Guid Id{ get; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

	}

	public abstract partial class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; private set;}

		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}






namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Objects.General
{


 	/// <summary>
	/// ISite Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Objects/General/Site</para>	
	/// <para>ID: 3321e208-437e-40cc-8bd4-51df54be561b</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISiteConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISite : IGlassBase , global::BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General.IBase_Site
	{
				}


	public static partial class ISiteConstants{

			public const string TemplateIdString = "3321e208-437e-40cc-8bd4-51df54be561b";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Site";

					
			public static readonly ID TitleFieldId = new ID("34d78483-e4f5-4e73-9c10-f56caa19bcad");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Site
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Objects/General/Site</para>	
	/// <para>ID: 3321e208-437e-40cc-8bd4-51df54be561b</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISiteConstants.TemplateIdString)] //, Cachable = true
	public partial class Site  : GlassBase, ISite 
	{
	   
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 34d78483-e4f5-4e73-9c10-f56caa19bcad</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISiteConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}





namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Objects.Settings
{


 	/// <summary>
	/// ISite_Settings Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Objects/Settings/Site Settings</para>	
	/// <para>ID: 5e2c1e99-bea0-48da-aca6-4658d830db99</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_SettingsConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISite_Settings : IGlassBase 
	{
				}


	public static partial class ISite_SettingsConstants{

			public const string TemplateIdString = "5e2c1e99-bea0-48da-aca6-4658d830db99";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Site Settings";

			

	}

	
	/// <summary>
	/// Site_Settings
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Objects/Settings/Site Settings</para>	
	/// <para>ID: 5e2c1e99-bea0-48da-aca6-4658d830db99</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_SettingsConstants.TemplateIdString)] //, Cachable = true
	public partial class Site_Settings  : GlassBase, ISite_Settings 
	{
	   
			
	}
}

namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Pages
{


 	/// <summary>
	/// IHome Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Pages/Home</para>	
	/// <para>ID: 6671c55d-dfa7-4e95-b6a5-38cff6394561</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHomeConstants.TemplateIdString )] //, Cachable = true
	public partial interface IHome : IGlassBase 
	{
				}


	public static partial class IHomeConstants{

			public const string TemplateIdString = "6671c55d-dfa7-4e95-b6a5-38cff6394561";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Home";

			

	}

	
	/// <summary>
	/// Home
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Pages/Home</para>	
	/// <para>ID: 6671c55d-dfa7-4e95-b6a5-38cff6394561</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHomeConstants.TemplateIdString)] //, Cachable = true
	public partial class Home  : GlassBase, IHome 
	{
	   
			
	}
}
namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General
{


 	/// <summary>
	/// IBase_Site Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base Site</para>	
	/// <para>ID: 6806c4b5-3c1c-486b-95b1-a05b5f8f148d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_SiteConstants.TemplateIdString )] //, Cachable = true
	public partial interface IBase_Site : IGlassBase 
	{
								/// <summary>
					/// The Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 34d78483-e4f5-4e73-9c10-f56caa19bcad</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IBase_SiteConstants.TitleFieldName)]
					string Title  {get; set;}
			
				}


	public static partial class IBase_SiteConstants{

			public const string TemplateIdString = "6806c4b5-3c1c-486b-95b1-a05b5f8f148d";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Base Site";

					
			public static readonly ID TitleFieldId = new ID("34d78483-e4f5-4e73-9c10-f56caa19bcad");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Base_Site
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base Site</para>	
	/// <para>ID: 6806c4b5-3c1c-486b-95b1-a05b5f8f148d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_SiteConstants.TemplateIdString)] //, Cachable = true
	public partial class Base_Site  : GlassBase, IBase_Site 
	{
	   
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 34d78483-e4f5-4e73-9c10-f56caa19bcad</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_SiteConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Pages
{


 	/// <summary>
	/// IBasic_Page Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Pages/Basic Page</para>	
	/// <para>ID: 6bd239df-3a84-460c-8502-fd6fff738376</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBasic_PageConstants.TemplateIdString )] //, Cachable = true
	public partial interface IBasic_Page : IGlassBase , global::BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General.IBase_Page
	{
				}


	public static partial class IBasic_PageConstants{

			public const string TemplateIdString = "6bd239df-3a84-460c-8502-fd6fff738376";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Basic Page";

					
			public static readonly ID Canonical_UrlFieldId = new ID("0291ff02-9945-41bd-81c9-797b6041f87b");
			public const string Canonical_UrlFieldName = "Canonical Url";
			
					
			public static readonly ID Meta_DescriptionFieldId = new ID("3b707eea-e4b5-4885-b06b-c3893ae56652");
			public const string Meta_DescriptionFieldName = "Meta Description";
			
					
			public static readonly ID Meta_KeywordsFieldId = new ID("3a0a9472-a356-4bac-a4db-fca15a769db4");
			public const string Meta_KeywordsFieldName = "Meta Keywords";
			
			

	}

	
	/// <summary>
	/// Basic_Page
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Pages/Basic Page</para>	
	/// <para>ID: 6bd239df-3a84-460c-8502-fd6fff738376</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBasic_PageConstants.TemplateIdString)] //, Cachable = true
	public partial class Basic_Page  : GlassBase, IBasic_Page 
	{
	   
						/// <summary>
				/// The Canonical Url field.
				/// <para></para>
				/// <para>Field Type: General Link</para>		
				/// <para>Field ID: 0291ff02-9945-41bd-81c9-797b6041f87b</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBasic_PageConstants.Canonical_UrlFieldName)]
				public virtual Link Canonical_Url  {get; set;}
					
						/// <summary>
				/// The Meta Description field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3b707eea-e4b5-4885-b06b-c3893ae56652</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBasic_PageConstants.Meta_DescriptionFieldName)]
				public virtual string Meta_Description  {get; set;}
					
						/// <summary>
				/// The Meta Keywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3a0a9472-a356-4bac-a4db-fca15a769db4</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBasic_PageConstants.Meta_KeywordsFieldName)]
				public virtual string Meta_Keywords  {get; set;}
					
			
	}
}
namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General
{


 	/// <summary>
	/// IBase_Page Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base Page</para>	
	/// <para>ID: 9c1edf67-b944-451d-a803-12882d508c3b</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_PageConstants.TemplateIdString )] //, Cachable = true
	public partial interface IBase_Page : IGlassBase , global::BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General.IBase_SEO
	{
				}


	public static partial class IBase_PageConstants{

			public const string TemplateIdString = "9c1edf67-b944-451d-a803-12882d508c3b";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Base Page";

					
			public static readonly ID Canonical_UrlFieldId = new ID("0291ff02-9945-41bd-81c9-797b6041f87b");
			public const string Canonical_UrlFieldName = "Canonical Url";
			
					
			public static readonly ID Meta_DescriptionFieldId = new ID("3b707eea-e4b5-4885-b06b-c3893ae56652");
			public const string Meta_DescriptionFieldName = "Meta Description";
			
					
			public static readonly ID Meta_KeywordsFieldId = new ID("3a0a9472-a356-4bac-a4db-fca15a769db4");
			public const string Meta_KeywordsFieldName = "Meta Keywords";
			
			

	}

	
	/// <summary>
	/// Base_Page
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base Page</para>	
	/// <para>ID: 9c1edf67-b944-451d-a803-12882d508c3b</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_PageConstants.TemplateIdString)] //, Cachable = true
	public partial class Base_Page  : GlassBase, IBase_Page 
	{
	   
						/// <summary>
				/// The Canonical Url field.
				/// <para></para>
				/// <para>Field Type: General Link</para>		
				/// <para>Field ID: 0291ff02-9945-41bd-81c9-797b6041f87b</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_PageConstants.Canonical_UrlFieldName)]
				public virtual Link Canonical_Url  {get; set;}
					
						/// <summary>
				/// The Meta Description field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3b707eea-e4b5-4885-b06b-c3893ae56652</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_PageConstants.Meta_DescriptionFieldName)]
				public virtual string Meta_Description  {get; set;}
					
						/// <summary>
				/// The Meta Keywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3a0a9472-a356-4bac-a4db-fca15a769db4</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_PageConstants.Meta_KeywordsFieldName)]
				public virtual string Meta_Keywords  {get; set;}
					
			
	}
}



namespace BlueCMS.Core.Models.sitecore.templates.BlueCMS.Base.General
{


 	/// <summary>
	/// IBase_SEO Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base SEO</para>	
	/// <para>ID: be0bcb2f-2855-46ec-a094-81567ad82713</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_SEOConstants.TemplateIdString )] //, Cachable = true
	public partial interface IBase_SEO : IGlassBase 
	{
								/// <summary>
					/// The Canonical Url field.
					/// <para></para>
					/// <para>Field Type: General Link</para>		
					/// <para>Field ID: 0291ff02-9945-41bd-81c9-797b6041f87b</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IBase_SEOConstants.Canonical_UrlFieldName)]
					Link Canonical_Url  {get; set;}
			
								/// <summary>
					/// The Meta Description field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 3b707eea-e4b5-4885-b06b-c3893ae56652</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IBase_SEOConstants.Meta_DescriptionFieldName)]
					string Meta_Description  {get; set;}
			
								/// <summary>
					/// The Meta Keywords field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 3a0a9472-a356-4bac-a4db-fca15a769db4</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IBase_SEOConstants.Meta_KeywordsFieldName)]
					string Meta_Keywords  {get; set;}
			
				}


	public static partial class IBase_SEOConstants{

			public const string TemplateIdString = "be0bcb2f-2855-46ec-a094-81567ad82713";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Base SEO";

					
			public static readonly ID Canonical_UrlFieldId = new ID("0291ff02-9945-41bd-81c9-797b6041f87b");
			public const string Canonical_UrlFieldName = "Canonical Url";
			
					
			public static readonly ID Meta_DescriptionFieldId = new ID("3b707eea-e4b5-4885-b06b-c3893ae56652");
			public const string Meta_DescriptionFieldName = "Meta Description";
			
					
			public static readonly ID Meta_KeywordsFieldId = new ID("3a0a9472-a356-4bac-a4db-fca15a769db4");
			public const string Meta_KeywordsFieldName = "Meta Keywords";
			
			

	}

	
	/// <summary>
	/// Base_SEO
	/// <para></para>
	/// <para>Path: /sitecore/templates/BlueCMS/Base/General/Base SEO</para>	
	/// <para>ID: be0bcb2f-2855-46ec-a094-81567ad82713</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBase_SEOConstants.TemplateIdString)] //, Cachable = true
	public partial class Base_SEO  : GlassBase, IBase_SEO 
	{
	   
						/// <summary>
				/// The Canonical Url field.
				/// <para></para>
				/// <para>Field Type: General Link</para>		
				/// <para>Field ID: 0291ff02-9945-41bd-81c9-797b6041f87b</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_SEOConstants.Canonical_UrlFieldName)]
				public virtual Link Canonical_Url  {get; set;}
					
						/// <summary>
				/// The Meta Description field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3b707eea-e4b5-4885-b06b-c3893ae56652</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_SEOConstants.Meta_DescriptionFieldName)]
				public virtual string Meta_Description  {get; set;}
					
						/// <summary>
				/// The Meta Keywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 3a0a9472-a356-4bac-a4db-fca15a769db4</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBase_SEOConstants.Meta_KeywordsFieldName)]
				public virtual string Meta_Keywords  {get; set;}
					
			
	}
}









