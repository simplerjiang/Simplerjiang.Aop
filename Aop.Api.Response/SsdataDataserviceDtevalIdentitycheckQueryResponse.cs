using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceDtevalIdentitycheckQueryResponse : AopResponse
	{
		[XmlElement("evidence")]
		public string Evidence
		{
			get;
			set;
		}

		[XmlElement("ext_map")]
		public string ExtMap
		{
			get;
			set;
		}

		[XmlElement("id_card_no_match_flag")]
		public string IdCardNoMatchFlag
		{
			get;
			set;
		}

		[XmlElement("name_match_flag")]
		public string NameMatchFlag
		{
			get;
			set;
		}

		[XmlElement("push_ant_data_flag")]
		public string PushAntDataFlag
		{
			get;
			set;
		}
	}
}
