using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossCsChannelQueryModel : AopObject
	{
		[XmlElement("att")]
		public string Att
		{
			get;
			set;
		}

		[XmlElement("connectionrate")]
		public string Connectionrate
		{
			get;
			set;
		}

		[XmlElement("curragentsloggedin")]
		public string Curragentsloggedin
		{
			get;
			set;
		}

		[XmlElement("curragenttalking")]
		public string Curragenttalking
		{
			get;
			set;
		}

		[XmlElement("currentnotreadyagents")]
		public string Currentnotreadyagents
		{
			get;
			set;
		}

		[XmlElement("currentreadyagents")]
		public string Currentreadyagents
		{
			get;
			set;
		}

		[XmlElement("currnumberwaitingcalls")]
		public string Currnumberwaitingcalls
		{
			get;
			set;
		}

		[XmlElement("endkey")]
		public string Endkey
		{
			get;
			set;
		}

		[XmlElement("startkey")]
		public string Startkey
		{
			get;
			set;
		}

		[XmlElement("visitorinflow")]
		public string Visitorinflow
		{
			get;
			set;
		}

		[XmlElement("visitorresponse")]
		public string Visitorresponse
		{
			get;
			set;
		}

		[XmlElement("visitorresponsetransfer")]
		public string Visitorresponsetransfer
		{
			get;
			set;
		}
	}
}
