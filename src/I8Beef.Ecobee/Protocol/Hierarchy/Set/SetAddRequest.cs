﻿using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SetAddRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/set"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "add".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "add"; } }

        /// <summary>
        /// The name of the new set.
        /// </summary>
        [JsonProperty(PropertyName = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The path to the parent for the new set.
        /// </summary>
        [JsonProperty(PropertyName = "parentPath")]
        public string ParentPath { get; set; }
    }
}
