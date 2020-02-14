using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProdRelationVO : AopObject
	{
		[XmlElement("num")]
		public long Num
		{
			get;
			set;
		}

		[XmlElement("num_type")]
		public string NumType
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_rel_code")]
		public string ProdRelCode
		{
			get;
			set;
		}

		[XmlElement("prod_rel_name")]
		public string ProdRelName
		{
			get;
			set;
		}

		[XmlElement("prod_rel_type")]
		public string ProdRelType
		{
			get;
			set;
		}

		[XmlElement("prod_rel_version")]
		public string ProdRelVersion
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
		{
			get;
			set;
		}

		[XmlElement("sub_prod_rel_type")]
		public string SubProdRelType
		{
			get;
			set;
		}
	}
}
