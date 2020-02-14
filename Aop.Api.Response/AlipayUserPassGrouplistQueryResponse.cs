using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserPassGrouplistQueryResponse : AopResponse
	{
		[XmlArray("pass_info_list")]
		[XmlArrayItem("pass_info_open_api_model")]
		public List<PassInfoOpenApiModel> PassInfoList
		{
			get;
			set;
		}
	}
}
