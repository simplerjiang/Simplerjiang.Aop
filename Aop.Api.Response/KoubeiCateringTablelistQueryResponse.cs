using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringTablelistQueryResponse : AopResponse
	{
		[XmlElement("tableinfo_result")]
		public TableInfoResult TableinfoResult
		{
			get;
			set;
		}
	}
}
