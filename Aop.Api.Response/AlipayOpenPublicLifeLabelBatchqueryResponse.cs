using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeLabelBatchqueryResponse : AopResponse
	{
		[XmlArray("labels")]
		[XmlArrayItem("life_label")]
		public List<LifeLabel> Labels
		{
			get;
			set;
		}
	}
}
