using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertDocVehicleLicense : AopObject
	{
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

		[XmlElement("engine_no")]
		public string EngineNo
		{
			get;
			set;
		}

		[XmlElement("issue_date")]
		public string IssueDate
		{
			get;
			set;
		}

		[XmlElement("model")]
		public string Model
		{
			get;
			set;
		}

		[XmlElement("owner")]
		public string Owner
		{
			get;
			set;
		}

		[XmlElement("plate_no")]
		public string PlateNo
		{
			get;
			set;
		}

		[XmlElement("register_date")]
		public string RegisterDate
		{
			get;
			set;
		}

		[XmlElement("vin")]
		public string Vin
		{
			get;
			set;
		}
	}
}
