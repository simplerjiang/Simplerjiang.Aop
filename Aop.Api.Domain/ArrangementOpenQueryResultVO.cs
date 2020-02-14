using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementOpenQueryResultVO : AopObject
	{
		[XmlElement("ar_no")]
		public string ArNo
		{
			get;
			set;
		}

		[XmlElement("ar_status")]
		public string ArStatus
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}

		[XmlElement("invalid_date")]
		public string InvalidDate
		{
			get;
			set;
		}

		[XmlElement("sign_date")]
		public string SignDate
		{
			get;
			set;
		}

		[XmlElement("valid_date")]
		public string ValidDate
		{
			get;
			set;
		}
	}
}
