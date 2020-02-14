using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneProductAccessApplyResponse : AopResponse
	{
		[XmlElement("is_access")]
		public bool IsAccess
		{
			get;
			set;
		}

		[XmlElement("product")]
		public InsProduct Product
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
		{
			get;
			set;
		}
	}
}
