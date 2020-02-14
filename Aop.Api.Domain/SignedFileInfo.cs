using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignedFileInfo : AopObject
	{
		[XmlElement("expired_time")]
		public string ExpiredTime
		{
			get;
			set;
		}

		[XmlElement("file_name")]
		public string FileName
		{
			get;
			set;
		}

		[XmlElement("file_type")]
		public string FileType
		{
			get;
			set;
		}

		[XmlElement("file_url")]
		public string FileUrl
		{
			get;
			set;
		}

		[XmlElement("gmt_time")]
		public string GmtTime
		{
			get;
			set;
		}

		[XmlElement("inner_data_id")]
		public string InnerDataId
		{
			get;
			set;
		}

		[XmlElement("out_data_id")]
		public string OutDataId
		{
			get;
			set;
		}

		[XmlElement("signed_data")]
		public string SignedData
		{
			get;
			set;
		}

		[XmlElement("source_type")]
		public string SourceType
		{
			get;
			set;
		}
	}
}
