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
	/// <summary>Menu singolo</summary>
	[PublishedContentModel("menuSingolo")]
	public partial class MenuSingolo : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "menuSingolo";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MenuSingolo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MenuSingolo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Antipasti
		///</summary>
		[ImplementPropertyType("antipasti")]
		public IEnumerable<string> Antipasti
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("antipasti"); }
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
		/// Caffe
		///</summary>
		[ImplementPropertyType("caffe")]
		public bool Caffe
		{
			get { return this.GetPropertyValue<bool>("caffe"); }
		}

		///<summary>
		/// Contorni
		///</summary>
		[ImplementPropertyType("contorni")]
		public IEnumerable<string> Contorni
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("contorni"); }
		}

		///<summary>
		/// Descrizione
		///</summary>
		[ImplementPropertyType("descrizione")]
		public IHtmlString Descrizione
		{
			get { return this.GetPropertyValue<IHtmlString>("descrizione"); }
		}

		///<summary>
		/// Dessert
		///</summary>
		[ImplementPropertyType("dessert")]
		public IEnumerable<string> Dessert
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("dessert"); }
		}

		///<summary>
		/// Digestivo
		///</summary>
		[ImplementPropertyType("digestivo")]
		public bool Digestivo
		{
			get { return this.GetPropertyValue<bool>("digestivo"); }
		}

		///<summary>
		/// FinoA
		///</summary>
		[ImplementPropertyType("finoA")]
		public DateTime FinoA
		{
			get { return this.GetPropertyValue<DateTime>("finoA"); }
		}

		///<summary>
		/// Immagine
		///</summary>
		[ImplementPropertyType("immagine")]
		public string Immagine
		{
			get { return this.GetPropertyValue<string>("immagine"); }
		}

		///<summary>
		/// menu del giorno: Spunta la casella se è il menù del giorno
		///</summary>
		[ImplementPropertyType("menuDelGiorno")]
		public bool MenuDelGiorno
		{
			get { return this.GetPropertyValue<bool>("menuDelGiorno"); }
		}

		///<summary>
		/// Piatto del giorno
		///</summary>
		[ImplementPropertyType("piattoDelGiorno")]
		public string PiattoDelGiorno
		{
			get { return this.GetPropertyValue<string>("piattoDelGiorno"); }
		}

		///<summary>
		/// Prezzo
		///</summary>
		[ImplementPropertyType("prezzo")]
		public decimal Prezzo
		{
			get { return this.GetPropertyValue<decimal>("prezzo"); }
		}

		///<summary>
		/// Primi
		///</summary>
		[ImplementPropertyType("primi")]
		public IEnumerable<string> Primi
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("primi"); }
		}

		///<summary>
		/// Secondi
		///</summary>
		[ImplementPropertyType("secondi")]
		public IEnumerable<string> Secondi
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("secondi"); }
		}

		///<summary>
		/// ValidoDa
		///</summary>
		[ImplementPropertyType("validoDa")]
		public DateTime ValidoDa
		{
			get { return this.GetPropertyValue<DateTime>("validoDa"); }
		}

		///<summary>
		/// Vino
		///</summary>
		[ImplementPropertyType("vino")]
		public IEnumerable<string> Vino
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("vino"); }
		}
	}
}
