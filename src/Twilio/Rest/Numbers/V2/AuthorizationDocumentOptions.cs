/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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



namespace Twilio.Rest.Numbers.V2
{

    /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
    public class CreateAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </summary> 
        public string AddressSid { get; }

        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        public string Email { get; }

        ///<summary> The contact phone number of the person authorized to sign the Authorization Document. </summary> 
        public Types.PhoneNumber ContactPhoneNumber { get; }

        ///<summary> The title of the person authorized to sign the Authorization Document for this phone number. </summary> 
        public string ContactTitle { get; set; }

        ///<summary> Email recipients who will be informed when an Authorization Document has been sent and signed. </summary> 
        public List<string> CcEmails { get; set; }


        /// <summary> Construct a new CreateAuthorizationDocumentOptions </summary>
        /// <param name="addressSid"> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </param>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        public CreateAuthorizationDocumentOptions(string addressSid, string email, Types.PhoneNumber contactPhoneNumber)
        {
            AddressSid = addressSid;
            Email = email;
            ContactPhoneNumber = contactPhoneNumber;
            CcEmails = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (ContactPhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactPhoneNumber", ContactPhoneNumber.ToString()));
            }
            if (ContactTitle != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactTitle", ContactTitle));
            }
            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(CcEmails => new KeyValuePair<string, string>("CcEmails", CcEmails)));
            }
            return p;
        }
        

    }
    /// <summary> Cancel the AuthorizationDocument request. </summary>
    public class DeleteAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies this AuthorizationDocument. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteAuthorizationDocumentOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        public DeleteAuthorizationDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific AuthorizationDocument. </summary>
    public class FetchAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this AuthorizationDocument. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchAuthorizationDocumentOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        public FetchAuthorizationDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
    public class ReadAuthorizationDocumentOptions : ReadOptions<AuthorizationDocumentResource>
    {
    
        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        public string Email { get; set; }

        ///<summary> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/api/phone-numbers/hosted-number-authorization-documents#status-values) for more information on each of these statuses. </summary> 
        public AuthorizationDocumentResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

