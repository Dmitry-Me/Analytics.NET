﻿using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Segment.Model
{
    public class Identify : BaseAction
    {

		[JsonProperty(PropertyName = "type")]
		private string Type = "identify";
		
		[JsonProperty(PropertyName = "userId")]
		public string UserId { get; private set; }

        [JsonProperty(PropertyName = "traits")]
        private Traits Traits { get; set; }

        internal Identify(string userId,
		                  Traits traits, 
						  Options options, 
		                  DateTime? timestamp)
	
			: base(timestamp, options)
        {
			this.UserId = userId;
            this.Traits = traits ?? new Traits();
        }

		public override string GetType()
        {
			return Type;
        }
    }
}
