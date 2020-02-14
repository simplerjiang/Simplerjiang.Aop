using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReportDataItem : AopObject
	{
		[XmlElement("row_data")]
		public string RowData
		{
			get;
			set;
		}
	}
}
