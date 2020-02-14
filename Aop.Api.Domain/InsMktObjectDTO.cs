using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktObjectDTO : AopObject
	{
		[XmlElement("obj_id")]
		public string ObjId
		{
			get;
			set;
		}

		[XmlElement("type")]
		public long Type
		{
			get;
			set;
		}
	}
}
