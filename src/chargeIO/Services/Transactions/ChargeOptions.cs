﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChargeIO
{
    public class ChargeOptions
    {
        [JsonProperty("amount")]
        public int? AmountInCents { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("auto_capture")]
        public bool AutoCapture { get; set; }

        [JsonProperty("gratuity")]
        public int? GratuityInCents { get; set; }

        [JsonProperty("signature")]
        public TransactionSignature Signature { get; set; }
        
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("method")]
        public IPaymentMethod Method { get; set; }
    }
}
