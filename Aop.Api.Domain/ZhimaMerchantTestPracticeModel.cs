using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantTestPracticeModel : AopObject
	{
		[XmlArray("add")]
		[XmlArrayItem("string")]
		public List<string> Add
		{
			get;
			set;
		}

		[XmlElement("xxxx")]
		public XXXXsdasdasd Xxxx
		{
			get;
			set;
		}
	}
}
