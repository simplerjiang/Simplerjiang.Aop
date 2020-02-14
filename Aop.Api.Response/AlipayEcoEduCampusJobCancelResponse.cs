using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduCampusJobCancelResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("isv_code")]
		public string IsvCode
		{
			get;
			set;
		}
	}
}
