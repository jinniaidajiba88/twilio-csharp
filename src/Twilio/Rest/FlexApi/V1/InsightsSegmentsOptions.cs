/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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




namespace Twilio.Rest.FlexApi.V1
{
    /// <summary> To get the Segments of an Account </summary>
    public class FetchInsightsSegmentsOptions : IOptions<InsightsSegmentsResource>
    {
    
        ///<summary> To unique id of the segment </summary> 
        public string PathSegmentId { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }



        /// <summary> Construct a new FetchInsightsSegmentsOptions </summary>
        /// <param name="pathSegmentId"> To unique id of the segment </param>
        public FetchInsightsSegmentsOptions(string pathSegmentId)
        {
            PathSegmentId = pathSegmentId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }


}

