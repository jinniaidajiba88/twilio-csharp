/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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




namespace Twilio.Rest.Trusthub.V1.TrustProducts
{

    /// <summary> Create a new Evaluation </summary>
    public class CreateTrustProductsEvaluationsOptions : IOptions<TrustProductsEvaluationsResource>
    {
        
        ///<summary> The unique string that we created to identify the trust_product resource. </summary> 
        public string PathTrustProductSid { get; }

        ///<summary> The unique string of a policy that is associated to the customer_profile resource. </summary> 
        public string PolicySid { get; }


        /// <summary> Construct a new CreateTrustProductEvaluationOptions </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the trust_product resource. </param>
        /// <param name="policySid"> The unique string of a policy that is associated to the customer_profile resource. </param>
        public CreateTrustProductsEvaluationsOptions(string pathTrustProductSid, string policySid)
        {
            PathTrustProductSid = pathTrustProductSid;
            PolicySid = policySid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PolicySid != null)
            {
                p.Add(new KeyValuePair<string, string>("PolicySid", PolicySid));
            }
            return p;
        }

        

    }
    /// <summary> Fetch specific Evaluation Instance. </summary>
    public class FetchTrustProductsEvaluationsOptions : IOptions<TrustProductsEvaluationsResource>
    {
    
        ///<summary> The unique string that we created to identify the trust_product resource. </summary> 
        public string PathTrustProductSid { get; }

        ///<summary> The unique string that identifies the Evaluation resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTrustProductEvaluationOptions </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the trust_product resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        public FetchTrustProductsEvaluationsOptions(string pathTrustProductSid, string pathSid)
        {
            PathTrustProductSid = pathTrustProductSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of Evaluations associated to the trust_product resource. </summary>
    public class ReadTrustProductsEvaluationsOptions : ReadOptions<TrustProductsEvaluationsResource>
    {
    
        ///<summary> The unique string that we created to identify the trust_product resource. </summary> 
        public string PathTrustProductSid { get; }



        /// <summary> Construct a new ListTrustProductEvaluationOptions </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the trust_product resource. </param>
        public ReadTrustProductsEvaluationsOptions(string pathTrustProductSid)
        {
            PathTrustProductSid = pathTrustProductSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

