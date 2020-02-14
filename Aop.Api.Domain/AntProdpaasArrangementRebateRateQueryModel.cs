using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntProdpaasArrangementRebateRateQueryModel : AopObject
	{
		[XmlElement("data_item_name")]
		public string DataItemName
		{
			get;
			set;
		}

		[XmlElement("first_category_id")]
		public string FirstCategoryId
		{
			get;
			set;
		}

		[XmlElement("gmt_query")]
		public string GmtQuery
		{
			get;
			set;
		}
	}
}
