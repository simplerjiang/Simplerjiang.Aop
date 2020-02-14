using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertDocDrivingLicense : AopObject
	{
		[XmlElement("clazz")]
		public string Clazz
		{
			get;
			set;
		}

		[XmlElement("driving_license_no")]
		public string DrivingLicenseNo
		{
			get;
			set;
		}

		[XmlElement("encoded_img_main")]
		public string EncodedImgMain
		{
			get;
			set;
		}

		[XmlElement("encoded_img_vice")]
		public string EncodedImgVice
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("file_no")]
		public string FileNo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("valide_date")]
		public string ValideDate
		{
			get;
			set;
		}
	}
}
