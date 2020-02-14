using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeSignQueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("sign_result_value")]
		public List<SignResultValue> DataList
		{
			get;
			set;
		}
	}
}
