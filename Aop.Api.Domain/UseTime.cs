using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UseTime : AopObject
	{
		[XmlElement("dimension")]
		public string Dimension
		{
			get;
			set;
		}

		[XmlElement("times")]
		public string Times
		{
			get;
			set;
		}

		[XmlElement("values")]
		public string Values
		{
			get;
			set;
		}
	}
}
