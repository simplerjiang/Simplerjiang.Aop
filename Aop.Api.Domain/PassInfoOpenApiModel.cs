using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PassInfoOpenApiModel : AopObject
	{
		[XmlElement("data_info")]
		public string DataInfo
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("logo_text")]
		public string LogoText
		{
			get;
			set;
		}

		[XmlElement("mechant_name")]
		public string MechantName
		{
			get;
			set;
		}

		[XmlElement("pass_id")]
		public string PassId
		{
			get;
			set;
		}

		[XmlElement("second_logo_text")]
		public string SecondLogoText
		{
			get;
			set;
		}

		[XmlArray("shop_id_list")]
		[XmlArrayItem("string")]
		public List<string> ShopIdList
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
