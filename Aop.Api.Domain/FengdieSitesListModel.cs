using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSitesListModel : AopObject
	{
		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}

		[XmlElement("is_online")]
		public bool IsOnline
		{
			get;
			set;
		}

		[XmlElement("offline_time")]
		public string OfflineTime
		{
			get;
			set;
		}

		[XmlElement("owner")]
		public FengdieSitesOwner Owner
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("template_name")]
		public string TemplateName
		{
			get;
			set;
		}

		[XmlElement("template_version")]
		public string TemplateVersion
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
