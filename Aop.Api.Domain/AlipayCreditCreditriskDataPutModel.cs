using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditCreditriskDataPutModel : AopObject
	{
		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("dataorgid")]
		public string Dataorgid
		{
			get;
			set;
		}

		[XmlElement("dataprovider")]
		public string Dataprovider
		{
			get;
			set;
		}

		[XmlElement("entitycode")]
		public string Entitycode
		{
			get;
			set;
		}

		[XmlElement("entityname")]
		public string Entityname
		{
			get;
			set;
		}

		[XmlElement("entitytype")]
		public string Entitytype
		{
			get;
			set;
		}

		[XmlElement("objectcontent")]
		public string Objectcontent
		{
			get;
			set;
		}
	}
}
