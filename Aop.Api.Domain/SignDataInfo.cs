using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignDataInfo : AopObject
	{
		[XmlElement("data_id")]
		public string DataId
		{
			get;
			set;
		}

		[XmlElement("data_name")]
		public string DataName
		{
			get;
			set;
		}

		[XmlElement("data_type")]
		public string DataType
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

		[XmlElement("oss_file_id")]
		public string OssFileId
		{
			get;
			set;
		}

		[XmlElement("preview_url")]
		public string PreviewUrl
		{
			get;
			set;
		}

		[XmlArray("signature_list")]
		[XmlArrayItem("file_signature")]
		public List<FileSignature> SignatureList
		{
			get;
			set;
		}

		[XmlElement("source_data")]
		public string SourceData
		{
			get;
			set;
		}
	}
}
