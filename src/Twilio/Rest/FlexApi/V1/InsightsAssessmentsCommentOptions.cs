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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.FlexApi.V1
{

    /// <summary> To create a comment assessment for a conversation </summary>
    public class CreateInsightsAssessmentsCommentOptions : IOptions<InsightsAssessmentsCommentResource>
    {
        
        ///<summary> The ID of the category </summary> 
        public string CategoryId { get; }

        ///<summary> The name of the category </summary> 
        public string CategoryName { get; }

        ///<summary> The Assessment comment. </summary> 
        public string Comment { get; }

        ///<summary> The id of the segment. </summary> 
        public string SegmentId { get; }

        ///<summary> The name of the user. </summary> 
        public string UserName { get; }

        ///<summary> The email id of the user. </summary> 
        public string UserEmail { get; }

        ///<summary> The id of the agent. </summary> 
        public string AgentId { get; }

        ///<summary> The offset </summary> 
        public decimal? Offset { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }


        /// <summary> Construct a new CreateInsightsAssessmentsCommentOptions </summary>
        /// <param name="categoryId"> The ID of the category </param>
        /// <param name="categoryName"> The name of the category </param>
        /// <param name="comment"> The Assessment comment. </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="userName"> The name of the user. </param>
        /// <param name="userEmail"> The email id of the user. </param>
        /// <param name="agentId"> The id of the agent. </param>
        /// <param name="offset"> The offset </param>
        public CreateInsightsAssessmentsCommentOptions(string categoryId, string categoryName, string comment, string segmentId, string userName, string userEmail, string agentId, decimal? offset)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Comment = comment;
            SegmentId = segmentId;
            UserName = userName;
            UserEmail = userEmail;
            AgentId = agentId;
            Offset = offset;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CategoryId != null)
            {
                p.Add(new KeyValuePair<string, string>("CategoryId", CategoryId));
            }
            if (CategoryName != null)
            {
                p.Add(new KeyValuePair<string, string>("CategoryName", CategoryName));
            }
            if (Comment != null)
            {
                p.Add(new KeyValuePair<string, string>("Comment", Comment));
            }
            if (SegmentId != null)
            {
                p.Add(new KeyValuePair<string, string>("SegmentId", SegmentId));
            }
            if (UserName != null)
            {
                p.Add(new KeyValuePair<string, string>("UserName", UserName));
            }
            if (UserEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("UserEmail", UserEmail));
            }
            if (AgentId != null)
            {
                p.Add(new KeyValuePair<string, string>("AgentId", AgentId));
            }
            if (Offset != null)
            {
                p.Add(new KeyValuePair<string, string>("Offset", Offset.Value.ToString()));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }
    /// <summary> To create a comment assessment for a conversation </summary>
    public class ReadInsightsAssessmentsCommentOptions : ReadOptions<InsightsAssessmentsCommentResource>
    {
    
        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }

        ///<summary> The id of the segment. </summary> 
        public string SegmentId { get; set; }

        ///<summary> The id of the agent. </summary> 
        public string AgentId { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (SegmentId != null)
            {
                p.Add(new KeyValuePair<string, string>("SegmentId", SegmentId));
            }
            if (AgentId != null)
            {
                p.Add(new KeyValuePair<string, string>("AgentId", AgentId));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }

}

