using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ButtonObject : AopObject
	{
		[XmlElement("action_param")]
		public string ActionParam
		{
			get;
			set;
		}

		[XmlElement("action_type")]
		public string ActionType
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
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

		[XmlArray("sub_button")]
		[XmlArrayItem("sub_button")]
		public List<SubButton> SubButton
		{
			get;
			set;
		}
	}
}
