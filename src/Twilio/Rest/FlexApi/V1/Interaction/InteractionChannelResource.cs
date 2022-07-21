/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// InteractionChannelResource
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

namespace Twilio.Rest.FlexApi.V1.Interaction
{

    public class InteractionChannelResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Close = new StatusEnum("close");
            public static readonly StatusEnum Closed = new StatusEnum("closed");
            public static readonly StatusEnum Wrapup = new StatusEnum("wrapup");
        }

        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }

            public static readonly TypeEnum Voice = new TypeEnum("voice");
            public static readonly TypeEnum Sms = new TypeEnum("sms");
            public static readonly TypeEnum Email = new TypeEnum("email");
            public static readonly TypeEnum Web = new TypeEnum("web");
            public static readonly TypeEnum Whatsapp = new TypeEnum("whatsapp");
            public static readonly TypeEnum Chat = new TypeEnum("chat");
            public static readonly TypeEnum Messenger = new TypeEnum("messenger");
            public static readonly TypeEnum Gbm = new TypeEnum("gbm");
        }

        public sealed class ChannelStatusEnum : StringEnum
        {
            private ChannelStatusEnum(string value) : base(value) {}
            public ChannelStatusEnum() {}
            public static implicit operator ChannelStatusEnum(string value)
            {
                return new ChannelStatusEnum(value);
            }

            public static readonly ChannelStatusEnum Setup = new ChannelStatusEnum("setup");
            public static readonly ChannelStatusEnum Active = new ChannelStatusEnum("active");
            public static readonly ChannelStatusEnum Failed = new ChannelStatusEnum("failed");
            public static readonly ChannelStatusEnum Closed = new ChannelStatusEnum("closed");
        }

        private static Request BuildFetchRequest(FetchInteractionChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/Interactions/" + options.PathInteractionSid + "/Channels/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a Channel for an Interaction.
        /// </summary>
        /// <param name="options"> Fetch InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static InteractionChannelResource Fetch(FetchInteractionChannelOptions options,
                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a Channel for an Interaction.
        /// </summary>
        /// <param name="options"> Fetch InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<InteractionChannelResource> FetchAsync(FetchInteractionChannelOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a Channel for an Interaction.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static InteractionChannelResource Fetch(string pathInteractionSid,
                                                       string pathSid,
                                                       ITwilioRestClient client = null)
        {
            var options = new FetchInteractionChannelOptions(pathInteractionSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a Channel for an Interaction.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<InteractionChannelResource> FetchAsync(string pathInteractionSid,
                                                                                               string pathSid,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new FetchInteractionChannelOptions(pathInteractionSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadInteractionChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/Interactions/" + options.PathInteractionSid + "/Channels",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// List all Channels for an Interaction.
        /// </summary>
        /// <param name="options"> Read InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static ResourceSet<InteractionChannelResource> Read(ReadInteractionChannelOptions options,
                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<InteractionChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<InteractionChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List all Channels for an Interaction.
        /// </summary>
        /// <param name="options"> Read InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InteractionChannelResource>> ReadAsync(ReadInteractionChannelOptions options,
                                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InteractionChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<InteractionChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List all Channels for an Interaction.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static ResourceSet<InteractionChannelResource> Read(string pathInteractionSid,
                                                                   int? pageSize = null,
                                                                   long? limit = null,
                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadInteractionChannelOptions(pathInteractionSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List all Channels for an Interaction.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InteractionChannelResource>> ReadAsync(string pathInteractionSid,
                                                                                                           int? pageSize = null,
                                                                                                           long? limit = null,
                                                                                                           ITwilioRestClient client = null)
        {
            var options = new ReadInteractionChannelOptions(pathInteractionSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InteractionChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InteractionChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InteractionChannelResource> NextPage(Page<InteractionChannelResource> page,
                                                                ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.FlexApi)
            );

            var response = client.Request(request);
            return Page<InteractionChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InteractionChannelResource> PreviousPage(Page<InteractionChannelResource> page,
                                                                    ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.FlexApi)
            );

            var response = client.Request(request);
            return Page<InteractionChannelResource>.FromJson("channels", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateInteractionChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/Interactions/" + options.PathInteractionSid + "/Channels/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update an existing Interaction Channel.
        /// </summary>
        /// <param name="options"> Update InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static InteractionChannelResource Update(UpdateInteractionChannelOptions options,
                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update an existing Interaction Channel.
        /// </summary>
        /// <param name="options"> Update InteractionChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<InteractionChannelResource> UpdateAsync(UpdateInteractionChannelOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update an existing Interaction Channel.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> Required. The Interaction channels's status </param>
        /// <param name="routing"> Optional. The state of associated tasks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InteractionChannel </returns>
        public static InteractionChannelResource Update(string pathInteractionSid,
                                                        string pathSid,
                                                        InteractionChannelResource.StatusEnum status,
                                                        object routing = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateInteractionChannelOptions(pathInteractionSid, pathSid, status){Routing = routing};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update an existing Interaction Channel.
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> Required. The Interaction channels's status </param>
        /// <param name="routing"> Optional. The state of associated tasks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InteractionChannel </returns>
        public static async System.Threading.Tasks.Task<InteractionChannelResource> UpdateAsync(string pathInteractionSid,
                                                                                                string pathSid,
                                                                                                InteractionChannelResource.StatusEnum status,
                                                                                                object routing = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateInteractionChannelOptions(pathInteractionSid, pathSid, status){Routing = routing};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a InteractionChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InteractionChannelResource object represented by the provided JSON </returns>
        public static InteractionChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<InteractionChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource.
        /// </summary>
        [JsonProperty("interaction_sid")]
        public string InteractionSid { get; private set; }
        /// <summary>
        /// The Interaction Channel's type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InteractionChannelResource.TypeEnum Type { get; private set; }
        /// <summary>
        /// The status of this channel.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InteractionChannelResource.ChannelStatusEnum Status { get; private set; }
        /// <summary>
        /// The Twilio error code for a failed channel.
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }
        /// <summary>
        /// The error message for a failed channel.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private InteractionChannelResource()
        {

        }
    }

}