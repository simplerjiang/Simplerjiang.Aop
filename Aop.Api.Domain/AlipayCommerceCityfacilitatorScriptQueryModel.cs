using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorScriptQueryModel : AopObject
	{
		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("script_type")]
		public string ScriptType
		{
			get;
			set;
		}
	}
}
