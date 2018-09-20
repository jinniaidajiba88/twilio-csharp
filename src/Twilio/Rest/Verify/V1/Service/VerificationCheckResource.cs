/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// VerificationCheckResource
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

namespace Twilio.Rest.Verify.V1.Service 
{

    public class VerificationCheckResource : Resource 
    {
        public sealed class ChannelEnum : StringEnum 
        {
            private ChannelEnum(string value) : base(value) {}
            public ChannelEnum() {}
            public static implicit operator ChannelEnum(string value)
            {
                return new ChannelEnum(value);
            }

            public static readonly ChannelEnum Sms = new ChannelEnum("sms");
            public static readonly ChannelEnum Call = new ChannelEnum("call");
        }

        private static Request BuildCreateRequest(CreateVerificationCheckOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v1/Services/" + options.PathServiceSid + "/VerificationCheck",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// challenge a specific Verification Check.
        /// </summary>
        /// <param name="options"> Create VerificationCheck parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationCheck </returns> 
        public static VerificationCheckResource Create(CreateVerificationCheckOptions options, 
                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// challenge a specific Verification Check.
        /// </summary>
        /// <param name="options"> Create VerificationCheck parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationCheck </returns> 
        public static async System.Threading.Tasks.Task<VerificationCheckResource> CreateAsync(CreateVerificationCheckOptions options, 
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// challenge a specific Verification Check.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Verify Service to be used to check a verification. </param>
        /// <param name="code"> The verification string </param>
        /// <param name="to"> To phonenumber </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationCheck </returns> 
        public static VerificationCheckResource Create(string pathServiceSid, 
                                                       string code, 
                                                       string to = null, 
                                                       ITwilioRestClient client = null)
        {
            var options = new CreateVerificationCheckOptions(pathServiceSid, code){To = to};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// challenge a specific Verification Check.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Verify Service to be used to check a verification. </param>
        /// <param name="code"> The verification string </param>
        /// <param name="to"> To phonenumber </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationCheck </returns> 
        public static async System.Threading.Tasks.Task<VerificationCheckResource> CreateAsync(string pathServiceSid, 
                                                                                               string code, 
                                                                                               string to = null, 
                                                                                               ITwilioRestClient client = null)
        {
            var options = new CreateVerificationCheckOptions(pathServiceSid, code){To = to};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a VerificationCheckResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VerificationCheckResource object represented by the provided JSON </returns> 
        public static VerificationCheckResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<VerificationCheckResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Verification Check.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// To phonenumber
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// sms or call
        /// </summary>
        [JsonProperty("channel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public VerificationCheckResource.ChannelEnum Channel { get; private set; }
        /// <summary>
        /// pending, approved, denied or expired
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// successful verification
        /// </summary>
        [JsonProperty("valid")]
        public bool? Valid { get; private set; }
        /// <summary>
        /// The date this Verification Check was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Verification Check was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        private VerificationCheckResource()
        {

        }
    }

}