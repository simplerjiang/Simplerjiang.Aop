using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneHealthActivitySyncResponse : AopResponse
	{
		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}
	}
}
