using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieEditorGetResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieEditorGetRespModel Data
		{
			get;
			set;
		}
	}
}
