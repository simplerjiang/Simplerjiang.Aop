using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceYuebaolqdDetailQueryResponse : AopResponse
	{
		[XmlArray("yeb_ldq_data")]
		[XmlArrayItem("alipay_yeb_lqd_data_result")]
		public List<AlipayYebLqdDataResult> YebLdqData
		{
			get;
			set;
		}
	}
}
