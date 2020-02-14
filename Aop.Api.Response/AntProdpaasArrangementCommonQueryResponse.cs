using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntProdpaasArrangementCommonQueryResponse : AopResponse
	{
		[XmlArray("arrangements")]
		[XmlArrayItem("arrangement_v_o_res")]
		public List<ArrangementVORes> Arrangements
		{
			get;
			set;
		}
	}
}
