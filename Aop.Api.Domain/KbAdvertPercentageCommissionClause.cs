using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertPercentageCommissionClause : AopObject
	{
		[XmlElement("max")]
		public string Max
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}
	}
}
