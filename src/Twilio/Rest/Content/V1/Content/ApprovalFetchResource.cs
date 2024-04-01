/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Content
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Content.V1.Content
{
    public class ApprovalFetchResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchApprovalFetchOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Content/{ContentSid}/ApprovalRequests";

            string PathContentSid = options.PathContentSid;
            path = path.Replace("{"+"ContentSid"+"}", PathContentSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Content,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Content resource's approval status by its unique Content Sid </summary>
        /// <param name="options"> Fetch ApprovalFetch parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ApprovalFetch </returns>
        public static ApprovalFetchResource Fetch(FetchApprovalFetchOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a Content resource's approval status by its unique Content Sid </summary>
        /// <param name="options"> Fetch ApprovalFetch parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ApprovalFetch </returns>
        public static async System.Threading.Tasks.Task<ApprovalFetchResource> FetchAsync(FetchApprovalFetchOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a Content resource's approval status by its unique Content Sid </summary>
        /// <param name="pathContentSid"> The Twilio-provided string that uniquely identifies the Content resource whose approval information to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ApprovalFetch </returns>
        public static ApprovalFetchResource Fetch(
                                         string pathContentSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchApprovalFetchOptions(pathContentSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a Content resource's approval status by its unique Content Sid </summary>
        /// <param name="pathContentSid"> The Twilio-provided string that uniquely identifies the Content resource whose approval information to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ApprovalFetch </returns>
        public static async System.Threading.Tasks.Task<ApprovalFetchResource> FetchAsync(string pathContentSid, ITwilioRestClient client = null)
        {
            var options = new FetchApprovalFetchOptions(pathContentSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ApprovalFetchResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ApprovalFetchResource object represented by the provided JSON </returns>
        public static ApprovalFetchResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ApprovalFetchResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The unique string that that we created to identify the Content resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/usage/api/account) that created Content resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Contains the whatsapp approval information for the Content resource, with fields such as approval status, rejection reason, and category, amongst others. </summary> 
        [JsonProperty("whatsapp")]
        public object Whatsapp { get; private set; }

        ///<summary> The URL of the resource, relative to `https://content.twilio.com`. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ApprovalFetchResource() {

        }
    }
}

