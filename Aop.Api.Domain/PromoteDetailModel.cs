using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoteDetailModel : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("item_info")]
		public PromoteItemModel ItemInfo
		{
			get;
			set;
		}

		[XmlElement("promote_data")]
		public PromoteDataModel PromoteData
		{
			get;
			set;
		}
	}
}
