using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReportErrorFeature : AopObject
	{
		[XmlElement("table_num")]
		public string TableNum
		{
			get;
			set;
		}
	}
}
