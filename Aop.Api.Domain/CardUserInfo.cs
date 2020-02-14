using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CardUserInfo : AopObject
	{
		[XmlElement("user_uni_id")]
		public string UserUniId
		{
			get;
			set;
		}

		[XmlElement("user_uni_id_type")]
		public string UserUniIdType
		{
			get;
			set;
		}
	}
}
