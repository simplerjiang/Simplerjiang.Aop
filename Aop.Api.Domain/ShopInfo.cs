using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopInfo : AopObject
	{
		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlArray("shop_scene_pic")]
		[XmlArrayItem("string")]
		public List<string> ShopScenePic
		{
			get;
			set;
		}

		[XmlElement("shop_sign_board_pic")]
		public string ShopSignBoardPic
		{
			get;
			set;
		}
	}
}
