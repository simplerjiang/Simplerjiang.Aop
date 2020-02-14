using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLabelQueryResponse : AopResponse
	{
		[XmlArray("label_list")]
		[XmlArrayItem("public_label")]
		public List<PublicLabel> LabelList
		{
			get;
			set;
		}
	}
}
