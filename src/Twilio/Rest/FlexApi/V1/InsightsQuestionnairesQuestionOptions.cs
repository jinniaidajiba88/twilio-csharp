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
using System.Linq;



namespace Twilio.Rest.FlexApi.V1
{

    /// <summary> To create a question for a Category </summary>
    public class CreateInsightsQuestionnairesQuestionOptions : IOptions<InsightsQuestionnairesQuestionResource>
    {
        
        ///<summary> The ID of the category </summary> 
        public string CategoryId { get; }

        ///<summary> The question. </summary> 
        public string Question { get; }

        ///<summary> The description for the question. </summary> 
        public string Description { get; }

        ///<summary> The answer_set for the question. </summary> 
        public string AnswerSetId { get; }

        ///<summary> The flag to enable for disable NA for answer. </summary> 
        public bool? AllowNa { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }


        /// <summary> Construct a new CreateInsightsQuestionnairesQuestionOptions </summary>
        /// <param name="categoryId"> The ID of the category </param>
        /// <param name="question"> The question. </param>
        /// <param name="description"> The description for the question. </param>
        /// <param name="answerSetId"> The answer_set for the question. </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        public CreateInsightsQuestionnairesQuestionOptions(string categoryId, string question, string description, string answerSetId, bool? allowNa)
        {
            CategoryId = categoryId;
            Question = question;
            Description = description;
            AnswerSetId = answerSetId;
            AllowNa = allowNa;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CategoryId != null)
            {
                p.Add(new KeyValuePair<string, string>("CategoryId", CategoryId));
            }
            if (Question != null)
            {
                p.Add(new KeyValuePair<string, string>("Question", Question));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (AnswerSetId != null)
            {
                p.Add(new KeyValuePair<string, string>("AnswerSetId", AnswerSetId));
            }
            if (AllowNa != null)
            {
                p.Add(new KeyValuePair<string, string>("AllowNa", AllowNa.Value.ToString().ToLower()));
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
    /// <summary> delete </summary>
    public class DeleteInsightsQuestionnairesQuestionOptions : IOptions<InsightsQuestionnairesQuestionResource>
    {
        
        ///<summary> The unique ID of the question </summary> 
        public string PathQuestionId { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }



        /// <summary> Construct a new DeleteInsightsQuestionnairesQuestionOptions </summary>
        /// <param name="pathQuestionId"> The unique ID of the question </param>
        public DeleteInsightsQuestionnairesQuestionOptions(string pathQuestionId)
        {
            PathQuestionId = pathQuestionId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

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


    /// <summary> To get all the question for the given categories </summary>
    public class ReadInsightsQuestionnairesQuestionOptions : ReadOptions<InsightsQuestionnairesQuestionResource>
    {
    
        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }

        ///<summary> The list of category IDs </summary> 
        public List<string> CategoryId { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CategoryId != null)
            {
                p.AddRange(CategoryId.Select(CategoryId => new KeyValuePair<string, string>("CategoryId", CategoryId)));
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

    /// <summary> To update the question </summary>
    public class UpdateInsightsQuestionnairesQuestionOptions : IOptions<InsightsQuestionnairesQuestionResource>
    {
    
        ///<summary> The unique ID of the question </summary> 
        public string PathQuestionId { get; }

        ///<summary> The flag to enable for disable NA for answer. </summary> 
        public bool? AllowNa { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }

        ///<summary> The ID of the category </summary> 
        public string CategoryId { get; set; }

        ///<summary> The question. </summary> 
        public string Question { get; set; }

        ///<summary> The description for the question. </summary> 
        public string Description { get; set; }

        ///<summary> The answer_set for the question. </summary> 
        public string AnswerSetId { get; set; }



        /// <summary> Construct a new UpdateInsightsQuestionnairesQuestionOptions </summary>
        /// <param name="pathQuestionId"> The unique ID of the question </param>
        /// <param name="allowNa"> The flag to enable for disable NA for answer. </param>
        public UpdateInsightsQuestionnairesQuestionOptions(string pathQuestionId, bool? allowNa)
        {
            PathQuestionId = pathQuestionId;
            AllowNa = allowNa;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AllowNa != null)
            {
                p.Add(new KeyValuePair<string, string>("AllowNa", AllowNa.Value.ToString().ToLower()));
            }
            if (CategoryId != null)
            {
                p.Add(new KeyValuePair<string, string>("CategoryId", CategoryId));
            }
            if (Question != null)
            {
                p.Add(new KeyValuePair<string, string>("Question", Question));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (AnswerSetId != null)
            {
                p.Add(new KeyValuePair<string, string>("AnswerSetId", AnswerSetId));
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

