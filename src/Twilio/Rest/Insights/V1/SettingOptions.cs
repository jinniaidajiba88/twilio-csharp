/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Insights.V1
{

    /// <summary>
    /// FetchSettingOptions
    /// </summary>
    public class FetchSettingOptions : IOptions<SettingResource>
    {
        /// <summary>
        /// The subaccount_sid
        /// </summary>
        public string SubaccountSid { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (SubaccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SubaccountSid", SubaccountSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateSettingOptions
    /// </summary>
    public class UpdateSettingOptions : IOptions<SettingResource>
    {
        /// <summary>
        /// The advanced_features
        /// </summary>
        public bool? AdvancedFeatures { get; set; }
        /// <summary>
        /// The voice_trace
        /// </summary>
        public bool? VoiceTrace { get; set; }
        /// <summary>
        /// The subaccount_sid
        /// </summary>
        public string SubaccountSid { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AdvancedFeatures != null)
            {
                p.Add(new KeyValuePair<string, string>("AdvancedFeatures", AdvancedFeatures.Value.ToString().ToLower()));
            }

            if (VoiceTrace != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceTrace", VoiceTrace.Value.ToString().ToLower()));
            }

            if (SubaccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SubaccountSid", SubaccountSid.ToString()));
            }

            return p;
        }
    }

}