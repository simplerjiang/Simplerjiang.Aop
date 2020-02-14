using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiagnoseResult : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("diagnose_code")]
		public string DiagnoseCode
		{
			get;
			set;
		}
	}
}
