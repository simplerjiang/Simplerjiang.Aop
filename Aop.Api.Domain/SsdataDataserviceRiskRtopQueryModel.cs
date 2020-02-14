using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskRtopQueryModel : AopObject
	{
		[XmlElement("rowkeys")]
		public string Rowkeys
		{
			get;
			set;
		}
	}
}
