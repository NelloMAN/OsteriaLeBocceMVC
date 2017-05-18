//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Menu</summary>
	[PublishedContentModel("menu")]
	public partial class Menu : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "menu";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Menu(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Menu, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// banner
		///</summary>
		[ImplementPropertyType("banner")]
		public string Banner
		{
			get { return this.GetPropertyValue<string>("banner"); }
		}

		///<summary>
		/// banner-xs
		///</summary>
		[ImplementPropertyType("bannerXs")]
		public string BannerXs
		{
			get { return this.GetPropertyValue<string>("bannerXs"); }
		}

		///<summary>
		/// Descrizione
		///</summary>
		[ImplementPropertyType("descrizione")]
		public IHtmlString Descrizione
		{
			get { return this.GetPropertyValue<IHtmlString>("descrizione"); }
		}
	}
}