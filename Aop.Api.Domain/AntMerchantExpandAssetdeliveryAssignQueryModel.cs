using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetdeliveryAssignQueryModel : AopObject
	{
		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}
	}
}
