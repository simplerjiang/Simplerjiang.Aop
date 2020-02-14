using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtSchoolinfoModifyResponse : AopResponse
	{
		[XmlElement("school_no")]
		public string SchoolNo
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
