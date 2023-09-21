/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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


namespace Twilio.Rest.Trusthub.V1
{
    public class SupportingDocumentResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum PendingReview = new StatusEnum("pending-review");
            public static readonly StatusEnum Rejected = new StatusEnum("rejected");
            public static readonly StatusEnum Approved = new StatusEnum("approved");
            public static readonly StatusEnum Expired = new StatusEnum("expired");
            public static readonly StatusEnum ProvisionallyApproved = new StatusEnum("provisionally-approved");

        }

        
        private static Request BuildCreateRequest(CreateSupportingDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SupportingDocuments";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Supporting Document. </summary>
        /// <param name="options"> Create SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Create(CreateSupportingDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Supporting Document. </summary>
        /// <param name="options"> Create SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> CreateAsync(CreateSupportingDocumentOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Supporting Document. </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="type"> The type of the Supporting Document. </param>
        /// <param name="attributes"> The set of parameters that are the attributes of the Supporting Documents resource which are derived Supporting Document Types. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Create(
                                          string friendlyName,
                                          string type,
                                          object attributes = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateSupportingDocumentOptions(friendlyName, type){  Attributes = attributes };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Supporting Document. </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="type"> The type of the Supporting Document. </param>
        /// <param name="attributes"> The set of parameters that are the attributes of the Supporting Documents resource which are derived Supporting Document Types. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string type,
                                                                                  object attributes = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateSupportingDocumentOptions(friendlyName, type){  Attributes = attributes };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Supporting Document. </summary>
        /// <param name="options"> Delete SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        private static Request BuildDeleteRequest(DeleteSupportingDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SupportingDocuments/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Supporting Document. </summary>
        /// <param name="options"> Delete SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static bool Delete(DeleteSupportingDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Supporting Document. </summary>
        /// <param name="options"> Delete SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSupportingDocumentOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Supporting Document. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSupportingDocumentOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Supporting Document. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSupportingDocumentOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchSupportingDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SupportingDocuments/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch specific Supporting Document Instance. </summary>
        /// <param name="options"> Fetch SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Fetch(FetchSupportingDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch specific Supporting Document Instance. </summary>
        /// <param name="options"> Fetch SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> FetchAsync(FetchSupportingDocumentOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch specific Supporting Document Instance. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSupportingDocumentOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch specific Supporting Document Instance. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSupportingDocumentOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadSupportingDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SupportingDocuments";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Supporting Document for an account. </summary>
        /// <param name="options"> Read SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static ResourceSet<SupportingDocumentResource> Read(ReadSupportingDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SupportingDocumentResource>.FromJson("results", response.Content);
            return new ResourceSet<SupportingDocumentResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Supporting Document for an account. </summary>
        /// <param name="options"> Read SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SupportingDocumentResource>> ReadAsync(ReadSupportingDocumentOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SupportingDocumentResource>.FromJson("results", response.Content);
            return new ResourceSet<SupportingDocumentResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Supporting Document for an account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static ResourceSet<SupportingDocumentResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSupportingDocumentOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Supporting Document for an account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SupportingDocumentResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSupportingDocumentOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SupportingDocumentResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SupportingDocumentResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SupportingDocumentResource> NextPage(Page<SupportingDocumentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SupportingDocumentResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SupportingDocumentResource> PreviousPage(Page<SupportingDocumentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SupportingDocumentResource>.FromJson("results", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateSupportingDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SupportingDocuments/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an existing Supporting Document. </summary>
        /// <param name="options"> Update SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Update(UpdateSupportingDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing Supporting Document. </summary>
        /// <param name="options"> Update SupportingDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> UpdateAsync(UpdateSupportingDocumentOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an existing Supporting Document. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The set of parameters that are the attributes of the Supporting Document resource which are derived Supporting Document Types. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SupportingDocument </returns>
        public static SupportingDocumentResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          object attributes = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSupportingDocumentOptions(pathSid){ FriendlyName = friendlyName, Attributes = attributes };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an existing Supporting Document. </summary>
        /// <param name="pathSid"> The unique string created by Twilio to identify the Supporting Document resource. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The set of parameters that are the attributes of the Supporting Document resource which are derived Supporting Document Types. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SupportingDocument </returns>
        public static async System.Threading.Tasks.Task<SupportingDocumentResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              object attributes = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSupportingDocumentOptions(pathSid){ FriendlyName = friendlyName, Attributes = attributes };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SupportingDocumentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SupportingDocumentResource object represented by the provided JSON </returns>
        public static SupportingDocumentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SupportingDocumentResource>(json);
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

    
        ///<summary> The unique string created by Twilio to identify the Supporting Document resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Document resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The image type uploaded in the Supporting Document container. </summary> 
        [JsonProperty("mime_type")]
        public string MimeType { get; private set; }

        
        [JsonProperty("status")]
        public SupportingDocumentResource.StatusEnum Status { get; private set; }

        ///<summary> The type of the Supporting Document. </summary> 
        [JsonProperty("type")]
        public string Type { get; private set; }

        ///<summary> The set of parameters that are the attributes of the Supporting Documents resource which are listed in the Supporting Document Types. </summary> 
        [JsonProperty("attributes")]
        public object Attributes { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Supporting Document resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SupportingDocumentResource() {

        }
    }
}

