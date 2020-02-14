using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCraftsmanDataWorkDeleteModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("craftsman_id")]
		public string CraftsmanId
		{
			get;
			set;
		}

		[XmlArray("work_ids")]
		[XmlArrayItem("string")]
		public List<string> WorkIds
		{
			get;
			set;
		}
	}
}
