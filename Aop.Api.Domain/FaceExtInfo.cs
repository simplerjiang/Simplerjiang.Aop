using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FaceExtInfo : AopObject
	{
		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}
	}
}
