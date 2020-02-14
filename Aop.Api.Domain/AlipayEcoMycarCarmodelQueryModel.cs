using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarCarmodelQueryModel : AopObject
	{
		[XmlElement("model_id")]
		public string ModelId
		{
			get;
			set;
		}
	}
}
