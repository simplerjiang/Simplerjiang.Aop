using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Data : AopObject
	{
		[XmlArray("user_id_list")]
		[XmlArrayItem("string")]
		public List<string> UserIdList
		{
			get;
			set;
		}
	}
}
