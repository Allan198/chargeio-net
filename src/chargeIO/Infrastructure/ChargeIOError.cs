﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChargeIO
{
	public class ChargeIOError
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("level")]
		public string Level { get; set; }

		[JsonProperty("context")]
		public string Context { get; set; }

    	[JsonProperty("sub_code")]
		public string SubCode { get; set; }
	}
}