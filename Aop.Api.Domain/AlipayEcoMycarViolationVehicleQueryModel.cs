using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarViolationVehicleQueryModel : AopObject
	{
		[XmlElement("vi_id")]
		public string ViId
		{
			get;
			set;
		}
	}
}
