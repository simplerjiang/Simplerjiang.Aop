using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserIdenticalAuthbaseQueryModel : AopObject
	{
		[XmlElement("base_user_id")]
		public string BaseUserId
		{
			get;
			set;
		}

		[XmlElement("comparator_user_id")]
		public string ComparatorUserId
		{
			get;
			set;
		}
	}
}
