using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SupportFunction : AopObject
	{
		[XmlElement("card_name")]
		public string CardName
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlArray("function_type")]
		[XmlArrayItem("string")]
		public List<string> FunctionType
		{
			get;
			set;
		}

		[XmlElement("goto_url")]
		public string GotoUrl
		{
			get;
			set;
		}
	}
}
