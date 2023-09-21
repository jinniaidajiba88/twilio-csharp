/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
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




namespace Twilio.Rest.Autopilot.V1.Assistant.FieldType
{

    /// <summary> create </summary>
    public class CreateFieldValueOptions : IOptions<FieldValueResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the new resource. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the Field Type associated with the Field Value. </summary> 
        public string PathFieldTypeSid { get; }

        ///<summary> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) tag that specifies the language of the value. Currently supported tags: `en-US` </summary> 
        public string Language { get; }

        ///<summary> The Field Value data. </summary> 
        public string Value { get; }

        ///<summary> The string value that indicates which word the field value is a synonym of. </summary> 
        public string SynonymOf { get; set; }


        /// <summary> Construct a new CreateFieldValueOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the new resource. </param>
        /// <param name="pathFieldTypeSid"> The SID of the Field Type associated with the Field Value. </param>
        /// <param name="language"> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) tag that specifies the language of the value. Currently supported tags: `en-US` </param>
        /// <param name="value"> The Field Value data. </param>
        public CreateFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string language, string value)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
            Language = language;
            Value = value;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }
            if (SynonymOf != null)
            {
                p.Add(new KeyValuePair<string, string>("SynonymOf", SynonymOf));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteFieldValueOptions : IOptions<FieldValueResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resources to delete. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the Field Type associated with the Field Value to delete. </summary> 
        public string PathFieldTypeSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the FieldValue resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteFieldValueOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resources to delete. </param>
        /// <param name="pathFieldTypeSid"> The SID of the Field Type associated with the Field Value to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the FieldValue resource to delete. </param>
        public DeleteFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> fetch </summary>
    public class FetchFieldValueOptions : IOptions<FieldValueResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resource to fetch. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the Field Type associated with the Field Value to fetch. </summary> 
        public string PathFieldTypeSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the FieldValue resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFieldValueOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resource to fetch. </param>
        /// <param name="pathFieldTypeSid"> The SID of the Field Type associated with the Field Value to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the FieldValue resource to fetch. </param>
        public FetchFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> read </summary>
    public class ReadFieldValueOptions : ReadOptions<FieldValueResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resources to read. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the Field Type associated with the Field Value to read. </summary> 
        public string PathFieldTypeSid { get; }

        ///<summary> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) tag that specifies the language of the value. Currently supported tags: `en-US` </summary> 
        public string Language { get; set; }



        /// <summary> Construct a new ListFieldValueOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the FieldType associated with the resources to read. </param>
        /// <param name="pathFieldTypeSid"> The SID of the Field Type associated with the Field Value to read. </param>
        public ReadFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

