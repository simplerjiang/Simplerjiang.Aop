using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsPartnerQueryModel : AopObject
	{
		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlArray("partner_ids")]
		[XmlArrayItem("string")]
		public List<string> PartnerIds
		{
			get;
			set;
		}
	}
}
