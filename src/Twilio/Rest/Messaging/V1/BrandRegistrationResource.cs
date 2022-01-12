/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// BrandRegistrationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Messaging.V1
{

    public class BrandRegistrationResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Pending = new StatusEnum("PENDING");
            public static readonly StatusEnum Approved = new StatusEnum("APPROVED");
            public static readonly StatusEnum Failed = new StatusEnum("FAILED");
            public static readonly StatusEnum InReview = new StatusEnum("IN_REVIEW");
            public static readonly StatusEnum Deleted = new StatusEnum("DELETED");
        }

        public sealed class IdentityStatusEnum : StringEnum
        {
            private IdentityStatusEnum(string value) : base(value) {}
            public IdentityStatusEnum() {}
            public static implicit operator IdentityStatusEnum(string value)
            {
                return new IdentityStatusEnum(value);
            }

            public static readonly IdentityStatusEnum SelfDeclared = new IdentityStatusEnum("SELF_DECLARED");
            public static readonly IdentityStatusEnum Unverified = new IdentityStatusEnum("UNVERIFIED");
            public static readonly IdentityStatusEnum Verified = new IdentityStatusEnum("VERIFIED");
            public static readonly IdentityStatusEnum VettedVerified = new IdentityStatusEnum("VETTED_VERIFIED");
        }

        public sealed class BrandFeedbackEnum : StringEnum
        {
            private BrandFeedbackEnum(string value) : base(value) {}
            public BrandFeedbackEnum() {}
            public static implicit operator BrandFeedbackEnum(string value)
            {
                return new BrandFeedbackEnum(value);
            }

            public static readonly BrandFeedbackEnum TaxId = new BrandFeedbackEnum("TAX_ID");
            public static readonly BrandFeedbackEnum StockSymbol = new BrandFeedbackEnum("STOCK_SYMBOL");
            public static readonly BrandFeedbackEnum Nonprofit = new BrandFeedbackEnum("NONPROFIT");
            public static readonly BrandFeedbackEnum GovernmentEntity = new BrandFeedbackEnum("GOVERNMENT_ENTITY");
            public static readonly BrandFeedbackEnum Others = new BrandFeedbackEnum("OTHERS");
        }

        private static Request BuildFetchRequest(FetchBrandRegistrationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Fetch(FetchBrandRegistrationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> FetchAsync(FetchBrandRegistrationOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBrandRegistrationOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> FetchAsync(string pathSid,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new FetchBrandRegistrationOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadBrandRegistrationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static ResourceSet<BrandRegistrationResource> Read(ReadBrandRegistrationOptions options,
                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<BrandRegistrationResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandRegistrationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandRegistrationResource>> ReadAsync(ReadBrandRegistrationOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BrandRegistrationResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandRegistrationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static ResourceSet<BrandRegistrationResource> Read(int? pageSize = null,
                                                                  long? limit = null,
                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadBrandRegistrationOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandRegistrationResource>> ReadAsync(int? pageSize = null,
                                                                                                          long? limit = null,
                                                                                                          ITwilioRestClient client = null)
        {
            var options = new ReadBrandRegistrationOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BrandRegistrationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BrandRegistrationResource>.FromJson("data", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BrandRegistrationResource> NextPage(Page<BrandRegistrationResource> page,
                                                               ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<BrandRegistrationResource>.FromJson("data", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BrandRegistrationResource> PreviousPage(Page<BrandRegistrationResource> page,
                                                                   ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<BrandRegistrationResource>.FromJson("data", response.Content);
        }

        private static Request BuildCreateRequest(CreateBrandRegistrationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Create(CreateBrandRegistrationOptions options,
                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> CreateAsync(CreateBrandRegistrationOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="customerProfileBundleSid"> Customer Profile Bundle Sid </param>
        /// <param name="a2PProfileBundleSid"> A2P Messaging Profile Bundle Sid </param>
        /// <param name="brandType"> Type of brand being created. One of: "STANDARD", "STARTER". </param>
        /// <param name="mock"> A boolean that specifies whether brand should be a mock or not. If true, brand will be
        ///            registered as a mock brand. Defaults to false if no value is provided. </param>
        /// <param name="skipAutomaticSecVet"> Skip Automatic Secondary Vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Create(string customerProfileBundleSid,
                                                       string a2PProfileBundleSid,
                                                       string brandType = null,
                                                       bool? mock = null,
                                                       bool? skipAutomaticSecVet = null,
                                                       ITwilioRestClient client = null)
        {
            var options = new CreateBrandRegistrationOptions(customerProfileBundleSid, a2PProfileBundleSid){BrandType = brandType, Mock = mock, SkipAutomaticSecVet = skipAutomaticSecVet};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="customerProfileBundleSid"> Customer Profile Bundle Sid </param>
        /// <param name="a2PProfileBundleSid"> A2P Messaging Profile Bundle Sid </param>
        /// <param name="brandType"> Type of brand being created. One of: "STANDARD", "STARTER". </param>
        /// <param name="mock"> A boolean that specifies whether brand should be a mock or not. If true, brand will be
        ///            registered as a mock brand. Defaults to false if no value is provided. </param>
        /// <param name="skipAutomaticSecVet"> Skip Automatic Secondary Vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> CreateAsync(string customerProfileBundleSid,
                                                                                               string a2PProfileBundleSid,
                                                                                               string brandType = null,
                                                                                               bool? mock = null,
                                                                                               bool? skipAutomaticSecVet = null,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new CreateBrandRegistrationOptions(customerProfileBundleSid, a2PProfileBundleSid){BrandType = brandType, Mock = mock, SkipAutomaticSecVet = skipAutomaticSecVet};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateBrandRegistrationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Update(UpdateBrandRegistrationOptions options,
                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update BrandRegistration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> UpdateAsync(UpdateBrandRegistrationOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistration </returns>
        public static BrandRegistrationResource Update(string pathSid, ITwilioRestClient client = null)
        {
            var options = new UpdateBrandRegistrationOptions(pathSid);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistration </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationResource> UpdateAsync(string pathSid,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new UpdateBrandRegistrationOptions(pathSid);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BrandRegistrationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandRegistrationResource object represented by the provided JSON </returns>
        public static BrandRegistrationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BrandRegistrationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A2P BrandRegistration Sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A2P Messaging Profile Bundle BundleSid
        /// </summary>
        [JsonProperty("customer_profile_bundle_sid")]
        public string CustomerProfileBundleSid { get; private set; }
        /// <summary>
        /// A2P Messaging Profile Bundle BundleSid
        /// </summary>
        [JsonProperty("a2p_profile_bundle_sid")]
        public string A2PProfileBundleSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Type of brand. One of: "STANDARD", "STARTER".
        /// </summary>
        [JsonProperty("brand_type")]
        public string BrandType { get; private set; }
        /// <summary>
        /// Brand Registration status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BrandRegistrationResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// Campaign Registry (TCR) Brand ID
        /// </summary>
        [JsonProperty("tcr_id")]
        public string TcrId { get; private set; }
        /// <summary>
        /// A reason why brand registration has failed
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason { get; private set; }
        /// <summary>
        /// The absolute URL of the Brand Registration
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Brand score
        /// </summary>
        [JsonProperty("brand_score")]
        public int? BrandScore { get; private set; }
        /// <summary>
        /// Brand feedback
        /// </summary>
        [JsonProperty("brand_feedback")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<BrandRegistrationResource.BrandFeedbackEnum> BrandFeedback { get; private set; }
        /// <summary>
        /// Identity Status
        /// </summary>
        [JsonProperty("identity_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BrandRegistrationResource.IdentityStatusEnum IdentityStatus { get; private set; }
        /// <summary>
        /// Russell 3000
        /// </summary>
        [JsonProperty("russell_3000")]
        public bool? Russell3000 { get; private set; }
        /// <summary>
        /// Tax Exempt Status
        /// </summary>
        [JsonProperty("tax_exempt_status")]
        public string TaxExemptStatus { get; private set; }
        /// <summary>
        /// Skip Automatic Secondary Vetting
        /// </summary>
        [JsonProperty("skip_automatic_sec_vet")]
        public bool? SkipAutomaticSecVet { get; private set; }
        /// <summary>
        /// A boolean that specifies whether brand should be a mock or not. If true, brand will be registered as a mock brand. Defaults to false if no value is provided.
        /// </summary>
        [JsonProperty("mock")]
        public bool? Mock { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private BrandRegistrationResource()
        {

        }
    }

}