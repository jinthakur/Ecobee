﻿using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CreateVacationFunction : Function
    {
        public CreateVacationFunction()
        {
            Params = new CreateVacationParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public override string Type { get { return "createVacation"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class CreateVacationParams : FunctionParams
    {
        /// <summary>
        /// The vacation event name. It must be unique.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The temperature to set the cool vacation hold at.
        /// </summary>
        [JsonProperty(PropertyName = "coolHoldTemp")]
        public int CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat vacation hold at.
        /// </summary>
        [JsonProperty(PropertyName = "heatHoldTemp")]
        public int HeatHoldTemp { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The start time in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end date in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The fan mode during the vacation. Values: auto, on Default: auto
        /// </summary>
        [JsonProperty(PropertyName = "fan")]
        public string Fan { get; set; }

        /// <summary>
        /// The minimum number of minutes to run the fan each hour. Range: 0-60, Default: 0
        /// </summary>
        [JsonProperty(PropertyName = "fanMinOnTime")]
        public string FanMinOnTime { get; set; }
    }
}
