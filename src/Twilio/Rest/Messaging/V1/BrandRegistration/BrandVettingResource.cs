/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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
using Twilio.Types;


namespace Twilio.Rest.Messaging.V1.BrandRegistration
{
    public class BrandVettingResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class VettingProviderEnum : StringEnum
        {
            private VettingProviderEnum(string value) : base(value) {}
            public VettingProviderEnum() {}
            public static implicit operator VettingProviderEnum(string value)
            {
                return new VettingProviderEnum(value);
            }
            public static readonly VettingProviderEnum CampaignVerify = new VettingProviderEnum("campaign-verify");

        }

        
        private static Request BuildCreateRequest(CreateBrandVettingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/a2p/BrandRegistrations/{BrandSid}/Vettings";

            string PathBrandSid = options.PathBrandSid;
            path = path.Replace("{"+"BrandSid"+"}", PathBrandSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Create(CreateBrandVettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> CreateAsync(CreateBrandVettingOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to create . </param>
        /// <param name="vettingProvider">  </param>
        /// <param name="vettingId"> The unique ID of the vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Create(
                                          string pathBrandSid,
                                          BrandVettingResource.VettingProviderEnum vettingProvider,
                                          string vettingId = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBrandVettingOptions(pathBrandSid, vettingProvider){  VettingId = vettingId };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to create . </param>
        /// <param name="vettingProvider">  </param>
        /// <param name="vettingId"> The unique ID of the vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> CreateAsync(
                                                                                  string pathBrandSid,
                                                                                  BrandVettingResource.VettingProviderEnum vettingProvider,
                                                                                  string vettingId = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBrandVettingOptions(pathBrandSid, vettingProvider){  VettingId = vettingId };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBrandVettingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/a2p/BrandRegistrations/{BrandSid}/Vettings/{BrandVettingSid}";

            string PathBrandSid = options.PathBrandSid;
            path = path.Replace("{"+"BrandSid"+"}", PathBrandSid);
            string PathBrandVettingSid = options.PathBrandVettingSid;
            path = path.Replace("{"+"BrandVettingSid"+"}", PathBrandVettingSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Fetch(FetchBrandVettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> FetchAsync(FetchBrandVettingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        /// <param name="pathBrandVettingSid"> The Twilio SID of the third-party vetting record. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Fetch(
                                         string pathBrandSid, 
                                         string pathBrandVettingSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBrandVettingOptions(pathBrandSid, pathBrandVettingSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        /// <param name="pathBrandVettingSid"> The Twilio SID of the third-party vetting record. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> FetchAsync(string pathBrandSid, string pathBrandVettingSid, ITwilioRestClient client = null)
        {
            var options = new FetchBrandVettingOptions(pathBrandSid, pathBrandVettingSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadBrandVettingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/a2p/BrandRegistrations/{BrandSid}/Vettings";

            string PathBrandSid = options.PathBrandSid;
            path = path.Replace("{"+"BrandSid"+"}", PathBrandSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static ResourceSet<BrandVettingResource> Read(ReadBrandVettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BrandVettingResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandVettingResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandVettingResource>> ReadAsync(ReadBrandVettingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BrandVettingResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandVettingResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        /// <param name="vettingProvider"> The third-party provider of the vettings to read </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static ResourceSet<BrandVettingResource> Read(
                                                     string pathBrandSid,
                                                     BrandVettingResource.VettingProviderEnum vettingProvider = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBrandVettingOptions(pathBrandSid){ VettingProvider = vettingProvider, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        /// <param name="vettingProvider"> The third-party provider of the vettings to read </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandVettingResource>> ReadAsync(
                                                                                             string pathBrandSid,
                                                                                             BrandVettingResource.VettingProviderEnum vettingProvider = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBrandVettingOptions(pathBrandSid){ VettingProvider = vettingProvider, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BrandVettingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BrandVettingResource> NextPage(Page<BrandVettingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BrandVettingResource> PreviousPage(Page<BrandVettingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a BrandVettingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandVettingResource object represented by the provided JSON </returns>
        public static BrandVettingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BrandVettingResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the vetting record. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string to identify Brand Registration. </summary> 
        [JsonProperty("brand_sid")]
        public string BrandSid { get; private set; }

        ///<summary> The Twilio SID of the third-party vetting record. </summary> 
        [JsonProperty("brand_vetting_sid")]
        public string BrandVettingSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The unique identifier of the vetting from the third-party provider. </summary> 
        [JsonProperty("vetting_id")]
        public string VettingId { get; private set; }

        ///<summary> The type of vetting that has been conducted. One of “STANDARD” (Aegis) or “POLITICAL” (Campaign Verify). </summary> 
        [JsonProperty("vetting_class")]
        public string VettingClass { get; private set; }

        ///<summary> The status of the import vetting attempt. One of “PENDING,” “SUCCESS,” or “FAILED”. </summary> 
        [JsonProperty("vetting_status")]
        public string VettingStatus { get; private set; }

        
        [JsonProperty("vetting_provider")]
        public BrandVettingResource.VettingProviderEnum VettingProvider { get; private set; }

        ///<summary> The absolute URL of the Brand Vetting resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private BrandVettingResource() {

        }
    }
}

