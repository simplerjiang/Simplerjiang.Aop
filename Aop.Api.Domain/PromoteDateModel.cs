using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoteDateModel : AopObject
	{
		[XmlElement("date")]
		public string Date
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
