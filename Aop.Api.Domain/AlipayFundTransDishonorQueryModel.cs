using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransDishonorQueryModel : AopObject
	{
		[XmlElement("dishonor_begin")]
		public string DishonorBegin
		{
			get;
			set;
		}

		[XmlElement("dishonor_end")]
		public string DishonorEnd
		{
			get;
			set;
		}

		[XmlElement("page")]
		public string Page
		{
			get;
			set;
		}
	}
}
