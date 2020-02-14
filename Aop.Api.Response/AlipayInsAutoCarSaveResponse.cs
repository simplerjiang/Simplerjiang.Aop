using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoCarSaveResponse : AopResponse
	{
		[XmlElement("car_no")]
		public string CarNo
		{
			get;
			set;
		}
	}
}
