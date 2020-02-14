using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCraftsmanDataWorkCreateResponse : AopResponse
	{
		[XmlArray("works")]
		[XmlArrayItem("craftsman_work_out_id_open_model")]
		public List<CraftsmanWorkOutIdOpenModel> Works
		{
			get;
			set;
		}
	}
}
