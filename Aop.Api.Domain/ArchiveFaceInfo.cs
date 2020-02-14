using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArchiveFaceInfo : AopObject
	{
		[XmlElement("face_image")]
		public string FaceImage
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

		[XmlElement("usable")]
		public bool Usable
		{
			get;
			set;
		}
	}
}
