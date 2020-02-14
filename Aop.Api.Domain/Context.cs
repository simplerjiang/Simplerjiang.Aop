using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Context : AopObject
	{
		[XmlElement("action_name")]
		public string ActionName
		{
			get;
			set;
		}

		[XmlElement("first")]
		public Keyword First
		{
			get;
			set;
		}

		[XmlElement("head_color")]
		public string HeadColor
		{
			get;
			set;
		}

		[XmlElement("keyword1")]
		public Keyword Keyword1
		{
			get;
			set;
		}

		[XmlElement("keyword2")]
		public Keyword Keyword2
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public Keyword Remark
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
