/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Wireless
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


namespace Twilio.Rest.Wireless.V1
{
    public class CommandResource : Resource
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
            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Sent = new StatusEnum("sent");
            public static readonly StatusEnum Delivered = new StatusEnum("delivered");
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }
            public static readonly DirectionEnum FromSim = new DirectionEnum("from_sim");
            public static readonly DirectionEnum ToSim = new DirectionEnum("to_sim");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CommandModeEnum : StringEnum
        {
            private CommandModeEnum(string value) : base(value) {}
            public CommandModeEnum() {}
            public static implicit operator CommandModeEnum(string value)
            {
                return new CommandModeEnum(value);
            }
            public static readonly CommandModeEnum Text = new CommandModeEnum("text");
            public static readonly CommandModeEnum Binary = new CommandModeEnum("binary");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TransportEnum : StringEnum
        {
            private TransportEnum(string value) : base(value) {}
            public TransportEnum() {}
            public static implicit operator TransportEnum(string value)
            {
                return new TransportEnum(value);
            }
            public static readonly TransportEnum Sms = new TransportEnum("sms");
            public static readonly TransportEnum Ip = new TransportEnum("ip");

        }

        
        private static Request BuildCreateRequest(CreateCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Commands";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Wireless,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Send a Command to a Sim. </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Create(CreateCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Send a Command to a Sim. </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(CreateCommandOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Send a Command to a Sim. </summary>
        /// <param name="command"> The message body of the Command. Can be plain text in text mode or a Base64 encoded byte string in binary mode. </param>
        /// <param name="sim"> The `sid` or `unique_name` of the [SIM](https://www.twilio.com/docs/iot/wireless/api/sim-resource) to send the Command to. </param>
        /// <param name="callbackMethod"> The HTTP method we use to call `callback_url`. Can be: `POST` or `GET`, and the default is `POST`. </param>
        /// <param name="callbackUrl"> The URL we call using the `callback_url` when the Command has finished sending, whether the command was delivered or it failed. </param>
        /// <param name="commandMode">  </param>
        /// <param name="includeSid"> Whether to include the SID of the command in the message body. Can be: `none`, `start`, or `end`, and the default behavior is `none`. When sending a Command to a SIM in text mode, we can automatically include the SID of the Command in the message body, which could be used to ensure that the device does not process the same Command more than once.  A value of `start` will prepend the message with the Command SID, and `end` will append it to the end, separating the Command SID from the message body with a space. The length of the Command SID is included in the 160 character limit so the SMS body must be 128 characters or less before the Command SID is included. </param>
        /// <param name="deliveryReceiptRequested"> Whether to request delivery receipt from the recipient. For Commands that request delivery receipt, the Command state transitions to 'delivered' once the server has received a delivery receipt from the device. The default value is `true`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Create(
                                          string command,
                                          string sim = null,
                                          Twilio.Http.HttpMethod callbackMethod = null,
                                          Uri callbackUrl = null,
                                          CommandResource.CommandModeEnum commandMode = null,
                                          string includeSid = null,
                                          bool? deliveryReceiptRequested = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateCommandOptions(command){  Sim = sim, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, CommandMode = commandMode, IncludeSid = includeSid, DeliveryReceiptRequested = deliveryReceiptRequested };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Send a Command to a Sim. </summary>
        /// <param name="command"> The message body of the Command. Can be plain text in text mode or a Base64 encoded byte string in binary mode. </param>
        /// <param name="sim"> The `sid` or `unique_name` of the [SIM](https://www.twilio.com/docs/iot/wireless/api/sim-resource) to send the Command to. </param>
        /// <param name="callbackMethod"> The HTTP method we use to call `callback_url`. Can be: `POST` or `GET`, and the default is `POST`. </param>
        /// <param name="callbackUrl"> The URL we call using the `callback_url` when the Command has finished sending, whether the command was delivered or it failed. </param>
        /// <param name="commandMode">  </param>
        /// <param name="includeSid"> Whether to include the SID of the command in the message body. Can be: `none`, `start`, or `end`, and the default behavior is `none`. When sending a Command to a SIM in text mode, we can automatically include the SID of the Command in the message body, which could be used to ensure that the device does not process the same Command more than once.  A value of `start` will prepend the message with the Command SID, and `end` will append it to the end, separating the Command SID from the message body with a space. The length of the Command SID is included in the 160 character limit so the SMS body must be 128 characters or less before the Command SID is included. </param>
        /// <param name="deliveryReceiptRequested"> Whether to request delivery receipt from the recipient. For Commands that request delivery receipt, the Command state transitions to 'delivered' once the server has received a delivery receipt from the device. The default value is `true`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(
                                                                                  string command,
                                                                                  string sim = null,
                                                                                  Twilio.Http.HttpMethod callbackMethod = null,
                                                                                  Uri callbackUrl = null,
                                                                                  CommandResource.CommandModeEnum commandMode = null,
                                                                                  string includeSid = null,
                                                                                  bool? deliveryReceiptRequested = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateCommandOptions(command){  Sim = sim, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, CommandMode = commandMode, IncludeSid = includeSid, DeliveryReceiptRequested = deliveryReceiptRequested };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a Command instance from your account. </summary>
        /// <param name="options"> Delete Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        private static Request BuildDeleteRequest(DeleteCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Commands/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Wireless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a Command instance from your account. </summary>
        /// <param name="options"> Delete Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static bool Delete(DeleteCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a Command instance from your account. </summary>
        /// <param name="options"> Delete Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCommandOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Command resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCommandOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Command resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCommandOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Commands/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Command instance from your account. </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Fetch(FetchCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a Command instance from your account. </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(FetchCommandOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Command resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Command resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Commands";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Commands from your account. </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static ResourceSet<CommandResource> Read(ReadCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Commands from your account. </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(ReadCommandOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Commands from your account. </summary>
        /// <param name="sim"> The `sid` or `unique_name` of the [Sim resources](https://www.twilio.com/docs/iot/wireless/api/sim-resource) to read. </param>
        /// <param name="status"> The status of the resources to read. Can be: `queued`, `sent`, `delivered`, `received`, or `failed`. </param>
        /// <param name="direction"> Only return Commands with this direction value. </param>
        /// <param name="transport"> Only return Commands with this transport value. Can be: `sms` or `ip`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static ResourceSet<CommandResource> Read(
                                                     string sim = null,
                                                     CommandResource.StatusEnum status = null,
                                                     CommandResource.DirectionEnum direction = null,
                                                     CommandResource.TransportEnum transport = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions(){ Sim = sim, Status = status, Direction = direction, Transport = transport, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Commands from your account. </summary>
        /// <param name="sim"> The `sid` or `unique_name` of the [Sim resources](https://www.twilio.com/docs/iot/wireless/api/sim-resource) to read. </param>
        /// <param name="status"> The status of the resources to read. Can be: `queued`, `sent`, `delivered`, `received`, or `failed`. </param>
        /// <param name="direction"> Only return Commands with this direction value. </param>
        /// <param name="transport"> Only return Commands with this transport value. Can be: `sms` or `ip`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(
                                                                                             string sim = null,
                                                                                             CommandResource.StatusEnum status = null,
                                                                                             CommandResource.DirectionEnum direction = null,
                                                                                             CommandResource.TransportEnum transport = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions(){ Sim = sim, Status = status, Direction = direction, Transport = transport, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CommandResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CommandResource> NextPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CommandResource> PreviousPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a CommandResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CommandResource object represented by the provided JSON </returns>
        public static CommandResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CommandResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Command resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Command resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource) that the Command was sent to or from. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> The message being sent to or from the SIM. For text mode messages, this can be up to 160 characters. For binary mode messages, this is a series of up to 140 bytes of data encoded using base64. </summary> 
        [JsonProperty("command")]
        public string Command { get; private set; }

        
        [JsonProperty("command_mode")]
        public CommandResource.CommandModeEnum CommandMode { get; private set; }

        
        [JsonProperty("transport")]
        public CommandResource.TransportEnum Transport { get; private set; }

        ///<summary> Whether to request a delivery receipt. </summary> 
        [JsonProperty("delivery_receipt_requested")]
        public bool? DeliveryReceiptRequested { get; private set; }

        
        [JsonProperty("status")]
        public CommandResource.StatusEnum Status { get; private set; }

        
        [JsonProperty("direction")]
        public CommandResource.DirectionEnum Direction { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CommandResource() {

        }
    }
}

