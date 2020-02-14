using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseRelationFriendsQueryModel : AopObject
	{
		[XmlElement("get_type")]
		public new long GetType
		{
			get;
			set;
		}

		[XmlElement("include_self")]
		public bool IncludeSelf
		{
			get;
			set;
		}
	}
}
