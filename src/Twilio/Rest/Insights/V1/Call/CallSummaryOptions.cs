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




namespace Twilio.Rest.Insights.V1.Call
{
    /// <summary> Get a specific Call Summary. </summary>
    public class FetchCallSummaryOptions : IOptions<CallSummaryResource>
    {
    
        ///<summary> The unique SID identifier of the Call. </summary> 
        public string PathCallSid { get; }

        ///<summary> The Processing State of this Call Summary. One of `complete`, `partial` or `all`. </summary> 
        public CallSummaryResource.ProcessingStateEnum ProcessingState { get; set; }



        /// <summary> Construct a new FetchSummaryOptions </summary>
        /// <param name="pathCallSid"> The unique SID identifier of the Call. </param>
        public FetchCallSummaryOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ProcessingState != null)
            {
                p.Add(new KeyValuePair<string, string>("ProcessingState", ProcessingState.ToString()));
            }
            return p;
        }
        

    }


}

