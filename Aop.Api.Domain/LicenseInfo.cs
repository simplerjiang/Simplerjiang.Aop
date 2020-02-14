using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LicenseInfo : AopObject
	{
		[XmlElement("agency")]
		public string Agency
		{
			get;
			set;
		}

		[XmlElement("gmt_expire")]
		public string GmtExpire
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("license_id")]
		public string LicenseId
		{
			get;
			set;
		}

		[XmlElement("license_name")]
		public string LicenseName
		{
			get;
			set;
		}

		[XmlElement("pic_url")]
		public string PicUrl
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("sequence")]
		public string Sequence
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
