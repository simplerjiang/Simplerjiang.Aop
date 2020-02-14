using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenEchoSendResponse : AopResponse
	{
		[XmlElement("obj")]
		public MyObjectDdd Obj
		{
			get;
			set;
		}

		[XmlElement("out_a")]
		public string OutA
		{
			get;
			set;
		}

		[XmlElement("out_b")]
		public long OutB
		{
			get;
			set;
		}

		[XmlElement("out_c")]
		public string OutC
		{
			get;
			set;
		}

		[XmlElement("out_d")]
		public string OutD
		{
			get;
			set;
		}

		[XmlElement("word")]
		public string Word
		{
			get;
			set;
		}
	}
}
