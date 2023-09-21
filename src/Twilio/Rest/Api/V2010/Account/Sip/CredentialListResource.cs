/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account.Sip
{
    public class CredentialListResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateCredentialListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a Credential List </summary>
        /// <param name="options"> Create CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Create(CreateCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a Credential List </summary>
        /// <param name="options"> Create CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> CreateAsync(CreateCredentialListOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a Credential List </summary>
        /// <param name="friendlyName"> A human readable descriptive text that describes the CredentialList, up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Create(
                                          string friendlyName,
                                          string pathAccountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateCredentialListOptions(friendlyName){  PathAccountSid = pathAccountSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a Credential List </summary>
        /// <param name="friendlyName"> A human readable descriptive text that describes the CredentialList, up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string pathAccountSid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateCredentialListOptions(friendlyName){  PathAccountSid = pathAccountSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a Credential List </summary>
        /// <param name="options"> Delete CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        private static Request BuildDeleteRequest(DeleteCredentialListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a Credential List </summary>
        /// <param name="options"> Delete CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static bool Delete(DeleteCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a Credential List </summary>
        /// <param name="options"> Delete CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialListOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListOptions(pathSid)      { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListOptions(pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCredentialListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Get a Credential List </summary>
        /// <param name="options"> Fetch CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Fetch(FetchCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Get a Credential List </summary>
        /// <param name="options"> Fetch CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> FetchAsync(FetchCredentialListOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Get a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Fetch(
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListOptions(pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Get a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListOptions(pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCredentialListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Get All Credential Lists </summary>
        /// <param name="options"> Read CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static ResourceSet<CredentialListResource> Read(ReadCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CredentialListResource>.FromJson("credential_lists", response.Content);
            return new ResourceSet<CredentialListResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Get All Credential Lists </summary>
        /// <param name="options"> Read CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListResource>> ReadAsync(ReadCredentialListOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialListResource>.FromJson("credential_lists", response.Content);
            return new ResourceSet<CredentialListResource>(page, options, client);
        }
        #endif
        /// <summary> Get All Credential Lists </summary>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static ResourceSet<CredentialListResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Get All Credential Lists </summary>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CredentialListResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CredentialListResource> NextPage(Page<CredentialListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CredentialListResource> PreviousPage(Page<CredentialListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateCredentialListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a Credential List </summary>
        /// <param name="options"> Update CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Update(UpdateCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a Credential List </summary>
        /// <param name="options"> Update CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<CredentialListResource> UpdateAsync(UpdateCredentialListOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="friendlyName"> A human readable descriptive text for a CredentialList, up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Update(
                                          string pathSid,
                                          string friendlyName,
                                          string pathAccountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialListOptions(pathSid, friendlyName){ PathAccountSid = pathAccountSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a Credential List </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="friendlyName"> A human readable descriptive text for a CredentialList, up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName,
                                                                              string pathAccountSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialListOptions(pathSid, friendlyName){ PathAccountSid = pathAccountSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a CredentialListResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialListResource object represented by the provided JSON </returns>
        public static CredentialListResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CredentialListResource>(json);
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

    
        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) that owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date that this resource was created, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> A human readable descriptive text that describes the CredentialList, up to 64 characters long. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A list of credentials associated with this credential list. </summary> 
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        ///<summary> The URI for this resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private CredentialListResource() {

        }
    }
}

