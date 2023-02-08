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


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.FlexApi.V1
{
    public class InsightsQuestionnairesResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateInsightsQuestionnairesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Questionnaires";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To create a Questionnaire </summary>
        /// <param name="options"> Create InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Create(CreateInsightsQuestionnairesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To create a Questionnaire </summary>
        /// <param name="options"> Create InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> CreateAsync(CreateInsightsQuestionnairesOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To create a Questionnaire </summary>
        /// <param name="name"> The name of this questionnaire </param>
        /// <param name="description"> The description of this questionnaire </param>
        /// <param name="active"> The flag to enable or disable questionnaire </param>
        /// <param name="questionIds"> The list of questions ids under a questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Create(
                                          string name,
                                          string description = null,
                                          bool? active = null,
                                          List<string> questionIds = null,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInsightsQuestionnairesOptions(name){  Description = description, Active = active, QuestionIds = questionIds, Token = token };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> To create a Questionnaire </summary>
        /// <param name="name"> The name of this questionnaire </param>
        /// <param name="description"> The description of this questionnaire </param>
        /// <param name="active"> The flag to enable or disable questionnaire </param>
        /// <param name="questionIds"> The list of questions ids under a questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> CreateAsync(
                                                                                  string name,
                                                                                  string description = null,
                                                                                  bool? active = null,
                                                                                  List<string> questionIds = null,
                                                                                  string token = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInsightsQuestionnairesOptions(name){  Description = description, Active = active, QuestionIds = questionIds, Token = token };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> To delete the questionnaire </summary>
        /// <param name="options"> Delete InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        private static Request BuildDeleteRequest(DeleteInsightsQuestionnairesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Questionnaires/{Id}";

            string PathId = options.PathId;
            path = path.Replace("{"+"Id"+"}", PathId);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To delete the questionnaire </summary>
        /// <param name="options"> Delete InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static bool Delete(DeleteInsightsQuestionnairesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> To delete the questionnaire </summary>
        /// <param name="options"> Delete InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInsightsQuestionnairesOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> To delete the questionnaire </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static bool Delete(string pathId, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesOptions(pathId)      { Token = token }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> To delete the questionnaire </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathId, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesOptions(pathId)  { Token = token };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchInsightsQuestionnairesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Questionnaires/{Id}";

            string PathId = options.PathId;
            path = path.Replace("{"+"Id"+"}", PathId);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To get the Questionnaire Detail </summary>
        /// <param name="options"> Fetch InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Fetch(FetchInsightsQuestionnairesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To get the Questionnaire Detail </summary>
        /// <param name="options"> Fetch InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> FetchAsync(FetchInsightsQuestionnairesOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> To get the Questionnaire Detail </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Fetch(
                                         string pathId, 
                                         string token = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInsightsQuestionnairesOptions(pathId){ Token = token };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> To get the Questionnaire Detail </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> FetchAsync(string pathId, string token = null, ITwilioRestClient client = null)
        {
            var options = new FetchInsightsQuestionnairesOptions(pathId){ Token = token };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadInsightsQuestionnairesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Questionnaires";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> To get all questionnaires with questions </summary>
        /// <param name="options"> Read InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static ResourceSet<InsightsQuestionnairesResource> Read(ReadInsightsQuestionnairesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InsightsQuestionnairesResource>.FromJson("questionnaires", response.Content);
            return new ResourceSet<InsightsQuestionnairesResource>(page, options, client);
        }

        #if !NET35
        /// <summary> To get all questionnaires with questions </summary>
        /// <param name="options"> Read InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsQuestionnairesResource>> ReadAsync(ReadInsightsQuestionnairesOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InsightsQuestionnairesResource>.FromJson("questionnaires", response.Content);
            return new ResourceSet<InsightsQuestionnairesResource>(page, options, client);
        }
        #endif
        /// <summary> To get all questionnaires with questions </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="includeInactive"> Flag indicating whether to include inactive questionnaires or not </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static ResourceSet<InsightsQuestionnairesResource> Read(
                                                     string token = null,
                                                     bool? includeInactive = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadInsightsQuestionnairesOptions(){ Token = token, IncludeInactive = includeInactive, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> To get all questionnaires with questions </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="includeInactive"> Flag indicating whether to include inactive questionnaires or not </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsQuestionnairesResource>> ReadAsync(
                                                                                             string token = null,
                                                                                             bool? includeInactive = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadInsightsQuestionnairesOptions(){ Token = token, IncludeInactive = includeInactive, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InsightsQuestionnairesResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesResource>.FromJson("questionnaires", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InsightsQuestionnairesResource> NextPage(Page<InsightsQuestionnairesResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesResource>.FromJson("questionnaires", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InsightsQuestionnairesResource> PreviousPage(Page<InsightsQuestionnairesResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsQuestionnairesResource>.FromJson("questionnaires", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateInsightsQuestionnairesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Questionnaires/{Id}";

            string PathId = options.PathId;
            path = path.Replace("{"+"Id"+"}", PathId);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To update the questionnaire </summary>
        /// <param name="options"> Update InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Update(UpdateInsightsQuestionnairesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> To update the questionnaire </summary>
        /// <param name="options"> Update InsightsQuestionnaires parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> UpdateAsync(UpdateInsightsQuestionnairesOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To update the questionnaire </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="active"> The flag to enable or disable questionnaire </param>
        /// <param name="name"> The name of this questionnaire </param>
        /// <param name="description"> The description of this questionnaire </param>
        /// <param name="questionIds"> The list of questions ids under a questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnaires </returns>
        public static InsightsQuestionnairesResource Update(
                                          string pathId,
                                          bool? active,
                                          string name = null,
                                          string description = null,
                                          List<string> questionIds = null,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesOptions(pathId, active){ Name = name, Description = description, QuestionIds = questionIds, Token = token };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> To update the questionnaire </summary>
        /// <param name="pathId"> The unique ID of the questionnaire </param>
        /// <param name="active"> The flag to enable or disable questionnaire </param>
        /// <param name="name"> The name of this questionnaire </param>
        /// <param name="description"> The description of this questionnaire </param>
        /// <param name="questionIds"> The list of questions ids under a questionnaire </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnaires </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesResource> UpdateAsync(
                                                                              string pathId,
                                                                              bool? active,
                                                                              string name = null,
                                                                              string description = null,
                                                                              List<string> questionIds = null,
                                                                              string token = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesOptions(pathId, active){ Name = name, Description = description, QuestionIds = questionIds, Token = token };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsQuestionnairesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsQuestionnairesResource object represented by the provided JSON </returns>
        public static InsightsQuestionnairesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsQuestionnairesResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique id of this questionnaire </summary> 
        [JsonProperty("id")]
        public string Id { get; private set; }

        ///<summary> The name of this category. </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The description of this questionnaire </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> The flag to enable or disable questionnaire </summary> 
        [JsonProperty("active")]
        public bool? Active { get; private set; }

        ///<summary> The list of questions with category for a questionnaire </summary> 
        [JsonProperty("questions")]
        public List<object> Questions { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsQuestionnairesResource() {

        }
    }
}

