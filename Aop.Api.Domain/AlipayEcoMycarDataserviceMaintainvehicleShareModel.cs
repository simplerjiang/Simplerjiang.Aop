using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AopObject
	{
		[XmlElement("vid")]
		public string Vid
		{
			get;
			set;
		}
	}
}
