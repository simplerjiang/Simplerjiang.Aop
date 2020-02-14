using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppLingqierwuLingqierquQueryModel : AopObject
	{
		[XmlArray("test")]
		[XmlArrayItem("string")]
		public List<string> Test
		{
			get;
			set;
		}
	}
}
