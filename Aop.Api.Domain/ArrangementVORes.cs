using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementVORes : AopObject
	{
		[XmlElement("ar_base")]
		public ArrangementBaseVO ArBase
		{
			get;
			set;
		}

		[XmlElement("ar_bsn_status")]
		public string ArBsnStatus
		{
			get;
			set;
		}

		[XmlElement("ar_condition")]
		public string ArCondition
		{
			get;
			set;
		}

		[XmlElement("arrangement_no")]
		public string ArrangementNo
		{
			get;
			set;
		}
	}
}
