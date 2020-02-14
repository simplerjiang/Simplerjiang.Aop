using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AopResponse
	{
		[XmlElement("info")]
		public MaintainVehicleInfo Info
		{
			get;
			set;
		}
	}
}
