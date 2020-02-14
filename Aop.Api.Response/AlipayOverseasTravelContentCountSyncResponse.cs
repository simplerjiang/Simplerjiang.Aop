using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTravelContentCountSyncResponse : AopResponse
	{
		[XmlElement("results")]
		public string Results
		{
			get;
			set;
		}
	}
}
