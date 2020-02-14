using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAlixiaohaoQueryModel : AopObject
	{
		[XmlElement("mobile_no")]
		public string MobileNo
		{
			get;
			set;
		}
	}
}
