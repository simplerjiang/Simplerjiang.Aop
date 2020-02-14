using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFacerepoSearchResponse : AopResponse
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("face_id")]
		public string FaceId
		{
			get;
			set;
		}
	}
}
