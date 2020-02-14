using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LotteryType : AopObject
	{
		[XmlElement("lottery_type_id")]
		public long LotteryTypeId
		{
			get;
			set;
		}

		[XmlElement("lottery_type_name")]
		public string LotteryTypeName
		{
			get;
			set;
		}
	}
}
