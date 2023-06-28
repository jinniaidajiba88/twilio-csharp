/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Insights.V1
{
    /// <summary> Get the Voice Insights Settings. </summary>
    public class FetchSettingOptions : IOptions<SettingResource>
    {
    
        ///<summary> The unique SID identifier of the Subaccount. </summary> 
        public string SubaccountSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (SubaccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SubaccountSid", SubaccountSid));
            }
            return p;
        }
        

    }


    /// <summary> Update a specific Voice Insights Setting. </summary>
    public class UpdateSettingOptions : IOptions<SettingResource>
    {
    
        ///<summary> A boolean flag to enable Advanced Features for Voice Insights. </summary> 
        public bool? AdvancedFeatures { get; set; }

        ///<summary> A boolean flag to enable Voice Trace. </summary> 
        public bool? VoiceTrace { get; set; }

        ///<summary> The unique SID identifier of the Subaccount. </summary> 
        public string SubaccountSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
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
                p.Add(new KeyValuePair<string, string>("SubaccountSid", SubaccountSid));
            }
            return p;
        }
        

    }


}

