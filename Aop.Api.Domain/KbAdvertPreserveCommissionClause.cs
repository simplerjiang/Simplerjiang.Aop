using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertPreserveCommissionClause : AopObject
	{
		[XmlElement("claimer_id_type")]
		public string ClaimerIdType
		{
			get;
			set;
		}

		[XmlArray("claimers")]
		[XmlArrayItem("string")]
		public List<string> Claimers
		{
			get;
			set;
		}
	}
}
