/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// AssignedAddOnResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber 
{

    public class AssignedAddOnResource : Resource 
    {
        private static Request BuildFetchRequest(FetchAssignedAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of an Add-on installation currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="options"> Fetch AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static AssignedAddOnResource Fetch(FetchAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on installation currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="options"> Fetch AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnResource> FetchAsync(FetchAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of an Add-on installation currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The unique Installed Add-on Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static AssignedAddOnResource Fetch(string pathResourceSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAssignedAddOnOptions(pathResourceSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on installation currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The unique Installed Add-on Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnResource> FetchAsync(string pathResourceSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAssignedAddOnOptions(pathResourceSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAssignedAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of Add-on installations currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="options"> Read AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static ResourceSet<AssignedAddOnResource> Read(ReadAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AssignedAddOnResource>.FromJson("assigned_add_ons", response.Content);
            return new ResourceSet<AssignedAddOnResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-on installations currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="options"> Read AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnResource>> ReadAsync(ReadAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssignedAddOnResource>.FromJson("assigned_add_ons", response.Content);
            return new ResourceSet<AssignedAddOnResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of Add-on installations currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static ResourceSet<AssignedAddOnResource> Read(string pathResourceSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAssignedAddOnOptions(pathResourceSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-on installations currently assigned to this Number.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnResource>> ReadAsync(string pathResourceSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAssignedAddOnOptions(pathResourceSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AssignedAddOnResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssignedAddOnResource>.FromJson("assigned_add_ons", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AssignedAddOnResource> NextPage(Page<AssignedAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssignedAddOnResource>.FromJson("assigned_add_ons", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AssignedAddOnResource> PreviousPage(Page<AssignedAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssignedAddOnResource>.FromJson("assigned_add_ons", response.Content);
        }

        private static Request BuildCreateRequest(CreateAssignedAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Assign an Add-on installation to the Number specified.
        /// </summary>
        ///
        /// <param name="options"> Create AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static AssignedAddOnResource Create(CreateAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Assign an Add-on installation to the Number specified.
        /// </summary>
        ///
        /// <param name="options"> Create AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnResource> CreateAsync(CreateAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Assign an Add-on installation to the Number specified.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="installedAddOnSid"> A string that uniquely identifies the Add-on installation </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static AssignedAddOnResource Create(string pathResourceSid, string installedAddOnSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateAssignedAddOnOptions(pathResourceSid, installedAddOnSid){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Assign an Add-on installation to the Number specified.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="installedAddOnSid"> A string that uniquely identifies the Add-on installation </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnResource> CreateAsync(string pathResourceSid, string installedAddOnSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateAssignedAddOnOptions(pathResourceSid, installedAddOnSid){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAssignedAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Remove the assignment of an Add-on installation from the Number specified.
        /// </summary>
        ///
        /// <param name="options"> Delete AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static bool Delete(DeleteAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Remove the assignment of an Add-on installation from the Number specified.
        /// </summary>
        ///
        /// <param name="options"> Delete AssignedAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAssignedAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Remove the assignment of an Add-on installation from the Number specified.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The Installed Add-on Sid to remove </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOn </returns> 
        public static bool Delete(string pathResourceSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAssignedAddOnOptions(pathResourceSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Remove the assignment of an Add-on installation from the Number specified.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The Installed Add-on Sid to remove </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOn </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathResourceSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAssignedAddOnOptions(pathResourceSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AssignedAddOnResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssignedAddOnResource object represented by the provided JSON </returns> 
        public static AssignedAddOnResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AssignedAddOnResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this assigned Add-on installation
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The Account id that has installed this Add-on
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The Phone Number id that has installed this Add-on
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// A description of this Add-on installation
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A short description of the Add-on functionality
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The JSON object representing the current configuration
        /// </summary>
        [JsonProperty("configuration")]
        public object Configuration { get; private set; }
        /// <summary>
        /// The string that uniquely identifies this Add-on installation
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The date this Add-on was installed
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Add-on installation was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        private AssignedAddOnResource()
        {

        }
    }

}