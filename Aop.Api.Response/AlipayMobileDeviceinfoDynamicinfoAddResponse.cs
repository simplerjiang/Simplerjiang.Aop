using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AopResponse
	{
		[XmlElement("operateresult")]
		public bool Operateresult
		{
			get;
			set;
		}
	}
}
